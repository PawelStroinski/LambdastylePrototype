using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using KellermanSoftware.CompareNetObjects;
using LambdastylePrototype;
using LambdastylePrototype.Parser;
using LambdastylePrototype.Interpreter;
using NUnit.Framework;
using StreamUtils;

namespace Test
{
    public class Runner
    {
        [TestCaseSource("GetStylesForProcessor")]
        public void Processor(Type style)
        {
            var folders = RunnerUtils.NamespaceFolders(style.Namespace);
            var inputFile = RunnerUtils.InputFileFullPath(folders);
            var expectedOutputFile = RunnerUtils.OutputFileFullPath(folders);
            var actualOutputFile = Path.GetTempFileName();
            var builtStyle = RunnerUtils.BuiltStyle(style);
            using (var input = new FileStream(inputFile, FileMode.Open, FileAccess.Read))
            using (var output = new EditableFileStream(actualOutputFile, FileMode.Create))
            {
                var processor = new Processor(input, output, builtStyle);
                processor.Process();
            }
            Assert.AreEqual(File.ReadAllText(expectedOutputFile), File.ReadAllText(actualOutputFile),
                actualOutputFile);
        }

        [TestCaseSource("GetStylesForParser")]
        public void Parser(Type style)
        {
            var folders = RunnerUtils.NamespaceFolders(style.Namespace);
            var builtStyle = RunnerUtils.BuiltStyle(style);
            var styleFile = RunnerUtils.StyleFileFullPath(folders);
            if (File.Exists(styleFile))
            {
                var parser = new Parser();
                var compareLogic = new CompareLogic();
                Sentence[] actualStyle;
                using (var styleFileStream = new FileStream(styleFile, FileMode.Open))
                    actualStyle = parser.Parse(styleFileStream);
                compareLogic.Config.ComparePrivateFields = true;
                compareLogic.Config.MembersToIgnore.Add("context");
                var comparison = compareLogic.Compare(builtStyle, actualStyle);
                if (!comparison.AreEqual)
                    Assert.Fail("\nParser: " + comparison.DifferencesString);
            }
        }

        [Test]
        public void Facade()
        {
            var style = GetStylesInternal().First();
            var folders = RunnerUtils.NamespaceFolders(style.Namespace);
            var inputFile = RunnerUtils.InputFileFullPath(folders);
            var expectedOutputFile = RunnerUtils.OutputFileFullPath(folders);
            var styleFile = RunnerUtils.StyleFileFullPath(folders);
            var input = File.ReadAllText(inputFile);
            var expectedOutput = File.ReadAllText(expectedOutputFile);
            var styleText = File.ReadAllText(styleFile);
            var facade = new Facade();
            var actualOutput = facade.ProcessString(input: input, style: styleText);
            Assert.AreEqual(expectedOutput, actualOutput);
        }

        [Test]
        public void EmptyInputShoudGiveEmptyOutput()
        {
            var facade = new Facade();
            using (var input = new MemoryStream())
            using (var style = new MemoryStream())
            using (var output = new EditableMemoryStream())
            {
                facade.ProcessStream(input: input, style: style, output: output);
                using (var outputReader = new StreamReader(output))
                    Assert.IsEmpty(outputReader.ReadToEnd());
            }
        }

        [Test]
        public void RunnerItselfItWorks()
        {
            var styles = GetStylesInternal();
            Assert.True(styles.Any());
            var foldersFirst = RunnerUtils.NamespaceFolders(styles[0].Namespace);
            var foldersNext = RunnerUtils.NamespaceFolders(styles[1].Namespace);
            Assert.AreEqual("input1.json", foldersFirst.Item1);
            Assert.AreEqual("input1.json", foldersNext.Item1);
            Assert.AreEqual("1 singlerun true", foldersFirst.Item2);
            Assert.IsTrue(foldersNext.Item2.StartsWith("1_1 "));
            var inputFile = RunnerUtils.InputFileFullPath(foldersFirst);
            Assert.IsTrue(File.Exists(inputFile), "was " + inputFile);
            var outputFile = RunnerUtils.OutputFileFullPath(foldersFirst);
            Assert.IsTrue(File.Exists(outputFile), "was " + outputFile);
            var styleFile = RunnerUtils.StyleFileFullPath(foldersFirst);
            Assert.IsTrue(File.Exists(styleFile), "was " + styleFile);
            var builtStyle = RunnerUtils.BuiltStyle(styles[0]);
            Assert.AreEqual(2, builtStyle.Length);
            Assert.IsNotEmpty(GetStylesForProcessor());
            Assert.IsNotEmpty(GetStylesForParser());
        }

        List<ITestCaseData> GetStylesForProcessor()
        {
            return GetStyles(testNameStart: string.Empty);
        }

        List<ITestCaseData> GetStylesForParser()
        {
            return GetStyles(testNameStart: "Parser: ");
        }

        List<ITestCaseData> GetStyles(string testNameStart)
        {
            var styles = GetStylesInternal();
            return styles
                .Select(style =>
                {
                    var folders = RunnerUtils.NamespaceFolders(style.Namespace);
                    var testCaseData = new TestCaseData(style);
                    testCaseData.SetName(testNameStart + folders.Item2);
                    testCaseData.SetCategory(folders.Item2);
                    testCaseData.SetDescription(Path.Combine(folders.Item1, folders.Item2) + " ");
                    return testCaseData;
                })
                .Cast<ITestCaseData>().ToList();
        }

        List<Type> GetStylesInternal()
        {
            return Assembly.GetExecutingAssembly().GetTypes()
                .Where(type => type.Name == "Style").Cast<Type>().ToList();
        }
    }
}

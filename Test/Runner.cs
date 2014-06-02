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
            var folders = NamespaceFolders(style.Namespace);
            var inputFile = InputFileFullPath(folders);
            var expectedOutputFile = OutputFileFullPath(folders);
            var actualOutputFile = Path.GetTempFileName();
            var builtStyle = BuiltStyle(style);
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
            var folders = NamespaceFolders(style.Namespace);
            var builtStyle = BuiltStyle(style);
            var styleFile = StyleFileFullPath(folders);
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
        public void RunnerItselfItWorks()
        {
            var styles = GetStylesInternal();
            Assert.True(styles.Any());
            var foldersFirst = NamespaceFolders(styles[0].Namespace);
            var foldersNext = NamespaceFolders(styles[1].Namespace);
            Assert.AreEqual("input1.json", foldersFirst.Item1);
            Assert.AreEqual("input1.json", foldersNext.Item1);
            Assert.AreEqual("1 singlerun true", foldersFirst.Item2);
            Assert.IsTrue(foldersNext.Item2.StartsWith("1_1 "));
            var inputFile = InputFileFullPath(foldersFirst);
            Assert.IsTrue(File.Exists(inputFile), "was " + inputFile);
            var outputFile = OutputFileFullPath(foldersFirst);
            Assert.IsTrue(File.Exists(outputFile), "was " + outputFile);
            var styleFile = StyleFileFullPath(foldersFirst);
            Assert.IsTrue(File.Exists(styleFile), "was " + styleFile);
            var builtStyle = BuiltStyle(styles[0]);
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
                    var folders = NamespaceFolders(style.Namespace);
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

        Tuple<string, string> NamespaceFolders(string ns)
        {
            var splet = ns.Split('.');
            var last = splet.Last();
            var middle = splet.Skip(1).Take(splet.Count() - 2);
            var groups = Regex.Match(last, @"_(\d+(?:_\d+)?)_(.*)").Groups;
            var digits = groups[1].Value;
            var comment = groups[2].Value;
            var lastFolder = digits + ' ' + comment.Replace('_', ' ');
            var middleFolder = string.Join(".", middle);
            return new Tuple<string, string>(middleFolder, lastFolder);
        }

        string InputFileFullPath(Tuple<string, string> folders)
        {
            var local = Path.Combine(ParentDirectory(), folders.Item1, folders.Item2, "input.json");
            if (File.Exists(local))
                return local;
            else
                return Path.Combine(ParentDirectory(), folders.Item1, folders.Item1);
        }

        string OutputFileFullPath(Tuple<string, string> folders)
        {
            return Path.Combine(ParentDirectory(), folders.Item1, folders.Item2, "output.txt");
        }

        string StyleFileFullPath(Tuple<string, string> folders)
        {
            return Path.Combine(ParentDirectory(), folders.Item1, folders.Item2, "style.txt");
        }

        Sentence[] BuiltStyle(Type style)
        {
            var instance = Activator.CreateInstance(style);
            var builder = new Builder();
            var method = style.GetMethod("Build", BindingFlags.NonPublic | BindingFlags.Instance);
            method.Invoke(instance, new object[] { builder });
            return builder.Style.ToArray();
        }

        string ParentDirectory()
        {
            var assembly = Assembly.GetExecutingAssembly();
            return new DirectoryInfo(Path.GetDirectoryName(assembly.Location)).Parent.Parent.FullName;
        }
    }
}

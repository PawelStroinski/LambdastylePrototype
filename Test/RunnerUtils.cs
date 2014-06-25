using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using LambdastylePrototype.Interpreter;

namespace Test
{
    static class RunnerUtils
    {
        public static Tuple<string, string> NamespaceFolders(string ns)
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

        public static string InputFileFullPath(Tuple<string, string> folders)
        {
            var local = Path.Combine(ParentDirectory(), folders.Item1, folders.Item2, "input.json");
            if (File.Exists(local))
                return local;
            else
                return Path.Combine(ParentDirectory(), folders.Item1, folders.Item1);
        }

        public static string OutputFileFullPath(Tuple<string, string> folders)
        {
            return Path.Combine(ParentDirectory(), folders.Item1, folders.Item2, "output.txt");
        }

        public static string StyleFileFullPath(Tuple<string, string> folders)
        {
            return Path.Combine(ParentDirectory(), folders.Item1, folders.Item2, "style.txt");
        }

        public static Sentence[] BuiltStyle(Type style)
        {
            var instance = Activator.CreateInstance(style);
            var builder = new Builder();
            var method = style.GetMethod("Build", BindingFlags.NonPublic | BindingFlags.Instance);
            method.Invoke(instance, new object[] { builder });
            return builder.Style.ToArray();
        }

        static string ParentDirectory()
        {
            var assembly = Assembly.GetExecutingAssembly();
            return new DirectoryInfo(Path.GetDirectoryName(assembly.Location)).Parent.Parent.FullName;
        }
    }
}

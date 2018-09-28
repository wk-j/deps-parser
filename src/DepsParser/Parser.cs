using System;
using System.Linq;
using System.IO;

namespace DepsParser {

    public class Parser {

        public string[] Content { private set; get; }

        public string GetLibraryVersion(string name) {
            var line = Content.Where(x => x.Contains(name + "/")).First();
            return line.Trim()
                .Replace(name, "")
                .Replace("/", "")
                .Replace("{", "")
                .Replace(":", "")
                .Replace("\"", "");
        }

        public static Parser Search(string dir, string filePattern) {
            var file = new DirectoryInfo(dir).GetFiles(filePattern, SearchOption.AllDirectories).First();
            var text = File.ReadAllLines(file.FullName);
            return new Parser {
                Content = text
            };
        }

    }
}

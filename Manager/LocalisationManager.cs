using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;
using HOI4MI.Util;

namespace HOI4MI.Manager
{
    public static class Localisation {

        private static Dictionary<string, LocaleItem> dict;
        private static string basePath;
        private static string localeFileLocation = @"\localisation";
        private static string vanillaLocaleFileLocation = @"A:\Programs\Steam\steamapps\common\Hearts of Iron IV\localisation";

        static Localisation() { 
            dict = new Dictionary<string, LocaleItem>();
        }

        public static string Get(string key) {
            try {
                return dict[key].Content;
            }
            catch {
                return null;
            }
        }

        public static string GetSafe(string key) {
            try {
                return dict[key].Content;
            }
            catch {
                return key;
            }
        }

        private static string[] GetLocaleFiles() {
            List<string> result = new List<String>();
            result.AddRange(Directory.GetFiles($@"{vanillaLocaleFileLocation}", "*l_english.yml"));
            result.AddRange(Directory.GetFiles($@"{basePath}{localeFileLocation}", "*", SearchOption.AllDirectories));
            return result.ToArray();
        }

        public static void Reload() {
            string[] localisationFiles = GetLocaleFiles();
            Match m;

            foreach (string fileName in localisationFiles) {
                string[] fileContents = new string[] { };
                fileContents = File.ReadAllLines(fileName);

                foreach (string line in fileContents) {
                    m = Regex.Match(line, @"\s*(.*):\d ""(.*)""");
                    if (!m.Success) continue;

                    string key = m.Groups[1].Value;
                    string val = m.Groups[2].Value;

                    LocaleItem l = new LocaleItem(val, fileName);

                    dict.AddOrSet(key, l);
                }
            }

        }

        public static bool IsLocaleVanilla(LocaleItem li) {
            return li.Content.Contains(vanillaLocaleFileLocation); ;
        }

        public static void SetBasePath(string p) {
            basePath = p;
        }
    }

    public struct LocaleItem {

        public LocaleItem(string content, string source) {
            Content = content;
            Source = source;
        }

        public string Content { get; }
        public string Source { get; }
    }
}

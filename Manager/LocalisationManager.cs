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
    public class LocalisationManager {

        private Dictionary<string, string> dict;
        private string basePath;
        private string localeFileLocation = @"\localisation";
        private string vanillaLocaleFileLocation = @"A:\Programs\Steam\steamapps\common\Hearts of Iron IV\localisation";

        public LocalisationManager(string p) { 
            dict = new Dictionary<string, string>();
            basePath = p;
        }

        public string GetLocalisationItem(string key) {
            try {
                return dict[key];
            }
            catch {
                return key;
            }
        }

        public void AddLocalisationItem(string key, string value) {
            dict.Add(key, value);
        }

        public string[] GetLocaleFiles() {
            List<string> result = new List<String>();
            result.AddRange(Directory.GetFiles($@"{vanillaLocaleFileLocation}", "*l_english.yml"));
            result.AddRange(Directory.GetFiles($@"{basePath}{localeFileLocation}", "*", SearchOption.AllDirectories));
            return result.ToArray();
        }

        public void ReloadLocalisation() {
            string[] locale = GetLocaleFiles();
            string[] fileContents = new string[] { };
            string key = "";
            string val = "";
            Match m;

            foreach (string file in locale) {
                fileContents = File.ReadAllLines(file);
                foreach (string line in fileContents) {
                    m = Regex.Match(line, @"\s*(.*):\d ""(.*)""");
                    if (!m.Success) continue;

                    key = m.Groups[1].Value;
                    val = m.Groups[2].Value;

                    dict.AddOrSet(key, val);
                }
            }
        }
    }
}

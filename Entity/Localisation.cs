using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;
using HOI4MI.Util;
using System.Data;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Net.NetworkInformation;

namespace HOI4MI.Entity
{
    public static class Localisation {

        public static Dictionary<string, LocaleItem> Locale { get { return new Dictionary<string, LocaleItem>(dict); } }

        private static Dictionary<string, LocaleItem> dict;
        private static string basePath;
        private static string localeFileLocation = @"\localisation";
        private static string vanillaLocaleFileLocation = @"A:\Programs\Steam\steamapps\common\Hearts of Iron IV\localisation";

        public static string Status { get; private set; }

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

        public static bool Exists(string key) {
            return dict.ContainsKey(key);
        }

        public static bool Update(string key, string value, LocaleType type) {
            LocaleItem li;

            if (!Exists(key)) {
                string path;
                switch (type) {
                    case LocaleType.VictoryPointName: {
                        path = @$"{basePath}{localeFileLocation}\ttr_victory_points_l_english.yml";
                        break;
                    }
                    case LocaleType.StateName: {
                        path = @$"{basePath}{localeFileLocation}\ttr_state_names_l_english.yml";
                        break;
                    }
                    default: { 
                        path = @$"{basePath}{localeFileLocation}\ttr_misc_l_english.yml";
                        break;
                    }
                }
                li = new LocaleItem(value, path, true);
                dict.AddOrSet(key, li);
                return true;
            }

            if (IsLocaleVanilla(dict[key])) {
                string path;
                switch (type) {
                    case LocaleType.VictoryPointName: {
                        path = @$"{basePath}{localeFileLocation}\replace\ttr_victory_points_replace_l_english.yml";
                        break;
                    }
                    case LocaleType.StateName: {
                        path = @$"{basePath}{localeFileLocation}\replace\ttr_state_names_replace_l_english.yml";
                        break;
                    }
                    default: {
                        path = @$"{basePath}{localeFileLocation}\replace\ttr_misc_replace_l_english.yml";
                        break;
                    }
                }
                li = new LocaleItem(value, path, true);
                dict.AddOrSet(key, li);
                return true;
            }

            li = new LocaleItem(value, dict[key].Source, true);
            dict[key] = li;
            return true;
        }

        public static bool Save() {

            //extract all modified locale items and group them by their source file
            var modified = dict.Where(i => i.Value.Modified).GroupBy(
                item => item.Value.Source,
                item => (item.Key, item.Value.Content),
                (source, vars) => new {
                    Source = source,
                    Vars = vars
                });

            //group represents all the locale items with a certain source file
            foreach (var group in modified) {
                string[] file = File.ReadAllLines(group.Source);
                
                
                foreach (var item in group.Vars) {
                    //determine if the key is new or already existed
                    int x = Array.FindIndex(file, x => Regex.IsMatch(x, $@" {item.Key}"));
                    //key is new
                    if (x == -1) {
                        Array.Resize(ref file, file.Length+1);
                        file[file.Length - 1] = $" {item.Key}:0 \"{item.Content}\"";
                    }
                    //key isn't new
                    else {
                        file[x] = $" {item.Key}:0 \"{item.Content}\"";
                    }
                }
                File.WriteAllLines(group.Source, file, Encoding.UTF8);
            }

            Status = $"All locale successfully written to file";
            return true;
            
        }

        private static string[] GetLocaleFiles() {
            List<string> result = new List<string>();
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

                    LocaleItem l = new LocaleItem(val, fileName, false);

                    dict.AddOrSet(key, l);
                }
            }

        }

        public static bool IsLocaleVanilla(LocaleItem li) {
            return li.Source.Contains(vanillaLocaleFileLocation);
        }

        public static void SetBasePath(string p) {
            basePath = p;
        }
    }

    public struct LocaleItem {

        public LocaleItem(string content, string source) {
            Content = content;
            Source = source;
            Modified = false;
        }

        public LocaleItem(string content, string source, bool modified) {
            Content = content;
            Source = source;
            Modified = modified;
        }

        public string Content { get; }
        public string Source { get; }
        public bool Modified { get; set; }
    }

    
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace HOI4MI.Util {
    public static class Extensions {

        public static void AddOrSet<TKey, TValue>(this Dictionary<TKey, TValue> d, TKey key, TValue val) {
            d.AddOrSet(key, val, true);
        }

        public static void AddOrSet<TKey, TValue>(this Dictionary<TKey, TValue> d, TKey key, TValue val, bool overwrite) {
            if (key == null) return;
            if (d.ContainsKey(key)) {
                if (overwrite) d[key] = val;
            }
            else {
                d.Add(key, val);
            }
        }

        public static string ConvertStateCategory(this StateCategory c) {
            return c switch
            {
                StateCategory.Wasteland => "wasteland",
                StateCategory.Tiny_Island => "tiny_island",
                StateCategory.Enclave => "enclave",
                StateCategory.Pastoral => "pastoral",
                StateCategory.Small_Island => "small_island",
                StateCategory.Rural => "rural",
                StateCategory.Town => "town",
                StateCategory.Large_Town => "large_town",
                StateCategory.City => "city",
                StateCategory.Large_City => "large_city",
                StateCategory.Metropolis => "metropolis",
                StateCategory.Megalopolis => "megalopolis",
                _ => null,
            };
        }

        public static StateCategory? ConvertStateCategory(this string s) {
            return s switch
            {
                "wasteland" => StateCategory.Wasteland,
                "tiny_island" => StateCategory.Tiny_Island,
                "enclave" => StateCategory.Enclave,
                "pastoral" => StateCategory.Pastoral,
                "small_island" => StateCategory.Small_Island,
                "rural" => StateCategory.Rural,
                "town" => StateCategory.Town,
                "large_town" => StateCategory.Large_Town,
                "city" => StateCategory.City,
                "large_city" => StateCategory.Large_City,
                "metropolis" => StateCategory.Metropolis,
                "megalopolis" => StateCategory.Megalopolis,
                _ => null,
            };
        }
    }

    public static class Utils {

        private static bool[] bools = { true, false };

        public static int[] RandomColour() {
            int[] result = new int[3];

            for (int i = 0; i < 3; i++)
                result[i] = new Random().Next(0, 256);

            return result;
            
        }

        public static bool[] BoolValues() {
            return bools;
        }

    }
}

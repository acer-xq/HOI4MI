using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateEditor.Util {
    public static class Extensions {

        public static void AddOrSet<TKey, TValue>(this Dictionary<TKey, TValue> d, TKey key, TValue val) {
            d.AddOrSet(key, val, true);
        }

        public static void AddOrSet<TKey, TValue>(this Dictionary<TKey, TValue> d, TKey key, TValue val, bool overwrite) {
            if (d.ContainsKey(key)) {
                if (overwrite) d[key] = val;
            }
            else {
                d.Add(key, val);
            }
        }
    }
}

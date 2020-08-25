using HOI4MI.Entity;
using HOI4MI.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HOI4MI.Manager
{
    public class ResourceManager {

        private Dictionary<Country, ResourceSet> resourceMap;

        public ResourceManager(string p) {
            resourceMap = new Dictionary<Country, ResourceSet>();
        }

        public void ReloadResourceMap(bool infrastructure, bool useCore) {
            ReloadResourceMap(infrastructure, 0, useCore);
        }

        public void ReloadResourceMap(bool infrastructure, double excavation, bool useCore) {
            resourceMap.Clear();
            foreach (var v in EmptyResourceMap(false)) { resourceMap.Add(v.Key, v.Value); }
            foreach (State s in State.States) {
                double multiplier = 1 + excavation * 0.1;
                if (infrastructure) multiplier += s.Infrastructure * 0.1;

                Country[] c = new Country[] { };
                if (useCore) {
                    c = Country.Find(x => s.Cores.Contains(x.tag)).ToArray();
                }
                else {
                    c = Country.Find(x => x.tag == s.Owner).ToArray();
                }

                foreach (Country d in c) {          
                    try {
                        resourceMap[d] += (s.Resources * multiplier);
                    }
                    catch {
                        resourceMap[d] = (s.Resources * multiplier);
                    }
                }
            }
        }

        public Dictionary<Country, ResourceSet> GetResourceMap() {
            return resourceMap;
        }

        public Dictionary<Country, ResourceSet> EmptyResourceMap(bool includeEmpty) {
            Dictionary<Country, ResourceSet> map = new Dictionary<Country, ResourceSet>();
            if (includeEmpty) {
                foreach (Country c in Country.Countries) {
                    map.Add(c, new ResourceSet());
                }
            }
            else {
                foreach (State s in State.States) {
                    Country c = Country.Get(s.Owner);
                    map.AddOrSet(c, new ResourceSet(), false);
                }
            }
            return map;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using StateEditor.Util;
using System.Drawing;
using System.Diagnostics;
using System.IO;

namespace StateEditor.Entity
{
    public class Province {
        public static List<Province> Provinces { get { return provinces.Values.OrderBy(x => x.id).ToList(); } }
        public static string Status { get; private set; }

        private static Dictionary<int, Province> provinces = new Dictionary<int, Province>();

        private static string basePath = "";
        private static string provinceDefLocation = @"\map\definition.csv";

        public bool Modified { get; private set; }

        public int[] Rgb { get => rgb; set { rgb = value; SetModified(); } }
        public int VictoryPoints { get => victoryPoints; set { victoryPoints = value; SetModified(); } }
        public int LandForts { get => landForts; set { landForts = value; SetModified(); } }
        public int CoastalForts { get => coastalForts; set { coastalForts = value; SetModified(); } }
        public int NavalBase { get => navalBase; set { navalBase = value; SetModified(); } }
        public bool Coastal { get => coastal; set { coastal = value; SetModified(); } }
        public ProvinceType Type { get => type; set { type = value; SetModified(); } }
        public Continent Continent { get => continent; set { continent = value; SetModified(); } }
        public Terrain Terrain { get => terrain; set { terrain = value; SetModified(); } }

        public readonly int id;
        private int[] rgb;
        private int victoryPoints;
        private int landForts;
        private int coastalForts;
        private int navalBase;
        private bool coastal;
        private ProvinceType type;
        private Continent continent;
        private Terrain terrain;

        private Province(int id) {
            this.id = id;
            rgb = new int[] { 0, 0, 0 };
            victoryPoints = 0;
            landForts = 0;
            coastalForts = 0;
            navalBase = 0;
            coastal = false;
            type = ProvinceType.Land;
            continent = Continent.Europe;
            terrain = Terrain.Unknown;
        }
        public static Province Get(int id) {
            if (provinces.ContainsKey(id)) return provinces[id];
            return null;
        }

        public static bool Create(int id, int[] colour) {
            //Province with id already exists
            if (provinces.ContainsKey(id)) return false;
            //Province with colour already exists
            if (!provinces.Values.All(p => p.Rgb != colour)) return false;

            Province s = new Province(id);
            s.rgb = colour;
            provinces.Add(id, s);
            s.SetModified();
            return true;
        }

        public static bool ReloadAll() {
            string provinceDefFile = $"{basePath}{provinceDefLocation}";
            if (!Parser.ParseProvinceDef(provinceDefFile)) {
                Status = "Could not reload provinces";
                return false;
            }
            return true;
        }

        public static bool Save() {
            if (!IsAllValid()) {
                Status = "Not all provinces valid";
                return false;
            }
            foreach (Province p in provinces.Values) {
                if (!p.Modified) continue;
                if (!Write(p)) {
                    //Status = $"Could not write province {p}";
                    return false;
                }
                else {
                    State.Save();
                }
            }
            Status = "All provinces successfully written to file";
            return true;
        }

        public static bool Write(Province p) {
            //s is the state containing p
            State s = State.Find(s => s.Provinces.Contains(p)).First();
            s.SetModified();

            StringBuilder sb = new StringBuilder();
            sb.Append($"{p.id};{p.rgb[0]};{p.rgb[1]};{p.rgb[2]};{p.type};{p.coastal};{p.terrain};{(int)p.continent}");
            string path = $"{basePath}{provinceDefLocation}";
            string[] def = File.ReadAllLines(path);
            if (def.Length < p.id+1) Array.Resize(ref def, p.id+1);
            def[p.id] = sb.ToString().ToLower();
            File.WriteAllLines(path, def);

            //TODO write province to strategic region
            p.SetUnmodified();
            return true;
        }

        public static bool IsAllValid() {
            return provinces.Values.All(p => p != null || p.IsValid());
        }

        public static void SetBasePath(string path) {
            basePath = path;
        }

        // INSTANCE METHODS//
        public void SetModified() {
            Modified = true;
        }

        public void SetUnmodified() {
            Modified = false;
        }

        public bool IsEmpty() {
            return landForts == 0 && coastalForts == 0 && navalBase == 0;
        }

        public bool HasVictoryPoints() {
            return victoryPoints != 0;
        }

        public bool IsValid() {
            //province ids must be contiguous
            if (id > provinces.Count) return false;

            List<State> temp = State.Find(s => s.Provinces.Contains(this));
            if (temp.Count < 1 && id != 0) { Status = $"Province {id} does not have a state"; return false; }
            if (temp.Count > 1 && id != 0) { Status = $"Province {id} is in more than one state"; return false; }

            if (victoryPoints < 0) return false;
            if (landForts < 0) return false;
            if (coastalForts < 0) return false;
            if (navalBase < 0) return false;
            return true;
        }

        public override string ToString() {
            return id.ToString();
        }

        public string ToStringVerbose() {
            StringBuilder result = new StringBuilder();
            result.Append($"{id}");
            if (HasVictoryPoints() || !IsEmpty()) {
                result.Append($": {{");
                result.Append(HasVictoryPoints() ? $"vp: {VictoryPoints}, " : "");
                result.Append(LandForts != 0 ? $"landForts: {LandForts}, " : "");
                result.Append(CoastalForts != 0 ? $"coastalForts: {CoastalForts}, " : "");
                result.Append(NavalBase != 0 ? $"navalBases: {NavalBase}, " : "");
                result.Remove(result.Length - 2, 2);
                result.Append($"}}");
            }
            return result.ToString();
        }
        
    }
}

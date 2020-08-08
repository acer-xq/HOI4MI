using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using StateEditor.Util;
using System.Drawing;

namespace StateEditor.Entity
{
    public class Province {
        public static List<Province> Provinces { get { return provinces.Values.OrderBy(x => x.id).ToList(); } }


        private static Dictionary<int, Province> provinces = new Dictionary<int, Province>();
        private static HashSet<int[]> provinceColours = new HashSet<int[]>();

        private static string basePath = "";
        private static string provinceDefLocation = @"\map\definition.csv";

        public int[] Rgb { get => rgb; set => rgb = value; }
        public int VictoryPoints { get => victoryPoints; set => victoryPoints = value; }
        public int LandForts { get => landForts; set => landForts = value; }
        public int CoastalForts { get => coastalForts; set => coastalForts = value; }
        public int NavalBase { get => navalBase; set => navalBase = value; }
        public bool Coastal { get => coastal; set => coastal = value; }
        public ProvinceType Type { get => type; set => type = value; }
        public Continent Continent { get => continent; set => continent = value; }
        public Terrain Terrain { get => terrain; set => terrain = value; }

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
            //State with id already exists
            if (provinces.ContainsKey(id)) return false;
            if (provinceColours.Contains(colour)) return false;

            Province s = new Province(id);
            s.rgb = colour;
            provinces.Add(id, s);
            //Modified(id);
            return true;
        }

        public static bool ReloadAll() {
            string provinceDefFile = $"{basePath}{provinceDefLocation}";
            if (Parser.ParseProvinceDef(provinceDefFile)) {
                Console.WriteLine(Parser.Status);
                return false;
            }
            return true;
        }

        public static void SetBasePath(string path) {
            basePath = path;
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

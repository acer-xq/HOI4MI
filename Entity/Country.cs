using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StateEditor.Entity
{
    public class Country : IComparable<Country> {

        public static List<Country> Countries { get { return countries.Values.OrderBy(x => x.tag).ToList(); } }
        public static int Count { get { return countries.Count; } }
        public static string Status { get; private set; }

        private static Dictionary<string, Country> countries = new Dictionary<string, Country>();
        private static string basePath = "";
        private static string countryFileLocation = @"\history\countries\";
        public bool Modified { get; private set; }

        public readonly string tag;

        #region FIELDS
        public string Name {
            get { return name; }
            set {
                SetModified();
                name = value;
            }
        }

        public string Oob {
            get { return oob; }
            set {
                SetModified();
                oob = value;
            }
        }

        public int ResearchSlots {
            get { return researchSlots; }
            set {
                SetModified();
                researchSlots = value;
            }
        }

        public int Convoys {
            get { return convoys; }
            set {
                SetModified();
                convoys = value;
            }
        }

        public double Stability {
            get { return stability; }
            set {
                SetModified();
                stability = value;
            }
        }

        public double WarSupport {
            get { return warSupport; }
            set {
                SetModified();
                warSupport = value;
            }
        }

        public int Capital {
            get { return capital; }
            set {
                SetModified();
                capital = value;
            }
        }

        public Politics Politics {
            get { return politics; }
            set {
                SetModified();
                politics = value;
            }
        }

        public string FactionName {
            get { return factionName; }
            set {
                SetModified();
                factionName = value;
            }
        }

        public List<string> FactionMembers {
            get { return factionMembers; }
            set {
                SetModified();
                factionMembers = value;
            }
        }

        private string name;
        private string oob;
        private int researchSlots;
        private int convoys;
        private double stability;
        private double warSupport;
        private int capital;
        private Politics politics;
        private string factionName;
        private List<string> factionMembers;
        #endregion

        private Country(string t) {
            tag = t;
            name = string.Empty;
            oob = string.Empty;
            researchSlots = 0;
            convoys = 0;
            stability = 0;
            warSupport = 0;
            politics = new Politics();
            factionName = string.Empty;
            factionMembers = new List<string> { };
        }

        public static Country Get(string tag) {
            if (countries.ContainsKey(tag)) return countries[tag];
            return null;
        }

        public static bool Create(string tag) {
            if (countries.ContainsKey(tag)) return false;

            Country c = new Country(tag);
            countries.Add(tag, c);
            c.SetModified();
            return true;
        }

        public static List<Country> Find(Func<Country, bool> p) {
            return countries.Values.Where(p).OrderBy(x => x.tag).ToList();
        }

        public static bool IsAllValid() {
            return countries.Values.All(s => s != null || s.IsValid());
        }

        public static bool ReloadAll() {
            countries.Clear();
            string[] stateFiles = Directory.GetFiles($@"{basePath}{countryFileLocation}");
            foreach (string s in stateFiles) {
                if (!s.EndsWith(".txt")) continue;
                if (!Parser.ParseCountry(s)) {
                    return false;
                }
            }
            return true;
        }

        public static bool Save() {
            return true;
        }

        public static bool Write(Country c) {
            return true;
        }

        public static bool SetBasePath(string path) {
            basePath = path;
            return true;
        }

        // INSTANCE METHODS //

        public bool IsValid() {
            return true;
        }

        private void SetModified() {
            Modified = true;
        }

        public void SetUnmodified() {
            Modified = false;
        }

        public string ToStringVerbose() {
            string members = $"{string.Join(", ", FactionMembers)}";
            return $"{tag}: {{name: {Name}, oob: {Oob}, stability: {Stability}, wsupport: {WarSupport}, research: {ResearchSlots}, convoys: {Convoys}, faction: {FactionName}, members: {members}, politics: {Politics.ToString()}}}";
        }

        public override string ToString() {
            return $"{tag}";
        }

        public int CompareTo(Country other) {
            return string.Compare(tag, other.tag);
        }
    }
}

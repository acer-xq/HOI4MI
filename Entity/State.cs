﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StateEditor.Entity;
using StateEditor.Util;

namespace StateEditor.Entity
{
    
    public sealed class State : IComparable<State> {

        public static List<State> States { get { return states.Values.OrderBy(x => x.id).ToList(); } }
        public static int Count { get { return states.Count; } }

        private static Dictionary<int, State> states = new Dictionary<int, State>();
        private static string basePath = "";
        private static string stateFileLocation = @"\history\states\";
        public static string Status { get; private set; }

        public readonly int id;
        public bool Modified { get; private set; }

        #region FIELDS
        public string FileName {
            get { return fileName; }
            set {
                SetModified(this);
                fileName = value; 
            } 
        }
        public string Name { 
            get { return name; }
            set {
                SetModified(this);
                name = value; 
            }
        }
        public string LocalisedName {
            get { return localisedName; }
            set {
                SetModified(this);
                localisedName = value;
            }
        }
        public int Manpower {
            get { return manpower; }
            set {
                SetModified(this);
                manpower = value;
            }
        }
        public int BuildFactor {
            get { return buildFactor; }
            set {
                SetModified(this);
                buildFactor = value;
            }
        }
        public StateCategory Category {
            get { return category; }
            set {
                SetModified(this);
                category = value;
            }
        }
        public ResourceSet Resources {
            get { return resources; }
            set {
                SetModified(this);
                resources = value;
            }
        }
        public string Owner {
            get { return owner; }
            set {
                SetModified(this);
                owner = value;
            }
        }
        public HashSet<string> Cores {
            get { return cores; }
            set {
                SetModified(this);
                cores = value;
            }
        }
        public HashSet<Province> Provinces {
            get { return provinces; }
            set {
                SetModified(this);
                provinces = value;
            }
        }
        public int Infrastructure {
            get { return infrastructure; }
            set {
                SetModified(this);
                infrastructure = value;
            }
        }
        public int MilitaryFactories {
            get { return militaryFactories; }
            set {
                SetModified(this);
                militaryFactories = value;
            }
        }
        public int CivillianFactories {
            get { return civillianFactories; }
            set {
                SetModified(this);
                civillianFactories = value;
            }
        }
        public int Dockyards {
            get { return dockyards; }
            set {
                SetModified(this);
                dockyards = value;
            }
        }
        public int Refineries {
            get { return refineries; }
            set {
                SetModified(this);
                refineries = value;
            }
        }
        public int Silos {
            get { return silos; }
            set {
                SetModified(this);
                silos = value;
            }
        }
        public int Antiair {
            get { return antiair; }
            set {
                SetModified(this);
                antiair = value;
            }
        }
        public int Reactors {
            get { return reactors; }
            set {
                SetModified(this);
                reactors = value;
            }
        }
        public int Airbases {
            get { return airbases; }
            set {
                SetModified(this);
                airbases = value;
            }
        }
        public int Rockets {
            get { return rockets; }
            set {
                SetModified(this);
                rockets = value;
            }
        }
        public int Radar {
            get { return radar; }
            set {
                SetModified(this);
                radar = value;
            }
        }

        private string owner;
        private HashSet<string> cores;
        private HashSet<Province> provinces;
        private int infrastructure;
        private int militaryFactories;
        private int civillianFactories;
        private int dockyards;
        private int refineries;
        private int silos;
        private int antiair;
        private int reactors;
        private int airbases;
        private int rockets;
        private int radar;
        private string fileName;
        private string name;
        private string localisedName;
        private int manpower;
        private int buildFactor;
        private StateCategory category;
        private ResourceSet resources;

        #endregion

        private State(int id) {
            this.id = id;
            fileName = "";
            name = "";
            localisedName = "";
            buildFactor = 1;
            category = StateCategory.Wasteland;
            manpower = 0;
            resources = new ResourceSet();
            owner = "";
            cores = new HashSet<string>();
            provinces = new HashSet<Province>();
            infrastructure = 0;
            militaryFactories = 0;
            civillianFactories = 0;
            dockyards = 0;
            refineries = 0;
            silos = 0;
            antiair = 0;
            reactors = 0;
            airbases = 0;
            rockets = 0;
            radar = 0;

        }

        public static State Get(int id) {
            if (states.ContainsKey(id)) return states[id];
            return null;
        }

        public static bool Create(int id) {
            //State with id already exists
            if (states.ContainsKey(id)) return false;

            State s = new State(id);
            states.Add(id, s);
            SetModified(s);
            return true;
        }

        public static List<State> Find(Func<State, bool> p) {
            return states.Values.Where(p).OrderBy(x => x.id).ToList();
        }

        public static bool ReloadAll() {
            states.Clear();
            string[] stateFiles = Directory.GetFiles($@"{basePath}{stateFileLocation}");
            foreach (string s in stateFiles) {
                if (!s.EndsWith(".txt")) continue;
                if (!Parser.ParseState(s)) {
                    Debug.WriteLine(Parser.GetError());
                    return false; 
                }
            }
            return true;
        }

        public static bool Reload(int i) {
            State s = Get(i);
            if (s == null) return false;
            string stateFile = $@"{basePath}{stateFileLocation}{s.fileName}";
            if (!Parser.ParseState(stateFile)) {
                Console.WriteLine(Parser.GetError());
                return false;
            }
            return true;
        }

        public static bool IsAllValid() {
            return states.Values.All(s => s != null || s.IsValid());
        }

        public static bool Save() {
            if (!IsAllValid()) {
                Status = "Not all states valid";
                return false; 
            }
            foreach (State s in states.Values) {
                if (!s.Modified) continue;
                if (!Write(s)) {
                    Status = $"Could not write state {s}";
                    return false; 
                }
                Debug.WriteLine($"State {s} written");
            }
            Status = "All states successfully written to file";
            return true;
        }

        public static bool Write(State s) {
            StringBuilder vps = new StringBuilder("");
            foreach (Province p in s.provinces) {
                if (p.HasVictoryPoints()) {
                    vps.Append($"\t\tvictory_points={{{p.id} {p.VictoryPoints}}}\n");
                }
            }
            StringBuilder sb = new StringBuilder();
            sb.Append($"\n## GENERATED BY HOI4MI ##");
            sb.Append($"\nstate={{\n");
            sb.Append($"\tid={s.id}\n");
            sb.Append($"\tname=\"{s.name}\"\n");
            sb.Append($"\tstate_category={s.category.ConvertStateCategory()}\n");
            sb.Append($"\tmanpower={s.manpower}\n");
            if (!s.resources.IsEmpty()) { 
                sb.Append($"\tresources={{\n");
                sb.Append(s.resources.Steel > 0 ? $"\t\tsteel={s.resources.Steel}\n" : "");
                sb.Append(s.resources.Tungsten > 0 ? $"\t\ttungsten={s.resources.Tungsten}\n" : "");
                sb.Append(s.resources.Oil > 0 ? $"\t\toil={s.resources.Oil}\n" : "");
                sb.Append(s.resources.Rubber > 0 ? $"\t\trubber={s.resources.Rubber}\n" : "");
                sb.Append(s.resources.Chromium > 0 ? $"\t\tchromium={s.resources.Chromium}\n" : "");
                sb.Append(s.resources.Aluminium > 0 ? $"\t\taluminium={s.resources.Aluminium}\n" : "");
                sb.Append($"\t}}\n");
            }

            sb.Append($"\thistory={{\n");
            sb.Append($"\t\towner={s.owner}\n");
            foreach (string str in s.cores) {
                sb.Append($"\t\tadd_core_of={str}\n");
            }
            sb.Append(vps.ToString());

            sb.Append($"\t\tbuildings={{\n");
            sb.Append($"\t\t\tinfrastructure={s.infrastructure}\n");
            sb.Append(s.civillianFactories > 0 ? $"\t\t\tindustrial_complex={s.civillianFactories}\n" : "");
            sb.Append(s.militaryFactories > 0 ? $"\t\t\tarms_factory={s.militaryFactories}\n" : "");
            sb.Append(s.dockyards > 0 ? $"\t\t\tdockyard={s.dockyards}\n" : "");
            sb.Append(s.refineries > 0 ? $"\t\t\tsynthetic_refinery={s.refineries}\n" : "");
            sb.Append(s.silos > 0 ? $"\t\t\tfuel_silo={s.silos}\n" : "");
            sb.Append(s.reactors > 0 ? $"\t\t\tnuclear_reactor={s.reactors}\n" : "");
            sb.Append(s.airbases > 0 ? $"\t\t\tair_base={s.airbases}\n" : "");
            sb.Append(s.antiair > 0 ? $"\t\t\tanti_air_building={s.antiair}\n" : "");
            sb.Append(s.radar > 0 ? $"\t\t\tradar_station={s.radar}\n" : "");
            sb.Append(s.rockets > 0 ? $"\t\t\trocket_site={s.rockets}\n" : "");
            foreach (Province p in s.provinces) {
                if (!p.IsEmpty()) {
                    sb.Append($"\t\t\t{p.id}={{\n");
                    sb.Append(p.LandForts > 0 ? $"\t\t\t\tbunker={p.LandForts}\n" : "");
                    sb.Append(p.CoastalForts > 0 ? $"\t\t\t\tcoastal_bunker={p.LandForts}\n" : "");
                    sb.Append(p.NavalBase > 0 ? $"\t\t\t\tnaval_base={p.NavalBase}\n" : "");
                    sb.Append($"\t\t\t}}\n");
                }
            }
            sb.Append($"\t\t}}\n");
            sb.Append($"\t}}\n");

            sb.Append($"\tprovinces={{\n\t\t");
            foreach (Province p in s.provinces) {
                sb.Append($"{p.id} ");
            }
            sb.Append($"\n\t}}\n");
            sb.Append($"}}\n");

            Debug.WriteLine($"{s.fileName}");
            string path = $"{basePath}{stateFileLocation}{s.fileName}";
            if (File.Exists(path)) File.Copy(path, $"{path}.old");
            File.WriteAllText(path, sb.ToString());
            return true;
        }


        public static bool TransferProvince(State s1, State s2, Province p) {
            if (s1 == null || s2 == null) return false;
            if (!s1.provinces.Contains(p)) return false;

            s1.provinces.Remove(p);
            s2.provinces.Add(p);
            return true;
        }

        private static void SetModified(State s) {
            s.Modified = true;
        }

        public static bool SetBasePath(string path) {
            basePath = path;
            return true;
        }

        public void SetUnmodified() {
            Modified = false;
        }

        public bool IsValid() {
            //states must have contiguous ids, if has an id larger than # of states this can't be true
            if (id > states.Count) return false;
            if (owner == "") return false;
            if (infrastructure < 0 || infrastructure > 10) return false;
            if (militaryFactories < 0) return false;
            if (civillianFactories < 0) return false;
            if (dockyards < 0) return false;
            if (silos < 0) return false;
            if (refineries < 0) return false;
            if (reactors < 0) return false;
            if (radar < 0) return false;
            if (antiair < 0) return false;
            if (rockets < 0) return false;
            if (airbases < 0) return false;

            if (provinces == null) return false;
            //a state must have at least 1 province
            if (provinces.Count == 0) return false;
            if (provinces.Any(p => !p.IsValid())) return false;

            if (!resources.IsValid()) return false;
            return true;
        }

        public int CompareTo(State s) {
            return Math.Sign(this.id - s.id);
        }

        public override string ToString() {

            return $"{localisedName} ({id}) ({owner})";
        }

        public string ToStringVerbose() {
            List<string> psl = new List<string>();
            foreach (Province p in provinces) {
                psl.Add(p.ToString());
            }
            string provincesString = $"{{{string.Join(", ", psl) }}}";
            string coresString = $"{{{string.Join(", ", cores)}}}";

            return $"State {id}: {{name: {name}, localisedname: {localisedName}, category: {category}, manpower: {manpower}, factor: {buildFactor}, resources: {resources.ToString()}, " + 
                   $"owner: {owner}, cores: {coresString}, inf: {infrastructure}, mils: {militaryFactories}, civs: {civillianFactories}, docks: {dockyards}, " +
                   $"refineries: {refineries}, silos: {silos}, antiair: {antiair}, reactors: {reactors}, airbases: {airbases}, rockets: {rockets}, radar: {radar}, provinces: {provincesString}}}";
        }

    }
}
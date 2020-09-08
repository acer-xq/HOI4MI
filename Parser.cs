using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;
using HOI4MI.Manager;
using HOI4MI.Entity;
using HOI4MI.Util;

namespace HOI4MI
{
    public static class Parser {

        public static string Status { get; private set; }

        private static NumberStyles valueFormat = NumberStyles.AllowDecimalPoint | NumberStyles.AllowLeadingWhite | NumberStyles.AllowTrailingWhite;

        private static string currentFile;

        public static bool ParseProvinceDef(string path) {
            string[] lines = File.ReadAllLines(path);
            string[] data;
            foreach (string l in lines) {
                data = l.Split(';');
                int id = -1;
                int[] rgb = new int[3];
                if (!int.TryParse(data[0], out id)) {
                    Status = $"malformed province ID in line {l}";
                    return false;
                }
                if (!int.TryParse(data[1], out rgb[0])) {
                    Status = $"malformed R for province {id}";
                    return false;
                }
                if (!int.TryParse(data[2], out rgb[1])) {
                    Status = $"malformed G for province {id}";
                    return false;
                }
                if (!int.TryParse(data[3], out rgb[2])) {
                    Status = $"malformed B for province {id}";
                    return false;
                }

                if (Province.Create(id, rgb)) {
                    Province p = Province.Get(id);
                    p.Type = data[4] switch {
                        "sea" => ProvinceType.Sea,
                        "lake" => ProvinceType.Lake,
                        _ => ProvinceType.Land,
                    };
                    p.Coastal = data[5] == "true";
                    p.Terrain = data[6] switch {
                        "ocean" => Terrain.Ocean,
                        "lake" => Terrain.Lake,
                        "forest" => Terrain.Forest,
                        "hills" => Terrain.Hills,
                        "mountain" => Terrain.Mountain,
                        "plains" => Terrain.Plains,
                        "urban" => Terrain.Urban,
                        "jungle" => Terrain.Jungle,
                        "marsh" => Terrain.Marsh,
                        "desert" => Terrain.Desert,
                        "water_fjords" => Terrain.Water_Fjords,
                        "water_shallow_sea" => Terrain.Water_Shallow_Sea,
                        "water_deep_ocean" => Terrain.Water_Deep_Ocean,
                        _ => Terrain.Unknown,
                    };
                    if (!int.TryParse(data[7], out int continent)) {
                        Status = $"malformed continent for province {id}";
                        return false;
                    }
                    p.Continent = (Continent)continent;
                    p.SetUnmodified();
                }

                else {
                    Status = $"Error creating province {id}.";
                    return false;
                }
            }
            return true;
        }
        
        public static bool ParseState(string path) {
            string f = File.ReadAllText(path);
            currentFile = RemoveWhiteSpace(f);

            //check the provinces list is a list of numbers
            string provinceString = FindKey("provinces");
            if (!Regex.IsMatch(provinceString, @"{((\s+)(\d+))+\s*}")) {
                Status = $"Malformed provinces in {path}.";
                return false;
            }

            //get all the numbers in string form
            var provStrings = Regex.Matches(provinceString, @"\d+");
            HashSet<Province> provs = new HashSet<Province>();

            foreach (Match m in provStrings) {
                string s = m.Value;
                //one of the provinces wasn't a number
                if (!int.TryParse(s, out int provId)) {
                    Status = $"Province {s} isn't an int in {path}.";
                    return false; 
                }

                Province p = Province.Get(provId);
                if (p == null) {
                    Status = $"Province {provId} doesn't exist";
                    return false;
                }
                //check if there are any province-level buildings
                string temp = FindKey(s);
                if (!string.IsNullOrEmpty(temp)) {
                    p.LandForts = FindKeyInt("[^_]bunker", temp);
                    p.CoastalForts = FindKeyInt("coastal_bunker", temp);
                    p.NavalBase = FindKeyInt("naval_base", temp);
                }
                provs.Add(p);
                p.SetUnmodified();
            }

            //check if there's any vps specified in the file
            //doesnt have to be for provinces from this state
            List<string> vpLists = FindMultipleKey("victory_points");
            foreach (string s in vpLists) {
                Match m = Regex.Match(s, $@"(\d+)\s+(\d+)");
                if (m.Success) {
                    int pid = int.Parse(m.Groups[1].Value);
                    Province p = Province.Get(pid);
                    if (p == null) {
                        Status = $"Victory points specified for invalid province {pid}";
                        return false;
                    }
                    p.VictoryPoints = int.Parse(m.Groups[2].Value);
                    p.Name = Localisation.GetSafe($"VICTORY_POINTS_{pid}");
                    p.SetUnmodified();
                }
            }

            ResourceSet res = new ResourceSet {
                Aluminium = FindKeyDouble("aluminium"),
                Steel = FindKeyDouble("steel"),
                Tungsten = FindKeyDouble("tungsten"),
                Chromium = FindKeyDouble("chromium"),
                Oil = FindKeyDouble("oil"),
                Rubber = FindKeyDouble("rubber")
            };

            StateCategory? c = FindKey("category").ConvertStateCategory();
            if (c == null) {
                //state didn't have a valid category listed
                Status = $"Error parsing state category in {path}.";
                return false;
            }

            int stateId = FindKeyInt("id");
            string stateName = FindKey("name");
            int buildingFactor = FindKeyInt("buildings_max_level_factor");

            if (State.Create(stateId)) {
                State s = State.Get(stateId);
                s.Name = stateName;
                s.FileName = path.Split('\\').Last();
                s.LocalisedName = Localisation.GetSafe(stateName);
                s.Manpower = FindKeyInt("manpower");
                s.BuildFactor = buildingFactor == 0 ? 1 : buildingFactor;
                s.Category = (StateCategory)c;
                s.Resources = res;

                s.Owner = FindKey("owner");
                s.Cores = FindMultipleKey("add_core_of").ToHashSet();
                s.Infrastructure = FindKeyInt("infrastructure");
                s.CivillianFactories = FindKeyInt("industrial_complex");
                s.MilitaryFactories = FindKeyInt("arms_factory");
                s.Dockyards = FindKeyInt("dockyard");
                s.Refineries = FindKeyInt("synthetic_refinery");
                s.Antiair = FindKeyInt("antiair");
                s.Silos = FindKeyInt("fuel_silo");
                s.Radar = FindKeyInt("radar_station");
                s.Rockets = FindKeyInt("rocket_site");
                s.Reactors = FindKeyInt("nuclear_reactor");
                s.Airbases = FindKeyInt("air_base");
                s.Impassable = FindKey("impassable") == "yes";
                s.Provinces = provs;
                s.SetUnmodified();
            }
            //something went wrong when creating the state
            else {
                Status = $"Error creating state {stateId} for {path}.";
                return false;
            }

            return true;
        }

        public static bool ParseCountry(string path) {
            string f = File.ReadAllText(path);
            currentFile = RemoveWhiteSpace(f);
            string tag = Regex.Match(path.Split(@"\").Last(), @"([A-Z]+) - .+").Groups[1].Value.ToUpper();
            
            //string tag = path.Split(@"\").Last().Substring(1, 3).ToUpper();

            if (!Regex.IsMatch(tag, @"[A-Z]+")) {
                Status = $"Country tag {tag} is not valid for {path}.";
                return false;
            }

            string pol = FindKey("set_politics");
            string pop = FindKey("set_popularities");
            Politics p = new Politics(); 
            if (pop != string.Empty) {
                p.neutrality = FindKeyInt("neutrality", pop);
                p.democracy = FindKeyInt("democratic", pop);
                p.fascism = FindKeyInt("fascism", pop);
                p.communism = FindKeyInt("communism", pop);
            };

            if (pol != string.Empty) {
                p.rulingParty = (Ideology)Enum.Parse(typeof(Ideology), FindKey("ruling_party", pol), true);
                p.lastElection = DateTime.Parse(FindKey("last_election", pol));
                p.electionFrequency = FindKeyInt("election_frequency", pol);
                p.electionsAllowed = FindKey("election_allowed", pol) == "yes";
            
            }

            if (Country.Create(tag)) {
                Country c = Country.Get(tag);
                c.Name = Localisation.Get($"{tag}_{p.rulingParty.ToString().ToLower()}");
                c.Oob = FindKey("oob");
                c.ResearchSlots = FindKeyInt("set_research_slots");
                c.Convoys = FindKeyInt("set_convoys");
                c.Stability = FindKeyDouble("set_stability");
                c.WarSupport = FindKeyDouble("set_war_support");
                c.Politics = p;
                c.FactionName = FindKey("create_faction");
                c.FactionMembers = FindMultipleKey("add_to_faction");
                c.Capital = FindKeyInt("capital");
                c.SetUnmodified();
            }
            else {
                Status = $"Error creating country {tag} for {path}.";
                return false;
            }

            return true;
        }

        public static string FindKey(string k) {
            return FindKey(k, currentFile);
        }

        public static string FindKey(string k, string s) {

            int depth = 0;
            string result = string.Empty;
            Match m = Regex.Match(s, $"{k}=");
            if (m.Success) {
                string temp = s.Substring(m.Index + m.Length);
                foreach (char c in temp) {
                    if (c == '{') depth++;
                    if (c == '}') {
                        if (depth == 0) break;
                        depth--;
                    }
                    if (c == '\n' && depth == 0) break;
                    result += c;
                }
            }
            
            return result.Trim('"');
        }

        private static List<string> FindMultipleKey(string k) {
            return FindMultipleKey(k, currentFile);
        }

        private static List<string> FindMultipleKey(string k, string s) {
            int depth = 0;
            List<string> result = new List<string>();

            MatchCollection m = Regex.Matches(s, $"{k}=");
            foreach (Match n in m) {
                string temp2 = string.Empty;
                if (n.Success) {
                    string temp = s.Substring(n.Index + n.Length);
                    foreach (char c in temp) {
                        if (c == '{') depth++;
                        if (c == '}') {
                            if (depth == 0) break;
                            depth--;
                        }
                        if (c == '\n' && depth == 0) break;
                        temp2 += c;
                    }
                    result.Add(temp2.Trim('"'));
                }
            }
            
            return result;
        }

        private static int FindKeyInt(string k) {
            return FindKeyInt(k, currentFile);
        }

        private static int FindKeyInt(string k, string s) {
            string value = FindKey(k, s);
            if (value == string.Empty) return 0;
            if (!int.TryParse(value, valueFormat, CultureInfo.CurrentCulture.NumberFormat, out int result)) throw new ArithmeticException();
            return result;
        }

        private static double FindKeyDouble(string k) {
            return FindKeyDouble(k, currentFile);
        }

        private static double FindKeyDouble(string k, string s) {
            string value = FindKey(k, s);
            if (value == string.Empty) return 0;
            if (!double.TryParse(value, valueFormat, CultureInfo.CurrentCulture.NumberFormat, out double result)) throw new ArithmeticException();
            return result;
        }

        private static string RemoveWhiteSpace(string lines) {
            lines = Regex.Replace(lines, @"^(.*)#.*$", "$1", RegexOptions.Multiline); //remove comments
            lines = Regex.Replace(lines, @"\r([^\n])", "\r\n", RegexOptions.Multiline);
            lines = Regex.Replace(lines, @"^\s*$\n|\r|\t", string.Empty, RegexOptions.Multiline); //remove empty lines
            lines = Regex.Replace(lines, @"(.)\s*=\s*(.)", "$1=$2", RegexOptions.Multiline); //remove spaces around =
            lines = Regex.Replace(lines, @"^\s*(\S.*?)\s*$", "$1", RegexOptions.Multiline); //remove leading and trailing spaces
            return lines;
        }
    }
}

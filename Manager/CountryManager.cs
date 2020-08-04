using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using StateEditor.Entity;

namespace StateEditor.Manager
{
    public class CountryManager {

        private string basePath;
        private string countryFileLocation = @"\history\countries";
        private Dictionary<string, Country> countries;
        public List<Country> Countries { get { return countries.Values.ToList(); } }

        private LocalisationManager localeManager;

        public CountryManager(string p, LocalisationManager lm) {
            basePath = p;
            localeManager = lm;
            countries = new Dictionary<string, Country>();
        }

        public Country GetCountry(string tag) {
            return countries[tag];
        }

        public List<Country> GetCountries(Func<Country, bool> p) {
            return countries.Values.Where(p).ToList();
        }

        public string[] GetCountryFiles() {
            return Directory.GetFiles($@"{basePath}{countryFileLocation}");
        }

        public void ReloadCountries() {
            string[] countryFiles = GetCountryFiles();
            foreach (string s in countryFiles) {
                Country temp = Parser.ParseCountry(File.ReadAllText(s), s.Replace(basePath, "").Replace(countryFileLocation, ""));
                countries.Add(temp.tag, temp);
            }
            countries.OrderBy(x => x.Key);
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateEditor.Entity
{
    public class Country : IComparable<Country> {
        public string tag;
        public string name;
        public string oob;

        public int researchSlots;
        public int convoys;
        public double stability;
        public double warSupport;
        public int capital;

        public Politics politics;
        public string factionName;
        public List<string> factionMembers;

        public Country(string t) {
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

        public string ToStringVerbose() {
            string members = $"{string.Join(", ", factionMembers)}";
            return $"{tag}: {{name: {name}, oob: {oob}, stability: {stability}, wsupport: {warSupport}, research: {researchSlots}, convoys: {convoys}, faction: {factionName}, members: {members}, politics: {politics.ToString()}}}";
        }

        public override string ToString() {
            return $"{tag}";
        }

        public int CompareTo(Country other) {
            return string.Compare(tag, other.tag);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StateEditor.Util;

namespace StateEditor.Entity
{
    public class Politics {
        public Ideology rulingParty;
        public DateTime lastElection;
        public int electionFrequency;
        public bool electionsAllowed;

        public int neutrality;
        public int democracy;
        public int fascism;
        public int communism;

        public Politics() {
            rulingParty = Ideology.Neutrality;
            lastElection = DateTime.MinValue;
            electionFrequency = 0;
            electionsAllowed = false;
            neutrality = 0;
            democracy = 0;
            fascism = 0;
            communism = 0;
        }

        public override string ToString() {
            return $"{{rulingParty: {rulingParty}, lastElection: {lastElection}, electionFreq: {electionFrequency}, " +
                $"elections: {electionsAllowed}, popularities: {{n: {neutrality}, d: {democracy}, f: {fascism}, c: {communism} }}";
        }
    }
}

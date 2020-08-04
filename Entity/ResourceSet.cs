using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateEditor.Entity
{
    public class ResourceSet {
        public static readonly string[] ResourceStrings = { "oil", "steel", "tungsten", "chromium", "aluminium", "rubber" };
        public double Oil { 
            get => resources[0]; 
            set => resources[0] = value; 
        }
        public double Steel { 
            get => resources[1]; 
            set => resources[1] = value; 
        }
        public double Tungsten { 
            get => resources[2]; 
            set => resources[2] = value; 
        }
        public double Chromium { 
            get => resources[3]; 
            set => resources[3] = value; 
        }
        public double Aluminium { 
            get => resources[4]; 
            set => resources[4] = value; 
        }
        public double Rubber { 
            get => resources[5]; 
            set => resources[5] = value; 
        }
        public double this[int i] {
            get => resources[i];
            set => resources[i] = value;
        }

        private double[] resources;

        public ResourceSet() {
            resources = new double[6];
        }

        public bool IsValid() {
            foreach (double d in resources) {
                if (d < 0) return false;
            }
            return true;
        }

        public static ResourceSet operator +(ResourceSet a, ResourceSet b) {
            return new ResourceSet() {
                resources = a.resources.Zip(b.resources, (x, y) => x + y).ToArray()
            };
        }
        public static ResourceSet operator -(ResourceSet a, ResourceSet b) {
            return new ResourceSet() {
                resources = a.resources.Zip(b.resources, (x, y) => x - y).ToArray()
            };
        }

        public static ResourceSet operator *(ResourceSet a, double b) {
            return new ResourceSet() {
                resources = a.resources.Select(x => b * x).ToArray()
            };
        }


        public override string ToString() {
            return $"{{oil: {Math.Round(Oil)}, steel: {Math.Round(Steel)}, tungsten: {Math.Round(Tungsten)}, " +
                $"chromium: {Math.Round(Chromium)}, aluminium: {Math.Round(Aluminium)}, rubber: {Math.Round(Rubber)}}}";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateEditor.Util
{
    public enum StateCategory { Wasteland, Tiny_Island, Enclave, Pastoral, Small_Island, Rural, Town, Large_Town, City, Large_City, Metropolis, Megalopolis };
    public enum Ideology { Neutrality, Democratic, Fascism, Communism };
    public enum Resource { Oil, Steel, Tungsten, Chromium, Aluminium, Rubber };
    public enum ProvinceType { Land, Sea, Lake };
    public enum Terrain { Unknown, Ocean, Lake, Forest, Hills, Mountain, Plains, Urban, Jungle, Marsh, Desert, Water_Fjords, Water_Shallow_Sea, Water_Deep_Ocean };
    public enum Continent { None = 0, Europe = 1, NorthAmerica = 2, SouthAmerica = 3, Africa = 5, Asia = 6, MiddleEast = 7, Oceania = 4};
}

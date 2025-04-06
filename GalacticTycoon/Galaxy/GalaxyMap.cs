using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GalacticTycoon.Galaxy
{
    public class GalaxyMap {
        public List<PlanetSystem> PlanetSystems { get; set; }
        public GalaxyMap() {
            PlanetSystems = new List<PlanetSystem>();
        }
        public void AddPlanetSystem(PlanetSystem system) {
            PlanetSystems.Add(system);
        }
    }
}

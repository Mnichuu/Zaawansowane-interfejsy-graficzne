using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GalacticTycoon.Galaxy
{
    public class PlanetSystem {
        public string Name { get; set; }
        public List<Planet> Planets { get; set; }

        public PlanetSystem(string name) {
            Name = name;
            Planets = new List<Planet>();
        }

        public void AddPlanet(Planet planet) {
            Planets.Add(planet);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GalacticTycoon.Game
{
    public static class GameRules {
        public static void BuildMinePlus(Player.Player player, Galaxy.Planet planet) {
            if (planet.Owner == player) {
                planet.AddBuilding(new Buildings.MinePlus());
            }
        }

        public static void BuildGalacticShipyard(Player.Player player, Galaxy.PlanetSystem system) {
            if (system.Planets.All(p => p.Owner == player))
            {
                system.buildGalacticShipyard();
            }
        }

        public static void BuildColony(Player.Player player, Galaxy.Planet planet) {
            if (planet.Owner == player) {
                planet.AddBuilding(new Buildings.Colony());
            }
        }

        public static void BuildResidence(Player.Player player, Galaxy.Planet planet) {
            if (planet.Owner == player) {
                planet.AddBuilding(new Buildings.Residence());
            }
        }
    }
}

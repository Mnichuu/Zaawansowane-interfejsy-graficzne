using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GalacticTycoon.Game
{
    public static class GameRules {
        public static void BuildSpacePort(Player.Player player, Galaxy.Planet planet) {
            if (planet.Owner == null) {
                planet.SetOwner(player);
                planet.AddBuilding(new Buildings.SpacePort());
            }
        }
        // TODO : Implement the rest of the game rules
    }
}

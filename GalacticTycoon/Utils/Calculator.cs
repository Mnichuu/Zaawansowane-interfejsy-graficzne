using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GalacticTycoon.Utils
{
    public static class Calculator {
        public static int CalculateIncome(Player.Player player) {
            int totalIncome = 0;
            foreach (var planet in player.OwnedPlanets) {
                foreach (var building in planet.Buildings) {
                    totalIncome += building.Income;
                }
            }
            return totalIncome;
        }
    }
}

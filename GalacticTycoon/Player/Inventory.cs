using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GalacticTycoon.Player
{
    public class Inventory {
        public List<Buildings.Building> Buildings { get; set; }
        public Inventory() {
            Buildings = new List<Buildings.Building>();
        }

        public void AddBuilding(Buildings.Building building) {
            Buildings.Add(building);
        }
    }
}

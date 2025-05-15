using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace GalacticTycoon.Galaxy
{
    public class Planet
    {
        public string Name { get; set; }
        public Player.Player Owner { get; set; }
        public List<Buildings.Building> Buildings { get; set; }
        public string Description { get; set; }

        public Planet(string name) {
            Name = name;
            Owner = null;
            Buildings = new List<Buildings.Building>();
        }

        public void SetOwner(Player.Player player) {
            Owner = player;
        }

        public void AddBuilding(Buildings.Building building) {
            Buildings.Add(building);
        }
    }
}

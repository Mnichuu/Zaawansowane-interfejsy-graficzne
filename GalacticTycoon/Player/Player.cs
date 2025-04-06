using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalacticTycoon.Events;
using GalacticTycoon.Galaxy;

namespace GalacticTycoon.Player
{
    public class Player
    {
        public string Name { get; set; }
        public int GalacticCredits { get; set; }
        public List<Galaxy.Planet> OwnedPlanets { get; set; }
        public List<Events.EventCard> EventCards { get; set; }
        public int TurnsSkipped { get; set; }

        public Player(string name) {
            Name = name;
            GalacticCredits = 1000;
            OwnedPlanets = new List<Galaxy.Planet>();
            EventCards = new List<Events.EventCard>();
            TurnsSkipped = 0;
        }
        public void AddCredits(int amount) {
            GalacticCredits += amount;
        }

        public void SpendCredits(int amount) {
            if (amount <= GalacticCredits) {
                GalacticCredits -= amount;
            }
            else {
                Console.WriteLine("Not enough credits!");
            }
        }
    }
}

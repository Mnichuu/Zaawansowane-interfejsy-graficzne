using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GalacticTycoon.Events
{
    public abstract class EventCard {
        public string Name { get; set; }

        protected EventCard(string name) {
            Name = name;
        }

        public abstract void ApplyEffect(Player.Player player);
    }
    public class PirateAttackCard : EventCard {
        private readonly int ransomAmount;
        private readonly int turnsLost;

        public PirateAttackCard(int ransomAmount = 500, int turnsLost = 2) : base("Pirate Attack") {
            this.ransomAmount = ransomAmount;
            this.turnsLost = turnsLost;
        }

        public override void ApplyEffect(Player.Player player) {
            var defenseCard = player.EventCards.FirstOrDefault(card => card is DefenseAgainstPiratesCard);
            if (defenseCard != null) {
                player.EventCards.Remove(defenseCard);
                return;
            }

            if (player.GalacticCredits >= ransomAmount) {
                player.SpendCredits(ransomAmount);
            } else {
                player.TurnsSkipped += turnsLost;
            }
        }
    }
    public class DefenseAgainstPiratesCard : EventCard {
        public DefenseAgainstPiratesCard() : base("Defense Against Pirates") { }

        public override void ApplyEffect(Player.Player player) {
            player.EventCards.Add(this);
        }
    }

    public class GalacticTicketCard : EventCard {
        public GalacticTicketCard() : base("Galactic Ticket") { }

        public override void ApplyEffect(Player.Player player) {
            player.EventCards.Add(this);
        }
    }

    public class TaxCard : EventCard {
        private readonly double taxRate;

        public TaxCard(double taxRate = 0.1) : base("Imperial Tax") {
            this.taxRate = taxRate;
        }

        public override void ApplyEffect(Player.Player player) {
            int totalTax = (int)(player.OwnedPlanets.Sum(planet => planet.Buildings.Count * 100) * taxRate);
            player.SpendCredits(totalTax);
        }
    }

    public class LotteryWinCard : EventCard {
        private readonly int prizeAmount;

        public LotteryWinCard(int prizeAmount = 100) : base("Lottery Win") {
            this.prizeAmount = prizeAmount;
        }

        public override void ApplyEffect(Player.Player player) {
            player.AddCredits(prizeAmount);
        }
    }

    public class EngineFailureCard : EventCard {
        private readonly int towingCost;

        public EngineFailureCard(int towingCost = 500) : base("Engine Failure") {
            this.towingCost = towingCost;
        }

        public override void ApplyEffect(Player.Player player) {
            player.TurnsSkipped++;
            player.SpendCredits(towingCost);
        }
    }

    public class GalacticShipyardFailureCard : EventCard {
        private readonly int repairCost;

        public GalacticShipyardFailureCard(int repairCost = 100) : base("Galactic Shipyard Failure") {
            this.repairCost = repairCost;
        }

        public override void ApplyEffect(Player.Player player) {
            if (player.GalacticCredits >= repairCost) {
                player.SpendCredits(repairCost);
            } else {
                var shipyard = player.OwnedPlanets
                    .SelectMany(planet => planet.Buildings)
                    .FirstOrDefault(building => building is Buildings.GalacticShipyard);

                if (shipyard != null) {
                    var planet = player.OwnedPlanets.First(p => p.Buildings.Contains(shipyard));
                    planet.Buildings.Remove(shipyard);
                }
            }
        }
    }
}


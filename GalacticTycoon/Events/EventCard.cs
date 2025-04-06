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
        public PirateAttackCard() : base("Pirate Attack") { }

        public override void ApplyEffect(Player.Player player) {
            // Efekt ataku pirackiego
        }
    }

    //TODO : Add more event cards
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GalacticTycoon.Events
{
    public static class EventResolver {
        public static void ResolveEvent(EventCard card, Player.Player player) {
            card.ApplyEffect(player);
        }
    }
}

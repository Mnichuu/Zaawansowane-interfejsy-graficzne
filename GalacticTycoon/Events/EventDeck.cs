using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GalacticTycoon.Events
{
    public class EventDeck {
        private List<EventCard> cards;
        public EventDeck() {
            cards = new List<EventCard>();
        }

        public void AddCard(EventCard card) {
            cards.Add(card);
        }

        public EventCard DrawCard() {
            if (cards.Count == 0) {
                throw new InvalidOperationException("No cards left in the deck.");
            }
            Random rand = new Random();
            int index = rand.Next(cards.Count);
            EventCard drawnCard = cards[index];
            cards.RemoveAt(index);
            return drawnCard;
        }
    }
}

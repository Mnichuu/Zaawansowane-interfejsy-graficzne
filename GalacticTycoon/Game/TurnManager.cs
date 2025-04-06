using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GalacticTycoon.Game
{
    public class TurnManager {
        private List<Player.Player> players;
        private int currentPlayerIndex;

        public TurnManager(List<Player.Player> players) {
            this.players = players;
            currentPlayerIndex = 0;
        }

        public void NextTurn() {
            currentPlayerIndex = (currentPlayerIndex + 1) % players.Count;
        }

        public Player.Player GetCurrentPlayer() {
            return players[currentPlayerIndex];
        }
    }
}

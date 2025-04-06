using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GalacticTycoon.Game
{
    public class GameState {
        public List<Player.Player> Players { get; set; }
        public Galaxy.GalaxyMap GalaxyMap { get; set; }
        public int CurrentTurn { get; set; }

        public GameState(List<Player.Player> players, Galaxy.GalaxyMap galaxyMap) {
            Players = players;
            GalaxyMap = galaxyMap;
            CurrentTurn = 0;
        }

        public void NextTurn() {
            CurrentTurn++;
        }
    }
    
}

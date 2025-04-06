using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GalacticTycoon.Buildings
{
    public class Farm : Building {
        public Farm() : base("Farm", Enums.BuildingType.Farm) {
            // Farms can only be built on planets owned by the player
            // They can also be built on planets owned by other players
            // They are the only building that can be built on a planet with no owner
            // They can also be built on planets owned by other players
        }
        public override void Upgrade() {
            if (Level < 5) {
                Level++;
            } else {
                throw new NotImplementedException();
            }
        }
    }
}

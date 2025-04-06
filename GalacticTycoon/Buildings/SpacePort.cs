using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GalacticTycoon.Buildings
{
    public class SpacePort : Building {
        public SpacePort() : base("Space Port", Enums.BuildingType.SpacePort) {
            // Poprzez wybudowanie SpacePortu przejmujemy planetę
            // SpacePort może być wybudowany tylko na planecie, która nie ma właściciela
        }

        public override void Upgrade() {
            throw new NotImplementedException();
        }
    }
}

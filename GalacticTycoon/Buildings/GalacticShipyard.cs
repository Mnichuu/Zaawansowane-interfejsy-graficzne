using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GalacticTycoon.Buildings
{
    public class GalacticShipyard : Building {
        public GalacticShipyard() : base("Galactic Shipyard", Enums.BuildingType.GalacticShipyard) {
            Income = 50;
        }

        public override void Upgrade() {
            throw new InvalidOperationException("Galactic Shipyard cannot be upgraded.");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GalacticTycoon.Buildings {
    public class MinePlus : Building {
        public MinePlus() : base("Mine Plus", Enums.BuildingType.MinePlus) {
        }

        public override void Upgrade() {
            if (Level < 5) {
                base.Upgrade();
            } else {
                throw new InvalidOperationException("Mine Plus cannot be upgraded beyond level 5.");
            }
        }
    }
}

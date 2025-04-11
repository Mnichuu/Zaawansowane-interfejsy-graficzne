using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GalacticTycoon.Buildings {
    public class Colony : Building {
        public Colony() : base("Colony", Enums.BuildingType.Colony) {
        }

        public override void Upgrade() {
            if (Level < 5)
            {
                base.Upgrade();
            } else {
                throw new InvalidOperationException("Colony cannot be upgraded beyond level 5.");
            }
        }
    }
}

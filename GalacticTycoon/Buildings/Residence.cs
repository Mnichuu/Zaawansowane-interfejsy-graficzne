using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace GalacticTycoon.Buildings {
    public class Residence : Building {
        public Residence() : base("Residence", Enums.BuildingType.Residence) {
        }

        public override void Upgrade() {
            if (Level < 3) {
                base.Upgrade();
            } else {
                throw new InvalidOperationException("Residence cannot be upgraded beyond level 3.");
            }
        }
    }
}

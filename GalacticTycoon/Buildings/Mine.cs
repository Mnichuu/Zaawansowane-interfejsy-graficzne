using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GalacticTycoon.Buildings
{
    public class Mine : Building {
        public Mine() : base("Mine", Enums.BuildingType.Mine) {
            // Mine może zostać rozbudowana z Outpostu
            // Podstawowo ma max 3 lvl
            // Jeżeli gracz posiada wszystkie może wybudować kopalnie w pasach asteroid (wtedy lvl 5)

        }
        public override void Upgrade() {
            if (Level < 3) {
                Level++;
            } else {
                throw new NotImplementedException();
            }
        }
    }
}

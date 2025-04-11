using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GalacticTycoon.Buildings
{
    public class Outpost : Building {
        public Outpost() : base("Outpost", Enums.BuildingType.Outpost) {
            // Outpost może zostać zbudowany tylko na planecie przejętej przez gracza (czyli na takiej która posiada SpacePort)
            // Outpost można rozbudować do:
            // - habitatów mieszkalnych
            // - kolonii
            // - hotelu galaktycznego
            // Jeżeli gracz jest właścicielem wszystkich planet w systemie to: - sieci hoteli planetarnych
            // - kopalnie (do 3 lvl)
            // - farmy (do 5 lvl)
        }
        public override void Upgrade() {
            if (Level < 5) {
                base.Upgrade();
            } else {
                throw new NotImplementedException();
            }
        }
    }
}

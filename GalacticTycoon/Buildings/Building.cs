using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GalacticTycoon.Buildings
{
    public abstract class Building {
        public string Name { get; private set; }
        public Enums.BuildingType BuildingType { get; private set; }
        public int Level { get; protected set; }

        public int Income { get; protected set; }

        public int Cost { get; set; }

        protected Building(string name, Enums.BuildingType buildingType) {
            Name = name;
            BuildingType = buildingType;
            Level = 0;
            Income = 5;
            Cost = 100;
        }
        public virtual void Upgrade() {
            Level++;
            Income += 5;
            
        }

    }
}

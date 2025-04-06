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

        protected Building(string name, Enums.BuildingType buildingType) {
            Name = name;
            BuildingType = buildingType;
            Level = 1;
        }
        public abstract void Upgrade();
    }
}

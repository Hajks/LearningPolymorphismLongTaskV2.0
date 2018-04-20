using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningPolymorphismLongTaskV2._0
{
    class OutsideWithDoor : Outside, IHasExteriorDoor
    {
        public OutsideWithDoor(string name, bool hot, string doorDescription):base(name, hot)
        {
            this.DoorDescription = doorDescription;
        }
        public string DoorDescription { get; }

        public Location DoorLocation { get; set; }
        public override string Description
        {
            get
            {
                return base.Description += "\r\n" + "Dodatkowo są tutaj "+ DoorDescription +".";
            }
        }
    }
}

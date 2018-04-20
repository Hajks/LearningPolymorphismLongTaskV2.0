using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningPolymorphismLongTaskV2._0
{
    class Opponent
    {
        public Opponent(Location myLocation)
        {
            this.myLocation = myLocation;
            myRandom = new Random();

        }
        private Location myLocation;
        public Random myRandom;
        public void Move()
        {
            bool hidden = false;
            while (!hidden)
            {
                if (myLocation is IHasExteriorDoor)
                {
                    IHasExteriorDoor locationWithDoor = myLocation as IHasExteriorDoor;

                    if (myRandom.Next(2) == 1)
                        myLocation = locationWithDoor.DoorLocation;
                }
            
                int rand = myRandom.Next(myLocation.Exits.Length);
                myLocation = myLocation.Exits[rand];
                if (myLocation is IHidingPlace)
                    hidden = true;
            }
        }
        public bool Check(Location locationToCheck)
        {
            if (locationToCheck == myLocation)
                return true;
            else
                return false;
        }
    }
}

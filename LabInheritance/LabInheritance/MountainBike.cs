using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabInheritance
{
    class MountainBike : Bicycle
    {
        public int seatHeight;

        public MountainBike(int startHeight, int startCadence, int startSpeed, int startGear) : base(startCadence, startSpeed, startGear)
        {
            seatHeight = startHeight;
        }
        public void setHeight(int input)
        {
            seatHeight = input;
        }
    }
}

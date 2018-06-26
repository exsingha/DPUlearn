using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabInheritance
{
    class Bicycle
    {
        public int cadence;
        public int gear;
        public int speed;

        public Bicycle(int i1, int i2, int i3)
        {
            cadence = i1;
            gear = i3;
            speed = i2;
        }
        public void setCadence(int input)
        {
            cadence = input;
        }
        public void setGear(int input)
        {
            gear = input;
        }
        public void applyBrake(int input)
        {
            speed -= input;
        }
        public void speedUp(int input)
        {
            speed += input;
        }
    }
}

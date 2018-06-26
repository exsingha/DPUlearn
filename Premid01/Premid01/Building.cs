using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Premid01
{
    class Building
    {
        private int floor;
        private string name;
        private Room[] classroom;
        private int countRoom;

        public Building(string _name, int _floor)
        {
            classroom = new Room[_floor];
        }
        public void setFloor(int _floor)
        {
            floor = _floor;
        }
        public int getFloor()
        {
            return floor;
        }
        public void setName(string _name)
        {
            name = _name;
        }
        public string getName()
        {
            return name;
        }
        public void addRoom(Room _classroom)
        {
            classroom[countRoom] = _classroom;
            countRoom++;
        }
        public void getRoom(int num)
        {
            for(int i=0;i< countRoom; i++)
            {
                if (num < classroom[i].getSizePeople()) {
                    if (classroom[i].getStatus().Equals("ok"))
                    {
                        Console.WriteLine(classroom[i].getNameRoom());
                    }

                }
                
            }
        }
        public void PrintDetails()
        {
            for(int i = 0; i < countRoom; i++)
            {
                Console.WriteLine(classroom[i].getNameRoom());
            }
        }
    }
}

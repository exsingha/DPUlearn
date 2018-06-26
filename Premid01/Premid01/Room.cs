using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Premid01
{
    class Room
    {
        private string name_room;
        private int people;
        private string status;
        private int num;
        private char[] select;

        public Room()
        {
            name_room = "";
            people = 0;
            status = "";
        }
        public Room(string _name_room, int _people)
        {
            name_room = _name_room;
            people = _people;
        }
        public string getNameRoom()
        {
            return name_room;
        }
        public int getSizePeople()
        {
            return people;
        }
        public string getStatus()
        {
            select = name_room.ToCharArray();

            if (select[2] == '2' || select[2] == '3')
            {
                status = "not ok";
                
            }
            else
            {
                status = "ok";
            }
            return status;
        }
    }
}

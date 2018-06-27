using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPLecture07_04
{
    class Pirate
    {
        private string name;
        private string imagename;

        public Pirate(string _name)
        {
            Name = _name;
            imagename = "/OOPLecture07_04;component/Images/" + name + ".jpg";
        }
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public string GetImageName()
        {
            return imagename;
        }
    }
}

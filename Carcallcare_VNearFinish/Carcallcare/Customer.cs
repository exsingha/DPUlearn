using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carcallcare
{
    public class Customer
    {
        public String mobile { get; set; }
        public String name { get; set; }
        public String bookRef { get; set; }
        public String type { get; set; }
        public String status { get; set; }
        public String description { get; set; }

        public Customer(String mob, String nam, String boo, String typ, String sta, String des)
        {
            mobile = mob;
            name = nam;
            bookRef = boo;
            type = typ;
            status = sta;
            description = des;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPLecture09
{
    public interface Relation
    {
        bool isGreater(Object a, Object b);
        bool isLess(Object a, Object b);
        bool isEqual(Object a, Object b);
    }
}

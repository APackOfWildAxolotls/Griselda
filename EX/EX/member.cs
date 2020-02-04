using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX
{
    class member : Rapper
    {
        string _name;
        public member(string name)
        {
            _name = name;
            haveBars = true;
            canSing = false;
        }
    }
}

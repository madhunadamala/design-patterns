using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    interface ITarget
    {
        //Rough estimate required
        string Request(int i);
    }
}

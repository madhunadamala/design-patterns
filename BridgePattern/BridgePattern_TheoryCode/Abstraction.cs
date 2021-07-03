using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern_TheoryCode
{
    class Abstraction
    {
        IBridge bridge;
        public Abstraction(IBridge implementation)
        {
            bridge = implementation;
        }

        public string Operation()
        {
            return "Abstraction" + " <<< BRIDGE >>> " + bridge.OperationImp(); 
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace mst_boredom_remover
{
    // This is an Interface class for all orders than can be given to a Unit
    abstract class Order
    {
        public abstract void Do(Unit unit);
    }
}

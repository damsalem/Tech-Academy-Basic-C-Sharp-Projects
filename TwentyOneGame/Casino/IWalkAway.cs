using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino
{
    interface IWalkAway
    {
        //Everything is public in an interface
        void WalkAway(Player player);
    }
}

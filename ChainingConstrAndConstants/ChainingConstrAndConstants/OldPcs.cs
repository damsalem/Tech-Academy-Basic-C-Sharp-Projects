using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainingConstrAndConstants
{
    class OldPcs
    {
        public OldPcs(int year, string compName)
        {
            yearMade = year;
            computerName = compName;
        }
        //This constructor inherits from the above and hardcodes 1990 as the year
        public OldPcs(string compName) : this(1990, compName)
        {

        }

        public int yearMade { get; set; }
        public string computerName { get; set; }
    }
}

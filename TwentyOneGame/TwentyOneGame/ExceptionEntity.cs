using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOneGame
{
    //Entity usually refers to a class where each property maps to a database.
    public class ExceptionEntity
    {
        public int Id { get; set; }
        public string ExceptionType { get; set; }
        public string ExceptionMessage { get; set; }
        public DateTime TimeStamp { get; set; }
    }
}

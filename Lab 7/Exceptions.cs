using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_7
{
    class YearOfSteamerCreationException : Exception
    {
        public YearOfSteamerCreationException (string message) : base(message) { }
    }
    class BoatCapacityException : Exception
    {
        public BoatCapacityException (string message) : base(message) { }
    }
    class SailsColorException : Exception
    {
        public SailsColorException (string message) : base(message) { }
    }
}

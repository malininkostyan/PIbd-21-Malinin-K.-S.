using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsBus
{
    public class ParkingOverflowException : Exception
    {
        public ParkingOverflowException() : base("На парковке нет свободных мест")
        { }
    }
}
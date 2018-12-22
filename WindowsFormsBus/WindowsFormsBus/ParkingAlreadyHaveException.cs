using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsBus
{
    public class ParkingAlreadyHaveException : Exception
    {
        public ParkingAlreadyHaveException() : base("На парковке уже есть такая машина")
        { }
    }
}

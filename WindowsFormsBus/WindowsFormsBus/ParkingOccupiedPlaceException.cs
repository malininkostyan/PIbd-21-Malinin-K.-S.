using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsBus
{
    public class ParkingOccupiedPlaceException : Exception
    {
        public ParkingOccupiedPlaceException(int i) : base("На месте " + i + " уже стоит автомобиль")
        { }
    }
}

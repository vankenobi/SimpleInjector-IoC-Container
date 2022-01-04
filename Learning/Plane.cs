using System;
using System.Collections.Generic;
using System.Text;

namespace Learning
{
    public class Plane : IAirVehicle , IVehicle
    {
        public void Go(string A, string B)
        {
            Console.WriteLine("Plane is gone from" + A + "To" + B);
        }

        public bool IsNormallWheelPressure()
        {
            return true;
        }

        public bool IsOpenFlaps()
        {
            return false;
        }

        public bool IsTurbulance()
        {
            return false;
        }
    }
}

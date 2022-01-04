using System;
using System.Collections.Generic;
using System.Text;

namespace Learning
{
    public class Car : ILandVehicle, IVehicle
    {
        public void Go(string A, string B)
        {
            Console.WriteLine("Car is gone from" + A + "to" + B);
        }

        public bool IsNormallWheelPressure()
        {
            return true;
        }

        public bool IsBreakdownInGear()
        {
            return false;
        }

       
    }
}

using System;

namespace Learning
{
    class Program
    {
        static void Main(string[] args)
        {
            IVehicle _vehicle;
            _vehicle = new Car();
            bool wheelPressure = _vehicle.IsNormallWheelPressure();
            Console.WriteLine("Wheel pressure " + (wheelPressure ? "is normall" : "is not normall"));


        }
    }
}

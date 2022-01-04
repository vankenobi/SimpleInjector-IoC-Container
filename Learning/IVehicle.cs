using System;
using System.Collections.Generic;
using System.Text;

namespace Learning
{
    public interface IVehicle
    {
        void Go(string A, string B);

        bool IsNormallWheelPressure();
    }
}

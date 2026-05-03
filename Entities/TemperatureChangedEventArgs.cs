using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    // 1. Define a custom EventArgs (optional)
    public class TemperatureChangedEventArgs : EventArgs
    {
        public double OldTemp { get; }
        public double NewTemp { get; }
        public TemperatureChangedEventArgs(double oldTemp, double newTemp)
            => (OldTemp, NewTemp) = (oldTemp, newTemp);
    }
}

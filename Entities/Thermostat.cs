using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    // 2. Publisher — the class that raises the event
    public class Thermostat
    {
        private double _temperature;

        // Declare the event using the built-in EventHandler<T> delegate
        public event EventHandler<TemperatureChangedEventArgs> TemperatureChanged;

        public double Temperature
        {
            get => _temperature;
            set
            {
                if (value == _temperature) return;

                var args = new TemperatureChangedEventArgs(_temperature, value);
                _temperature = value;

                // 3. Raise the event (null-check with ?.Invoke is thread-safer)
                TemperatureChanged?.Invoke(this, args);
            }
        }
    }
}

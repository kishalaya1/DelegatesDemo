using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    // 4. Subscriber — reacts to the event
    public class AlertSystem
    {
        public void Subscribe(Thermostat t) =>
            t.TemperatureChanged += OnTemperatureChanged;

        public void Unsubscribe(Thermostat t) =>
            t.TemperatureChanged -= OnTemperatureChanged;   // always clean up!

        private void OnTemperatureChanged(object? sender, TemperatureChangedEventArgs e)
        {
            Console.WriteLine($"[Alert] Temp changed: {e.OldTemp}°C → {e.NewTemp}°C");
            if (e.NewTemp > 30)
                Console.WriteLine("  ⚠ Warning: Too hot!");
        }
    }
}

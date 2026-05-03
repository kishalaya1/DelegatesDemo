using Entities;
using System;
using System.Threading;

namespace DelegatesDemo
{
    public class EventsExample
    {
        // Demo entry: call EventsExample.Run() from your Program.Main
        public static void Run()
        {
            var thermostat = new Thermostat();
            var alert = new AlertSystem();

            alert.Subscribe(thermostat);

            thermostat.Temperature = 20;   // [Alert] Temp changed: 0°C → 20°C
            thermostat.Temperature = 25;   // [Alert] Temp changed: 20°C → 25°C
            thermostat.Temperature = 35;   // [Alert] Temp changed: 25°C → 35°C  ⚠

            alert.Unsubscribe(thermostat); // detach — no more alerts
            thermostat.Temperature = 40;   // (silence)
        }

    }
}

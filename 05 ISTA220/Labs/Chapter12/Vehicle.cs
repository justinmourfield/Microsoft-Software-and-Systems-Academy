using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles
{
    class Vehicle
    {
        public void StartEngine(string engineNoise)
            {
            Console.WriteLine($"Starting engine {engineNoise}");
            }

        public void StopEngine(string stoppingEngine)
        {
            Console.WriteLine($" Stopping engine {stoppingEngine}");
        }

        public virtual void Drive()
        {
            Console.WriteLine("Default implementation of Drive method in vehicle base class");
        }
    }
}

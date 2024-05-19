using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task5
{
    internal class Motocycle : IVehicle

    {
        public string Name { get; set; }
        public string Color { get; set; }

        public Motocycle(string name, string color)
        {
            Name = name;
            Color = color;
        }
        public void GetDetails()
        {
            Console.WriteLine($"{Name}, {Color}");
        }

        public void Start()
        {
            Console.WriteLine("Motocycle Started");
        }

        public void Stop()
        {
            Console.WriteLine("Motocycle Stopped");
        }
    }
}

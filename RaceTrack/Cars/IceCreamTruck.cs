using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaceTrack.RaceTrack.Cars
{
    public class IceCreamTruck : RaceCar
    { 
        public IceCreamTruck()
        {
            Name = "Ice Cream Truck";
            TopSpeed = 40;
        }

        public override void StartEngine()
        {
            Console.WriteLine($"The {Name} begins to move.");
        }

        public override void Brake(){
            Console.WriteLine($"The {Name} brakes.");
        }
        public override void StopEngine()
        {
            Console.WriteLine($"The {Name} stops.");
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RaceTrack.RaceTrack.Cars;

namespace RaceTrack.RaceTrack.Drivers
{
    public class HappyGuy : Driver
    {
        public HappyGuy(RaceCar car) : base(car)
        {
            Name = "Happy Guy";
            SkillLevel = 1;
        }

        public override void Drive()
        {
            Car.Accelerate(SkillLevel);
        }

    }
}
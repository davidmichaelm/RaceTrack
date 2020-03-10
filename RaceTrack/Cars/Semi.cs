using System;

namespace RaceTrack.RaceTrack.Cars
{
    public class Semi : RaceCar
    {
        public Semi()
        {
            Name = "Semi";
            TopSpeed = 65;
        }

        public override void StartEngine()
        {
            Console.WriteLine($"The {Name} engine starts up loudly");
        }

        public override void StopEngine()
        {
            Console.WriteLine($"The {Name} engine shuts down");
        }
    }
}
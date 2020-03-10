using RaceTrack.RaceTrack.Cars;

namespace RaceTrack.RaceTrack.Drivers
{
    public class GoodBuddy : Driver
    {
        public GoodBuddy(RaceCar car) : base(car)
        {
            Name = "Good Buddy";
            SkillLevel = 8;
        }

        public override void Drive()
        {
            Car.Accelerate(SkillLevel);
        }
    }
}
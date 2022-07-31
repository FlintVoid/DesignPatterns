namespace DesignPatterns.Creational.Builder
{
    public class Director : IDirector
    {
        public void ConstructSportCar(IBuilder builder)
        {
            builder.Reset();
            builder.SetSeats(2);
            builder.SetEngine(new SportsEngine());
            builder.SetTripComputer(true);
            builder.SetGPS(true);
        }

        public void ConsctructClassicCar(IBuilder builder)
        {
            builder.Reset();
            builder.SetSeats(5);
            builder.SetEngine(new ClassicEngine());
            builder.SetTripComputer(false);
            builder.SetGPS(true);
        }
    }
}
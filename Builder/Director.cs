namespace DesignPatterns.Creational.Builder
{
    public class Director
    {
        public void ConstructSportCar(Builder builder)
        {
            builder.Reset();
            builder.SetSeats(2);
            builder.SetEngine(new SportsEngine());
            builder.SetTripComputer(true);
            builder.SetGPS(true);
        }
    }
}
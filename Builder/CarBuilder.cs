namespace DesignPatterns.Creational.Builder
{
    public class CarBuilder : Builder
    {
        private Car _car;

        public CarBuilder()
        {
            _car = new Car();
        }
        
        public void Reset()
        {
            _car = new Car();
        }

        public void SetSeats(int count)
        {
            _car.SetFeature($"Seats {count}");
        }

        public void SetEngine(Engine engine)
        {
            _car.SetFeature(engine.ToString());
        }

        public void SetTripComputer(bool available)
        {
            _car.SetFeature($"trip computer {available}");
        }

        public void SetGPS(bool available)
        {
            _car.SetFeature($"gps {available}");
        }

        public Car GetResult()
        {
            return _car;
        }
    }
}
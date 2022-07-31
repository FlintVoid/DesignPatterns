namespace DesignPatterns.Creational.Builder
{
    public class CarManualBuilder : IBuilder
    {
        private Manual _manual;

        public CarManualBuilder()
        {
            _manual = new Manual();
        }
        
        public void Reset()
        {
            _manual = new Manual();
        }

        public void SetSeats(int count)
        {
            _manual.SetFeature($"Seats {count}");
        }

        public void SetEngine(IEngine engine)
        {
            _manual.SetFeature(engine.ToString());
        }

        public void SetTripComputer(bool available)
        {
            _manual.SetFeature($"trip computer {available}");
        }

        public void SetGPS(bool available)
        {
            _manual.SetFeature($"gps {available}");
        }

        public Manual GetResult()
        {
            return _manual;
        }
    }
}
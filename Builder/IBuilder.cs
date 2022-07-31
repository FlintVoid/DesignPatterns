namespace DesignPatterns.Creational.Builder
{
    public interface IBuilder
    {
        void Reset();
        void SetSeats(int count);
        void SetEngine(IEngine engine);
        void SetTripComputer(bool available);
        void SetGPS(bool available);
    }
}
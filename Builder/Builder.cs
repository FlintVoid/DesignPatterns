namespace DesignPatterns.Creational.Builder
{
    public interface Builder
    {
        void Reset();
        void SetSeats(int count);
        void SetEngine(Engine engine);
        void SetTripComputer(bool available);
        void SetGPS(bool available);
    }
}
namespace DesignPatterns.Creational.Builder
{
    public interface IDirector
    {
        void ConstructSportCar(IBuilder builder);

        void ConsctructClassicCar(IBuilder builder);
    }
}
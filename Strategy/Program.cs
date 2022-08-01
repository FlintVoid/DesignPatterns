namespace DesignPatterns.Behavioral.Strategy
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            SpaceShip spaceShip = new SpaceShip();
            spaceShip.ActivateAmmo();
            spaceShip.SetAmmo(new Laser());
            spaceShip.ActivateAmmo();
            spaceShip.ActivateAmmo();
            spaceShip.SetAmmo(new Rocket());
            spaceShip.ActivateAmmo();
            spaceShip.SetAmmo(new Shield());
            spaceShip.ActivateAmmo();
        }
    }
}
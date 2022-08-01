namespace DesignPatterns.Behavioral.Strategy
{
    public interface ISpaceShip
    {
        void ActivateAmmo();
        void SetAmmo(IStrategyAmmo ammo);
    }
}
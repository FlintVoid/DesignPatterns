using System;

namespace DesignPatterns.Behavioral.Strategy
{
    public class SpaceShip : ISpaceShip
    {
        private IStrategyAmmo _ammo;
        
        public void ActivateAmmo()
        {
            if (_ammo == null)
            {
                Console.WriteLine("You don't have ammo");
            }
            else
            {
                _ammo.Activate();
            }
        }

        public void SetAmmo(IStrategyAmmo ammo)
        {
            _ammo = ammo;
        }
    }
}
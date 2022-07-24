using DesignPatterns.Structural.Decorator.Beverage;

namespace DesignPatterns.Structural.Decorator.Condiment
{
    public abstract class CondimentDecorator : IBeverage
    {
        private IBeverage _beverage;
        
        public CondimentDecorator(IBeverage beverage)
        {
            _beverage = beverage;
        }

        public virtual string GetDescription()
        {
            return _beverage.GetDescription();
        }

        public virtual double Cost()
        {
            return _beverage.Cost();
        }
    }
}
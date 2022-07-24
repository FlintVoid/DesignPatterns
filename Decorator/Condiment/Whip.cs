using DesignPatterns.Structural.Decorator.Beverage;

namespace DesignPatterns.Structural.Decorator.Condiment
{
    public class Whip : CondimentDecorator
    {
        public Whip(IBeverage beverage) : base(beverage)
        {
        }

        public override double Cost()
        {
            return base.Cost() + 0.1;
        }

        public override string GetDescription()
        {
            return base.GetDescription() + ", with Whip";
        }
    }
}
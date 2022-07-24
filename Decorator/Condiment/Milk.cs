namespace DesignPatterns.Structural.Decorator.Condiment
{
    public class Milk: CondimentDecorator
    {
        public Milk(Beverage.Beverage beverage) : base(beverage)
        {
        }

        public override string GetDescription()
        {
            return base.GetDescription() + ", milk";
        }

        public override double Cost()
        {
            return base.Cost() + 0.1;
        }
    }
}
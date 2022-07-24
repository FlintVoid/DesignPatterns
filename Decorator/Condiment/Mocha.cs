namespace DesignPatterns.Structural.Decorator.Condiment
{
    public class Mocha : CondimentDecorator
    {
        public Mocha(Beverage.Beverage beverage) : base(beverage)
        {
        }

        public override string GetDescription()
        {
            return base.GetDescription() + ", coffee mocha";
        }

        public override double Cost()
        {
            return base.Cost() + 0.1;
        }
    }
}
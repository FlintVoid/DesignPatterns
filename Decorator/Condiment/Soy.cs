namespace DesignPatterns.Structural.Decorator.Condiment
{
    public class Soy : CondimentDecorator
    {
        public Soy(Beverage.Beverage beverage) : base(beverage)
        {
        }

        public override string GetDescription()
        {
            return base.GetDescription() + " , Soy Milk";
        }

        public override double Cost()
        {
            return 0.15 + base.Cost();
        }
    }
}
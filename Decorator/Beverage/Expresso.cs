namespace DesignPatterns.Structural.Decorator.Beverage
{
    public class Expresso : Beverage
    {
        public Expresso(BeverageSize size) : base(size)
        {
        }

        public override string GetDescription()
        {
            return base.GetDescription() + " Expresso";
        }

        public override double Cost()
        {
            switch (Size)
            {
                case BeverageSize.TALL:
                    return 1.99;
                case BeverageSize.GRANDE: return 2.1;
                case BeverageSize.VENTI: return 2.2;
                default: return 0.0;
            }
        }
    }
}
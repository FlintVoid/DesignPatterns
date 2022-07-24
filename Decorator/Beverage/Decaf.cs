namespace DesignPatterns.Structural.Decorator.Beverage
{
    public class Decaf : Beverage
    {
        public Decaf(BeverageSize size) : base(size)
        {
        }

        public override string GetDescription()
        {
            return base.GetDescription() + " Decaf";
        }

        public override double Cost()
        {
            switch (Size)
            {
                case BeverageSize.TALL:
                    return 1.05;
                case BeverageSize.GRANDE: return 1.2;
                case BeverageSize.VENTI: return 1.4;
                default: return 0.0;
            }
        }
    }
}
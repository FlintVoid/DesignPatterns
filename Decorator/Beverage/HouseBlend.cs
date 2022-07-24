namespace DesignPatterns.Structural.Decorator.Beverage
{
    public class HouseBlend : Beverage
    {
        public HouseBlend(BeverageSize size) : base(size)
        {
        }

        public override string GetDescription()
        {
            return base.GetDescription() + " House blend";
        }

        public override double Cost()
        {
            switch (Size)
            {
                case BeverageSize.TALL: return 0.89;
                case BeverageSize.GRANDE: return 1.0;
                case BeverageSize.VENTI: return 1.1;
                default: return 0.0;
            }
        }
    }
}
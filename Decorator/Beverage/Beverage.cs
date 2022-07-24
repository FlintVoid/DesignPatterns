namespace DesignPatterns.Structural.Decorator.Beverage
{
    public abstract class Beverage : IBeverage
    {
        public BeverageSize Size { get; }

        public Beverage(BeverageSize size)
        {
            Size = size;
        }

        public virtual string GetDescription()
        {
            return Size.ToString();
        }
       
        public abstract double Cost();
    }
}
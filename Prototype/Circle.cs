namespace DesignPatterns.Creational.Prototype
{
    public class Circle : Shape
    {
        public int Radius { get; }
        
        public Circle(Circle source) : base(source)
        {
            if (source == null)
                return;
            Radius = source.Radius;
        }

        public Circle(int x, int y, string color, int radius) : base(x, y, color)
        {
            Radius = radius;
        }

        public override Shape Clone()
        {
            return new Circle(this);
        }
    }
}
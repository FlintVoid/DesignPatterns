namespace DesignPatterns.Creational.Prototype
{
    public class Rectangle : Shape
    {
        public int Width { get; }
        public int Height { get; }
        
        public Rectangle(Rectangle source) : base(source)
        {
            if (source == null)
                return;
            
            Width = source.Width;
            Height = source.Height;
        }

        public Rectangle(int x, int y, string color, int width, int height) : base(x, y, color)
        {
            Width = width;
            Height = height;
        }

        public override Shape Clone()
        {
            return new Rectangle(this);
        }
    }
}
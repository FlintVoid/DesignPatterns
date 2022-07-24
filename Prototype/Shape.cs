namespace DesignPatterns.Creational.Prototype
{
    public abstract class Shape
    {
        public int PosX { get; }
        public int PosY { get; }
        public string Color { get; private set; }

        public Shape(Shape source)
        {
            if (source == null)
                return;
            PosX = source.PosX;
            PosY = source.PosY;
            Color = source.Color;
        }

        public Shape(int x, int y, string color)
        {
            PosX = x;
            PosY = y;
            Color = color;
        }
        
        public void ChangeColor(string newColor)
        {
            Color = newColor;
        }

        public abstract Shape Clone();
    }
}
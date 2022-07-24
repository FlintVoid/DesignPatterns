namespace DesignPatterns.Structural.Composite
{
    public class Circle : Graphic
    {
        private double _radius;
        private int _posX;
        private int _posY;

        public Circle(int x, int y, double radius)
        {
            _posX = x;
            _posY = y;
            _radius = radius;
        }
        
        public void Move(int x, int y)
        {
            _posX += x;
            _posY += y;
        }

        public string Draw()
        {
            return $"Draw Circle in position {_posX},{_posY} with radius {_radius}";
        }
    }
}
namespace DesignPatterns.Structural.Composite
{
    public class Dot : Graphic
    {
        private int _posX;
        private int _posY;

        public Dot(int x, int y)
        {
            _posX = x;
            _posY = y;
        }
        
        public void Move(int x, int y)
        {
            _posX += x;
            _posY += y;
        }

        public string Draw()
        {
            return $"Draw dot in position {_posX},{_posY}";
        }
    }
}
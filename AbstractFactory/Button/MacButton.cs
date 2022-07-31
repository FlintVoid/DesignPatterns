namespace DesignPatterns.Creational.AbstractFactory.Button
{
    public class MacButton : IButton
    {
        public string Paint()
        {
            return "Draw button mac os style";
        }
    }
}
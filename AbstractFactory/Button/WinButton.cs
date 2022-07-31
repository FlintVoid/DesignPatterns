namespace DesignPatterns.Creational.AbstractFactory.Button
{
    public class WinButton : IButton
    {
        public string Paint()
        {
            return "Draw button window style";
        }
    }
}
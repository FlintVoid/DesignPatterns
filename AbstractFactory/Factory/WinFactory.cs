using DesignPatterns.Creational.AbstractFactory.Button;
using DesignPatterns.Creational.AbstractFactory.Checkbox;

namespace DesignPatterns.Creational.AbstractFactory.Factory
{
    public class WinFactory : GUIFactory
    {
        public Button.Button CreateButton()
        {
            return new WinButton();
        }

        public Checkbox.Checkbox CreateCheckBox()
        {
            return new WinCheckbox();
        }
    }
}
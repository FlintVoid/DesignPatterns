using DesignPatterns.Creational.AbstractFactory.Button;
using DesignPatterns.Creational.AbstractFactory.Checkbox;

namespace DesignPatterns.Creational.AbstractFactory.Factory
{
    public class MacFactory : GUIFactory
    {
        private GUIFactory _guiFactoryImplementation;
        
        public Button.Button CreateButton()
        {
            return new MacButton();
        }

        public Checkbox.Checkbox CreateCheckBox()
        {
            return new MacCheckbox();
        }
    }
}
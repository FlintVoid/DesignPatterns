using DesignPatterns.Creational.AbstractFactory.Button;
using DesignPatterns.Creational.AbstractFactory.Checkbox;

namespace DesignPatterns.Creational.AbstractFactory.Factory
{
    public class MacFactory : IFactory
    {
        private IFactory _factoryImplementation;
        
        public IButton CreateButton()
        {
            return new MacButton();
        }

        public ICheckbox CreateCheckBox()
        {
            return new MacCheckbox();
        }
    }
}
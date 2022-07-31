namespace DesignPatterns.Creational.AbstractFactory.Factory
{
    public interface IFactory
    {
        Button.IButton CreateButton();
        Checkbox.ICheckbox CreateCheckBox();
    }
}
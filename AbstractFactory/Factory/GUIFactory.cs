namespace DesignPatterns.Creational.AbstractFactory.Factory
{
    public interface GUIFactory
    {
        Button.Button CreateButton();
        Checkbox.Checkbox CreateCheckBox();
    }
}
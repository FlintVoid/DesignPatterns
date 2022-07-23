using FactoryMethod.Buttons;

namespace FactoryMethod.Dialogs
{
    public class HTMLDialog : Dialog
    {
        protected override Button CreateButton()
        {
            return new HTMLButton();
        }
    }
}
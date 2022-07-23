using FactoryMethod.Buttons;

namespace FactoryMethod.Dialogs
{
    public class WindowsDialog : Dialog
    {
        protected override Button CreateButton()
        {
            return new WindowsButton();
        }
    }
}
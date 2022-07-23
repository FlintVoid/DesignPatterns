using System;

namespace FactoryMethod.Buttons
{
    public class WindowsButton : Button
    {
        public string Render()
        {
            return "window style button";
        }

        public void OnClick(Action onClickAction)
        {
            //Set native handler
        }
    }
}
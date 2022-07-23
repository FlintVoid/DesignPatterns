using System;

namespace FactoryMethod.Buttons
{
    public class HTMLButton : Button
    {
        public string Render()
        {
            return "html button";
        }

        public void OnClick(Action onClickAction)
        {
            //Set click handler browser
        }
    }
}
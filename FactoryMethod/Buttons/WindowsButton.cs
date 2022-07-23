using System;

namespace FactoryMethod.Buttons
{
    public class WindowsButton : Button
    {
        public string Render()
        {
            return "window style button";
        }

        /// <summary>
        ///Set native handler
        /// </summary>
        /// <param name="onClickAction"></param>
        public void OnClick(Action onClickAction)
        {
            
        }
    }
}
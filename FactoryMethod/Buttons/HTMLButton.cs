using System;

namespace FactoryMethod.Buttons
{
    public class HTMLButton : Button
    {
        public string Render()
        {
            return "html button";
        }

        /// <summary>
        /// Set click handler browser
        /// </summary>
        /// <param name="onClickAction"></param>
        public void OnClick(Action onClickAction)
        {
          
        }
    }
}
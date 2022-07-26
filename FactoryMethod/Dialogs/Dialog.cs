﻿using FactoryMethod.Buttons;

namespace FactoryMethod.Dialogs
{
    public abstract class Dialog
    {
        public string RenderWindow()
        {
            Button okButton = CreateButton();
            okButton.OnClick(CloseDialog);
            return $"Draw Dialog with {okButton.Render()}";
        }
        
        protected abstract Button CreateButton();
       
        /// <summary>
        /// //Close dialog
        /// </summary>
        private void CloseDialog()
        {
            
        }
    }
}
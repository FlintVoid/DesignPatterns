using System;

namespace FactoryMethod.Buttons
{
    public interface Button
    {
        string Render();
        void OnClick(Action onClickAction);
    }
}
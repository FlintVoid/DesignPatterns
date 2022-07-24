using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Structural.Composite
{
    public class CompoundGraphic : Graphic
    {
        private List<Graphic> _children = new List<Graphic>();

        public void Add(Graphic graphic)
        {
            _children.Add(graphic);
        }

        public void Add(Graphic[] graphics)
        {
            foreach (var graphic in graphics)
            {
                _children.Add(graphic);
            }
        }

        public void Remove(Graphic graphic)
        {
            _children.Remove(graphic);
        }

        public void Remove(Graphic[] graphics)
        {
            foreach (var graphic in graphics)
            {
                _children.Remove(graphic);
            }
        }

        public void Move(int x, int y)
        {
            foreach (var graphic in _children)
            {
                graphic.Move(x, y);
            }
        }

        public string Draw()
        {
            StringBuilder stringBuilder = new StringBuilder();
            foreach (var graphic in _children)
            {
                stringBuilder.Append(graphic.Draw() + Environment.NewLine);
            }

            return stringBuilder.ToString();
        }
    }
}
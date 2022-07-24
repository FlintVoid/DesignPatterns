using System;

namespace DesignPatterns.Structural.Composite
{
    public class ImageEditor
    {
        private CompoundGraphic cg = new CompoundGraphic();

        public void Load()
        {
            cg = new CompoundGraphic();
            cg.Add(new Dot(1, 2));
            cg.Add(new Circle(5,3,10));
        }

        public void GroupSelected(Graphic[] components)
        {
            var group = new CompoundGraphic();
            group.Add(components);
            cg.Remove(components);
            cg.Add(group);
        }

        public void Draw()
        {
            Console.WriteLine(cg.Draw());
        }
    }
}
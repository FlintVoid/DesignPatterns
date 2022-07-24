namespace DesignPatterns.Structural.Composite
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            ImageEditor imageEditor = new ImageEditor();
            imageEditor.Load();
            imageEditor.Draw();
        }
    }
}
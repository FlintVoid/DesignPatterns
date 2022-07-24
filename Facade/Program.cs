using System;

namespace DesignPatterns.Structural.Facade
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var converter = new VideoConverter();
            var mp4 = converter.Convert("where is my car, dude", "mp4");
            Console.WriteLine(mp4.Save());
        }
    }
}
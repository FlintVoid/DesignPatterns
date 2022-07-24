using System;

namespace DesignPatterns.Structural.Bridge
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var tv = new TV();
            var remote = new Remote(tv);
            Console.WriteLine($"Device is {remote.TogglePower()}");
            Console.WriteLine($"Device channel is {remote.ChannelDown()}");
            Console.WriteLine($"Device volume is {remote.VolumeDown()}");
        }
    }
}
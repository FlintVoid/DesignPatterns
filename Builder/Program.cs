using System;

namespace DesignPatterns.Creational.Builder
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            IDirector director = new Director();
            CarBuilder builder = new CarBuilder();
            director.ConstructSportCar(builder);
            Console.WriteLine(builder.GetResult().ToString());

            CarManualBuilder manualBuilder = new CarManualBuilder();
            director.ConstructSportCar(manualBuilder);
            Console.WriteLine(manualBuilder.GetResult().ToString());
            
            director.ConsctructClassicCar(builder);
            Console.WriteLine(builder.GetResult().ToString());
        }
    }
}
using System;

namespace DesignPatterns.Behavioral.Snapshot
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            SalesProspect salesProspect = new SalesProspect();
            salesProspect.Name = "Noel van Halen";
            salesProspect.Phone = "(412) 256-0990";
            salesProspect.Budget = 25000.0;
            // Store internal state
            ProspectMemory prospectMemory = new ProspectMemory();
            prospectMemory.Memento = salesProspect.SaveMemento();
            // Continue changing originator
            salesProspect.Name = "Leo Welch";
            salesProspect.Phone = "(310) 209-7111";
            salesProspect.Budget = 1000000.0;
            // Restore saved state
            salesProspect.RestoreMemento(prospectMemory.Memento);
            // Wait for user
            Console.ReadKey();
        }
    }
}
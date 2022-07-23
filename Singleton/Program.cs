using System;
using System.Collections.Generic;

namespace DesignPatterns.Creational.Singleton
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Database database = Database.GetInstance();
            ShowAll(database.SelectALL());
            database.RemoveLast();
            
            ShowAll(Database.GetInstance().SelectALL());
        }

        private static void ShowAll(IEnumerable<string> entities)
        {
            foreach (var entity in entities)
            {
                Console.Write(entity + ' ');
            }

            Console.WriteLine();
        }
    }
}
using System;
using FactoryMethod.Dialogs;

namespace DesignPatterns.Creational.FactoryMethod
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var config = ReadApplicationConfigFile();
            Dialog dialog;
            switch (config)
            {
                case nameof(HTMLDialog) : dialog = new HTMLDialog(); break;
                case nameof(WindowsDialog) : dialog = new WindowsDialog();
                    break;
                default: throw new Exception("Error! Unknown config");
            }
            
            Console.WriteLine(dialog.RenderWindow());
        }

        /// <summary>
        /// Read application config file
        /// </summary>
        /// <returns></returns>
        private static string ReadApplicationConfigFile()
        {
            var configs = new[] { nameof(HTMLDialog), nameof(WindowsDialog) };
            return configs[new Random().Next(0, configs.Length)];
        }
    }
}
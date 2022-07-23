using System;
using FactoryMethod.Dialogs;

namespace FactoryMethod
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

        private static string ReadApplicationConfigFile()
        {
            //Read application config file
            var configs = new[] { nameof(HTMLDialog), nameof(WindowsDialog) };
            return configs[new Random().Next(0, configs.Length)];
        }
    }
}
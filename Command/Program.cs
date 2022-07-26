using System;
using System.Collections.Generic;
using System.Linq;

namespace DesignPatterns.Behavioral.Command
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var bankAccount = new BankAccount();
            var commands = new List<ICommand>
            {
                new BankAccountCommand(bankAccount, BankAccountCommand.Action.Deposit, 100),
                new BankAccountCommand(bankAccount, BankAccountCommand.Action.Withdraw, 1000),
            };
            Console.WriteLine(bankAccount);

            foreach (var command in commands)
            {
                command.Call();
            }

            Console.WriteLine(bankAccount);
            foreach (var command in Enumerable.Reverse(commands))
            {
                command.Undo();
            }

            Console.WriteLine(bankAccount);
        }
    }
}
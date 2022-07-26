using System;

namespace DesignPatterns.Behavioral.Command
{
    public class BankAccount
    {
        private int _balance;
        private int overdraftLimit = -500;

        public void Deposit(int amount)
        {
            _balance += amount;
            Console.WriteLine($"Deposited ${amount}, balance is now {_balance}");
        }

        public bool WithDraw(int amount)
        {
            if (_balance - amount < overdraftLimit) return false;
            _balance -= amount;
            Console.WriteLine($"Withdraw ${amount}, balance is now {_balance}");
            return true;
        }

        public override string ToString()
        {
            return $"balance is now {_balance}";
        }
    }
}
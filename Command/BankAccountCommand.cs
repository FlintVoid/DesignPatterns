using System;

namespace DesignPatterns.Behavioral.Command
{
    public class BankAccountCommand : ICommand
    {
        private readonly BankAccount _bankAccount;

        public BankAccountCommand(BankAccount bankAccount, Action action, int amount)
        {
            _bankAccount = bankAccount ?? throw new ArgumentNullException(paramName: nameof(bankAccount));
            _action = action;
            _amount = amount;
        }

        public enum Action
        {
            Deposit,
            Withdraw
        }

        private Action _action;
        private int _amount;
        private bool _succeced;

        public void Call()
        {
            switch (_action)
            {
                case Action.Deposit:
                    _bankAccount.Deposit(_amount);
                    _succeced = true;
                    break;
                case Action.Withdraw:
                    _succeced = _bankAccount.WithDraw(_amount);
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        public void Undo()
        {
            if (!_succeced) return;
            switch (_action)
            {
                case Action.Deposit:
                    _bankAccount.WithDraw(_amount);
                    break;
                case Action.Withdraw:
                    _bankAccount.Deposit(_amount);
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        public bool Success { get; set; }
    }
}
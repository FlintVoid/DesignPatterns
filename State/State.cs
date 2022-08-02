namespace DesignPatterns.Behavioral.State
{
    /// <summary>
    /// The 'State' abstract class
    /// </summary>
    public abstract class State
    {
        protected Account _account;
        protected double _balance;
        protected double _interest;
        protected double _lowerLimit;
        protected double _serviceFee;

        protected double _upperLimit;

        // Properties
        public Account Account
        {
            get { return _account; }
            set { _account = value; }
        }

        public double Balance
        {
            get { return _balance; }
            set { _balance = value; }
        }

        public void Deposit(double amount)
        {
            _balance += amount;
            StateChangeCheck();
        }

        public void Withdraw(double amount)
        {
            _balance -= (amount + _serviceFee);
            StateChangeCheck();
        }

        protected abstract void StateChangeCheck();
    }
}
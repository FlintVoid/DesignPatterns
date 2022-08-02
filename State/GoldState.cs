namespace DesignPatterns.Behavioral.State
{
    /// <summary>
    /// A 'ConcreteState' class
    /// <remarks>
    /// Gold indicates an interest bearing state
    /// </remarks>
    /// </summary>
    public class GoldState : State, IPayInterest
    {
        // Overloaded constructors
        public GoldState(State state)
            : this(state.Balance, state.Account)
        {
        }

        public GoldState(double balance, Account account)
        {
            _balance = balance;
            _account = account;
            Initialize();
        }

        private void Initialize()
        {
            // Should come from a database
            _interest = 0.05;
            _lowerLimit = 1000.0;
            _upperLimit = 10000000.0;
            _serviceFee = 0.0;
        }

        public void PayInterest()
        {
            _balance += _interest * _balance;
            StateChangeCheck();
        }

        protected override void StateChangeCheck()
        {
            if (_balance < 0.0)
            {
                _account.State = new RedState(this);
            }
            else if (_balance < _lowerLimit)
            {
                _account.State = new SilverState(this);
            }
        }
    }
}
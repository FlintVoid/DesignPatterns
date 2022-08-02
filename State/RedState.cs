namespace DesignPatterns.Behavioral.State
{
    /// <summary>
    /// A 'ConcreteState' class
    /// <remarks>
    /// Red indicates that account is overdrawn 
    /// </remarks>
    /// </summary>
    public class RedState : State
    {
        // Constructor
        public RedState(State state)
        {
            _balance = state.Balance;
            _account = state.Account;
            Initialize();
        }

        private void Initialize()
        {
            // Should come from a datasource
            _interest = 0.0;
            _lowerLimit = -100.0;
            _upperLimit = 0.0;
            _serviceFee = 15.00;
        }

        protected override void StateChangeCheck()
        {
            if (_balance > _upperLimit)
            {
                _account.State = new SilverState(this);
            }
        }
    }
}
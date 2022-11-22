namespace AccountState.Models;

public class SilverState : State
{
    public SilverState(State state)
        : this(state.Balance, state.Account)
    {
    }

    public SilverState(decimal balance, Account account)
    {
        Balance = balance;
        Account = account;
        Initialize();
    }

    public override void Deposit(decimal money)
    {
        Balance+=money;

        if(Balance > base.UpperLimit) 
        {
            Account.State = new GoldState(this);
        }
    }

    public override void Withdraw(decimal money)
    {
        Balance-=money;

        if (Balance < base.LowerLimit)
        {
            Account.State = new RedState(this);
        }
    }


    private void Initialize()
    {
        base.UpperLimit = 1000;
        base.LowerLimit = 0;
    }
}

namespace AccountState.Models;

public class GoldState : State
{
    public GoldState(State state)
        : this(state.Balance, state.Account)
    {
    }

    public GoldState(decimal balance, Account account)
    {
        Balance = balance;
        Account = account;
        Initialize();
    }

    public override void Deposit(decimal money) => Balance+=money;

    public override void Withdraw(decimal money)
    {
        Balance-=money;
        if (Balance < base.LowerLimit)
        {
            Account.State = new SilverState(this);
        }
    }

    private void Initialize()
    {
        base.LowerLimit = 1000;
        base.UpperLimit = 1000000;
    }
}

namespace AccountState.Models;

public class RedState : State
{
    public RedState(State state)
        : this (state.Balance, state.Account)
    {
    }

    public RedState(decimal balance, Account account)
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
            Account.State = new SilverState(this);
        }
    }

    public override void Withdraw(decimal money)
    {
        Console.WriteLine("You dont have enought funds in your account.");
    }

    private void Initialize()
    {
        base.UpperLimit = 0;
        base.LowerLimit = -100;
    }
}

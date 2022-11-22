namespace AccountState.Models;

public abstract class State
{
    protected decimal LowerLimit { get; set; }

    protected decimal UpperLimit { get; set; }

    protected decimal Interest { get; set; }

    public Account Account { get; protected set; }

    public decimal Balance { get; protected set; }

    public abstract void Deposit(decimal money);

    public abstract void Withdraw(decimal money);
}

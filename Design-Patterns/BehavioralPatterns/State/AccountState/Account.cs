using AccountState.Models;

namespace AccountState;

public class Account
{
	public Account(string owner)
	{
		Owner = owner;
		State = new SilverState(0,this);
	}

	public string Owner { get; set; }

	public State State { get; set; }

	public decimal Balance => State.Balance;

	public void Deposit(decimal money)
	{
		State.Deposit(money);
		Console.WriteLine($"Succesfull Deposit: {money}");
		Console.WriteLine($"Your current balance is {Balance}");
		Console.WriteLine(State.GetType().Name);
	}

	public void Withdraw(decimal money)
	{
		State.Withdraw(money);
		Console.WriteLine($"Succesfull Withdraw:  {money}");
		Console.WriteLine($"Your current balance is  {Balance}");
		Console.WriteLine(State.GetType().Name);
	}
}

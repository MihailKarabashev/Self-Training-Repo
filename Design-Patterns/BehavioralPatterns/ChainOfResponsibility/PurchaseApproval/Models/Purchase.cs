namespace PurchaseApproval.Models;

public class Purchase
{
    public Purchase(decimal amount, int number)
    {
        Amount = amount;
        Number = number;
    }

    public decimal Amount { get; private set; }

    public int Number { get; set; }
}

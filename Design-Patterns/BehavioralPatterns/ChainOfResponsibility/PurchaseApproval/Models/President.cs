namespace PurchaseApproval.Models;

public class President : Approver
{
    public override void ProcessRequest(Purchase purchase)
    {
        if (purchase.Amount < 300)
        {
            Console.WriteLine("Calling from President");
        }
        else if (Successor != null)
        {
            Successor.ProcessRequest(purchase);
        }
        else
        {
            Console.WriteLine("Cannot process your purchase.");
        }
    }
}

namespace PurchaseApproval.Models;

public class VicePresident : Approver
{
    public override void ProcessRequest(Purchase purchase)
    {
        if (purchase.Amount < 200)
        {
            Console.WriteLine("Calling from Vice President");
        }
        else if (Successor != null)
        {
            Successor.ProcessRequest(purchase);
        }
    }
}

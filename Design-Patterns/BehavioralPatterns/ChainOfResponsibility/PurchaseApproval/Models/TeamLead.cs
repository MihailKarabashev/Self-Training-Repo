namespace PurchaseApproval.Models;

public class TeamLead : Approver
{
    public override void ProcessRequest(Purchase purchase)
    {
        if (purchase.Amount < 100)
        {
            Console.WriteLine("Calling from Team Leade");
        }
        else if(Successor != null)
        {
            Successor.ProcessRequest(purchase);
        }
    }
}

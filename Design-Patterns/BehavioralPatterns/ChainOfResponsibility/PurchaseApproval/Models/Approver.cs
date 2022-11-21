namespace PurchaseApproval.Models;

public abstract class Approver
{
    protected Approver Successor { get; set; }

    public void SetSuccessor(Approver successor)
    {
        Successor = successor;
    }

    public abstract void ProcessRequest(Purchase purchase);
}

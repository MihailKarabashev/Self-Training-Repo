
using PurchaseApproval.Models;

Approver teamLead = new TeamLead();
Approver vice = new VicePresident();
Approver president = new President();

teamLead.SetSuccessor(vice);
vice.SetSuccessor(president);

var purchse1 = new Purchase(99, 2);
teamLead.ProcessRequest(purchse1);

var purchse2 = new Purchase(100, 2);
teamLead.ProcessRequest(purchse2);

var purchse3 = new Purchase(200, 2);
teamLead.ProcessRequest(purchse3);

var purchse4 = new Purchase(300, 2);
teamLead.ProcessRequest(purchse4);


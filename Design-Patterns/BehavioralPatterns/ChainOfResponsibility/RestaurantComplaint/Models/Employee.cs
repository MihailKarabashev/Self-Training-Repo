using RestaurantComplaint.Enums;

namespace RestaurantComplaint.Models;

public abstract class Employee
{
    protected Priority level;

    public Employee Successor { get; private set; }

    public void SetSuccessor(Employee successor)
    {
        Successor = successor;
    }

    public void ProcessComplaint(Complaint complaint)
    {
        if(complaint.Priority <= level)
        {
            Console.WriteLine($"Mr/Mrs {complaint.CustomerName} Your complaint will be handled by the {this.GetType().Name}");
        }
        else if(Successor!= null)
        {
            Successor.ProcessComplaint(complaint);
        }
        else
        {
            Console.WriteLine("Cannot process your complaint");
        }
    }
}

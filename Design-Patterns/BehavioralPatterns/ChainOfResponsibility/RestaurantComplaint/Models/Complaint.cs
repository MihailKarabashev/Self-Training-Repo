using RestaurantComplaint.Enums;

namespace RestaurantComplaint.Models;

public class Complaint
{
    public string CustomerName { get; set; }

    public Priority Priority { get; set; }
}

using RestaurantComplaint.Enums;

namespace RestaurantComplaint.Models;

public class Waiter : Employee
{
	public Waiter(Priority level)
	{
		this.level = level;
	}
}

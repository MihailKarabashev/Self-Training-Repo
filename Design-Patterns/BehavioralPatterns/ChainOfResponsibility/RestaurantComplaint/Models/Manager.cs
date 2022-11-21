using RestaurantComplaint.Enums;

namespace RestaurantComplaint.Models;

public class Manager : Employee
{
	public Manager(Priority level)
	{
		this.level = level;
	}
}

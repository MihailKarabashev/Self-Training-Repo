﻿using RestaurantComplaint.Enums;

namespace RestaurantComplaint.Models;

public class Cook : Employee
{
	public Cook(Priority level)
	{
		this.level = level;
	}
}

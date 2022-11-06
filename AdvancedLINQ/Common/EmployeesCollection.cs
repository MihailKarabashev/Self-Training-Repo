namespace AdvancedLINQ.Common;

public class EmployeesCollection
{
    public static List<Employee> Employees = new List<Employee>
    {
        new Employee
        {
            EmployeeId = 1,
            Name = "EmployeeName 1",
            Department = "Sales",
            Salary = 55000.00
        },
        new Employee
        {
            EmployeeId = 3,
            Name = "EmployeeName 3",
            Department = "Sales",
            Salary = 25000.00
        },
        new Employee
        {
            EmployeeId = 2,
            Name = "EmployeeName 2",
            Department = "Engineering",
            Salary = 65000.00
        },
         new Employee
        {
            EmployeeId = 4,
            Name = "EmployyeName 4",
            Department = "IT",
            Salary = 85000.00
        },
   };

}

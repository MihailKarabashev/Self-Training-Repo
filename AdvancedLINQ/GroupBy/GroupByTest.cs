using System.Text;

namespace AdvancedLINQ.GroupBy;

public class GroupByTest
{
   private static readonly List<Employee> employees = new List<Employee>
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
   };


    public static string GroupByCriteria()
    {
        var strBuilder = new StringBuilder();

        var employeeDepartmentAggregateReport = employees.GroupBy(x => x.Department).Select(x => new
        {
            DepartmentName = x.First().Department,
            TotalDepartmentSalaryCosts = x.Sum(sum => sum.Salary)
        });

        strBuilder.AppendLine("Department Salary Report");

        foreach (var item in employeeDepartmentAggregateReport)
        {
            strBuilder.AppendLine($"{item.DepartmentName} - Total Salary - ${item.TotalDepartmentSalaryCosts}");
        }

        return strBuilder.ToString().TrimEnd();
    }

    public static string GroupEmployeesByDepartment()
    {
        var strBuilder = new StringBuilder();
        var result = employees
            .GroupBy(x => x.Department);

        foreach (var item in result)
        {
            strBuilder.AppendLine($"Department - {item.Key}");
            strBuilder.AppendLine(new String('-', 15));

            foreach (var employeeName in item.Select(x => x))
            {
                strBuilder.AppendLine(employeeName.Name);
            }
        }

        return strBuilder.ToString().TrimEnd();
    }

    public static string GroupEmployeesByDepartmentAndSalary()
    {
        var strBuilder = new StringBuilder();

        var result = employees
            .Where(x => x.Salary > 25000.00)
            .GroupBy(x => new { x.Department, x.Salary });

        foreach (var item in result)
        {
            strBuilder.AppendLine($"Department-Sales -" +
                $"{item.Key}");
            strBuilder.AppendLine(new string('-', 15));

            foreach (var value in item.Select(x => x))
            {
                strBuilder.AppendLine(value.Name);
            }

            strBuilder.AppendLine("\r\n");
        }

        return strBuilder.ToString().TrimEnd();
    }
}

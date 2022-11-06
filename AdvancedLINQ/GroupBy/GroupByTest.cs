using System.Text;

namespace AdvancedLINQ.GroupBy;

public class GroupByTest
{
    public static string GroupByCriteria(List<Employee> employees)
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

    public static string GroupEmployeesByDepartment(List<Employee> employees)
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

    public static string GroupEmployeesByDepartmentAndSalary(List<Employee> employees)
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

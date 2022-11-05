// See https://aka.ms/new-console-template for more information
using AdvancedLINQ;

var employees = new List<Employee>
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

//GroupEmployeesByDepartment(employees);

//GroupEmployeesByDepartmentAndSalary(employees);



GroupByCriteria(employees);

static void GroupEmployeesByDepartment(List<Employee> employees)
{
    var result = employees
        .GroupBy(x => x.Department);

    foreach (var item in result)
    {
        Console.WriteLine($"Department - {item.Key}");
        Console.WriteLine(new String('-', 15));

        foreach (var employeeName in item.Select(x => x))
        {
            Console.WriteLine(employeeName.Name);
        }
    }
}

static void GroupEmployeesByDepartmentAndSalary(List<Employee> employees)
{
    var result = employees
        .Where(x => x.Salary > 25000.00)
        .GroupBy(x => new { x.Department, x.Salary });

    foreach (var item in result)
    {
        Console.WriteLine($"Department-Sales -" +
            $"{item.Key}");
        Console.WriteLine(new string('-', 15));

        foreach (var value in item.Select(x => x))
        {
            Console.WriteLine(value.Name);
        }

        Console.WriteLine("\r\n");
    }
}

static void GroupByCriteria(List<Employee> employees)
{
    var employeeDepartmentAggregateReport = employees.GroupBy(x => x.Department).Select(x => new
    {
        DepartmentName = x.First().Department,
        TotalDepartmentSalaryCosts = x.Sum(sum => sum.Salary)
    });

    Console.WriteLine("Department Salary Report");

    foreach (var item in employeeDepartmentAggregateReport)
    {
        Console.WriteLine($"{item.DepartmentName} - Total Salary - ${item.TotalDepartmentSalaryCosts}");
    }
}
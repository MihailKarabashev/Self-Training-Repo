namespace EmployeeCloning.Models;

public abstract class Employee
{
    public abstract Employee Clone();

    public abstract string GetDetails();
}

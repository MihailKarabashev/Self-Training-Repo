namespace AdvancedLINQ.Common;

public class DirectorsCollection
{
    public static List<Director> Directors = new List<Director>
    {
     new Director()
    {
        AbleToHire = true,
        Permissions = "READ_WRITE_CREATE_DELETE",
        EmployeeId = 100,
        Name = "Nikola Jokic",
        Department = "Leadership",
        Salary = 175000.00,
        DepartmentResponsibleFor = "Engineering"
    },
    new Director()
    {
        AbleToHire = true,
        Permissions = "READ_WRITE_CREATE_DELETE",
        EmployeeId = 101,
        Name = "Petr Cech",
        Department = "Leadership",
        Salary = 175000.00,
        DepartmentResponsibleFor = "IT"
    }
   };
}

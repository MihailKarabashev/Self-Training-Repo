using System.Text.Json;

namespace AdvancedLINQ.Convert;

public class ConvertTest
{
    private static readonly List<Employee> mixedEmployees = new List<Employee>()
   {
       new Director
       {
          AbleToHire = true,
          Permissions = "READ_WRITE_CREATE_DELETE",
          EmployeeId = 1,
          Name = "Rodrigo Suarez",
          Department = "Leadership",
          Salary = 175000.00
       },
       new Administrator
       {
           EmployeeId = 2,
           Name = "Jessica Cuevas",
           Department = "Engineering",
           Salary = 65000.00
       }
   };

    public static void GetAdministratorsAsString()
    {
        //pull out all instances of Director from List with Employee
        var directors = mixedEmployees
            .OfType<Director>()
            .ToList()
            .ConvertAll(d => JsonSerializer.Serialize(d));

        directors.ForEach(x => Console.WriteLine(x));
    }

}

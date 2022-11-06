namespace AdvancedLINQ.Joining.InnerJoin;

public class InnerJoinTest
{
    public static void Join(List<Employee> employees , List<Director> directors)
    {
        var join = employees.Join(directors,
            em => em.Department,
            dir => dir.DepartmentResponsibleFor,
            (em, dir) => new { EmployeeName = em.Name, DirectorName = dir.Name, Deparment = em.Department });

        foreach (var item in join)
        {
            Console.WriteLine(item);
        }
    }
}

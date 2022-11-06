// See https://aka.ms/new-console-template for more information


using AdvancedLINQ.Common;
using AdvancedLINQ.Convert;
using AdvancedLINQ.GroupBy;
using AdvancedLINQ.Joining.InnerJoin;
//GroupByTest.GroupByCriteria(EmployeesCollection.Employees);
//GroupByTest.GroupEmployeesByDepartment(EmployeesCollection.Employees);
//GroupByTest.GroupEmployeesByDepartmentAndSalary(EmployeesCollection.Employees);

//ConvertTest.GetAdministratorsAsString();

//InnerJoinTest.Join(EmployeesCollection.Employees,DirectorsCollection.Directors);

//Partitioning Operations

//Skip
var list = new List<int>() { 2, 7, 2, 4, 5, 8, 9, 6, 1, 8, 9, 7 };

Console.Write("Skip=>>>" + " ");
foreach (var item in list.Skip(7))
{
    Console.Write(item + " ");
}

Console.WriteLine();


Console.Write("SkipWhile=>>>" + " ");

foreach (var item in list.SkipWhile(x=> x<9))
{
    Console.Write(item + " ");

}

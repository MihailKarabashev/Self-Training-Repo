// See https://aka.ms/new-console-template for more information


using AdvancedLINQ.Common;
using AdvancedLINQ.Convert;
using AdvancedLINQ.GroupBy;
using AdvancedLINQ.Joining.InnerJoin;
//GroupByTest.GroupByCriteria(EmployeesCollection.Employees);
//GroupByTest.GroupEmployeesByDepartment(EmployeesCollection.Employees);
//GroupByTest.GroupEmployeesByDepartmentAndSalary(EmployeesCollection.Employees);

//ConvertTest.GetAdministratorsAsString();

 InnerJoinTest.Join(EmployeesCollection.Employees,DirectorsCollection.Directors);


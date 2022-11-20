using EmployeeCloning.Models;

var developer = new Developer("Misho", "Junior", 100, "C#");
var devCopy = developer.Clone() as Developer;
devCopy.Name = "Koce";

Console.WriteLine(developer.GetDetails());
Console.WriteLine(devCopy.GetDetails());

var typist = new Typist("Ivan", "Team Lead", 200);
var typistCopy = typist.Clone() as Typist;
typist.WordsPerMinute = 250;
typist.Name = "Dragan";

Console.WriteLine(typist.GetDetails());
Console.WriteLine(typistCopy.GetDetails());

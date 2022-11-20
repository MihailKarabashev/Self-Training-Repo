namespace EmployeeCloning.Models;

public class Typist : Employee
{

    public Typist(string name, string role, int wordsPerMinute)
    {
        Name = name;
        Role = role;
        WordsPerMinute = wordsPerMinute;
    }
    public string Name { get; set; }

    public string Role { get; set; }

    public int WordsPerMinute { get; set; }

    public override Employee Clone()
    {
        return this.MemberwiseClone() as Employee;
    }

    public override string GetDetails()
    {
        return string.Format("{0} - {1} - {2}wpm", Name, Role, WordsPerMinute);
    }
}

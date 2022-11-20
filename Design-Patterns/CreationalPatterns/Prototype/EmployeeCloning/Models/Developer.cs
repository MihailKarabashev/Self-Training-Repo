namespace EmployeeCloning.Models;

public class Developer : Employee
{
    public Developer(string name, string role, int wordsPerMinute, string preferredLanguage)
    {
        Name = name;
        Role = role;
        WordsPerMinute = wordsPerMinute;
        PreferredLanguage = preferredLanguage;
    }

    public string Name { get; set; }

    public string Role { get; set; }

    public int WordsPerMinute { get; set; }

    public string PreferredLanguage { get; set; }

    public override Employee Clone()
    {
        return this.MemberwiseClone() as Employee;
    }

    public override string GetDetails()
    {
        return string.Format("{0} - {1} - {2}", Name, Role, PreferredLanguage);
    }
}

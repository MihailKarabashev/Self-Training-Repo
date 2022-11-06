namespace AdvancedLINQ;

public class Director : Employee
{
    public string Permissions { get; set; } = string.Empty;

    public bool AbleToHire { get; set; } = false;
}

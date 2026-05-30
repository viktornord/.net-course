namespace Task3;

public class Employee
{
    private readonly string _lastName;
    private readonly string _firstName;

    public string Position { get; set; } = string.Empty;
    public int YearsOfExperience { get; set; }

    public Employee(string lastName, string firstName)
    {
        _lastName = lastName;
        _firstName = firstName;
    }

    public string LastName => _lastName;

    public string FirstName => _firstName;

    public double CalculateSalary()
    {
        double baseSalary = Position.ToLowerInvariant() switch
        {
            "junior developer" => 25000,
            "developer" => 35000,
            "senior developer" => 50000,
            "team lead" => 65000,
            "manager" => 75000,
            _ => 30000
        };

        return baseSalary + YearsOfExperience * 1500;
    }

    public double CalculateTax()
    {
        const double taxRate = 0.05; // ФОП 5% 3 група
        return CalculateSalary() * taxRate;
    }
}

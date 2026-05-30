using Task3;

Console.OutputEncoding = System.Text.Encoding.UTF8;

Console.Write("Last name: ");
string lastName = Console.ReadLine()?.Trim() ?? string.Empty;

Console.Write("First name: ");
string firstName = Console.ReadLine()?.Trim() ?? string.Empty;

Console.Write("Position: ");
string position = Console.ReadLine()?.Trim() ?? string.Empty;

Console.Write("Years of experience: ");
int.TryParse(Console.ReadLine(), out int yearsOfExperience);

var employee = new Employee(lastName, firstName)
{
    Position = position,
    YearsOfExperience = yearsOfExperience
};

double salary = employee.CalculateSalary();
double tax = employee.CalculateTax();

Console.WriteLine();
Console.WriteLine("Employee information:");
Console.WriteLine($"Last name: {employee.LastName}");
Console.WriteLine($"First name: {employee.FirstName}");
Console.WriteLine($"Position: {employee.Position}");
Console.WriteLine($"Salary: {salary:F2} UAH");
Console.WriteLine($"Tax amount: {tax:F2} UAH");

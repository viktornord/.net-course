using Task6;

Console.OutputEncoding = System.Text.Encoding.UTF8;

Console.Write("Login: ");
string login = Console.ReadLine()?.Trim() ?? string.Empty;

Console.Write("First name: ");
string firstName = Console.ReadLine()?.Trim() ?? string.Empty;

Console.Write("Last name: ");
string lastName = Console.ReadLine()?.Trim() ?? string.Empty;

Console.Write("Age: ");
int.TryParse(Console.ReadLine(), out int age);

var user = new User(login, firstName, lastName, age);

Console.WriteLine();
Console.WriteLine("User data:");
Console.WriteLine($"Login: {user.Login}");
Console.WriteLine($"First name: {user.FirstName}");
Console.WriteLine($"Last name: {user.LastName}");
Console.WriteLine($"Age: {user.Age}");
Console.WriteLine($"Date of registration: {user.RegistrationDate:yyyy-MM-dd HH:mm:ss}");

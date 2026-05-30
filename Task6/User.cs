namespace Task6;

public class User
{
    public readonly string Login;
    public readonly string FirstName;
    public readonly string LastName;
    public readonly int Age;
    public readonly DateTime RegistrationDate;

    public User(string login, string firstName, string lastName, int age)
    {
        Login = login;
        FirstName = firstName;
        LastName = lastName;
        Age = age;
        RegistrationDate = DateTime.Now;
    }
}

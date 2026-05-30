namespace DotNetCourse;

/// <summary>
/// Task 5: Which variable names are valid in C#?
/// </summary>
public static class Task5
{
    public static void Run()
    {
        Console.WriteLine("C# identifier rules: start with letter or _; then letters, digits, _; no spaces or ? & etc.");
        Console.WriteLine();

        // Valid examples (uncomment invalid names in a separate file — they will not compile):
        int _Identifier = 1;
        int Identifier = 2;
        int myVariab1le = 3;

        Console.WriteLine("uberflu?     — INVALID (? is not allowed in identifiers)");
        Console.WriteLine("_Identifier  — VALID   (value = {0})", _Identifier);
        Console.WriteLine("Identifier   — VALID   (value = {0})", Identifier);
        Console.WriteLine("& myVar      — INVALID (spaces and & are not allowed)");
        Console.WriteLine("myVariab1le  — VALID   (value = {0})", myVariab1le);
    }
}

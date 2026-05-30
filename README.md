# dot-net-course — Homework 3 (Operators & expressions)

Console application with one file per assignment task. Run a specific task by passing its number (or `taskN`) as an argument.

## Prerequisites

- [.NET SDK](https://dotnet.microsoft.com/download) (project targets **net10.0**)

## Build

```bash
dotnet build
```

## Run a task

From the project directory:

```bash
dotnet run -- 1
dotnet run -- 2
# … through 7
```

You can also use `task1` … `task7` instead of the digit.

| Argument | File       | Description |
|----------|------------|-------------|
| `1`      | `Task1.cs` | `++` / `--` and compound assignments on `x`, `y`, `z` |
| `2`      | `Task2.cs` | Arithmetic mean of three integers (int vs `double`) |
| `3`      | `Task3.cs` | Circle area \(A = \pi r^2\) |
| `4`      | `Task4.cs` | Cylinder volume and surface area |
| `5`      | `Task5.cs` | Valid and invalid C# identifier names |
| `7`      | `Task7.cs` | Arithmetic operations on two integers |

With no argument, the program prints usage:

```bash
dotnet run
```

## Visual Studio

1. Open `dot-net-course.csproj` (or the folder) in Visual Studio.
2. **Project → Properties → Debug → General → Open debug launch profiles UI**.
3. Set **Command line arguments** to the task number (e.g. `1`), or run from a terminal: `dotnet run -- 1`.


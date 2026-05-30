# dot-net-course — Homework 4 (Switch & selection)

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
dotnet run -- 2
dotnet run -- 3
dotnet run -- 5
```

You can also use `task2`, `task3`, or `task5` instead of the digit.

| Argument | File       | Description |
|----------|------------|-------------|
| `2`      | `Task2.cs` | Console calculator; `switch` on operation sign; division-by-zero check |
| `3`      | `Task3.cs` | Interval checker: [0–14], [15–35], [36–50], [51–100] |
| `5`      | `Task5.cs` | Ukrainian–English weather translator (10 words) |

With no argument, the program prints usage:

```bash
dotnet run
```

### Task 2 (calculator)

Uses fixed operands (`operand1`, `operand2`). When prompted, enter one of: `+`, `-`, `*`, `/`.

```bash
dotnet run -- 2
```

### Task 3 (intervals)

Enter an integer when prompted. Numbers outside 0–100 are reported as not belonging to any interval.

```bash
dotnet run -- 3
```

### Task 5 (translator)

Enter a Ukrainian weather word when prompted. Known words are listed at startup.

```bash
dotnet run -- 5
```

## Visual Studio

1. Open `dot-net-course.csproj` (or the folder) in Visual Studio.
2. **Project → Properties → Debug → General → Open debug launch profiles UI**.
3. Set **Command line arguments** to the task number (e.g. `2`), or run from a terminal: `dotnet run -- 2`.

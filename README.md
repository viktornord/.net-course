# dot-net-course

Console application for .NET course homework. Each task lives in its own source file and is started from `Program.cs` by task number.

## Prerequisites

- [.NET SDK](https://dotnet.microsoft.com/download) (project targets `net10.0`)
- Or **Visual Studio** with the **Console Application** workload

## Run a task

From the project folder:

```bash
dotnet run -- 2
dotnet run -- 3
dotnet run -- 4
dotnet run -- 6
```

In **Visual Studio**: set this project as startup, open **Project → Properties → Debug → Application arguments**, and enter `2`, `3`, `4`, or `6`, then run (F5).

Run without arguments to see usage:

```bash
dotnet run
```

## Tasks

| Task | File     | Description |
|------|----------|-------------|
| 2    | Task2.cs | Enter two integers and an operator (`+`, `-`, `*`, `/`); calls `Add`, `Sub`, `Mul`, or `Div` (division checks for zero) |
| 3    | Task3.cs | Enter amount and conversion rate; prints the converted amount |
| 4    | Task4.cs | Enter an integer; reports sign, primality (divisor count), and divisibility by 2, 5, 3, 6, and 9 |
| 6    | Task6.cs | Enter three integers; `Calculate` prints their arithmetic mean |

All tasks read input from the console when run.

## Build only

```bash
dotnet build
```

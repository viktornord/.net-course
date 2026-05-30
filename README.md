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
| 2    | Task2.cs | Enter `A` and `B` (`A < B`); prints the sum of integers strictly between them and all odd values in that range |
| 3    | Task3.cs | Draws a filled rectangle, right triangle, equilateral triangle, and rhombus using `Console.Write("*")`, spaces, and newlines |
| 4    | Task4.cs | Enter `N` customers; prints the number of delivery routes `N!` (factorial computed with a `do-while` loop) |
| 6    | Task6.cs | Draws a rectangle of `*` using nested loops; height and width are set in integer variables |

Tasks **2**, **3**, and **4** read input from the console. Task **6** uses preset dimensions (`height = 5`, `width = 8`); edit `Task6.cs` to change them.

## Build only

```bash
dotnet build
```

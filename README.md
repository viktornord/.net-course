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
dotnet run -- 7
```

In **Visual Studio**: set this project as startup, open **Project → Properties → Debug → Application arguments**, and enter `2`, `3`, `4`, `6`, or `7`, then run (F5).

Run without arguments to see usage:

```bash
dotnet run
```

## Tasks

| Task | File     | Description |
|------|----------|-------------|
| 2    | Task2.cs | Parity check: modulo vs. least significant bit |
| 3    | Task3.cs | Step-by-step evaluation of `x`, `y`, `z` expressions |
| 4    | Task4.cs | Employee bonus by years of service |
| 6    | Task6.cs | Power-of-two check (bitwise and division) |
| 7    | Task7.cs | De Morgan: `A \| B` ≡ `~(~A & ~B)` |

Tasks **2**, **4**, **6**, and **7** read input from the console. Task **3** runs the given expressions automatically.

## Build only

```bash
dotnet build
```

# dot-net-course

Console application for .NET course homework. Each task lives in its own source file and is started from `Program.cs` by task number.

## Prerequisites

- [.NET SDK](https://dotnet.microsoft.com/download) (project targets `net10.0`)
- Or **Visual Studio** with the **Console Application** workload

## Run a task

From the project folder:

```bash
dotnet run -- 1
dotnet run -- 2
dotnet run -- 3
```

Task **5** is the cross-platform version of the Windows Forms assignment (works on **macOS** and **Windows**). Click a type name to see `MinValue`–`MaxValue` for that integral type.

Run the GUI directly:

```bash
dotnet run --project Task5
```

In **Visual Studio**: set this project as startup, open **Project → Properties → Debug → Application arguments**, and enter `1`, `2`, `3`, then run (F5).

Run without arguments to see usage:

```bash
dotnet run
```

## Build only

```bash
dotnet build
```

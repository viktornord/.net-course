# .NET Course

Console assignments for the .NET course. Each task lives in its own project folder.

## Prerequisites

- [.NET SDK](https://dotnet.microsoft.com/download) (this repo targets **.NET 10**)
- Check your install: `dotnet --version`

## Projects

| Project | Description |
|---------|-------------|
| `Task2/` | Classroom with `Pupil` hierarchy (`ExcellentPupil`, `GoodPupil`, `BadPupil`) and `ClassRoom` for 2–4 students |
| `Task3/` | `Vehicle` base class with `Car`, `Plane`, and `Ship` derived types; displays info for each |
| `Task4/` | `DocumentWorker` hierarchy (`ProDocumentWorker`, `ExpertDocumentWorker`); access key selects edition |
| `Task5/` | `Printer` base class with colored derived printers (`RedPrinter`, `GreenPrinter`, `BluePrinter`) |

## How to run

**Task 2 — Classroom**

```bash
dotnet run --project Task2
```

**Task 3 — Vehicles**

```bash
dotnet run --project Task3
```

**Task 4 — Document worker**

```bash
dotnet run --project Task4
```

**Task 5 — Printers**

```bash
dotnet run --project Task5
```

## Build

```bash
dotnet build Task2/Task2.csproj
dotnet build Task3/Task3.csproj
dotnet build Task4/Task4.csproj
dotnet build Task5/Task5.csproj
```

You can also open `Task2/Task2.csproj`, `Task3/Task3.csproj`, `Task4/Task4.csproj`, or `Task5/Task5.csproj` in Visual Studio and press **F5**.

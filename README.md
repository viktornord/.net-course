# dot-net-course

Console assignments implemented as separate .NET projects.

## Prerequisites

- Install [.NET SDK](https://dotnet.microsoft.com/download)
- Verify installation:

```bash
dotnet --version
```

## Tasks

| Project | Description |
| --- | --- |
| `Task2/` | Abstract document handler with XML/TXT/DOC implementations |
| `Task3/` | Player class implementing `IPlayable` and `IRecodable` interfaces |
| `Task5/` | `Book` document from essentials-hw1 Task 3, refactored with `DocumentPart` abstract base |

## How to run

```bash
dotnet run --project Task2
dotnet run --project Task3
dotnet run --project Task5
```

## Build

```bash
dotnet build Task2/Task2.csproj
dotnet build Task3/Task3.csproj
dotnet build Task5/Task5.csproj
```

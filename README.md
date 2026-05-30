# .NET Course

Console exercises for a .NET course. Each task lives in its own folder with a separate project file.

## Prerequisites

- [.NET 10 SDK](https://dotnet.microsoft.com/download) (or newer)

Check your installation:

```bash
dotnet --version
```

## Running a task

From the repository root, run a task with:

```bash
dotnet run --project Task<N>
```

Replace `<N>` with the task number (2, 3, 4, or 6).

### Task 2 — Rectangle

Computes area and perimeter of a rectangle.

```bash
dotnet run --project Task2
```

### Task 3 — Book

Demonstrates composition with `Title`, `Author`, and `Content` classes.

```bash
dotnet run --project Task3
```

### Task 4 — Figure

Builds a polygon from points and prints its name and perimeter.

```bash
dotnet run --project Task4
```

### Task 6 — Address

Creates an address with properties and prints its fields.

```bash
dotnet run --project Task6
```

## Root project

The root `dot-net-course` project is a default console app and is separate from the tasks above:

```bash
dotnet run
```

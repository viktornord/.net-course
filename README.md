# .NET Course — Console Tasks

Console application with array exercises (Tasks 2, 3, 4, and 6). Each task lives in its own file:

| File       | Description |
|------------|-------------|
| `Task2.cs` | User-defined array size; max, min, sum, mean, odd values |
| `Task3.cs` | `MyReverse` and `SubArray` methods |
| `Task4.cs` | Grow array by one element; insert value at index 0 |
| `Task6.cs` | 10-element array printed in reverse order |

## Requirements

- [.NET SDK](https://dotnet.microsoft.com/download) (project targets `net10.0`)

## Build

From the repository root:

```bash
dotnet build
```

## Run

### Interactive menu

```bash
dotnet run
```

Choose `2`, `3`, `4`, or `6` when prompted. Task 2 asks for array size `N`.

### Run a specific task directly

```bash
dotnet run -- 2
dotnet run -- 3
dotnet run -- 4
dotnet run -- 6
```

### Visual Studio

1. Open `dot-net-course.csproj` (or the solution if you add one).
2. Set the project as the startup project.
3. Press **F5** to run, or use **Debug → Start Without Debugging**.
4. Optional: **Project → Properties → Debug → Application arguments** — set `2`, `3`, `4`, or `6` to start on that task.

## Task summaries

**Task 2** — Enter positive `N`. The program fills an `int[]` with random integers, then prints the largest and smallest values, the sum, the arithmetic mean, and all odd elements.

**Task 3** — Demonstrates `MyReverse(int[])` (new array in reverse order) and `SubArray(int[], index, count)`. If `count` extends past the end of the source array, missing slots are filled with `1`.

**Task 4** — `IncreaseLengthByOne` copies the array into a new array one element longer (same indices). `AddAtStart` inserts a value at index `0` and shifts the original elements to indices `1..n`.

**Task 6** — Creates an array of 10 integers and prints them from last index to first.

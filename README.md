# .NET Course

Solutions for a .NET programming course. Each task lives in its own folder when it needs a separate app; the root project is a simple console template.

## Requirements

- [.NET SDK 10](https://dotnet.microsoft.com/download) or newer

Check your install:

```bash
dotnet --version
```

## Repository layout

| Path | Description |
|------|-------------|
| `Program.cs` | Root console app (default template) |
| `dot-net-course.csproj` | Root console project |
| `Task3/` | Task 3 — two text boxes and a button (cross-platform GUI) |

## Run the root console app

```bash
dotnet run
```

## Task 3 — Text boxes and button click

**Assignment:** A form with two `TextBox` controls and one `Button`. On click (`button_Click`), copy the text from `textBox1` into `textBox2`.

**Implementation:** [Avalonia UI](https://avaloniaui.net/) instead of Windows Forms so the same project runs on **macOS**, **Windows**, and Linux. Control names and the event handler match the WinForms-style layout (`Form1.cs`, `Form1.Designer.cs`).

```bash
dotnet run --project Task3
```

1. Type in the top text box.
2. Click **Copy to textBox2**.
3. The bottom text box shows the same text.

### Build Task 3 only

```bash
dotnet build Task3/Task3.csproj
```

### IDE

- **Windows:** Visual Studio or JetBrains Rider — open `Task3/Task3.csproj`.
- **macOS:** Rider or VS Code with the C# extension — open `Task3/Task3.csproj`.

> Classic **Windows Forms** projects from Visual Studio run only on Windows. Task 3 uses Avalonia for cross-platform desktop UI with equivalent behavior.


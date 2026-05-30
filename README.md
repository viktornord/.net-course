# dot-net-course

Homework tasks for a .NET course. Console tasks **2**, **3**, and **6** share one project; **Task 4** is a separate cross-platform GUI app.

| Task | Location | Description |
|------|----------|-------------|
| 2 | `Task2.cs` | Bank loan repayment (UAH 100 × 7; flexible lump payments) |
| 3 | `Task3.cs` | Delivery routes count via recursive factorial N! |
| 4 | `Task4/` | Calculator GUI (remainder, power, concat, divide) — **macOS / Windows / Linux** |
| 6 | `Task6.cs` | `Calculate` — three integers divided by 5 |

> **Task 4 note:** The assignment describes **Windows Forms**, which only runs on Windows. This repo uses **[Avalonia UI](https://avaloniaui.net/)** with the same controls (`textBox1`, `textBox2`, `textBox3`, radio buttons, **Calculate** button) so you can run it on **Mac** (and other platforms) without changing the homework logic.

## Prerequisites

- [.NET SDK](https://dotnet.microsoft.com/download) (project targets `net10.0`)

## Build

From the repository root:

```bash
dotnet build                    # console tasks (2, 3, 6)
dotnet build Task4/Task4.csproj # GUI task 4
# or build everything:
dotnet build dot-net-course.sln
```

## Run a task

Pass the task number after `--` (required so the argument is passed to your app, not to `dotnet run`):

```bash
dotnet run -- 2
dotnet run -- 3
dotnet run -- 6
```

Without a task number, the app prints usage:

```bash
dotnet run
```

### Task 2 — Loan repayment

- Total obligation: **UAH 700** (7 × UAH 100).
- Enter payment amounts one per line (e.g. `300`, then `400` to close the loan).
- Press Enter on an empty line to exit.
- After each payment you see remaining debt, overpayment (if any), and a **no debt** message when the loan is paid off.

### Task 3 — Delivery routes

- Enter the number of customers **N**.
- The program prints **N!** (number of possible routes for one vehicle visiting each customer once) using **recursive** factorial.
- It also prints why recursion is a weak choice for factorial in practice.

### Task 6 — Calculate

- Enter three integers when prompted.
- The program shows each value divided by 5 (integer division, e.g. `7 → 1`).

### Task 4 — Calculator (GUI)

From the repo root:

```bash
dotnet run --project Task4
```

**macOS / Linux / Windows** — a window opens with:

| Control | Role |
|---------|------|
| `textBox1`, `textBox2` | Input values |
| Radio buttons | Remainder (%), exponentiation (^), concatenation, division (/) |
| **Calculate** | Runs the selected operation |
| `textBox3` | Shows the result |

- **Concatenation** joins the two text fields as strings (e.g. `Hello` + `World` → `HelloWorld`).
- Other operations parse both fields as numbers.

In **Visual Studio** or **Rider**: set **Task4** as the startup project and press **F5**.

On **Mac**, use **Visual Studio for Mac** (retired), **Rider**, or **`dotnet run --project Task4`** from the terminal.

## Visual Studio

1. Open `dot-net-course.csproj`.
2. **Project → Properties → Debug → General** → set **Command line arguments** to `2`, `3`, or `6`.
3. Press **F5** to run the selected task.

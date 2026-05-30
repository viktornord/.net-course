# .NET Course — Console Tasks

This repository contains separate console application projects for course assignments.

## Prerequisites

- [.NET SDK 10.0](https://dotnet.microsoft.com/download) or later
- Optional: [Visual Studio 2022](https://visualstudio.microsoft.com/) or [Visual Studio Code](https://code.visualstudio.com/) with the C# extension

Verify your installation:

```bash
dotnet --version
```

## Projects

| Folder  | Description |
|---------|-------------|
| `Task2/` | Currency converter (UAH ↔ USD / EUR / GBP) |
| `Task3/` | Employee salary and tax calculator |
| `Task4/` | Invoice total with and without VAT |
| `Task6/` | User registration with read-only registration date |

## How to Run

Each task is an independent project. From the repository root:

### Task 2 — Currency Converter

```bash
dotnet run --project Task2
```

Convert between hryvnia (UAH) and USD, EUR, or GBP using a menu-driven interface.

### Task 3 — Employee

```bash
dotnet run --project Task3
```

Enter employee details (last name, first name, position, years of experience). The program displays salary and tax amount.

Supported positions for salary calculation: `Junior Developer`, `Developer`, `Senior Developer`, `Team Lead`, `Manager` (case-insensitive).

### Task 4 — Invoice

```bash
dotnet run --project Task4
```

Enter invoice details and product information. The program displays the total amount with and without VAT (20%).

Known articles: `laptop`, `monitor`, `keyboard`, `mouse` (case-insensitive). Other articles use a default unit price.

### Task 6 — User

```bash
dotnet run --project Task6
```

Enter user information. The program creates a `User` object and displays all fields, including the registration date set automatically at object creation.

## Build All Projects

```bash
dotnet build Task2/Task2.csproj
dotnet build Task3/Task3.csproj
dotnet build Task4/Task4.csproj
dotnet build Task6/Task6.csproj
```

## Open in Visual Studio

1. Open Visual Studio.
2. Choose **Open a project or solution**.
3. Select the `.csproj` file inside the task folder (for example, `Task2/Task2.csproj`).
4. Press **F5** to build and run.

## Project Structure

Each task folder follows the same layout:

```
TaskN/
├── TaskN.csproj    # Project file
├── Program.cs      # Entry point
└── *.cs            # Task-specific classes (Converter, Employee, Invoice, User)
```

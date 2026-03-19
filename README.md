# Programming 3 Tutoring Repository

This repository contains materials for **Programming 3** tutoring, organized as a reusable template plus workshop/exam practice variants.

## Repository Structure

```text
C# Repos/
|- cs-winforms-exam-template-2025-26-main/
|  |- Studentska.sln
|  |- Studentska.Data/
|  |- Studentska.Servis/
|  `- Studentska.WinApp/
`- Workshops/
   |- ISPITNI 20-02-2025 - STIPENDIJE/
   |- ISPITNI 14-02-2026 - PRAKSE/
   `- ISPITNI 28-01-2026 - KNJIGE/
```

## Tech Stack

- **Language:** C#
- **Platform:** .NET 8
- **UI:** Windows Forms (`net8.0-windows`)
- **Data layer:** Entity Framework Core + SQLite
- **Solution layout:** `Studentska.Data`, `Studentska.Servis`, `Studentska.WinApp`

## Folder Purpose

- `cs-winforms-exam-template-2025-26-main`
  - Main baseline template used for tutoring and student exercises.
- `Workshops/*`
  - Scenario-specific workshop/exam variants (e.g., Scholarships, Internships, Books).
  - Each folder contains its own `Studentska.sln` and project set.

## Requirements

- Windows OS (WinForms project)
- .NET SDK 8.0+
- Visual Studio 2022 (recommended) or JetBrains Rider

## Quick Start

Use these commands from the specific project/workshop folder you want to run:

```bash
dotnet restore .\Studentska.sln
dotnet build .\Studentska.sln -c Debug
dotnet run --project .\Studentska.WinApp\Studentska.WinApp.csproj
```

## Suggested Tutoring Workflow

1. Start from the template solution.
2. Introduce one workshop scenario at a time.
3. Ask students to implement features in `Data` and `Servis`, then connect UI in `WinApp`.
4. Use workshop folders for mock-exam practice and timed exercises.

## Notes

- Most subfolder `README.md` files are currently placeholders.
- There are no dedicated automated test projects yet.

## License

This repository includes a `LICENSE` file at the root.

# AGENTS.md

Notes for anyone, human or AI agent, changing this code. `README.md` and `CodeComplete_Documentation.html` (a
tab-by-tab user guide) cover what the tool does; this file covers how the code is put together.

## What this is

CodeComplete (project `TAICodeComplete`), a Windows Forms code generator. You point it at a SQL Server table or
view, and it writes a data-access class with CRUD methods. It also writes matching TypeScript, web-service, REST,
HTML, XAML, WinForms and SQL code, and has small utilities (stringify, SQL beautifier, Base64). An optional LM
Studio connection adds AI-assisted generation.

It targets .NET Framework 4.7.2 with WinForms, so it builds and runs on Windows only.

## Commands

Open `TAICodeComplete.sln` in Visual Studio, or from a Developer Command Prompt:

```bat
nuget restore TAICodeComplete.sln
msbuild TAICodeComplete.sln /p:Configuration=Debug
```

NuGet packages come from `TAICodeComplete/packages.config` into a `packages/` folder beside the solution
(Newtonsoft.Json, RestSharp, System.Text.Json and their dependencies). The Debug build is x86. There are no tests.

## Layout

- `TAICodeComplete/frmMain.cs`: almost all of the tool, about 7,000 lines. The tabs, the SQL Server queries
  (`SqlConnection` to the chosen server and database) and every code generator live here, with the UI in
  `frmMain.Designer.cs`.
- `frmFieldSelect`, `frmSelectLookupFields`, `frmTblLookupUI`, `tblDocDefTemplateUI`: secondary dialogs for picking
  fields and lookup tables.
- `Program.cs`: the entry point, plus helper classes such as a registry reader.
- `TestForm1.cs`: a sample form opened from the main window's test button.
- `clsTBLMEMBERMAIN.cs`: an example of a generated data-access class (`tblMemberMain`), compiled into the project.
- `LMStudioClient.cs`: a RestSharp client for LM Studio's OpenAI-style API (default `http://localhost:1234/v1`).
- `NetworkScanner.cs`: scans the local /24 subnets for SQL Server (port 1433) and LM Studio servers.
- `SourceFormat.cs`: syntax-colouring formatters for C-like code.
- `SupportDLLs/` and `ScintellaSupportStuff/`: referenced binaries that are not on NuGet (TAIGridControl2,
  SQL_Formatter, VB PowerPacks, ScintillaNET). Keep them; the project points at them by `HintPath`.
- `bin/Debug/`: some files here are committed on purpose. The HTML preview writes `TEMP.HTML` and `STYLE.CSS`
  next to the program and loads the jQuery, jQuery UI and w2ui files under `JS/`. Don't delete the folder when
  cleaning build output.
- `Images/`: arrow icons (embedded resources) and the README screenshots.

## Rules that keep it working

- **Designer files.** Change forms in the Visual Studio designer, or keep `*.Designer.cs` and `*.resx` in step by
  hand. Each form is listed in `TAICodeComplete.csproj`, which uses the old non-SDK format: new files must be
  added there as `<Compile>` items.
- **Line endings.** Most sources are CRLF, and some files have a UTF-8 byte-order mark. Keep each file's existing
  line endings and encoding so diffs show only real changes.
- **No secrets in the repo.** Connection strings and LM Studio addresses are typed into the UI at run time; don't
  commit real server names or credentials.

## Making a change

- Build in Visual Studio and try the change against a test database.
- Update `README.md`, and the matching tab section in `CodeComplete_Documentation.html`, when a tab's behaviour
  changes.

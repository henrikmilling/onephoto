# OnePhoto - C# Command Line Tool

## Project Overview
- **Type**: .NET 8.0 console application (C#)
- **Purpose**: Command-line tool called `onephoto`
- **Runtime**: .NET 8.0 or later required

## Build & Run Commands
Use these VS Code tasks to build and execute:
- **Build**: `dotnet build onephoto.csproj` (keyboard: Ctrl+Shift+B)
- **Run**: `dotnet run --project onephoto.csproj` (keyboard: Ctrl+Shift+D)
- **Run with debug**: Launch configuration ".NET Core Launch (console)" (F5)

Commands are configured in `.vscode/tasks.json` and `.vscode/launch.json`.

## Architecture & Code Organization
- **Entry point**: [Program.cs](Program.cs) - Contains `Program` class with `Main(string[] args)` method
- **Namespace**: `OnePhoto` (configured in `onephoto.csproj` as `RootNamespace`)
- **Single-file structure**: Currently a minimal CLI tool with no additional source files yet

## C# Project Conventions
- **Framework**: .NET 8.0 (`TargetFramework` in `.csproj`)
- **Language features enabled**: 
  - Implicit usings (`<ImplicitUsings>enable</ImplicitUsings>`) - System namespaces auto-imported
  - Nullable reference types (`<Nullable>enable</Nullable>`) - Strict null checking enabled
- **Output**: Executable (`<OutputType>Exe</OutputType>`) produces `onephoto.dll`
- **Assembly name**: `onephoto` (configured in `.csproj`)

## Adding New Features
When extending the CLI:
1. Add command handling logic to `Program.Main()`
2. For complex commands, create separate classes in new files under root directory
3. Reference new files in `.csproj` if using custom project structure
4. Follow C# naming: PascalCase for classes/methods, camelCase for local variables
5. Update [README.md](README.md) with usage examples

## Key Files
- [onephoto.csproj](onephoto.csproj) - Project configuration (dependencies, build settings)
- [Program.cs](Program.cs) - CLI entry point and command logic
- [README.md](README.md) - User-facing documentation
- [.vscode/tasks.json](.vscode/tasks.json) - Build/run task definitions
- [.vscode/launch.json](.vscode/launch.json) - Debug configuration

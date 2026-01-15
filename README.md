# onephoto

A C# command line tool application for processing jdupes JSON output.

## Getting Started

### Prerequisites
- .NET 8.0 SDK or later

### Build
```bash
dotnet build
```

### Run
```bash
dotnet run -- <jdupes-json-file>
```

Example:
```bash
dotnet run -- duplicates.json
```

This will parse the JSON file and display information about duplicate file sets.

## Project Structure
- `Program.cs` - Main entry point
- `JdupesResult.cs` - Classes for deserializing jdupes JSON
- `onephoto.csproj` - Project configuration

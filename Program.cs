using System.Text.Json;

namespace onephoto;

class Program
{
    static void Main(string[] args)
    {
        if (args.Length == 0)
        {
            Console.WriteLine("Usage: onephoto <jdupes-json-file>");
            return;
        }

        string filePath = args[0];

        try
        {
            string json = File.ReadAllText(filePath);
            var result = JsonSerializer.Deserialize<JdupesResult>(json);

            if (result == null)
            {
                Console.WriteLine("Failed to parse JSON.");
                return;
            }

            Console.WriteLine($"Jdupes version: {result.JdupesVersion}");
            Console.WriteLine($"Command: {result.CommandLine}");
            Console.WriteLine($"Found {result.MatchSets.Count} duplicate sets:");

            foreach (var set in result.MatchSets)
            {
                Console.WriteLine($"Size: {set.FileSize} bytes, Files: {set.FileList.Count}");
                foreach (var file in set.FileList)
                {
                    Console.WriteLine($"  {file.FilePath}");
                }
                Console.WriteLine();
            }
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine($"File not found: {filePath}");
        }
        catch (JsonException ex)
        {
            Console.WriteLine($"Invalid JSON: {ex.Message}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
}

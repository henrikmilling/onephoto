using System.Text.Json.Serialization;

namespace onephoto;

public class JdupesResult
{
    [JsonPropertyName("jdupesVersion")]
    public string JdupesVersion { get; set; } = string.Empty;

    [JsonPropertyName("jdupesVersionDate")]
    public string JdupesVersionDate { get; set; } = string.Empty;

    [JsonPropertyName("commandLine")]
    public string CommandLine { get; set; } = string.Empty;

    [JsonPropertyName("extensionFlags")]
    public string ExtensionFlags { get; set; } = string.Empty;

    [JsonPropertyName("matchSets")]
    public List<MatchSet> MatchSets { get; set; } = new();
}

public class MatchSet
{
    [JsonPropertyName("fileSize")]
    public long FileSize { get; set; }

    [JsonPropertyName("fileList")]
    public List<FileEntry> FileList { get; set; } = new();
}

public class FileEntry
{
    [JsonPropertyName("filePath")]
    public string FilePath { get; set; } = string.Empty;
}
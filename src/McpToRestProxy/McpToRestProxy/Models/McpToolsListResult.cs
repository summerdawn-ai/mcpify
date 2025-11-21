using System.Text.Json.Serialization;

namespace Summerdawn.Mcp.RestProxy.Models;

public sealed class McpToolsListResult
{
    public IReadOnlyList<McpToolDefinition> Tools { get; init; } = [];

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? NextCursor { get; init; }
}

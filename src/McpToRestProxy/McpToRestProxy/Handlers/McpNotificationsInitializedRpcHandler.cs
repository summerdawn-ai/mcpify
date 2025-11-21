using Summerdawn.Mcp.RestProxy.Models;

namespace Summerdawn.Mcp.RestProxy.Handlers;

public sealed class McpNotificationsInitializedRpcHandler : IRpcHandler
{
    public Task<JsonRpcResponse> HandleAsync(JsonRpcRequest rpcRequest, CancellationToken cancellationToken = default)
    {
        return Task.FromResult(JsonRpcResponse.Empty);
    }
}

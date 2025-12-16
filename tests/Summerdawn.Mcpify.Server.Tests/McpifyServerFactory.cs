using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Testing;

namespace Summerdawn.Mcpify.Server.Tests;

/// <summary>
/// Custom WebApplicationFactory that uses Mcpify.Server's main entry point.
/// </summary>
public class McpifyServerFactory : WebApplicationFactory<Program>
{
    protected override void ConfigureWebHost(IWebHostBuilder builder)
    {
        // Set content root to test directory so it uses the test mappings.json
        builder.UseContentRoot(AppContext.BaseDirectory);

        base.ConfigureWebHost(builder);
    }
}

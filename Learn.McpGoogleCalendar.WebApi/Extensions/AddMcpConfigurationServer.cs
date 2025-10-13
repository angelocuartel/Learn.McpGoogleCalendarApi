namespace Learn.McpGoogleCalendar.WebApi.Extensions
{
    public static partial class ConfigureExtenions
    {
        public static IServiceCollection AddMcpConfigurationServer
            (this IServiceCollection services, IConfiguration configuration)
        {
            services.AddMcpServer()
            .WithHttpTransport()
            .WithToolsFromAssembly();

            return services;
        }
    }
}

namespace DevIO.Api.Configuration
{
    public static class ApiConfig
    {
        public static IServiceCollection AddApiConfig(this IServiceCollection services)
        {
            return services;
        }

        public static IApplicationBuilder UseApiConfig(this IServiceCollection app)
        {
            return app;
        }
    }    
}

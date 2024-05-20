using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace bursaDAL.Configurations
{
    public static class MigrationsManager
    {
        public static IApplicationBuilder MigrateDatabase(this IApplicationBuilder app)
        {
            if (app is null)
            {
                ArgumentNullException.ThrowIfNull(app);
            }
            
            using var scope = app.ApplicationServices.CreateScope();
            using var context = scope.ServiceProvider.GetRequiredService<BursaContext>();
            return app;
        }
    }
}

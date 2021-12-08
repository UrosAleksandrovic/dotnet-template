using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Prime.ProjectName.Data;

namespace Prime.ProjectName.Api.Extenions
{
    public static class AppBuilderExtensions
    {
        public static void UpdateDatabase(this IApplicationBuilder app)
        {
            using var serviceScope = app.ApplicationServices.GetService<IServiceScopeFactory>().CreateScope();
            var context = serviceScope.ServiceProvider.GetRequiredService<ProjectNameDbContext>();
            context.Database.Migrate();
        }
    }
}

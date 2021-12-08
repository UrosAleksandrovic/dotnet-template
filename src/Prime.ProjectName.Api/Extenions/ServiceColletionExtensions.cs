using AutoMapper.Extensions.ExpressionMapping;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;
using Prime.ProjectName.Data;

namespace Prime.ProjectName.Api.Extenions
{
    public static class ServiceColletionExtensions
    {
        public static IServiceCollection AddProjectNameDbContext(
            this IServiceCollection services, string connString) 
            => services.AddDbContext<ProjectNameDbContext>(
                options => options.UseSqlServer(connString));

        public static IServiceCollection AddProjectNameAutomapper(this IServiceCollection services) 
            => services.AddAutoMapper(mc =>
                {
                    mc.AddExpressionMapping();
                    mc.AddProfile(new Data.Mapper.MapperProfile());
                    mc.AddProfile(new Data.Mapper.MapperProfile());
                    mc.AddProfile(new Data.Mapper.MapperProfile());
                });

        public static IServiceCollection AddProjectNameSwagger(this IServiceCollection services)
            => services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "ProjectName API", Version = "v1" });
            });
    }
}

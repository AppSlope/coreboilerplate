using CoreBoilerplate.Infrastructure.Middlewares;
using Microsoft.AspNetCore.Builder;

namespace CoreBoilerplate.Infrastructure.Extensions
{
    public static class ApplicationBuilderExtensions
    {
        public static IApplicationBuilder UseInfrastructureMiddlewares(this IApplicationBuilder app)
        {
            app.UseGlobalErrorHandler();
            app.UseSwaggerDocumentation();
            return app;
        }
        private static IApplicationBuilder UseGlobalErrorHandler(this IApplicationBuilder app)
        {
            app.UseMiddleware<GlobalErrorHandler>();
            return app;
        }

        private static IApplicationBuilder UseSwaggerDocumentation(this IApplicationBuilder app)
        {
            app.UseSwagger();
            app.UseSwaggerUI(options =>
            {
                options.DefaultModelsExpandDepth(-1);
                options.SwaggerEndpoint("/swagger/v1/swagger.json", "CoreBoilerplate");
                options.RoutePrefix = "swagger";
                options.DisplayRequestDuration();
            });
            return app;
        }
    }
}
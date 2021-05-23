using CoreBoilerplate.Application.Abstractions.DapperContexts;
using CoreBoilerplate.Application.Abstractions.EFContexts;
using CoreBoilerplate.Application.Exceptions;
using CoreBoilerplate.Infrastructure.Identity;
using CoreBoilerplate.Infrastructure.Persistence.DapperContexts;
using CoreBoilerplate.Infrastructure.Persistence.EFContexts;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CoreBoilerplate.Infrastructure.Persistence.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddPersistenceLayerServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(configuration.GetConnectionString(PersistenceConstants.DefaultConnectionName)));
            services.AddIdentity<ExtendedIdentityUser, IdentityRole>().AddEntityFrameworkStores<ApplicationDbContext>().AddDefaultTokenProviders();
            services.AddScoped<IApplicationDbContext>(provider => provider.GetService<ApplicationDbContext>() ?? throw new DBContextNullException());
            services.AddScoped<IDapperDbWriteContext, DapperDbWriteContext>();
            services.AddScoped<IDapperDbReadContext, DapperDbReadContext>();
            return services;
        }
    }
}
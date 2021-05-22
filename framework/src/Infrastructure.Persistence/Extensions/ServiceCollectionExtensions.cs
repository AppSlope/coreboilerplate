﻿using CoreBoilerplate.Application.Abstractions.DapperContexts;
using CoreBoilerplate.Application.Abstractions.EFContexts;
using CoreBoilerplate.Application.Exceptions;
using CoreBoilerplate.Infrastructure.Persistence.DapperContexts;
using CoreBoilerplate.Infrastructure.Persistence.EFContexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CoreBoilerplate.Infrastructure.Persistence.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddPersistence(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ApplicationDbContext>(options =>options.UseSqlServer(configuration.GetConnectionString(PersistenceConstants.DefaultConnectionName)));
            services.AddScoped<IApplicationDbContext>(provider => provider.GetService<ApplicationDbContext>() ?? throw new PersistenceException("Fetching DBContext Failed."));
            services.AddScoped<IDapperDbWriteContext, DapperDbWriteContext>();
            services.AddScoped<IDapperDbReadContext, DapperDbReadContext>();
            return services;
        }
    }
}
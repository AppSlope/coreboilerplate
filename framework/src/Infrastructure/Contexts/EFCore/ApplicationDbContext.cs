using CoreBoilerplate.Application.Abstractions.EFContexts;
using CoreBoilerplate.Infrastructure.Identity;
using CoreBoilerplate.Infrastructure.Extensions;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Data;
using System.Threading;
using System.Threading.Tasks;

namespace CoreBoilerplate.Infrastructure.Contexts.EFCore
{
    //Read details about this implmentation in the interface cs file.
    public class ApplicationDbContext : IdentityDbContext<ExtendedIdentityUser, ExtendedIdentityRole, int>, IApplicationDbContext
    {
        public IDbConnection Connection => Database.GetDbConnection();

        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            return base.SaveChangesAsync(cancellationToken);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);
            modelBuilder.ApplyIdentityConfiguration();
        }
    }
}
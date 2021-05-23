﻿using CoreBoilerplate.Infrastructure.Identity;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace CoreBoilerplate.Infrastructure.Extensions
{
    public static class ModelBuilderExtensions
    {
        public static void ApplyIdentityConfiguration(this ModelBuilder builder)
        {
            builder.Entity<ExtendedIdentityUser>(entity =>
            {
                entity.ToTable(name: "Users", "Identity");
            });

            builder.Entity<ExtendedIdentityRole>(entity =>
            {
                entity.ToTable(name: "Roles", "Identity");
            });
            builder.Entity<IdentityUserRole<int>>(entity =>
            {
                entity.ToTable("UserRoles", "Identity");
            });

            builder.Entity<IdentityUserClaim<int>>(entity =>
            {
                entity.ToTable("UserClaims", "Identity");
            });

            builder.Entity<IdentityUserLogin<int>>(entity =>
            {
                entity.ToTable("UserLogins", "Identity");
            });

            builder.Entity<IdentityRoleClaim<int>>(entity =>
            {
                entity.ToTable("RoleClaims", "Identity");
            });

            builder.Entity<IdentityUserToken<int>>(entity =>
            {
                entity.ToTable("UserTokens", "Identity");
            });
        }
    }
}
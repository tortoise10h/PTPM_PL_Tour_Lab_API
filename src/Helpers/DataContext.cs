using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.Http;
using src.Entities;
using src.Extensions;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using System.Threading.Tasks;
using System.Linq;
using System.Threading;
using System;

namespace src.Helpers
{
    public class DataContext : IdentityDbContext<ApplicationUser>
    {
        public DbSet<TourCategory> TourCategories { get; set; }
        public DbSet<Tour> Tours { get; set; }

        protected readonly IConfiguration Configuration;
        private readonly ICurrentUserService _currentUserService;

        public DataContext(DbContextOptions options, IConfiguration configuration)
            : base(options)
        {
            Configuration = configuration;
        }

        public DataContext()
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            // connect to database
            options.UseSqlServer(Configuration.GetConnectionString("TourismManagementDBConnection"));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ConfigDBTablesRelationship();

            // modelBuilder.ConfigTablesRequirements();

            // modelBuilder.Seed();
        }

        public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken())
        {
            AutoTrack();
            // foreach (Microsoft.EntityFrameworkCore.ChangeTracking.EntityEntry<BaseEntity> entry in ChangeTracker.Entries<BaseEntity>())
            // {
            //     switch (entry.State)
            //     {
            //         case EntityState.Added:
            //             entry.Entity.CreatedBy = _currentUserService.UserId;
            //             entry.Entity.CreatedAt = DateTime.Now;
            //             break;

            //         case EntityState.Modified:
            //             entry.Entity.LastModifiedBy = _currentUserService.UserId;
            //             entry.Entity.LastModifiedAt = DateTime.Now;
            //             break;
            //     }
            // }

            int result = await base.SaveChangesAsync();

            return result;
        }

        private void AutoTrack()
        {
            var entities = ChangeTracker.Entries().Where(x => x.Entity is BaseEntity && (x.State == EntityState.Added || x.State == EntityState.Modified));

            foreach (var entity in entities)
            {
                if (entity.State == EntityState.Added)
                {
                    ((BaseEntity)entity.Entity).CreatedAt = DateTime.UtcNow;
                    ((BaseEntity)entity.Entity).CreatedBy = null;
                }

                ((BaseEntity)entity.Entity).LastModifiedAt = DateTime.UtcNow;
                ((BaseEntity)entity.Entity).LastModifiedBy = null;
            }
        }
    }
}
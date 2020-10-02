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
        public DbSet<TouristAttraction> TouristAttraction { get; set; }

        protected readonly IConfiguration Configuration;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public DataContext(DbContextOptions options, IConfiguration configuration, IHttpContextAccessor httpContextAccessor)
            : base(options)
        {
            Configuration = configuration;
            _httpContextAccessor = httpContextAccessor;
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

            modelBuilder.ConfigTablesRequirements();

            modelBuilder.Seed();
        }

        public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken())
        {
            AutoTrack();
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
                    ((BaseEntity)entity.Entity).CreatedBy = _httpContextAccessor.HttpContext.User.Claims.Count() > 0
                        ? _httpContextAccessor.HttpContext.User.Claims.First(x => x.Type == "id").Value
                        : null;
                }

                ((BaseEntity)entity.Entity).LastModifiedAt = DateTime.UtcNow;
                ((BaseEntity)entity.Entity).LastModifiedBy = _httpContextAccessor.HttpContext.User.Claims.Count() > 0
                        ? _httpContextAccessor.HttpContext.User.Claims.First(x => x.Type == "id").Value
                        : null;
            }
        }
    }
}
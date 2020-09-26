using src.Entities;
using Microsoft.EntityFrameworkCore;

namespace src.Extensions
{
    public static class ModelBuilderExtensions
    {
        public static void ConfigDBTablesRelationship(this ModelBuilder modelBuilder)
        {
            /** [Tour] and [TourCategory] */
            modelBuilder.Entity<Tour>()
                .HasOne<TourCategory>(t => t.TourCategory)
                .WithMany(tc => tc.Tours)
                .HasForeignKey(t => t.TourCategoryId)
                .OnDelete(DeleteBehavior.NoAction);

            /** [Tour] and [TourPrice] */
            modelBuilder.Entity<TourPrice>()
                .HasOne<Tour>(t => t.Tour)
                .WithMany(tp => tp.TourPrices)
                .HasForeignKey(t => t.TourId)
                .OnDelete(DeleteBehavior.NoAction);

            /** [Tour] and [Group] */
            modelBuilder.Entity<Group>()
                .HasOne<Tour>(t => t.Tour)
                .WithMany(g => g.Groups)
                .HasForeignKey(t => t.TourId)
                .OnDelete(DeleteBehavior.NoAction);

            /** [Tour] and [TourDetail] */
            modelBuilder.Entity<TourDetail>()
                .HasOne<Tour>(t => t.Tour)
                .WithMany(td => td.TourDetails)
                .HasForeignKey(td => td.TourId)
                .OnDelete(DeleteBehavior.NoAction);

            /** [TouristAttraction] and [TourDetail] */
            modelBuilder.Entity<TourDetail>()
                .HasOne<TouristAttraction>(ta => ta.TouristAttraction)
                .WithMany(td => td.TourDetails)
                .HasForeignKey(td => td.TouristAttractionId)
                .OnDelete(DeleteBehavior.NoAction);

            /** [Group] and [GroupCost] */
            modelBuilder.Entity<Group>()
                .HasMany<GroupCost>(g => g.GroupCosts)
                .WithOne(gc => gc.Group)
                .HasForeignKey(gc => gc.GroupId)
                .OnDelete(DeleteBehavior.NoAction);

            /** [CostType] and [GroupCost] */
            modelBuilder.Entity<GroupCost>()
                .HasOne<CostType>(gc => gc.CostType)
                .WithMany(ct => ct.GroupCosts)
                .HasForeignKey(gc => gc.CostTypeId)
                .OnDelete(DeleteBehavior.NoAction);

            /** [Group] and [GroupDetail] */
            modelBuilder.Entity<GroupDetail>()
                .HasOne<Group>(gd => gd.Group)
                .WithMany(g => g.GroupDetails)
                .HasForeignKey(gd => gd.GroupId)
                .OnDelete(DeleteBehavior.NoAction);

            /** [Customer] and [GroupDetail] */
            modelBuilder.Entity<ApplicationUser>()
                .HasMany<GroupDetail>(au => au.GroupDetails)
                .WithOne(g => g.ApplicationUser)
                .HasForeignKey(gd => gd.UserId)
                .OnDelete(DeleteBehavior.NoAction);

            /** [Group] and [StaffGroupRole] */
            modelBuilder.Entity<Group>()
                .HasMany<StaffGroupRole>(g => g.StaffGroupRoles)
                .WithOne(sgr => sgr.Group)
                .HasForeignKey(sgr => sgr.GroupId)
                .OnDelete(DeleteBehavior.NoAction);

            /** [Staff] and [StaffGroupRole] */
            modelBuilder.Entity<ApplicationUser>()
                .HasMany<StaffGroupRole>(au => au.StaffGroupRoles)
                .WithOne(sgr => sgr.ApplicationUser)
                .HasForeignKey(sgr => sgr.StaffId)
                .OnDelete(DeleteBehavior.NoAction);

            /** [StaffGroupRole] and [GroupRole] */
            modelBuilder.Entity<GroupRole>()
                .HasMany<StaffGroupRole>(gr => gr.StaffGroupRoles)
                .WithOne(sgr => sgr.GroupRole)
                .HasForeignKey(gd => gd.GroupRoleId)
                .OnDelete(DeleteBehavior.NoAction);
        }

        public static void ConfigTablesRequirements(this ModelBuilder modelBuilder)
        {

        }

        public static void Seed(this ModelBuilder modelBuilder)
        {

        }
    }
}
using src.Entities;
using Microsoft.EntityFrameworkCore;
using src.Common.Enums;
using System;
using Microsoft.AspNetCore.Identity;

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
            /** Tour */
            modelBuilder.Entity<Tour>()
                .Property(t => t.Status)
                .HasDefaultValue(TourStatusEnum.Opening);
        }

        public static void Seed(this ModelBuilder modelBuilder)
        {
            /*------------------------------------
             |                                   |
             |       SEED USERS AND ROLES        |
             |                                   |
             |-----------------------------------| */
            string adminRoleId = Guid.NewGuid().ToString();
            string superAdminRoleId = Guid.NewGuid().ToString();

            string adminId = Guid.NewGuid().ToString();
            string superAdminId = Guid.NewGuid().ToString();

            modelBuilder.Entity<IdentityRole>()
                .HasData(
                    new IdentityRole
                    {
                        Id = adminRoleId,
                        Name = "Admin",
                        NormalizedName = "admin"
                    },
                    new IdentityRole
                    {
                        Id = superAdminRoleId,
                        Name = "SuperAdmin",
                        NormalizedName = "superadmin"
                    }
                );

            var hasher = new PasswordHasher<ApplicationUser>();
            modelBuilder.Entity<ApplicationUser>()
                .HasData(
                    new ApplicationUser
                    {
                        Id = superAdminId,
                        FirstName = "Super Admin",
                        LastName = "Lil",
                        UserName = "lilsuperadmin@gmail.com",
                        NormalizedUserName = "lilsuperadmin@gmail.com".ToUpper(),
                        Email = "lilsuperadmin@gmail.com",
                        NormalizedEmail = "lilsuperadmin@gmail.com".ToUpper(),
                        EmailConfirmed = true,
                        PasswordHash = hasher.HashPassword(null, "12345678"),
                        SecurityStamp = string.Empty
                    },
                    new ApplicationUser
                    {
                        Id = adminId,
                        FirstName = "Admin",
                        LastName = "Yung",
                        UserName = "yungadmin@gmail.com",
                        NormalizedUserName = "yungadmin@gmail.com".ToUpper(),
                        Email = "yungadmin@gmail.com",
                        NormalizedEmail = "yungadmin@gmail.com".ToUpper(),
                        EmailConfirmed = true,
                        PasswordHash = hasher.HashPassword(null, "12345678"),
                        SecurityStamp = string.Empty
                    });

            modelBuilder.Entity<IdentityUserRole<string>>()
                .HasData(
                    new IdentityUserRole<string>
                    {
                        RoleId = adminRoleId,
                        UserId = adminId
                    },
                    new IdentityUserRole<string>
                    {
                        RoleId = superAdminRoleId,
                        UserId = superAdminId
                    }
                );

            /*------------------------------------
             |                                   |
             |       SEED TOUR CATEGORIES        |
             |                                   |
             |-----------------------------------| */
            Guid tourCategory1Id = Guid.NewGuid();
            Guid tourCategory2Id = Guid.NewGuid();
            Guid tourCategory3Id = Guid.NewGuid();
            Guid tourCategory4Id = Guid.NewGuid();
            Guid tourCategory5Id = Guid.NewGuid();
            Guid tourCategory6Id = Guid.NewGuid();

            modelBuilder.Entity<TourCategory>()
                .HasData(
                    new TourCategory
                    {
                        Id = tourCategory1Id,
                        Name = "Du lịch tham quan",
                    },
                    new TourCategory
                    {
                        Id = tourCategory2Id,
                        Name = "Du lịch văn hóa",
                    },
                    new TourCategory
                    {
                        Id = tourCategory3Id,
                        Name = "Du lịch ẩm thực",
                    },
                    new TourCategory
                    {
                        Id = tourCategory4Id,
                        Name = "Du lịch xanh",
                    },
                    new TourCategory
                    {
                        Id = tourCategory5Id,
                        Name = "Du lịch MICE",
                    },
                    new TourCategory
                    {
                        Id = tourCategory6Id,
                        Name = "Teambuilding",
                    }
                );

            /*------------------------------------
             |                                   |
             |     SEED TOURIST ATTRACTIONS      |
             |                                   |
             |-----------------------------------| */
            Guid touristAttractionId1 = Guid.NewGuid();
            Guid touristAttractionId2 = Guid.NewGuid();
            Guid touristAttractionId3 = Guid.NewGuid();
            Guid touristAttractionId4 = Guid.NewGuid();
            Guid touristAttractionId5 = Guid.NewGuid();
            Guid touristAttractionId6 = Guid.NewGuid();
            Guid touristAttractionId7 = Guid.NewGuid();
            Guid touristAttractionId8 = Guid.NewGuid();
            Guid touristAttractionId9 = Guid.NewGuid();
            Guid touristAttractionId10 = Guid.NewGuid();
            Guid touristAttractionId11 = Guid.NewGuid();
            Guid touristAttractionId12 = Guid.NewGuid();
            Guid touristAttractionId13 = Guid.NewGuid();
            Guid touristAttractionId14 = Guid.NewGuid();
            Guid touristAttractionId15 = Guid.NewGuid();
            Guid touristAttractionId16 = Guid.NewGuid();


            modelBuilder.Entity<TouristAttraction>()
                .HasData(
                    new TouristAttraction
                    {
                        Id = touristAttractionId1,
                        Name = "TP. Hồ Chí Minh ",
                        Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aenean dui est, fringilla eu urna non, rhoncus tristique urna. Phasellus sed mauris eu metus sollicitudin gravida. Aliquam ut molestie orci. Suspendisse nec quam ut massa rutrum ullamcorper non eu elit. Nam ligula sapien, placerat nec ligula et, maximus sagittis est. Maecenas et ex nec nunc sagittis aliquam vitae vitae neque. Ut ut malesuada sapien, tincidunt auctor elit. Quisque volutpat urna at posuere maximus. Nunc felis lectus, bibendum ut quam id, porttitor vehicula turpis. Sed ac efficitur risus. Proin feugiat sit amet dui vel tempor.Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aenean dui est, fringilla eu urna non, rhoncus tristique urna. Phasellus sed mauris eu metus sollicitudin gravida. Aliquam ut molestie orci. Suspendisse nec quam ut massa rutrum ullamcorper non eu elit. Nam ligula sapien, placerat nec ligula et, maximus sagittis est. Maecenas et ex nec nunc sagittis aliquam vitae vitae neque. Ut ut malesuada sapien, tincidunt auctor elit. Quisque volutpat urna at posuere maximus. Nunc felis lectus, bibendum ut quam id, porttitor vehicula turpis. Sed ac efficitur risus. Proin feugiat sit amet dui vel tempor."
                    },
                    new TouristAttraction
                    {
                        Id = touristAttractionId2,
                        Name = "Hà Nội",
                        Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aenean dui est, fringilla eu urna non, rhoncus tristique urna. Phasellus sed mauris eu metus sollicitudin gravida. Aliquam ut molestie orci. Suspendisse nec quam ut massa rutrum ullamcorper non eu elit. Nam ligula sapien, placerat nec ligula et, maximus sagittis est. Maecenas et ex nec nunc sagittis aliquam vitae vitae neque. Ut ut malesuada sapien, tincidunt auctor elit. Quisque volutpat urna at posuere maximus. Nunc felis lectus, bibendum ut quam id, porttitor vehicula turpis. Sed ac efficitur risus. Proin feugiat sit amet dui vel tempor.Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aenean dui est, fringilla eu urna non, rhoncus tristique urna. Phasellus sed mauris eu metus sollicitudin gravida. Aliquam ut molestie orci. Suspendisse nec quam ut massa rutrum ullamcorper non eu elit. Nam ligula sapien, placerat nec ligula et, maximus sagittis est. Maecenas et ex nec nunc sagittis aliquam vitae vitae neque. Ut ut malesuada sapien, tincidunt auctor elit. Quisque volutpat urna at posuere maximus. Nunc felis lectus, bibendum ut quam id, porttitor vehicula turpis. Sed ac efficitur risus. Proin feugiat sit amet dui vel tempor."
                    },
                    new TouristAttraction
                    {
                        Id = touristAttractionId3,
                        Name = "Sapa",
                        Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aenean dui est, fringilla eu urna non, rhoncus tristique urna. Phasellus sed mauris eu metus sollicitudin gravida. Aliquam ut molestie orci. Suspendisse nec quam ut massa rutrum ullamcorper non eu elit. Nam ligula sapien, placerat nec ligula et, maximus sagittis est. Maecenas et ex nec nunc sagittis aliquam vitae vitae neque. Ut ut malesuada sapien, tincidunt auctor elit. Quisque volutpat urna at posuere maximus. Nunc felis lectus, bibendum ut quam id, porttitor vehicula turpis. Sed ac efficitur risus. Proin feugiat sit amet dui vel tempor.Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aenean dui est, fringilla eu urna non, rhoncus tristique urna. Phasellus sed mauris eu metus sollicitudin gravida. Aliquam ut molestie orci. Suspendisse nec quam ut massa rutrum ullamcorper non eu elit. Nam ligula sapien, placerat nec ligula et, maximus sagittis est. Maecenas et ex nec nunc sagittis aliquam vitae vitae neque. Ut ut malesuada sapien, tincidunt auctor elit. Quisque volutpat urna at posuere maximus. Nunc felis lectus, bibendum ut quam id, porttitor vehicula turpis. Sed ac efficitur risus. Proin feugiat sit amet dui vel tempor."
                    },
                    new TouristAttraction
                    {
                        Id = touristAttractionId4,
                        Name = "Ninh Bình",
                        Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aenean dui est, fringilla eu urna non, rhoncus tristique urna. Phasellus sed mauris eu metus sollicitudin gravida. Aliquam ut molestie orci. Suspendisse nec quam ut massa rutrum ullamcorper non eu elit. Nam ligula sapien, placerat nec ligula et, maximus sagittis est. Maecenas et ex nec nunc sagittis aliquam vitae vitae neque. Ut ut malesuada sapien, tincidunt auctor elit. Quisque volutpat urna at posuere maximus. Nunc felis lectus, bibendum ut quam id, porttitor vehicula turpis. Sed ac efficitur risus. Proin feugiat sit amet dui vel tempor.Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aenean dui est, fringilla eu urna non, rhoncus tristique urna. Phasellus sed mauris eu metus sollicitudin gravida. Aliquam ut molestie orci. Suspendisse nec quam ut massa rutrum ullamcorper non eu elit. Nam ligula sapien, placerat nec ligula et, maximus sagittis est. Maecenas et ex nec nunc sagittis aliquam vitae vitae neque. Ut ut malesuada sapien, tincidunt auctor elit. Quisque volutpat urna at posuere maximus. Nunc felis lectus, bibendum ut quam id, porttitor vehicula turpis. Sed ac efficitur risus. Proin feugiat sit amet dui vel tempor."
                    },
                    new TouristAttraction
                    {
                        Id = touristAttractionId5,
                        Name = "Đà Lạt",
                        Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aenean dui est, fringilla eu urna non, rhoncus tristique urna. Phasellus sed mauris eu metus sollicitudin gravida. Aliquam ut molestie orci. Suspendisse nec quam ut massa rutrum ullamcorper non eu elit. Nam ligula sapien, placerat nec ligula et, maximus sagittis est. Maecenas et ex nec nunc sagittis aliquam vitae vitae neque. Ut ut malesuada sapien, tincidunt auctor elit. Quisque volutpat urna at posuere maximus. Nunc felis lectus, bibendum ut quam id, porttitor vehicula turpis. Sed ac efficitur risus. Proin feugiat sit amet dui vel tempor.Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aenean dui est, fringilla eu urna non, rhoncus tristique urna. Phasellus sed mauris eu metus sollicitudin gravida. Aliquam ut molestie orci. Suspendisse nec quam ut massa rutrum ullamcorper non eu elit. Nam ligula sapien, placerat nec ligula et, maximus sagittis est. Maecenas et ex nec nunc sagittis aliquam vitae vitae neque. Ut ut malesuada sapien, tincidunt auctor elit. Quisque volutpat urna at posuere maximus. Nunc felis lectus, bibendum ut quam id, porttitor vehicula turpis. Sed ac efficitur risus. Proin feugiat sit amet dui vel tempor."
                    },
                    new TouristAttraction
                    {
                        Id = touristAttractionId6,
                        Name = "Nha Trang",
                        Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aenean dui est, fringilla eu urna non, rhoncus tristique urna. Phasellus sed mauris eu metus sollicitudin gravida. Aliquam ut molestie orci. Suspendisse nec quam ut massa rutrum ullamcorper non eu elit. Nam ligula sapien, placerat nec ligula et, maximus sagittis est. Maecenas et ex nec nunc sagittis aliquam vitae vitae neque. Ut ut malesuada sapien, tincidunt auctor elit. Quisque volutpat urna at posuere maximus. Nunc felis lectus, bibendum ut quam id, porttitor vehicula turpis. Sed ac efficitur risus. Proin feugiat sit amet dui vel tempor.Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aenean dui est, fringilla eu urna non, rhoncus tristique urna. Phasellus sed mauris eu metus sollicitudin gravida. Aliquam ut molestie orci. Suspendisse nec quam ut massa rutrum ullamcorper non eu elit. Nam ligula sapien, placerat nec ligula et, maximus sagittis est. Maecenas et ex nec nunc sagittis aliquam vitae vitae neque. Ut ut malesuada sapien, tincidunt auctor elit. Quisque volutpat urna at posuere maximus. Nunc felis lectus, bibendum ut quam id, porttitor vehicula turpis. Sed ac efficitur risus. Proin feugiat sit amet dui vel tempor."
                    },
                    new TouristAttraction
                    {
                        Id = touristAttractionId7,
                        Name = "Tây Nguyên",
                        Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aenean dui est, fringilla eu urna non, rhoncus tristique urna. Phasellus sed mauris eu metus sollicitudin gravida. Aliquam ut molestie orci. Suspendisse nec quam ut massa rutrum ullamcorper non eu elit. Nam ligula sapien, placerat nec ligula et, maximus sagittis est. Maecenas et ex nec nunc sagittis aliquam vitae vitae neque. Ut ut malesuada sapien, tincidunt auctor elit. Quisque volutpat urna at posuere maximus. Nunc felis lectus, bibendum ut quam id, porttitor vehicula turpis. Sed ac efficitur risus. Proin feugiat sit amet dui vel tempor.Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aenean dui est, fringilla eu urna non, rhoncus tristique urna. Phasellus sed mauris eu metus sollicitudin gravida. Aliquam ut molestie orci. Suspendisse nec quam ut massa rutrum ullamcorper non eu elit. Nam ligula sapien, placerat nec ligula et, maximus sagittis est. Maecenas et ex nec nunc sagittis aliquam vitae vitae neque. Ut ut malesuada sapien, tincidunt auctor elit. Quisque volutpat urna at posuere maximus. Nunc felis lectus, bibendum ut quam id, porttitor vehicula turpis. Sed ac efficitur risus. Proin feugiat sit amet dui vel tempor."
                    },
                    new TouristAttraction
                    {
                        Id = touristAttractionId8,
                        Name = "Đông Bắc",
                        Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aenean dui est, fringilla eu urna non, rhoncus tristique urna. Phasellus sed mauris eu metus sollicitudin gravida. Aliquam ut molestie orci. Suspendisse nec quam ut massa rutrum ullamcorper non eu elit. Nam ligula sapien, placerat nec ligula et, maximus sagittis est. Maecenas et ex nec nunc sagittis aliquam vitae vitae neque. Ut ut malesuada sapien, tincidunt auctor elit. Quisque volutpat urna at posuere maximus. Nunc felis lectus, bibendum ut quam id, porttitor vehicula turpis. Sed ac efficitur risus. Proin feugiat sit amet dui vel tempor.Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aenean dui est, fringilla eu urna non, rhoncus tristique urna. Phasellus sed mauris eu metus sollicitudin gravida. Aliquam ut molestie orci. Suspendisse nec quam ut massa rutrum ullamcorper non eu elit. Nam ligula sapien, placerat nec ligula et, maximus sagittis est. Maecenas et ex nec nunc sagittis aliquam vitae vitae neque. Ut ut malesuada sapien, tincidunt auctor elit. Quisque volutpat urna at posuere maximus. Nunc felis lectus, bibendum ut quam id, porttitor vehicula turpis. Sed ac efficitur risus. Proin feugiat sit amet dui vel tempor."
                    },
                    new TouristAttraction
                    {
                        Id = touristAttractionId9,
                        Name = "Miền Tây",
                        Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aenean dui est, fringilla eu urna non, rhoncus tristique urna. Phasellus sed mauris eu metus sollicitudin gravida. Aliquam ut molestie orci. Suspendisse nec quam ut massa rutrum ullamcorper non eu elit. Nam ligula sapien, placerat nec ligula et, maximus sagittis est. Maecenas et ex nec nunc sagittis aliquam vitae vitae neque. Ut ut malesuada sapien, tincidunt auctor elit. Quisque volutpat urna at posuere maximus. Nunc felis lectus, bibendum ut quam id, porttitor vehicula turpis. Sed ac efficitur risus. Proin feugiat sit amet dui vel tempor.Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aenean dui est, fringilla eu urna non, rhoncus tristique urna. Phasellus sed mauris eu metus sollicitudin gravida. Aliquam ut molestie orci. Suspendisse nec quam ut massa rutrum ullamcorper non eu elit. Nam ligula sapien, placerat nec ligula et, maximus sagittis est. Maecenas et ex nec nunc sagittis aliquam vitae vitae neque. Ut ut malesuada sapien, tincidunt auctor elit. Quisque volutpat urna at posuere maximus. Nunc felis lectus, bibendum ut quam id, porttitor vehicula turpis. Sed ac efficitur risus. Proin feugiat sit amet dui vel tempor."
                    },
                    new TouristAttraction
                    {
                        Id = touristAttractionId10,
                        Name = "ĐBSCL",
                        Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aenean dui est, fringilla eu urna non, rhoncus tristique urna. Phasellus sed mauris eu metus sollicitudin gravida. Aliquam ut molestie orci. Suspendisse nec quam ut massa rutrum ullamcorper non eu elit. Nam ligula sapien, placerat nec ligula et, maximus sagittis est. Maecenas et ex nec nunc sagittis aliquam vitae vitae neque. Ut ut malesuada sapien, tincidunt auctor elit. Quisque volutpat urna at posuere maximus. Nunc felis lectus, bibendum ut quam id, porttitor vehicula turpis. Sed ac efficitur risus. Proin feugiat sit amet dui vel tempor.Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aenean dui est, fringilla eu urna non, rhoncus tristique urna. Phasellus sed mauris eu metus sollicitudin gravida. Aliquam ut molestie orci. Suspendisse nec quam ut massa rutrum ullamcorper non eu elit. Nam ligula sapien, placerat nec ligula et, maximus sagittis est. Maecenas et ex nec nunc sagittis aliquam vitae vitae neque. Ut ut malesuada sapien, tincidunt auctor elit. Quisque volutpat urna at posuere maximus. Nunc felis lectus, bibendum ut quam id, porttitor vehicula turpis. Sed ac efficitur risus. Proin feugiat sit amet dui vel tempor."
                    },
                    new TouristAttraction
                    {
                        Id = touristAttractionId11,
                        Name = "Phan Thiết",
                        Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aenean dui est, fringilla eu urna non, rhoncus tristique urna. Phasellus sed mauris eu metus sollicitudin gravida. Aliquam ut molestie orci. Suspendisse nec quam ut massa rutrum ullamcorper non eu elit. Nam ligula sapien, placerat nec ligula et, maximus sagittis est. Maecenas et ex nec nunc sagittis aliquam vitae vitae neque. Ut ut malesuada sapien, tincidunt auctor elit. Quisque volutpat urna at posuere maximus. Nunc felis lectus, bibendum ut quam id, porttitor vehicula turpis. Sed ac efficitur risus. Proin feugiat sit amet dui vel tempor.Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aenean dui est, fringilla eu urna non, rhoncus tristique urna. Phasellus sed mauris eu metus sollicitudin gravida. Aliquam ut molestie orci. Suspendisse nec quam ut massa rutrum ullamcorper non eu elit. Nam ligula sapien, placerat nec ligula et, maximus sagittis est. Maecenas et ex nec nunc sagittis aliquam vitae vitae neque. Ut ut malesuada sapien, tincidunt auctor elit. Quisque volutpat urna at posuere maximus. Nunc felis lectus, bibendum ut quam id, porttitor vehicula turpis. Sed ac efficitur risus. Proin feugiat sit amet dui vel tempor."
                    },
                    new TouristAttraction
                    {
                        Id = touristAttractionId12,
                        Name = "Hạ Long",
                        Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aenean dui est, fringilla eu urna non, rhoncus tristique urna. Phasellus sed mauris eu metus sollicitudin gravida. Aliquam ut molestie orci. Suspendisse nec quam ut massa rutrum ullamcorper non eu elit. Nam ligula sapien, placerat nec ligula et, maximus sagittis est. Maecenas et ex nec nunc sagittis aliquam vitae vitae neque. Ut ut malesuada sapien, tincidunt auctor elit. Quisque volutpat urna at posuere maximus. Nunc felis lectus, bibendum ut quam id, porttitor vehicula turpis. Sed ac efficitur risus. Proin feugiat sit amet dui vel tempor.Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aenean dui est, fringilla eu urna non, rhoncus tristique urna. Phasellus sed mauris eu metus sollicitudin gravida. Aliquam ut molestie orci. Suspendisse nec quam ut massa rutrum ullamcorper non eu elit. Nam ligula sapien, placerat nec ligula et, maximus sagittis est. Maecenas et ex nec nunc sagittis aliquam vitae vitae neque. Ut ut malesuada sapien, tincidunt auctor elit. Quisque volutpat urna at posuere maximus. Nunc felis lectus, bibendum ut quam id, porttitor vehicula turpis. Sed ac efficitur risus. Proin feugiat sit amet dui vel tempor."
                    },
                    new TouristAttraction
                    {
                        Id = touristAttractionId13,
                        Name = "Hồ Tràm",
                        Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aenean dui est, fringilla eu urna non, rhoncus tristique urna. Phasellus sed mauris eu metus sollicitudin gravida. Aliquam ut molestie orci. Suspendisse nec quam ut massa rutrum ullamcorper non eu elit. Nam ligula sapien, placerat nec ligula et, maximus sagittis est. Maecenas et ex nec nunc sagittis aliquam vitae vitae neque. Ut ut malesuada sapien, tincidunt auctor elit. Quisque volutpat urna at posuere maximus. Nunc felis lectus, bibendum ut quam id, porttitor vehicula turpis. Sed ac efficitur risus. Proin feugiat sit amet dui vel tempor.Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aenean dui est, fringilla eu urna non, rhoncus tristique urna. Phasellus sed mauris eu metus sollicitudin gravida. Aliquam ut molestie orci. Suspendisse nec quam ut massa rutrum ullamcorper non eu elit. Nam ligula sapien, placerat nec ligula et, maximus sagittis est. Maecenas et ex nec nunc sagittis aliquam vitae vitae neque. Ut ut malesuada sapien, tincidunt auctor elit. Quisque volutpat urna at posuere maximus. Nunc felis lectus, bibendum ut quam id, porttitor vehicula turpis. Sed ac efficitur risus. Proin feugiat sit amet dui vel tempor."
                    },
                    new TouristAttraction
                    {
                        Id = touristAttractionId14,
                        Name = "Phú Quốc",
                        Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aenean dui est, fringilla eu urna non, rhoncus tristique urna. Phasellus sed mauris eu metus sollicitudin gravida. Aliquam ut molestie orci. Suspendisse nec quam ut massa rutrum ullamcorper non eu elit. Nam ligula sapien, placerat nec ligula et, maximus sagittis est. Maecenas et ex nec nunc sagittis aliquam vitae vitae neque. Ut ut malesuada sapien, tincidunt auctor elit. Quisque volutpat urna at posuere maximus. Nunc felis lectus, bibendum ut quam id, porttitor vehicula turpis. Sed ac efficitur risus. Proin feugiat sit amet dui vel tempor.Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aenean dui est, fringilla eu urna non, rhoncus tristique urna. Phasellus sed mauris eu metus sollicitudin gravida. Aliquam ut molestie orci. Suspendisse nec quam ut massa rutrum ullamcorper non eu elit. Nam ligula sapien, placerat nec ligula et, maximus sagittis est. Maecenas et ex nec nunc sagittis aliquam vitae vitae neque. Ut ut malesuada sapien, tincidunt auctor elit. Quisque volutpat urna at posuere maximus. Nunc felis lectus, bibendum ut quam id, porttitor vehicula turpis. Sed ac efficitur risus. Proin feugiat sit amet dui vel tempor."
                    },
                    new TouristAttraction
                    {
                        Id = touristAttractionId15,
                        Name = "Đắk Nông",
                        Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aenean dui est, fringilla eu urna non, rhoncus tristique urna. Phasellus sed mauris eu metus sollicitudin gravida. Aliquam ut molestie orci. Suspendisse nec quam ut massa rutrum ullamcorper non eu elit. Nam ligula sapien, placerat nec ligula et, maximus sagittis est. Maecenas et ex nec nunc sagittis aliquam vitae vitae neque. Ut ut malesuada sapien, tincidunt auctor elit. Quisque volutpat urna at posuere maximus. Nunc felis lectus, bibendum ut quam id, porttitor vehicula turpis. Sed ac efficitur risus. Proin feugiat sit amet dui vel tempor.Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aenean dui est, fringilla eu urna non, rhoncus tristique urna. Phasellus sed mauris eu metus sollicitudin gravida. Aliquam ut molestie orci. Suspendisse nec quam ut massa rutrum ullamcorper non eu elit. Nam ligula sapien, placerat nec ligula et, maximus sagittis est. Maecenas et ex nec nunc sagittis aliquam vitae vitae neque. Ut ut malesuada sapien, tincidunt auctor elit. Quisque volutpat urna at posuere maximus. Nunc felis lectus, bibendum ut quam id, porttitor vehicula turpis. Sed ac efficitur risus. Proin feugiat sit amet dui vel tempor."
                    },
                    new TouristAttraction
                    {
                        Id = touristAttractionId16,
                        Name = "Tây Ninh",
                        Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aenean dui est, fringilla eu urna non, rhoncus tristique urna. Phasellus sed mauris eu metus sollicitudin gravida. Aliquam ut molestie orci. Suspendisse nec quam ut massa rutrum ullamcorper non eu elit. Nam ligula sapien, placerat nec ligula et, maximus sagittis est. Maecenas et ex nec nunc sagittis aliquam vitae vitae neque. Ut ut malesuada sapien, tincidunt auctor elit. Quisque volutpat urna at posuere maximus. Nunc felis lectus, bibendum ut quam id, porttitor vehicula turpis. Sed ac efficitur risus. Proin feugiat sit amet dui vel tempor.Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aenean dui est, fringilla eu urna non, rhoncus tristique urna. Phasellus sed mauris eu metus sollicitudin gravida. Aliquam ut molestie orci. Suspendisse nec quam ut massa rutrum ullamcorper non eu elit. Nam ligula sapien, placerat nec ligula et, maximus sagittis est. Maecenas et ex nec nunc sagittis aliquam vitae vitae neque. Ut ut malesuada sapien, tincidunt auctor elit. Quisque volutpat urna at posuere maximus. Nunc felis lectus, bibendum ut quam id, porttitor vehicula turpis. Sed ac efficitur risus. Proin feugiat sit amet dui vel tempor."
                    }
                );

            /*------------------------------------
             |                                   |
             |           SEED TOURS              |
             |                                   |
             |-----------------------------------| */

            Guid tourId1 = Guid.NewGuid();
            Guid tourId2 = Guid.NewGuid();
            Guid tourId3 = Guid.NewGuid();
            Guid tourId4 = Guid.NewGuid();
            Guid tourId5 = Guid.NewGuid();
            Guid tourId6 = Guid.NewGuid();
            Guid tourId7 = Guid.NewGuid();
            Guid tourId8 = Guid.NewGuid();
            Guid tourId9 = Guid.NewGuid();
            Guid tourId10 = Guid.NewGuid();
            Guid tourId11 = Guid.NewGuid();
            Guid tourId12 = Guid.NewGuid();
            Guid tourId13 = Guid.NewGuid();
            Guid tourId14 = Guid.NewGuid();
            Guid tourId15 = Guid.NewGuid();
            Guid tourId16 = Guid.NewGuid();
            Guid tourId17 = Guid.NewGuid();
            Guid tourId18 = Guid.NewGuid();
            Guid tourId19 = Guid.NewGuid();
            Guid tourId20 = Guid.NewGuid();

            modelBuilder.Entity<Tour>()
                .HasData(
                    new Tour
                    {
                        Id = tourId1,
                        Name = "Du lịch Hải Phòng - Hạ Long - Ninh Bình - Hà Nội - Lào Cai - Sapa - Đền Hùng",
                        Price = 8029000,
                        Status = TourStatusEnum.Opening,
                        Specification = "Thời gian: 6 ngày 5 đêm Phương tiện: Hàng không Vietnam Airlines Thăm quần thể di tích Bạch Đằng Giang với đền thờ các vị anh...A",
                        TourCategoryId = tourCategory1Id,
                    },
                    new Tour
                    {
                        Id = tourId2,
                        Name = "Du lịch Nha Trang - Đà Lạt",
                        Price = 4279000,
                        Status = TourStatusEnum.Opening,
                        Specification = "Thời gian: 5 ngày 4 đêm Phương tiện: Đi về bằng xeVân hay còn gọi là Chùa Ốc, ngôi chùa làm...",
                        TourCategoryId = tourCategory1Id,
                    },
                    new Tour
                    {
                        Id = tourId3,
                        Name = "Du lịch Buôn Ma Thuột - Buôn Đôn - Pleiku - Komtum",
                        Price = 4879000,
                        Status = TourStatusEnum.Opening,
                        Specification = "Thời gian: 5 ngày 4 đêm Phương tiện: Đi về bằng xeay Nur hùng vĩ.\n Tham quan cầu treo và ngắm...",
                        TourCategoryId = tourCategory1Id,
                    },
                    new Tour
                    {
                        Id = tourId4,
                        Name = "Du lịch [Mùa Hoa Tam Giác Mạch] Hà Giang - Đồng Văn - Cao Bằng - Thác Bản Giốc- Lạng Sơn",
                        Price = 7529000,
                        Status = TourStatusEnum.Opening,
                        Specification = "Thời gian: 5 ngày 4 đêm Phương tiện: Hàng không Vietnam Airlines Thanh  ngắm núi Tô Thị Vượt đèo Mã...",
                        TourCategoryId = tourCategory1Id,
                    },
                    new Tour
                    {
                        Id = tourId5,
                        Name = "Du lịch Nha Trang - Hòn Lao - Dốc Lết - I Resort - Làng Yến Mai Sinh",
                        Price = 2979000,
                        Status = TourStatusEnum.Opening,
                        Specification = "Thời gian: 4 ngày 3 đêm Phương tiện: Đi về bằng xeịch Hòn Lao  đảo Khỉ, khu du lịch sinh...",
                        TourCategoryId = tourCategory1Id,
                    },
                    new Tour
                    {
                        Id = tourId6,
                        Name = "Du lịch Đà Lạt - Dambri - Đường Hầm Điêu Khắc - Langbiang",
                        Price = 3079000,
                        Status = TourStatusEnum.Opening,
                        Specification = "Thời gian: 4 ngày 3 đêm Phương tiện: Đi về bằng xeường Lâm Viên với không gian rộng lớn, thoáng mát hướng...",
                        TourCategoryId = tourCategory2Id,
                    },
                    new Tour
                    {
                        Id = tourId7,
                        Name = "Du lịch khám phá Cái Bè - Cần Thơ - Châu Đốc - Hà Tiên",
                        Price = 3679000,
                        Status = TourStatusEnum.Opening,
                        Specification = "Thời gian: 4 ngày 3 đêm Phương tiện: Đi về bằng xeNam bộ hơn trăm năm tuổi, theo lối kiến trúc...",
                        TourCategoryId = tourCategory2Id,
                    },
                    new Tour
                    {
                        Id = tourId8,
                        Name = "Du lịch Phan Thiết - Mũi Né - Lâu Đài Rượu Vang",
                        Price = 2739000,
                        Status = TourStatusEnum.Opening,
                        Specification = "Thời gian: 3 ngày 2 đêm Phương tiện: Đi về bằng xean trưng bày nghệ thuật “Làng chài xưa”\n Chụp hình...",
                        TourCategoryId = tourCategory2Id,
                    },
                    new Tour
                    {
                        Id = tourId9,
                        Name = "Du lịch Hà Nội - Lào Cai - Sapa - Hạ Long",
                        Price = 7129000,
                        Status = TourStatusEnum.Opening,
                        Specification = "Thời gian: 5 ngày 4 đêm Phương tiện: Hàng không Vietnam Airlinesn Cát Cát, ngắm toàn bộ cảnh Sapa từ Sân Mây\n...",
                        TourCategoryId = tourCategory2Id,
                    },
                    new Tour
                    {
                        Id = tourId10,
                        Name = "Du lịch Mỹ Tho - Cần Thơ - Cà Mau - Bạc Liêu - Sóc Trăng",
                        Price = 3879000,
                        Status = TourStatusEnum.Opening,
                        Specification = "Thời gian: 4 ngày 3 đêm Phương tiện: Đi về bằng xethức trái cây theo mùa, nghe nhạc tài tử Nam...",
                        TourCategoryId = tourCategory2Id,
                    },
                    new Tour
                    {
                        Id = tourId11,
                        Name = "Du lịch [mùa nước nổi] Cầu Cao Lãnh - Châu Đốc - Làng Cá Bè  - Rừng Tràm Trà Sư",
                        Price = 1979000,
                        Status = TourStatusEnum.Opening,
                        Specification = "Thời gian: 2 ngày 1 đêm Phương tiện: Đi về bằng xe Xứ nổi tiếng hiển linh.\n Tham quan Rừng Tràm...",
                        TourCategoryId = tourCategory3Id,
                    },
                    new Tour
                    {
                        Id = tourId12,
                        Name = "Du lịch Phan Thiết - Mũi Né - Làng Chài Xưa",
                        Price = 2379000,
                        Status = TourStatusEnum.Opening,
                        Specification = "Thời gian: 3 ngày 2 đêm Phương tiện: Đi về bằng xevàng dưới tác động của gió biển đã tạo nên...",
                        TourCategoryId = tourCategory3Id,
                    },
                    new Tour
                    {
                        Id = tourId13,
                        Name = "Du lịch Hồ Tràm - Trải nghiệm đẳng cấp 5 sao The Grand Ho Tram Strip",
                        Price = 2379000,
                        Status = TourStatusEnum.Opening,
                        Specification = "Thời gian: 2 ngày 1 đêm Phương tiện: Đi về bằng xeụ 5 sao cao cấp tại The Grand Ho Tram Strip...",
                        TourCategoryId = tourCategory3Id,
                    },
                    new Tour
                    {
                        Id = tourId14,
                        Name = "Du lịch Đà Lạt - Thác Datanla - Đồi Chè Cầu Đất -Trang Trại Rau & Hoa - Thác Dambri",
                        Price = 3079000,
                        Status = TourStatusEnum.Opening,
                        Specification = "Thời gian: 4 ngày 3 đêm Phương tiện: Đi về bằng xebri  ngọn thác hùng vĩ tại cao nguyên Bảo Lộc...",
                        TourCategoryId = tourCategory3Id,
                    },
                    new Tour
                    {
                        Id = tourId15,
                        Name = "Du lịch [Mùa Hoa Tam Giác Mạch] tại Hà Giang - Đồng Văn - Cao Bằng - Thác Bản Giốc - Pác Pó - Ba Bể",
                        Price = 9079000,
                        Status = TourStatusEnum.Opening,
                        Specification = "Thời gian: 6 ngày 5 đêm Phương tiện: Hàng không Vietnam Airlines Đồng Văn  Công viên địa chất toàn cầu....",
                        TourCategoryId = tourCategory3Id,
                    },
                    new Tour
                    {
                        Id = tourId16,
                        Name = "Du lịch Phú Quốc [Suối Tranh - Tặng Vé Cáp Treo Vượt Biển & Công Viên Nước  Hòn Thơm]",
                        Price = 3879000,
                        Status = TourStatusEnum.Opening,
                        Specification = "Thời gian: 3 ngày 2 đêm Phương tiện: Hàng không Vietnam Airlinesnh  quý khách có thể đi dạo trong rừng, thư...",
                        TourCategoryId = tourCategory4Id,
                    },
                    new Tour
                    {
                        Id = tourId17,
                        Name = "Du lịch Đà Lạt - Hồ Tuyền Lâm - Đường Hầm Điêu Khắc",
                        Price = 2379000,
                        Status = TourStatusEnum.Opening,
                        Specification = "Thời gian: 3 ngày 2 đêm Phương tiện: Đi về bằng xem điêu khắc đất đỏ (Đà Lạt Star)  tái hiện...",
                        TourCategoryId = tourCategory4Id,
                    },
                    new Tour
                    {
                        Id = tourId18,
                        Name = "Du lịch Bảo Lộc - Hồ Tà Đùng - Đắk Nông - Khu Bảo Tồn Thiên Nhiên Nậm Nung",
                        Price = 2679000,
                        Status = TourStatusEnum.Opening,
                        Specification = "Thời gian: 3 ngày 2 đêm Phương tiện: Đi về bằng xesản xuất trà và đồi chè Tâm Châu.\n Dừng...",
                        TourCategoryId = tourCategory4Id,
                    },
                    new Tour
                    {
                        Id = tourId19,
                        Name = "Du lịch Tây Ninh - Tòa Thánh Tây Ninh - Núi Bà Đen - Hồ Dầu Tiếng",
                        Price = 1879000,
                        Status = TourStatusEnum.Opening,
                        Specification = "Thời gian: 2 ngày 1 đêm Phương tiện: Đi về bằng xeĐen ngon núi cao nhất Đông Nam Bộ&nbsp; chỉ mất...",
                        TourCategoryId = tourCategory4Id,
                    },
                    new Tour
                    {
                        Id = tourId20,
                        Name = "Du lịch [Mùa nước nổi] Cao Lãnh - Tràm Chim Tam Nông - Khu Du Lịch Đồng Sen",
                        Price = 1779000,
                        Status = TourStatusEnum.Opening,
                        Specification = "Thời gian: 2 ngày 1 đêm Viếng Khu Di tích Cụ Nguyễn Sinh Sắc (nhà sàn Bác Hồ, khu Lăng...",
                        TourCategoryId = tourCategory4Id,
                    }
                );

            /*------------------------------------
             |                                   |
             |        SEED TOUR DETAILS          |
             |                                   |
             |-----------------------------------| */
            modelBuilder.Entity<TourDetail>()
               .HasData(
                    new TourDetail
                    {
                        Id = Guid.NewGuid(),
                        TourId = tourId1,
                        TouristAttractionId = touristAttractionId1,
                    },
                    new TourDetail
                    {
                        Id = Guid.NewGuid(),
                        TourId = tourId1,
                        TouristAttractionId = touristAttractionId2,
                    },
                    new TourDetail
                    {
                        Id = Guid.NewGuid(),
                        TourId = tourId1,
                        TouristAttractionId = touristAttractionId3,
                    },
                    new TourDetail
                    {
                        Id = Guid.NewGuid(),
                        TourId = tourId1,
                        TouristAttractionId = touristAttractionId4
                    },
                    new TourDetail
                    {
                        Id = Guid.NewGuid(),
                        TourId = tourId2,
                        TouristAttractionId = touristAttractionId1,
                    },
                    new TourDetail
                    {
                        Id = Guid.NewGuid(),
                        TourId = tourId2,
                        TouristAttractionId = touristAttractionId5,
                    },
                    new TourDetail
                    {
                        Id = Guid.NewGuid(),
                        TourId = tourId2,
                        TouristAttractionId = touristAttractionId6
                    },
                    new TourDetail
                    {
                        Id = Guid.NewGuid(),
                        TourId = tourId3,
                        TouristAttractionId = touristAttractionId1,
                    },
                    new TourDetail
                    {
                        Id = Guid.NewGuid(),
                        TourId = tourId3,
                        TouristAttractionId = touristAttractionId7
                    },
                    new TourDetail
                    {
                        Id = Guid.NewGuid(),
                        TourId = tourId4,
                        TouristAttractionId = touristAttractionId1,
                    },
                    new TourDetail
                    {
                        Id = Guid.NewGuid(),
                        TourId = tourId4,
                        TouristAttractionId = touristAttractionId8
                    },
                    new TourDetail
                    {
                        Id = Guid.NewGuid(),
                        TourId = tourId5,
                        TouristAttractionId = touristAttractionId1,
                    },
                    new TourDetail
                    {
                        Id = Guid.NewGuid(),
                        TourId = tourId5,
                        TouristAttractionId = touristAttractionId6
                    },
                    new TourDetail
                    {
                        Id = Guid.NewGuid(),
                        TourId = tourId6,
                        TouristAttractionId = touristAttractionId1,
                    },
                    new TourDetail
                    {
                        Id = Guid.NewGuid(),
                        TourId = tourId6,
                        TouristAttractionId = touristAttractionId5
                    },
                    new TourDetail
                    {
                        Id = Guid.NewGuid(),
                        TourId = tourId7,
                        TouristAttractionId = touristAttractionId1,
                    },
                    new TourDetail
                    {
                        Id = Guid.NewGuid(),
                        TourId = tourId7,
                        TouristAttractionId = touristAttractionId9,
                    },
                    new TourDetail
                    {
                        Id = Guid.NewGuid(),
                        TourId = tourId7,
                        TouristAttractionId = touristAttractionId10
                    },
                    new TourDetail
                    {
                        Id = Guid.NewGuid(),
                        TourId = tourId8,
                        TouristAttractionId = touristAttractionId1,
                    },
                    new TourDetail
                    {
                        Id = Guid.NewGuid(),
                        TourId = tourId8,
                        TouristAttractionId = touristAttractionId11
                    },
                    new TourDetail
                    {
                        Id = Guid.NewGuid(),
                        TourId = tourId9,
                        TouristAttractionId = touristAttractionId1,
                    },
                    new TourDetail
                    {
                        Id = Guid.NewGuid(),
                        TourId = tourId9,
                        TouristAttractionId = touristAttractionId2,
                    },
                    new TourDetail
                    {
                        Id = Guid.NewGuid(),
                        TourId = tourId9,
                        TouristAttractionId = touristAttractionId12,
                    },
                    new TourDetail
                    {
                        Id = Guid.NewGuid(),
                        TourId = tourId9,
                        TouristAttractionId = touristAttractionId3
                    },
                    new TourDetail
                    {
                        Id = Guid.NewGuid(),
                        TourId = tourId10,
                        TouristAttractionId = touristAttractionId1,
                    },
                    new TourDetail
                    {
                        Id = Guid.NewGuid(),
                        TourId = tourId10,
                        TouristAttractionId = touristAttractionId9,
                    },
                    new TourDetail
                    {
                        Id = Guid.NewGuid(),
                        TourId = tourId10,
                        TouristAttractionId = touristAttractionId10,
                    },
                    new TourDetail
                    {
                        Id = Guid.NewGuid(),
                        TourId = tourId11,
                        TouristAttractionId = touristAttractionId1,
                    },
                    new TourDetail
                    {
                        Id = Guid.NewGuid(),
                        TourId = tourId11,
                        TouristAttractionId = touristAttractionId9,
                    },
                    new TourDetail
                    {
                        Id = Guid.NewGuid(),
                        TourId = tourId11,
                        TouristAttractionId = touristAttractionId10
                    },
                    new TourDetail
                    {
                        Id = Guid.NewGuid(),
                        TourId = tourId12,
                        TouristAttractionId = touristAttractionId1,
                    },
                    new TourDetail
                    {
                        Id = Guid.NewGuid(),
                        TourId = tourId12,
                        TouristAttractionId = touristAttractionId11
                    },
                    new TourDetail
                    {
                        Id = Guid.NewGuid(),
                        TourId = tourId13,
                        TouristAttractionId = touristAttractionId1,
                    },
                    new TourDetail
                    {
                        Id = Guid.NewGuid(),
                        TourId = tourId13,
                        TouristAttractionId = touristAttractionId13
                    },
                    new TourDetail
                    {
                        Id = Guid.NewGuid(),
                        TourId = tourId14,
                        TouristAttractionId = touristAttractionId1,
                    },
                    new TourDetail
                    {
                        Id = Guid.NewGuid(),
                        TourId = tourId14,
                        TouristAttractionId = touristAttractionId5
                    },
                    new TourDetail
                    {
                        Id = Guid.NewGuid(),
                        TourId = tourId15,
                        TouristAttractionId = touristAttractionId1,
                    },
                    new TourDetail
                    {
                        Id = Guid.NewGuid(),
                        TourId = tourId15,
                        TouristAttractionId = touristAttractionId8
                    },
                    new TourDetail
                    {
                        Id = Guid.NewGuid(),
                        TourId = tourId16,
                        TouristAttractionId = touristAttractionId1,
                    },
                    new TourDetail
                    {
                        Id = Guid.NewGuid(),
                        TourId = tourId16,
                        TouristAttractionId = touristAttractionId14
                    },
                    new TourDetail
                    {
                        Id = Guid.NewGuid(),
                        TourId = tourId17,
                        TouristAttractionId = touristAttractionId1,
                    },
                    new TourDetail
                    {
                        Id = Guid.NewGuid(),
                        TourId = tourId17,
                        TouristAttractionId = touristAttractionId5
                    },
                    new TourDetail
                    {
                        Id = Guid.NewGuid(),
                        TourId = tourId18,
                        TouristAttractionId = touristAttractionId1,
                    },
                    new TourDetail
                    {
                        Id = Guid.NewGuid(),
                        TourId = tourId18,
                        TouristAttractionId = touristAttractionId15
                    },
                    new TourDetail
                    {
                        Id = Guid.NewGuid(),
                        TourId = tourId19,
                        TouristAttractionId = touristAttractionId1,
                    },
                    new TourDetail
                    {
                        Id = Guid.NewGuid(),
                        TourId = tourId19,
                        TouristAttractionId = touristAttractionId16
                    },
                    new TourDetail
                    {
                        Id = Guid.NewGuid(),
                        TourId = tourId20,
                        TouristAttractionId = touristAttractionId1,
                    },
                    new TourDetail
                    {
                        Id = Guid.NewGuid(),
                        TourId = tourId20,
                        TouristAttractionId = touristAttractionId9
                    }
                );
        }
    }
}
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

            /** Tour */
            modelBuilder.Entity<Group>()
                .Property(t => t.Status)
                .HasDefaultValue(GroupStatusEnum.New);
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
            string customerRoleId = Guid.NewGuid().ToString();

            string adminId = Guid.NewGuid().ToString();
            string superAdminId = Guid.NewGuid().ToString();
            string customer1Id = Guid.NewGuid().ToString();
            string customer2Id = Guid.NewGuid().ToString();
            string customer3Id = Guid.NewGuid().ToString();
            string customer4Id = Guid.NewGuid().ToString();
            string customer5Id = Guid.NewGuid().ToString();
            string customer6Id = Guid.NewGuid().ToString();
            string customer7Id = Guid.NewGuid().ToString();
            string customer8Id = Guid.NewGuid().ToString();
            string customer9Id = Guid.NewGuid().ToString();
            string customer10Id = Guid.NewGuid().ToString();
            string customer11Id = Guid.NewGuid().ToString();
            string customer12Id = Guid.NewGuid().ToString();
            string customer13Id = Guid.NewGuid().ToString();
            string customer14Id = Guid.NewGuid().ToString();
            string customer15Id = Guid.NewGuid().ToString();

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
                    },
                    new IdentityRole
                    {
                        Id = customerRoleId,
                        Name = "Customer",
                        NormalizedName = "customer"
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
                    },
                    new ApplicationUser
                    {
                        Id = customer1Id,
                        FirstName = "Loan",
                        LastName = "Trần Kiều",
                        UserName = "trankieuloan@gmail.com",
                        NormalizedUserName = "trankieuloan@gmail.com".ToUpper(),
                        Email = "trankieuloan@gmail.com",
                        NormalizedEmail = "trankieuloan@gmail.com".ToUpper(),
                        EmailConfirmed = true,
                        PasswordHash = hasher.HashPassword(null, "12345678"),
                        SecurityStamp = string.Empty
                    },
                    new ApplicationUser
                    {
                        Id = customer2Id,
                        FirstName = "Sơn",
                        LastName = "Phạm Vĩnh",
                        UserName = "phamvinhson@gmail.com",
                        NormalizedUserName = "phamvinhson@gmail.com".ToUpper(),
                        Email = "phamvinhson@gmail.com",
                        NormalizedEmail = "phamvinhson@gmail.com".ToUpper(),
                        EmailConfirmed = true,
                        PasswordHash = hasher.HashPassword(null, "12345678"),
                        SecurityStamp = string.Empty
                    },
                    new ApplicationUser
                    {
                        Id = customer3Id,
                        FirstName = "Hiếu",
                        LastName = "Nguyễn Trung",
                        UserName = "nguyentrunghieu@gmail.com",
                        NormalizedUserName = "nguyentrunghieu@gmail.com".ToUpper(),
                        Email = "nguyentrunghieu@gmail.com",
                        NormalizedEmail = "nguyentrunghieu@gmail.com".ToUpper(),
                        EmailConfirmed = true,
                        PasswordHash = hasher.HashPassword(null, "12345678"),
                        SecurityStamp = string.Empty
                    },
                    new ApplicationUser
                    {
                        Id = customer4Id,
                        FirstName = "Lộc",
                        LastName = "Nguyễn Như",
                        UserName = "nguyennhuloc@gmail.com",
                        NormalizedUserName = "nguyennhuloc@gmail.com".ToUpper(),
                        Email = "nguyennhuloc@gmail.com",
                        NormalizedEmail = "nguyennhuloc@gmail.com".ToUpper(),
                        EmailConfirmed = true,
                        PasswordHash = hasher.HashPassword(null, "12345678"),
                        SecurityStamp = string.Empty
                    },
                    new ApplicationUser
                    {
                        Id = customer5Id,
                        FirstName = "Anh",
                        LastName = "Cao Thị Vân",
                        UserName = "caothivananh@gmail.com",
                        NormalizedUserName = "caothivananh@gmail.com".ToUpper(),
                        Email = "caothivananh@gmail.com",
                        NormalizedEmail = "caothivananh@gmail.com".ToUpper(),
                        EmailConfirmed = true,
                        PasswordHash = hasher.HashPassword(null, "12345678"),
                        SecurityStamp = string.Empty
                    },
                    new ApplicationUser
                    {
                        Id = customer6Id,
                        FirstName = "Nguyên",
                        LastName = "Trần Thảo",
                        UserName = "tranthaonguyen@gmail.com",
                        NormalizedUserName = "tranthaonguyen@gmail.com".ToUpper(),
                        Email = "tranthaonguyen@gmail.com",
                        NormalizedEmail = "tranthaonguyen@gmail.com".ToUpper(),
                        EmailConfirmed = true,
                        PasswordHash = hasher.HashPassword(null, "12345678"),
                        SecurityStamp = string.Empty
                    },
                    new ApplicationUser
                    {
                        Id = customer7Id,
                        FirstName = "Anh",
                        LastName = "Trương Thị Trâm",
                        UserName = "truongthitramanh@gmail.com",
                        NormalizedUserName = "truongthitramanh@gmail.com".ToUpper(),
                        Email = "truongthitramanh@gmail.com",
                        NormalizedEmail = "truongthitramanh@gmail.com".ToUpper(),
                        EmailConfirmed = true,
                        PasswordHash = hasher.HashPassword(null, "12345678"),
                        SecurityStamp = string.Empty
                    },
                    new ApplicationUser
                    {
                        Id = customer8Id,
                        FirstName = "Quát",
                        LastName = "Cao Bá",
                        UserName = "caobaquat@gmail.com",
                        NormalizedUserName = "caobaquat@gmail.com".ToUpper(),
                        Email = "caobaquat@gmail.com",
                        NormalizedEmail = "caobaquat@gmail.com".ToUpper(),
                        EmailConfirmed = true,
                        PasswordHash = hasher.HashPassword(null, "12345678"),
                        SecurityStamp = string.Empty
                    },
                    new ApplicationUser
                    {
                        Id = customer9Id,
                        FirstName = "Thành",
                        LastName = "Huỳnh Trấn",
                        UserName = "huynhtranthanh@gmail.com",
                        NormalizedUserName = "huynhtranthanh@gmail.com".ToUpper(),
                        Email = "huynhtranthanh@gmail.com",
                        NormalizedEmail = "huynhtranthanh@gmail.com".ToUpper(),
                        EmailConfirmed = true,
                        PasswordHash = hasher.HashPassword(null, "12345678"),
                        SecurityStamp = string.Empty
                    },
                    new ApplicationUser
                    {
                        Id = customer10Id,
                        FirstName = "Long",
                        LastName = "Nguyễn Thành",
                        UserName = "nguyenthanhlong@gmail.com",
                        NormalizedUserName = "nguyenthanhlong@gmail.com".ToUpper(),
                        Email = "nguyenthanhlong@gmail.com",
                        NormalizedEmail = "nguyenthanhlong@gmail.com".ToUpper(),
                        EmailConfirmed = true,
                        PasswordHash = hasher.HashPassword(null, "12345678"),
                        SecurityStamp = string.Empty
                    },
                    new ApplicationUser
                    {
                        Id = customer11Id,
                        FirstName = "Hương",
                        LastName = "Hồ Xuân",
                        UserName = "hoxuanhuong@gmail.com",
                        NormalizedUserName = "hoxuanhuong@gmail.com".ToUpper(),
                        Email = "hoxuanhuong@gmail.com",
                        NormalizedEmail = "hoxuanhuong@gmail.com".ToUpper(),
                        EmailConfirmed = true,
                        PasswordHash = hasher.HashPassword(null, "12345678"),
                        SecurityStamp = string.Empty
                    },
                    new ApplicationUser
                    {
                        Id = customer12Id,
                        FirstName = "Huệ",
                        LastName = "Nguyễn",
                        UserName = "nguyenhue@gmail.com",
                        NormalizedUserName = "nguyenhue@gmail.com".ToUpper(),
                        Email = "nguyenhue@gmail.com",
                        NormalizedEmail = "nguyenhue@gmail.com".ToUpper(),
                        EmailConfirmed = true,
                        PasswordHash = hasher.HashPassword(null, "12345678"),
                        SecurityStamp = string.Empty
                    },
                    new ApplicationUser
                    {
                        Id = customer13Id,
                        FirstName = "Độ",
                        LastName = "Phùng Thanh",
                        UserName = "phungthanhdo@gmail.com",
                        NormalizedUserName = "phungthanhdo@gmail.com".ToUpper(),
                        Email = "phungthanhdo@gmail.com",
                        NormalizedEmail = "phungthanhdo@gmail.com".ToUpper(),
                        EmailConfirmed = true,
                        PasswordHash = hasher.HashPassword(null, "12345678"),
                        SecurityStamp = string.Empty
                    },
                    new ApplicationUser
                    {
                        Id = customer14Id,
                        FirstName = "Trung",
                        LastName = "Phan Tấn",
                        UserName = "phantantrung@gmail.com",
                        NormalizedUserName = "phantantrung@gmail.com".ToUpper(),
                        Email = "phantantrung@gmail.com",
                        NormalizedEmail = "phantantrung@gmail.com".ToUpper(),
                        EmailConfirmed = true,
                        PasswordHash = hasher.HashPassword(null, "12345678"),
                        SecurityStamp = string.Empty
                    },
                    new ApplicationUser
                    {
                        Id = customer15Id,
                        FirstName = "Tú",
                        LastName = "Trương Tuấn",
                        UserName = "truongtuantu@gmail.com",
                        NormalizedUserName = "truongtuantu@gmail.com".ToUpper(),
                        Email = "truongtuantu@gmail.com",
                        NormalizedEmail = "truongtuantu@gmail.com".ToUpper(),
                        EmailConfirmed = true,
                        PasswordHash = hasher.HashPassword(null, "12345678"),
                        SecurityStamp = string.Empty
                    }
                );

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
                    },
                    new IdentityUserRole<string>
                    {
                        RoleId = customerRoleId,
                        UserId = customer1Id
                    },
                    new IdentityUserRole<string>
                    {
                        RoleId = customerRoleId,
                        UserId = customer2Id
                    },
                    new IdentityUserRole<string>
                    {
                        RoleId = customerRoleId,
                        UserId = customer3Id
                    },
                    new IdentityUserRole<string>
                    {
                        RoleId = customerRoleId,
                        UserId = customer4Id
                    },
                    new IdentityUserRole<string>
                    {
                        RoleId = customerRoleId,
                        UserId = customer5Id
                    },
                    new IdentityUserRole<string>
                    {
                        RoleId = customerRoleId,
                        UserId = customer6Id
                    },
                    new IdentityUserRole<string>
                    {
                        RoleId = customerRoleId,
                        UserId = customer7Id
                    },
                    new IdentityUserRole<string>
                    {
                        RoleId = customerRoleId,
                        UserId = customer8Id
                    },
                    new IdentityUserRole<string>
                    {
                        RoleId = customerRoleId,
                        UserId = customer9Id
                    },
                    new IdentityUserRole<string>
                    {
                        RoleId = customerRoleId,
                        UserId = customer10Id
                    },
                    new IdentityUserRole<string>
                    {
                        RoleId = customerRoleId,
                        UserId = customer11Id
                    },
                    new IdentityUserRole<string>
                    {
                        RoleId = customerRoleId,
                        UserId = customer12Id
                    },
                    new IdentityUserRole<string>
                    {
                        RoleId = customerRoleId,
                        UserId = customer13Id
                    },
                    new IdentityUserRole<string>
                    {
                        RoleId = customerRoleId,
                        UserId = customer14Id
                    },
                    new IdentityUserRole<string>
                    {
                        RoleId = customerRoleId,
                        UserId = customer15Id
                    }
                );

            /*------------------------------------
             |                                   |
             |       SEED TOUR CATEGORIES        |
             |                                   |
             |-----------------------------------| */
            int tourCategory1Id = 1;
            int tourCategory2Id = 2;
            int tourCategory3Id = 3;
            int tourCategory4Id = 4;
            int tourCategory5Id = 5;
            int tourCategory6Id = 6;

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
            int touristAttractionId1 = 1;
            int touristAttractionId2 = 2;
            int touristAttractionId3 = 3;
            int touristAttractionId4 = 4;
            int touristAttractionId5 = 5;
            int touristAttractionId6 = 6;
            int touristAttractionId7 = 7;
            int touristAttractionId8 = 8;
            int touristAttractionId9 = 9;
            int touristAttractionId10 = 10;
            int touristAttractionId11 = 11;
            int touristAttractionId12 = 12;
            int touristAttractionId13 = 13;
            int touristAttractionId14 = 14;
            int touristAttractionId15 = 15;
            int touristAttractionId16 = 16;


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

            int tourId1 = 1;
            int tourId2 = 2;
            int tourId3 = 3;
            int tourId4 = 4;
            int tourId5 = 5;
            int tourId6 = 6;
            int tourId7 = 7;
            int tourId8 = 8;
            int tourId9 = 9;
            int tourId10 = 10;
            int tourId11 = 11;
            int tourId12 = 12;
            int tourId13 = 13;
            int tourId14 = 14;
            int tourId15 = 15;
            int tourId16 = 16;
            int tourId17 = 17;
            int tourId18 = 18;
            int tourId19 = 19;
            int tourId20 = 20;

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
                        Id = 1,
                        TourId = tourId1,
                        TouristAttractionId = touristAttractionId1,
                    },
                    new TourDetail
                    {
                        Id = 2,
                        TourId = tourId1,
                        TouristAttractionId = touristAttractionId2,
                    },
                    new TourDetail
                    {
                        Id = 3,
                        TourId = tourId1,
                        TouristAttractionId = touristAttractionId3,
                    },
                    new TourDetail
                    {
                        Id = 4,
                        TourId = tourId1,
                        TouristAttractionId = touristAttractionId4
                    },
                    new TourDetail
                    {
                        Id = 5,
                        TourId = tourId2,
                        TouristAttractionId = touristAttractionId1,
                    },
                    new TourDetail
                    {
                        Id = 6,
                        TourId = tourId2,
                        TouristAttractionId = touristAttractionId5,
                    },
                    new TourDetail
                    {
                        Id = 7,
                        TourId = tourId2,
                        TouristAttractionId = touristAttractionId6
                    },
                    new TourDetail
                    {
                        Id = 8,
                        TourId = tourId3,
                        TouristAttractionId = touristAttractionId1,
                    },
                    new TourDetail
                    {
                        Id = 9,
                        TourId = tourId3,
                        TouristAttractionId = touristAttractionId7
                    },
                    new TourDetail
                    {
                        Id = 10,
                        TourId = tourId4,
                        TouristAttractionId = touristAttractionId1,
                    },
                    new TourDetail
                    {
                        Id = 11,
                        TourId = tourId4,
                        TouristAttractionId = touristAttractionId8
                    },
                    new TourDetail
                    {
                        Id = 12,
                        TourId = tourId5,
                        TouristAttractionId = touristAttractionId1,
                    },
                    new TourDetail
                    {
                        Id = 13,
                        TourId = tourId5,
                        TouristAttractionId = touristAttractionId6
                    },
                    new TourDetail
                    {
                        Id = 14,
                        TourId = tourId6,
                        TouristAttractionId = touristAttractionId1,
                    },
                    new TourDetail
                    {
                        Id = 15,
                        TourId = tourId6,
                        TouristAttractionId = touristAttractionId5
                    },
                    new TourDetail
                    {
                        Id = 16,
                        TourId = tourId7,
                        TouristAttractionId = touristAttractionId1,
                    },
                    new TourDetail
                    {
                        Id = 17,
                        TourId = tourId7,
                        TouristAttractionId = touristAttractionId9,
                    },
                    new TourDetail
                    {
                        Id = 18,
                        TourId = tourId7,
                        TouristAttractionId = touristAttractionId10
                    },
                    new TourDetail
                    {
                        Id = 19,
                        TourId = tourId8,
                        TouristAttractionId = touristAttractionId1,
                    },
                    new TourDetail
                    {
                        Id = 20,
                        TourId = tourId8,
                        TouristAttractionId = touristAttractionId11
                    },
                    new TourDetail
                    {
                        Id = 21,
                        TourId = tourId9,
                        TouristAttractionId = touristAttractionId1,
                    },
                    new TourDetail
                    {
                        Id = 22,
                        TourId = tourId9,
                        TouristAttractionId = touristAttractionId2,
                    },
                    new TourDetail
                    {
                        Id = 23,
                        TourId = tourId9,
                        TouristAttractionId = touristAttractionId12,
                    },
                    new TourDetail
                    {
                        Id = 24,
                        TourId = tourId9,
                        TouristAttractionId = touristAttractionId3
                    },
                    new TourDetail
                    {
                        Id = 25,
                        TourId = tourId10,
                        TouristAttractionId = touristAttractionId1,
                    },
                    new TourDetail
                    {
                        Id = 26,
                        TourId = tourId10,
                        TouristAttractionId = touristAttractionId9,
                    },
                    new TourDetail
                    {
                        Id = 27,
                        TourId = tourId10,
                        TouristAttractionId = touristAttractionId10,
                    },
                    new TourDetail
                    {
                        Id = 28,
                        TourId = tourId11,
                        TouristAttractionId = touristAttractionId1,
                    },
                    new TourDetail
                    {
                        Id = 29,
                        TourId = tourId11,
                        TouristAttractionId = touristAttractionId9,
                    },
                    new TourDetail
                    {
                        Id = 30,
                        TourId = tourId11,
                        TouristAttractionId = touristAttractionId10
                    },
                    new TourDetail
                    {
                        Id = 31,
                        TourId = tourId12,
                        TouristAttractionId = touristAttractionId1,
                    },
                    new TourDetail
                    {
                        Id = 32,
                        TourId = tourId12,
                        TouristAttractionId = touristAttractionId11
                    },
                    new TourDetail
                    {
                        Id = 33,
                        TourId = tourId13,
                        TouristAttractionId = touristAttractionId1,
                    },
                    new TourDetail
                    {
                        Id = 34,
                        TourId = tourId13,
                        TouristAttractionId = touristAttractionId13
                    },
                    new TourDetail
                    {
                        Id = 35,
                        TourId = tourId14,
                        TouristAttractionId = touristAttractionId1,
                    },
                    new TourDetail
                    {
                        Id = 36,
                        TourId = tourId14,
                        TouristAttractionId = touristAttractionId5
                    },
                    new TourDetail
                    {
                        Id = 37,
                        TourId = tourId15,
                        TouristAttractionId = touristAttractionId1,
                    },
                    new TourDetail
                    {
                        Id = 38,
                        TourId = tourId15,
                        TouristAttractionId = touristAttractionId8
                    },
                    new TourDetail
                    {
                        Id = 39,
                        TourId = tourId16,
                        TouristAttractionId = touristAttractionId1,
                    },
                    new TourDetail
                    {
                        Id = 40,
                        TourId = tourId16,
                        TouristAttractionId = touristAttractionId14
                    },
                    new TourDetail
                    {
                        Id = 41,
                        TourId = tourId17,
                        TouristAttractionId = touristAttractionId1,
                    },
                    new TourDetail
                    {
                        Id = 42,
                        TourId = tourId17,
                        TouristAttractionId = touristAttractionId5
                    },
                    new TourDetail
                    {
                        Id = 43,
                        TourId = tourId18,
                        TouristAttractionId = touristAttractionId1,
                    },
                    new TourDetail
                    {
                        Id = 44,
                        TourId = tourId18,
                        TouristAttractionId = touristAttractionId15
                    },
                    new TourDetail
                    {
                        Id = 45,
                        TourId = tourId19,
                        TouristAttractionId = touristAttractionId1,
                    },
                    new TourDetail
                    {
                        Id = 46,
                        TourId = tourId19,
                        TouristAttractionId = touristAttractionId16
                    },
                    new TourDetail
                    {
                        Id = 47,
                        TourId = tourId20,
                        TouristAttractionId = touristAttractionId1,
                    },
                    new TourDetail
                    {
                        Id = 48,
                        TourId = tourId20,
                        TouristAttractionId = touristAttractionId9
                    }
                );
        }
    }
}
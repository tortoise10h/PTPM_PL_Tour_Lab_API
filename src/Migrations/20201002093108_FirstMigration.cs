using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace src.Migrations
{
    public partial class FirstMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    UserName = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CostType",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: true),
                    LastModifiedAt = table.Column<DateTime>(nullable: false),
                    LastModifiedBy = table.Column<string>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CostType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GroupRole",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: true),
                    LastModifiedAt = table.Column<DateTime>(nullable: false),
                    LastModifiedBy = table.Column<string>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GroupRole", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TourCategories",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: true),
                    LastModifiedAt = table.Column<DateTime>(nullable: false),
                    LastModifiedBy = table.Column<string>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TourCategories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TouristAttraction",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: true),
                    LastModifiedAt = table.Column<DateTime>(nullable: false),
                    LastModifiedBy = table.Column<string>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TouristAttraction", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(nullable: false),
                    ProviderKey = table.Column<string>(nullable: false),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    RoleId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    LoginProvider = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Tours",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: true),
                    LastModifiedAt = table.Column<DateTime>(nullable: false),
                    LastModifiedBy = table.Column<string>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Specification = table.Column<string>(nullable: true),
                    TourCategoryId = table.Column<Guid>(nullable: false),
                    Price = table.Column<double>(nullable: false),
                    Status = table.Column<int>(nullable: false, defaultValue: 1)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tours", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tours_TourCategories_TourCategoryId",
                        column: x => x.TourCategoryId,
                        principalTable: "TourCategories",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Group",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: true),
                    LastModifiedAt = table.Column<DateTime>(nullable: false),
                    LastModifiedBy = table.Column<string>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Price = table.Column<long>(nullable: false),
                    StartDate = table.Column<DateTime>(nullable: false),
                    EndDate = table.Column<DateTime>(nullable: false),
                    TourId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Group", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Group_Tours_TourId",
                        column: x => x.TourId,
                        principalTable: "Tours",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "TourDetail",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: true),
                    LastModifiedAt = table.Column<DateTime>(nullable: false),
                    LastModifiedBy = table.Column<string>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    TourId = table.Column<Guid>(nullable: false),
                    TouristAttractionId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TourDetail", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TourDetail_Tours_TourId",
                        column: x => x.TourId,
                        principalTable: "Tours",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_TourDetail_TouristAttraction_TouristAttractionId",
                        column: x => x.TouristAttractionId,
                        principalTable: "TouristAttraction",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "TourPrice",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: true),
                    LastModifiedAt = table.Column<DateTime>(nullable: false),
                    LastModifiedBy = table.Column<string>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    TourId = table.Column<Guid>(nullable: false),
                    Price = table.Column<long>(nullable: false),
                    StartDate = table.Column<DateTime>(nullable: false),
                    EndDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TourPrice", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TourPrice_Tours_TourId",
                        column: x => x.TourId,
                        principalTable: "Tours",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "GroupCost",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: true),
                    LastModifiedAt = table.Column<DateTime>(nullable: false),
                    LastModifiedBy = table.Column<string>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    GroupId = table.Column<Guid>(nullable: false),
                    CostTypeId = table.Column<Guid>(nullable: false),
                    Price = table.Column<long>(nullable: false),
                    Note = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GroupCost", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GroupCost_CostType_CostTypeId",
                        column: x => x.CostTypeId,
                        principalTable: "CostType",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_GroupCost_Group_GroupId",
                        column: x => x.GroupId,
                        principalTable: "Group",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "GroupDetail",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: true),
                    LastModifiedAt = table.Column<DateTime>(nullable: false),
                    LastModifiedBy = table.Column<string>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    UserId = table.Column<string>(nullable: true),
                    GroupId = table.Column<Guid>(nullable: false),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GroupDetail", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GroupDetail_Group_GroupId",
                        column: x => x.GroupId,
                        principalTable: "Group",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_GroupDetail_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "StaffGroupRole",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: true),
                    LastModifiedAt = table.Column<DateTime>(nullable: false),
                    LastModifiedBy = table.Column<string>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    StaffId = table.Column<string>(nullable: true),
                    GroupId = table.Column<Guid>(nullable: false),
                    GroupRoleId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StaffGroupRole", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StaffGroupRole_Group_GroupId",
                        column: x => x.GroupId,
                        principalTable: "Group",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_StaffGroupRole_GroupRole_GroupRoleId",
                        column: x => x.GroupRoleId,
                        principalTable: "GroupRole",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_StaffGroupRole_AspNetUsers_StaffId",
                        column: x => x.StaffId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "89048b52-1fab-49a3-a72c-c1747573f1a8", "d61f0abd-49fd-443c-b5bd-33d5389242a1", "Admin", "admin" },
                    { "3ee257c4-5da7-45a1-ab8e-4fb8717f301a", "5891f62f-a001-4648-97a8-fd1b58231c51", "SuperAdmin", "superadmin" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "25390f08-ed89-4359-9e8f-1153cc3c900a", 0, "57f08966-74d7-4055-874b-0263ab90ee81", "lilsuperadmin@gmail.com", true, "Super Admin", "Lil", false, null, "LILSUPERADMIN@GMAIL.COM", "LILSUPERADMIN@GMAIL.COM", "AQAAAAEAACcQAAAAEDpGzrz21CSvAQhFdb1kFkgbHYr/YTvwK5I12fT2cNXWyePF3wGVRAPQsc1oecJppg==", null, false, "", false, "lilsuperadmin@gmail.com" },
                    { "079ac745-64bd-46c3-83fb-f12850376f58", 0, "35b09fb5-989d-4a34-859f-c8a2761b6153", "yungadmin@gmail.com", true, "Admin", "Yung", false, null, "YUNGADMIN@GMAIL.COM", "YUNGADMIN@GMAIL.COM", "AQAAAAEAACcQAAAAED6JvSRF9RivWrlNcdpWvnI27eRrwUCErq3QSxB2g2tSrn7eLDmM+v46F76yflmvsQ==", null, false, "", false, "yungadmin@gmail.com" }
                });

            migrationBuilder.InsertData(
                table: "TourCategories",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "IsDeleted", "LastModifiedAt", "LastModifiedBy", "Name" },
                values: new object[,]
                {
                    { new Guid("596a71ab-e2a5-40e2-bc67-d3ac19a37766"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Teambuilding" },
                    { new Guid("26bf26f7-f911-436a-b824-67f597859b77"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Du lịch xanh" },
                    { new Guid("c3a8f076-5bef-4ff9-8c7c-3d4d8d367cbc"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Du lịch MICE" },
                    { new Guid("7f9b595f-a764-4f5a-b33c-13498583a2a1"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Du lịch văn hóa" },
                    { new Guid("fc3f8129-c3e0-4797-93de-6d7342784cf3"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Du lịch tham quan" },
                    { new Guid("46d05cb1-3ac5-4137-9d29-77ad9e1abad3"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Du lịch ẩm thực" }
                });

            migrationBuilder.InsertData(
                table: "TouristAttraction",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "Description", "IsDeleted", "LastModifiedAt", "LastModifiedBy", "Name" },
                values: new object[,]
                {
                    { new Guid("24b6f142-139a-4734-a421-3ed9dd4ea3b7"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aenean dui est, fringilla eu urna non, rhoncus tristique urna. Phasellus sed mauris eu metus sollicitudin gravida. Aliquam ut molestie orci. Suspendisse nec quam ut massa rutrum ullamcorper non eu elit. Nam ligula sapien, placerat nec ligula et, maximus sagittis est. Maecenas et ex nec nunc sagittis aliquam vitae vitae neque. Ut ut malesuada sapien, tincidunt auctor elit. Quisque volutpat urna at posuere maximus. Nunc felis lectus, bibendum ut quam id, porttitor vehicula turpis. Sed ac efficitur risus. Proin feugiat sit amet dui vel tempor.Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aenean dui est, fringilla eu urna non, rhoncus tristique urna. Phasellus sed mauris eu metus sollicitudin gravida. Aliquam ut molestie orci. Suspendisse nec quam ut massa rutrum ullamcorper non eu elit. Nam ligula sapien, placerat nec ligula et, maximus sagittis est. Maecenas et ex nec nunc sagittis aliquam vitae vitae neque. Ut ut malesuada sapien, tincidunt auctor elit. Quisque volutpat urna at posuere maximus. Nunc felis lectus, bibendum ut quam id, porttitor vehicula turpis. Sed ac efficitur risus. Proin feugiat sit amet dui vel tempor.", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Miền Tây" },
                    { new Guid("965faee2-f183-4afc-8ad7-2d8ecd9e4998"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aenean dui est, fringilla eu urna non, rhoncus tristique urna. Phasellus sed mauris eu metus sollicitudin gravida. Aliquam ut molestie orci. Suspendisse nec quam ut massa rutrum ullamcorper non eu elit. Nam ligula sapien, placerat nec ligula et, maximus sagittis est. Maecenas et ex nec nunc sagittis aliquam vitae vitae neque. Ut ut malesuada sapien, tincidunt auctor elit. Quisque volutpat urna at posuere maximus. Nunc felis lectus, bibendum ut quam id, porttitor vehicula turpis. Sed ac efficitur risus. Proin feugiat sit amet dui vel tempor.Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aenean dui est, fringilla eu urna non, rhoncus tristique urna. Phasellus sed mauris eu metus sollicitudin gravida. Aliquam ut molestie orci. Suspendisse nec quam ut massa rutrum ullamcorper non eu elit. Nam ligula sapien, placerat nec ligula et, maximus sagittis est. Maecenas et ex nec nunc sagittis aliquam vitae vitae neque. Ut ut malesuada sapien, tincidunt auctor elit. Quisque volutpat urna at posuere maximus. Nunc felis lectus, bibendum ut quam id, porttitor vehicula turpis. Sed ac efficitur risus. Proin feugiat sit amet dui vel tempor.", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Phú Quốc" },
                    { new Guid("1c40f05a-8a03-4a32-b77b-50ef1a25ccc9"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aenean dui est, fringilla eu urna non, rhoncus tristique urna. Phasellus sed mauris eu metus sollicitudin gravida. Aliquam ut molestie orci. Suspendisse nec quam ut massa rutrum ullamcorper non eu elit. Nam ligula sapien, placerat nec ligula et, maximus sagittis est. Maecenas et ex nec nunc sagittis aliquam vitae vitae neque. Ut ut malesuada sapien, tincidunt auctor elit. Quisque volutpat urna at posuere maximus. Nunc felis lectus, bibendum ut quam id, porttitor vehicula turpis. Sed ac efficitur risus. Proin feugiat sit amet dui vel tempor.Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aenean dui est, fringilla eu urna non, rhoncus tristique urna. Phasellus sed mauris eu metus sollicitudin gravida. Aliquam ut molestie orci. Suspendisse nec quam ut massa rutrum ullamcorper non eu elit. Nam ligula sapien, placerat nec ligula et, maximus sagittis est. Maecenas et ex nec nunc sagittis aliquam vitae vitae neque. Ut ut malesuada sapien, tincidunt auctor elit. Quisque volutpat urna at posuere maximus. Nunc felis lectus, bibendum ut quam id, porttitor vehicula turpis. Sed ac efficitur risus. Proin feugiat sit amet dui vel tempor.", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Hồ Tràm" },
                    { new Guid("9a50d5fa-95e1-4919-a5a9-5c8d05057f9f"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aenean dui est, fringilla eu urna non, rhoncus tristique urna. Phasellus sed mauris eu metus sollicitudin gravida. Aliquam ut molestie orci. Suspendisse nec quam ut massa rutrum ullamcorper non eu elit. Nam ligula sapien, placerat nec ligula et, maximus sagittis est. Maecenas et ex nec nunc sagittis aliquam vitae vitae neque. Ut ut malesuada sapien, tincidunt auctor elit. Quisque volutpat urna at posuere maximus. Nunc felis lectus, bibendum ut quam id, porttitor vehicula turpis. Sed ac efficitur risus. Proin feugiat sit amet dui vel tempor.Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aenean dui est, fringilla eu urna non, rhoncus tristique urna. Phasellus sed mauris eu metus sollicitudin gravida. Aliquam ut molestie orci. Suspendisse nec quam ut massa rutrum ullamcorper non eu elit. Nam ligula sapien, placerat nec ligula et, maximus sagittis est. Maecenas et ex nec nunc sagittis aliquam vitae vitae neque. Ut ut malesuada sapien, tincidunt auctor elit. Quisque volutpat urna at posuere maximus. Nunc felis lectus, bibendum ut quam id, porttitor vehicula turpis. Sed ac efficitur risus. Proin feugiat sit amet dui vel tempor.", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Hạ Long" },
                    { new Guid("810c17b0-3a74-43a3-aa8e-026afe4af9d5"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aenean dui est, fringilla eu urna non, rhoncus tristique urna. Phasellus sed mauris eu metus sollicitudin gravida. Aliquam ut molestie orci. Suspendisse nec quam ut massa rutrum ullamcorper non eu elit. Nam ligula sapien, placerat nec ligula et, maximus sagittis est. Maecenas et ex nec nunc sagittis aliquam vitae vitae neque. Ut ut malesuada sapien, tincidunt auctor elit. Quisque volutpat urna at posuere maximus. Nunc felis lectus, bibendum ut quam id, porttitor vehicula turpis. Sed ac efficitur risus. Proin feugiat sit amet dui vel tempor.Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aenean dui est, fringilla eu urna non, rhoncus tristique urna. Phasellus sed mauris eu metus sollicitudin gravida. Aliquam ut molestie orci. Suspendisse nec quam ut massa rutrum ullamcorper non eu elit. Nam ligula sapien, placerat nec ligula et, maximus sagittis est. Maecenas et ex nec nunc sagittis aliquam vitae vitae neque. Ut ut malesuada sapien, tincidunt auctor elit. Quisque volutpat urna at posuere maximus. Nunc felis lectus, bibendum ut quam id, porttitor vehicula turpis. Sed ac efficitur risus. Proin feugiat sit amet dui vel tempor.", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Phan Thiết" },
                    { new Guid("a046c91b-e230-4a00-abc0-325fe87b10e4"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aenean dui est, fringilla eu urna non, rhoncus tristique urna. Phasellus sed mauris eu metus sollicitudin gravida. Aliquam ut molestie orci. Suspendisse nec quam ut massa rutrum ullamcorper non eu elit. Nam ligula sapien, placerat nec ligula et, maximus sagittis est. Maecenas et ex nec nunc sagittis aliquam vitae vitae neque. Ut ut malesuada sapien, tincidunt auctor elit. Quisque volutpat urna at posuere maximus. Nunc felis lectus, bibendum ut quam id, porttitor vehicula turpis. Sed ac efficitur risus. Proin feugiat sit amet dui vel tempor.Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aenean dui est, fringilla eu urna non, rhoncus tristique urna. Phasellus sed mauris eu metus sollicitudin gravida. Aliquam ut molestie orci. Suspendisse nec quam ut massa rutrum ullamcorper non eu elit. Nam ligula sapien, placerat nec ligula et, maximus sagittis est. Maecenas et ex nec nunc sagittis aliquam vitae vitae neque. Ut ut malesuada sapien, tincidunt auctor elit. Quisque volutpat urna at posuere maximus. Nunc felis lectus, bibendum ut quam id, porttitor vehicula turpis. Sed ac efficitur risus. Proin feugiat sit amet dui vel tempor.", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "ĐBSCL" },
                    { new Guid("2a112722-8c4f-4917-8c5e-8e564fd36fdf"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aenean dui est, fringilla eu urna non, rhoncus tristique urna. Phasellus sed mauris eu metus sollicitudin gravida. Aliquam ut molestie orci. Suspendisse nec quam ut massa rutrum ullamcorper non eu elit. Nam ligula sapien, placerat nec ligula et, maximus sagittis est. Maecenas et ex nec nunc sagittis aliquam vitae vitae neque. Ut ut malesuada sapien, tincidunt auctor elit. Quisque volutpat urna at posuere maximus. Nunc felis lectus, bibendum ut quam id, porttitor vehicula turpis. Sed ac efficitur risus. Proin feugiat sit amet dui vel tempor.Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aenean dui est, fringilla eu urna non, rhoncus tristique urna. Phasellus sed mauris eu metus sollicitudin gravida. Aliquam ut molestie orci. Suspendisse nec quam ut massa rutrum ullamcorper non eu elit. Nam ligula sapien, placerat nec ligula et, maximus sagittis est. Maecenas et ex nec nunc sagittis aliquam vitae vitae neque. Ut ut malesuada sapien, tincidunt auctor elit. Quisque volutpat urna at posuere maximus. Nunc felis lectus, bibendum ut quam id, porttitor vehicula turpis. Sed ac efficitur risus. Proin feugiat sit amet dui vel tempor.", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Đông Bắc" },
                    { new Guid("80c35b14-0af2-4260-9f4c-486009bc3adc"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aenean dui est, fringilla eu urna non, rhoncus tristique urna. Phasellus sed mauris eu metus sollicitudin gravida. Aliquam ut molestie orci. Suspendisse nec quam ut massa rutrum ullamcorper non eu elit. Nam ligula sapien, placerat nec ligula et, maximus sagittis est. Maecenas et ex nec nunc sagittis aliquam vitae vitae neque. Ut ut malesuada sapien, tincidunt auctor elit. Quisque volutpat urna at posuere maximus. Nunc felis lectus, bibendum ut quam id, porttitor vehicula turpis. Sed ac efficitur risus. Proin feugiat sit amet dui vel tempor.Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aenean dui est, fringilla eu urna non, rhoncus tristique urna. Phasellus sed mauris eu metus sollicitudin gravida. Aliquam ut molestie orci. Suspendisse nec quam ut massa rutrum ullamcorper non eu elit. Nam ligula sapien, placerat nec ligula et, maximus sagittis est. Maecenas et ex nec nunc sagittis aliquam vitae vitae neque. Ut ut malesuada sapien, tincidunt auctor elit. Quisque volutpat urna at posuere maximus. Nunc felis lectus, bibendum ut quam id, porttitor vehicula turpis. Sed ac efficitur risus. Proin feugiat sit amet dui vel tempor.", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Sapa" },
                    { new Guid("9dde7c2f-d092-4f90-a598-921156fdbf4d"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aenean dui est, fringilla eu urna non, rhoncus tristique urna. Phasellus sed mauris eu metus sollicitudin gravida. Aliquam ut molestie orci. Suspendisse nec quam ut massa rutrum ullamcorper non eu elit. Nam ligula sapien, placerat nec ligula et, maximus sagittis est. Maecenas et ex nec nunc sagittis aliquam vitae vitae neque. Ut ut malesuada sapien, tincidunt auctor elit. Quisque volutpat urna at posuere maximus. Nunc felis lectus, bibendum ut quam id, porttitor vehicula turpis. Sed ac efficitur risus. Proin feugiat sit amet dui vel tempor.Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aenean dui est, fringilla eu urna non, rhoncus tristique urna. Phasellus sed mauris eu metus sollicitudin gravida. Aliquam ut molestie orci. Suspendisse nec quam ut massa rutrum ullamcorper non eu elit. Nam ligula sapien, placerat nec ligula et, maximus sagittis est. Maecenas et ex nec nunc sagittis aliquam vitae vitae neque. Ut ut malesuada sapien, tincidunt auctor elit. Quisque volutpat urna at posuere maximus. Nunc felis lectus, bibendum ut quam id, porttitor vehicula turpis. Sed ac efficitur risus. Proin feugiat sit amet dui vel tempor.", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Nha Trang" },
                    { new Guid("6e9e3782-fe5b-407b-9f0b-364c2b572ad9"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aenean dui est, fringilla eu urna non, rhoncus tristique urna. Phasellus sed mauris eu metus sollicitudin gravida. Aliquam ut molestie orci. Suspendisse nec quam ut massa rutrum ullamcorper non eu elit. Nam ligula sapien, placerat nec ligula et, maximus sagittis est. Maecenas et ex nec nunc sagittis aliquam vitae vitae neque. Ut ut malesuada sapien, tincidunt auctor elit. Quisque volutpat urna at posuere maximus. Nunc felis lectus, bibendum ut quam id, porttitor vehicula turpis. Sed ac efficitur risus. Proin feugiat sit amet dui vel tempor.Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aenean dui est, fringilla eu urna non, rhoncus tristique urna. Phasellus sed mauris eu metus sollicitudin gravida. Aliquam ut molestie orci. Suspendisse nec quam ut massa rutrum ullamcorper non eu elit. Nam ligula sapien, placerat nec ligula et, maximus sagittis est. Maecenas et ex nec nunc sagittis aliquam vitae vitae neque. Ut ut malesuada sapien, tincidunt auctor elit. Quisque volutpat urna at posuere maximus. Nunc felis lectus, bibendum ut quam id, porttitor vehicula turpis. Sed ac efficitur risus. Proin feugiat sit amet dui vel tempor.", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Đà Lạt" },
                    { new Guid("744bd736-24a1-40d5-a96b-bda8c9772ea9"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aenean dui est, fringilla eu urna non, rhoncus tristique urna. Phasellus sed mauris eu metus sollicitudin gravida. Aliquam ut molestie orci. Suspendisse nec quam ut massa rutrum ullamcorper non eu elit. Nam ligula sapien, placerat nec ligula et, maximus sagittis est. Maecenas et ex nec nunc sagittis aliquam vitae vitae neque. Ut ut malesuada sapien, tincidunt auctor elit. Quisque volutpat urna at posuere maximus. Nunc felis lectus, bibendum ut quam id, porttitor vehicula turpis. Sed ac efficitur risus. Proin feugiat sit amet dui vel tempor.Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aenean dui est, fringilla eu urna non, rhoncus tristique urna. Phasellus sed mauris eu metus sollicitudin gravida. Aliquam ut molestie orci. Suspendisse nec quam ut massa rutrum ullamcorper non eu elit. Nam ligula sapien, placerat nec ligula et, maximus sagittis est. Maecenas et ex nec nunc sagittis aliquam vitae vitae neque. Ut ut malesuada sapien, tincidunt auctor elit. Quisque volutpat urna at posuere maximus. Nunc felis lectus, bibendum ut quam id, porttitor vehicula turpis. Sed ac efficitur risus. Proin feugiat sit amet dui vel tempor.", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Ninh Bình" },
                    { new Guid("bc4902da-4002-46af-ae46-d1c98227ffc7"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aenean dui est, fringilla eu urna non, rhoncus tristique urna. Phasellus sed mauris eu metus sollicitudin gravida. Aliquam ut molestie orci. Suspendisse nec quam ut massa rutrum ullamcorper non eu elit. Nam ligula sapien, placerat nec ligula et, maximus sagittis est. Maecenas et ex nec nunc sagittis aliquam vitae vitae neque. Ut ut malesuada sapien, tincidunt auctor elit. Quisque volutpat urna at posuere maximus. Nunc felis lectus, bibendum ut quam id, porttitor vehicula turpis. Sed ac efficitur risus. Proin feugiat sit amet dui vel tempor.Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aenean dui est, fringilla eu urna non, rhoncus tristique urna. Phasellus sed mauris eu metus sollicitudin gravida. Aliquam ut molestie orci. Suspendisse nec quam ut massa rutrum ullamcorper non eu elit. Nam ligula sapien, placerat nec ligula et, maximus sagittis est. Maecenas et ex nec nunc sagittis aliquam vitae vitae neque. Ut ut malesuada sapien, tincidunt auctor elit. Quisque volutpat urna at posuere maximus. Nunc felis lectus, bibendum ut quam id, porttitor vehicula turpis. Sed ac efficitur risus. Proin feugiat sit amet dui vel tempor.", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Đắk Nông" },
                    { new Guid("6dea04e5-0974-40e0-8480-ba307ce4f4f3"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aenean dui est, fringilla eu urna non, rhoncus tristique urna. Phasellus sed mauris eu metus sollicitudin gravida. Aliquam ut molestie orci. Suspendisse nec quam ut massa rutrum ullamcorper non eu elit. Nam ligula sapien, placerat nec ligula et, maximus sagittis est. Maecenas et ex nec nunc sagittis aliquam vitae vitae neque. Ut ut malesuada sapien, tincidunt auctor elit. Quisque volutpat urna at posuere maximus. Nunc felis lectus, bibendum ut quam id, porttitor vehicula turpis. Sed ac efficitur risus. Proin feugiat sit amet dui vel tempor.Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aenean dui est, fringilla eu urna non, rhoncus tristique urna. Phasellus sed mauris eu metus sollicitudin gravida. Aliquam ut molestie orci. Suspendisse nec quam ut massa rutrum ullamcorper non eu elit. Nam ligula sapien, placerat nec ligula et, maximus sagittis est. Maecenas et ex nec nunc sagittis aliquam vitae vitae neque. Ut ut malesuada sapien, tincidunt auctor elit. Quisque volutpat urna at posuere maximus. Nunc felis lectus, bibendum ut quam id, porttitor vehicula turpis. Sed ac efficitur risus. Proin feugiat sit amet dui vel tempor.", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Hà Nội" },
                    { new Guid("38b6f8cf-3ca0-4c3c-973a-2897b0ff5afc"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aenean dui est, fringilla eu urna non, rhoncus tristique urna. Phasellus sed mauris eu metus sollicitudin gravida. Aliquam ut molestie orci. Suspendisse nec quam ut massa rutrum ullamcorper non eu elit. Nam ligula sapien, placerat nec ligula et, maximus sagittis est. Maecenas et ex nec nunc sagittis aliquam vitae vitae neque. Ut ut malesuada sapien, tincidunt auctor elit. Quisque volutpat urna at posuere maximus. Nunc felis lectus, bibendum ut quam id, porttitor vehicula turpis. Sed ac efficitur risus. Proin feugiat sit amet dui vel tempor.Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aenean dui est, fringilla eu urna non, rhoncus tristique urna. Phasellus sed mauris eu metus sollicitudin gravida. Aliquam ut molestie orci. Suspendisse nec quam ut massa rutrum ullamcorper non eu elit. Nam ligula sapien, placerat nec ligula et, maximus sagittis est. Maecenas et ex nec nunc sagittis aliquam vitae vitae neque. Ut ut malesuada sapien, tincidunt auctor elit. Quisque volutpat urna at posuere maximus. Nunc felis lectus, bibendum ut quam id, porttitor vehicula turpis. Sed ac efficitur risus. Proin feugiat sit amet dui vel tempor.", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "TP. Hồ Chí Minh " },
                    { new Guid("6cd8c432-1744-4f2d-9f26-3a98a5ce04f0"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aenean dui est, fringilla eu urna non, rhoncus tristique urna. Phasellus sed mauris eu metus sollicitudin gravida. Aliquam ut molestie orci. Suspendisse nec quam ut massa rutrum ullamcorper non eu elit. Nam ligula sapien, placerat nec ligula et, maximus sagittis est. Maecenas et ex nec nunc sagittis aliquam vitae vitae neque. Ut ut malesuada sapien, tincidunt auctor elit. Quisque volutpat urna at posuere maximus. Nunc felis lectus, bibendum ut quam id, porttitor vehicula turpis. Sed ac efficitur risus. Proin feugiat sit amet dui vel tempor.Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aenean dui est, fringilla eu urna non, rhoncus tristique urna. Phasellus sed mauris eu metus sollicitudin gravida. Aliquam ut molestie orci. Suspendisse nec quam ut massa rutrum ullamcorper non eu elit. Nam ligula sapien, placerat nec ligula et, maximus sagittis est. Maecenas et ex nec nunc sagittis aliquam vitae vitae neque. Ut ut malesuada sapien, tincidunt auctor elit. Quisque volutpat urna at posuere maximus. Nunc felis lectus, bibendum ut quam id, porttitor vehicula turpis. Sed ac efficitur risus. Proin feugiat sit amet dui vel tempor.", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Tây Nguyên" },
                    { new Guid("a9a5c1a4-747e-4eae-985c-98e8eecbf9fe"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aenean dui est, fringilla eu urna non, rhoncus tristique urna. Phasellus sed mauris eu metus sollicitudin gravida. Aliquam ut molestie orci. Suspendisse nec quam ut massa rutrum ullamcorper non eu elit. Nam ligula sapien, placerat nec ligula et, maximus sagittis est. Maecenas et ex nec nunc sagittis aliquam vitae vitae neque. Ut ut malesuada sapien, tincidunt auctor elit. Quisque volutpat urna at posuere maximus. Nunc felis lectus, bibendum ut quam id, porttitor vehicula turpis. Sed ac efficitur risus. Proin feugiat sit amet dui vel tempor.Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aenean dui est, fringilla eu urna non, rhoncus tristique urna. Phasellus sed mauris eu metus sollicitudin gravida. Aliquam ut molestie orci. Suspendisse nec quam ut massa rutrum ullamcorper non eu elit. Nam ligula sapien, placerat nec ligula et, maximus sagittis est. Maecenas et ex nec nunc sagittis aliquam vitae vitae neque. Ut ut malesuada sapien, tincidunt auctor elit. Quisque volutpat urna at posuere maximus. Nunc felis lectus, bibendum ut quam id, porttitor vehicula turpis. Sed ac efficitur risus. Proin feugiat sit amet dui vel tempor.", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Tây Ninh" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[,]
                {
                    { "25390f08-ed89-4359-9e8f-1153cc3c900a", "3ee257c4-5da7-45a1-ab8e-4fb8717f301a" },
                    { "079ac745-64bd-46c3-83fb-f12850376f58", "89048b52-1fab-49a3-a72c-c1747573f1a8" }
                });

            migrationBuilder.InsertData(
                table: "Tours",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "IsDeleted", "LastModifiedAt", "LastModifiedBy", "Name", "Price", "Specification", "Status", "TourCategoryId" },
                values: new object[,]
                {
                    { new Guid("a2e858f8-cf90-47e9-a824-cf4998736e8a"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Du lịch Bảo Lộc - Hồ Tà Đùng - Đắk Nông - Khu Bảo Tồn Thiên Nhiên Nậm Nung", 2679000.0, @"Thời gian: 3 ngày 2 đêm Phương tiện: Đi về bằng xesản xuất trà và đồi chè Tâm Châu.
                 Dừng...", 1, new Guid("26bf26f7-f911-436a-b824-67f597859b77") },
                    { new Guid("79298a4d-7d2a-4886-b7fa-cc7e22b45fca"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Du lịch Đà Lạt - Hồ Tuyền Lâm - Đường Hầm Điêu Khắc", 2379000.0, "Thời gian: 3 ngày 2 đêm Phương tiện: Đi về bằng xem điêu khắc đất đỏ (Đà Lạt Star)  tái hiện...", 1, new Guid("26bf26f7-f911-436a-b824-67f597859b77") },
                    { new Guid("c7ab6996-2e82-41e9-a451-43d8fcdf12d3"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Du lịch Phú Quốc [Suối Tranh - Tặng Vé Cáp Treo Vượt Biển & Công Viên Nước  Hòn Thơm]", 3879000.0, "Thời gian: 3 ngày 2 đêm Phương tiện: Hàng không Vietnam Airlinesnh  quý khách có thể đi dạo trong rừng, thư...", 1, new Guid("26bf26f7-f911-436a-b824-67f597859b77") },
                    { new Guid("4cedc6aa-454e-4a6e-ae78-99dac8a99157"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Du lịch [Mùa Hoa Tam Giác Mạch] tại Hà Giang - Đồng Văn - Cao Bằng - Thác Bản Giốc - Pác Pó - Ba Bể", 9079000.0, "Thời gian: 6 ngày 5 đêm Phương tiện: Hàng không Vietnam Airlines Đồng Văn  Công viên địa chất toàn cầu....", 1, new Guid("46d05cb1-3ac5-4137-9d29-77ad9e1abad3") },
                    { new Guid("cbd47971-c062-43e0-98b1-0eb71f43bd62"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Du lịch Đà Lạt - Thác Datanla - Đồi Chè Cầu Đất -Trang Trại Rau & Hoa - Thác Dambri", 3079000.0, "Thời gian: 4 ngày 3 đêm Phương tiện: Đi về bằng xebri  ngọn thác hùng vĩ tại cao nguyên Bảo Lộc...", 1, new Guid("46d05cb1-3ac5-4137-9d29-77ad9e1abad3") },
                    { new Guid("1244b4a4-8c6c-49f0-951c-3deb9ea14235"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Du lịch Hồ Tràm - Trải nghiệm đẳng cấp 5 sao The Grand Ho Tram Strip", 2379000.0, "Thời gian: 2 ngày 1 đêm Phương tiện: Đi về bằng xeụ 5 sao cao cấp tại The Grand Ho Tram Strip...", 1, new Guid("46d05cb1-3ac5-4137-9d29-77ad9e1abad3") },
                    { new Guid("b0589093-4325-4cf9-a631-0324a330c8a0"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Du lịch Phan Thiết - Mũi Né - Làng Chài Xưa", 2379000.0, "Thời gian: 3 ngày 2 đêm Phương tiện: Đi về bằng xevàng dưới tác động của gió biển đã tạo nên...", 1, new Guid("46d05cb1-3ac5-4137-9d29-77ad9e1abad3") },
                    { new Guid("c6d0f3fd-c780-404b-9528-f416a13d6d6d"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Du lịch [mùa nước nổi] Cầu Cao Lãnh - Châu Đốc - Làng Cá Bè  - Rừng Tràm Trà Sư", 1979000.0, @"Thời gian: 2 ngày 1 đêm Phương tiện: Đi về bằng xe Xứ nổi tiếng hiển linh.
                 Tham quan Rừng Tràm...", 1, new Guid("46d05cb1-3ac5-4137-9d29-77ad9e1abad3") },
                    { new Guid("7a23b9ef-14d7-4d90-9883-0c12bfd3e554"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Du lịch Mỹ Tho - Cần Thơ - Cà Mau - Bạc Liêu - Sóc Trăng", 3879000.0, "Thời gian: 4 ngày 3 đêm Phương tiện: Đi về bằng xethức trái cây theo mùa, nghe nhạc tài tử Nam...", 1, new Guid("7f9b595f-a764-4f5a-b33c-13498583a2a1") },
                    { new Guid("6cac5f82-f157-4a3a-b0f4-edd4d766b46e"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Du lịch Hà Nội - Lào Cai - Sapa - Hạ Long", 7129000.0, @"Thời gian: 5 ngày 4 đêm Phương tiện: Hàng không Vietnam Airlinesn Cát Cát, ngắm toàn bộ cảnh Sapa từ Sân Mây
                ...", 1, new Guid("7f9b595f-a764-4f5a-b33c-13498583a2a1") },
                    { new Guid("745dd70d-7ecf-4205-8f6d-37917f624f2f"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Du lịch Phan Thiết - Mũi Né - Lâu Đài Rượu Vang", 2739000.0, @"Thời gian: 3 ngày 2 đêm Phương tiện: Đi về bằng xean trưng bày nghệ thuật “Làng chài xưa”
                 Chụp hình...", 1, new Guid("7f9b595f-a764-4f5a-b33c-13498583a2a1") },
                    { new Guid("895bcdc2-de6e-49f1-be96-fe4acacd3008"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Du lịch khám phá Cái Bè - Cần Thơ - Châu Đốc - Hà Tiên", 3679000.0, "Thời gian: 4 ngày 3 đêm Phương tiện: Đi về bằng xeNam bộ hơn trăm năm tuổi, theo lối kiến trúc...", 1, new Guid("7f9b595f-a764-4f5a-b33c-13498583a2a1") },
                    { new Guid("60bc8a87-0e8d-46c7-b3a7-183acdfe57e5"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Du lịch Đà Lạt - Dambri - Đường Hầm Điêu Khắc - Langbiang", 3079000.0, "Thời gian: 4 ngày 3 đêm Phương tiện: Đi về bằng xeường Lâm Viên với không gian rộng lớn, thoáng mát hướng...", 1, new Guid("7f9b595f-a764-4f5a-b33c-13498583a2a1") },
                    { new Guid("6a65a7f2-4c50-4938-b037-af9d98a9a97f"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Du lịch Nha Trang - Hòn Lao - Dốc Lết - I Resort - Làng Yến Mai Sinh", 2979000.0, "Thời gian: 4 ngày 3 đêm Phương tiện: Đi về bằng xeịch Hòn Lao  đảo Khỉ, khu du lịch sinh...", 1, new Guid("fc3f8129-c3e0-4797-93de-6d7342784cf3") },
                    { new Guid("2898ddaa-9110-49dc-9a81-22f63fdd9482"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Du lịch [Mùa Hoa Tam Giác Mạch] Hà Giang - Đồng Văn - Cao Bằng - Thác Bản Giốc- Lạng Sơn", 7529000.0, "Thời gian: 5 ngày 4 đêm Phương tiện: Hàng không Vietnam Airlines Thanh  ngắm núi Tô Thị Vượt đèo Mã...", 1, new Guid("fc3f8129-c3e0-4797-93de-6d7342784cf3") },
                    { new Guid("8d4a9610-a533-4bb1-842f-7fa03417fb1c"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Du lịch Buôn Ma Thuột - Buôn Đôn - Pleiku - Komtum", 4879000.0, @"Thời gian: 5 ngày 4 đêm Phương tiện: Đi về bằng xeay Nur hùng vĩ.
                 Tham quan cầu treo và ngắm...", 1, new Guid("fc3f8129-c3e0-4797-93de-6d7342784cf3") },
                    { new Guid("db595e1b-711e-4e4b-beb7-dc72e0908849"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Du lịch Nha Trang - Đà Lạt", 4279000.0, "Thời gian: 5 ngày 4 đêm Phương tiện: Đi về bằng xeVân hay còn gọi là Chùa Ốc, ngôi chùa làm...", 1, new Guid("fc3f8129-c3e0-4797-93de-6d7342784cf3") },
                    { new Guid("083091ab-0935-483b-b908-286b2a0b62dc"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Du lịch Hải Phòng - Hạ Long - Ninh Bình - Hà Nội - Lào Cai - Sapa - Đền Hùng", 8029000.0, "Thời gian: 6 ngày 5 đêm Phương tiện: Hàng không Vietnam Airlines Thăm quần thể di tích Bạch Đằng Giang với đền thờ các vị anh...A", 1, new Guid("fc3f8129-c3e0-4797-93de-6d7342784cf3") },
                    { new Guid("d8526018-7d97-44c6-803a-c4da8fa1d29c"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Du lịch Tây Ninh - Tòa Thánh Tây Ninh - Núi Bà Đen - Hồ Dầu Tiếng", 1879000.0, "Thời gian: 2 ngày 1 đêm Phương tiện: Đi về bằng xeĐen ngon núi cao nhất Đông Nam Bộ&nbsp; chỉ mất...", 1, new Guid("26bf26f7-f911-436a-b824-67f597859b77") },
                    { new Guid("ef24bb7e-b43c-4f88-bb1d-801f88b5c9c1"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Du lịch [Mùa nước nổi] Cao Lãnh - Tràm Chim Tam Nông - Khu Du Lịch Đồng Sen", 1779000.0, "Thời gian: 2 ngày 1 đêm Viếng Khu Di tích Cụ Nguyễn Sinh Sắc (nhà sàn Bác Hồ, khu Lăng...", 1, new Guid("26bf26f7-f911-436a-b824-67f597859b77") }
                });

            migrationBuilder.InsertData(
                table: "TourDetail",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "IsDeleted", "LastModifiedAt", "LastModifiedBy", "TourId", "TouristAttractionId" },
                values: new object[,]
                {
                    { new Guid("68fc8ef3-b60c-406e-adde-62b976c0640f"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("083091ab-0935-483b-b908-286b2a0b62dc"), new Guid("38b6f8cf-3ca0-4c3c-973a-2897b0ff5afc") },
                    { new Guid("b35f7c24-e71d-4c35-aedb-7bd532e06044"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("7a23b9ef-14d7-4d90-9883-0c12bfd3e554"), new Guid("a046c91b-e230-4a00-abc0-325fe87b10e4") },
                    { new Guid("faf91bf1-3f96-4e50-a8db-bdeb1b56bb9d"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("c6d0f3fd-c780-404b-9528-f416a13d6d6d"), new Guid("38b6f8cf-3ca0-4c3c-973a-2897b0ff5afc") },
                    { new Guid("1c24f0e0-66e5-4fdf-8b7e-76630976a37e"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("c6d0f3fd-c780-404b-9528-f416a13d6d6d"), new Guid("24b6f142-139a-4734-a421-3ed9dd4ea3b7") },
                    { new Guid("38454040-b6fe-40ee-baf4-eb1bcb20cd86"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("c6d0f3fd-c780-404b-9528-f416a13d6d6d"), new Guid("a046c91b-e230-4a00-abc0-325fe87b10e4") },
                    { new Guid("5a391339-09a8-448f-b39d-23c182bf15fe"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("b0589093-4325-4cf9-a631-0324a330c8a0"), new Guid("38b6f8cf-3ca0-4c3c-973a-2897b0ff5afc") },
                    { new Guid("617d66f8-b28c-449f-974e-fef0731b5646"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("b0589093-4325-4cf9-a631-0324a330c8a0"), new Guid("810c17b0-3a74-43a3-aa8e-026afe4af9d5") },
                    { new Guid("96412beb-148c-4c0a-9bad-4516592d11d9"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("1244b4a4-8c6c-49f0-951c-3deb9ea14235"), new Guid("38b6f8cf-3ca0-4c3c-973a-2897b0ff5afc") },
                    { new Guid("bd74faef-ec3c-4ca2-8f38-8e4f2a1043b8"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("1244b4a4-8c6c-49f0-951c-3deb9ea14235"), new Guid("1c40f05a-8a03-4a32-b77b-50ef1a25ccc9") },
                    { new Guid("795141f5-a56d-4acf-bd9e-d8d985d1b90b"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("cbd47971-c062-43e0-98b1-0eb71f43bd62"), new Guid("38b6f8cf-3ca0-4c3c-973a-2897b0ff5afc") },
                    { new Guid("ba701bb0-e681-4e35-950d-3ab84f3888ae"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("7a23b9ef-14d7-4d90-9883-0c12bfd3e554"), new Guid("24b6f142-139a-4734-a421-3ed9dd4ea3b7") },
                    { new Guid("8bff3f09-8515-4a72-b46c-75a640fe999a"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("cbd47971-c062-43e0-98b1-0eb71f43bd62"), new Guid("6e9e3782-fe5b-407b-9f0b-364c2b572ad9") },
                    { new Guid("a476d2dc-b1fb-4ceb-8eb2-05ae34f97d92"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("4cedc6aa-454e-4a6e-ae78-99dac8a99157"), new Guid("2a112722-8c4f-4917-8c5e-8e564fd36fdf") },
                    { new Guid("dffff367-5a88-424c-a609-b363adb69ac2"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("c7ab6996-2e82-41e9-a451-43d8fcdf12d3"), new Guid("38b6f8cf-3ca0-4c3c-973a-2897b0ff5afc") },
                    { new Guid("225653b6-5672-4210-ac2e-46d455041537"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("c7ab6996-2e82-41e9-a451-43d8fcdf12d3"), new Guid("965faee2-f183-4afc-8ad7-2d8ecd9e4998") },
                    { new Guid("4688d73b-2251-420a-847e-95c6b2e76a98"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("79298a4d-7d2a-4886-b7fa-cc7e22b45fca"), new Guid("38b6f8cf-3ca0-4c3c-973a-2897b0ff5afc") },
                    { new Guid("fdee55c3-1202-494e-aca3-80c1733f6e2e"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("79298a4d-7d2a-4886-b7fa-cc7e22b45fca"), new Guid("6e9e3782-fe5b-407b-9f0b-364c2b572ad9") },
                    { new Guid("bc57f283-109e-4eac-a068-1c043e140a20"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("a2e858f8-cf90-47e9-a824-cf4998736e8a"), new Guid("38b6f8cf-3ca0-4c3c-973a-2897b0ff5afc") },
                    { new Guid("2da39056-3366-4a93-af3c-be82ea14ceea"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("a2e858f8-cf90-47e9-a824-cf4998736e8a"), new Guid("bc4902da-4002-46af-ae46-d1c98227ffc7") },
                    { new Guid("cd93d55a-c08e-40b2-9d3e-bbe17c6827fd"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("d8526018-7d97-44c6-803a-c4da8fa1d29c"), new Guid("38b6f8cf-3ca0-4c3c-973a-2897b0ff5afc") },
                    { new Guid("5957f335-510b-4b6d-97d4-96913a2fdc0f"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("d8526018-7d97-44c6-803a-c4da8fa1d29c"), new Guid("a9a5c1a4-747e-4eae-985c-98e8eecbf9fe") },
                    { new Guid("66e32649-9af9-4754-9e3d-6ba381a7e0fe"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("4cedc6aa-454e-4a6e-ae78-99dac8a99157"), new Guid("38b6f8cf-3ca0-4c3c-973a-2897b0ff5afc") },
                    { new Guid("b0bdb476-2d55-434c-9d26-cb3a21e07cee"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("7a23b9ef-14d7-4d90-9883-0c12bfd3e554"), new Guid("38b6f8cf-3ca0-4c3c-973a-2897b0ff5afc") },
                    { new Guid("b5ab58e6-c6b5-4ab5-8cd6-503b22800b72"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("6cac5f82-f157-4a3a-b0f4-edd4d766b46e"), new Guid("80c35b14-0af2-4260-9f4c-486009bc3adc") },
                    { new Guid("967b0735-5f74-459c-a248-0a5d2f335881"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("6cac5f82-f157-4a3a-b0f4-edd4d766b46e"), new Guid("9a50d5fa-95e1-4919-a5a9-5c8d05057f9f") },
                    { new Guid("2d21649f-6874-4660-bcef-043ac25363f9"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("083091ab-0935-483b-b908-286b2a0b62dc"), new Guid("6dea04e5-0974-40e0-8480-ba307ce4f4f3") },
                    { new Guid("6ae533f9-0a46-4179-972a-8eddf53d4ba0"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("083091ab-0935-483b-b908-286b2a0b62dc"), new Guid("80c35b14-0af2-4260-9f4c-486009bc3adc") },
                    { new Guid("a8029895-be61-4373-ac4b-ad27261f59fd"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("083091ab-0935-483b-b908-286b2a0b62dc"), new Guid("744bd736-24a1-40d5-a96b-bda8c9772ea9") },
                    { new Guid("bc866f5d-a7e0-4891-a3ad-ff98c08c23de"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("db595e1b-711e-4e4b-beb7-dc72e0908849"), new Guid("38b6f8cf-3ca0-4c3c-973a-2897b0ff5afc") },
                    { new Guid("c57f6cb1-3c8f-4500-94e2-bd69973894b7"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("db595e1b-711e-4e4b-beb7-dc72e0908849"), new Guid("6e9e3782-fe5b-407b-9f0b-364c2b572ad9") },
                    { new Guid("45799b4d-f308-4317-8416-55b98f0f298a"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("db595e1b-711e-4e4b-beb7-dc72e0908849"), new Guid("9dde7c2f-d092-4f90-a598-921156fdbf4d") },
                    { new Guid("508a91c6-f9ba-49f8-b9c2-9ddbb3fb8ab1"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("8d4a9610-a533-4bb1-842f-7fa03417fb1c"), new Guid("38b6f8cf-3ca0-4c3c-973a-2897b0ff5afc") },
                    { new Guid("52e611fc-88b8-4cc7-b7c0-80bd9bd83479"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("8d4a9610-a533-4bb1-842f-7fa03417fb1c"), new Guid("6cd8c432-1744-4f2d-9f26-3a98a5ce04f0") },
                    { new Guid("0ac66e78-a5b4-4b0e-9a4c-f2ce2fc39b9d"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("2898ddaa-9110-49dc-9a81-22f63fdd9482"), new Guid("38b6f8cf-3ca0-4c3c-973a-2897b0ff5afc") },
                    { new Guid("15e0a1c5-6ee8-4405-99af-a3c2a87c4f3a"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("2898ddaa-9110-49dc-9a81-22f63fdd9482"), new Guid("2a112722-8c4f-4917-8c5e-8e564fd36fdf") },
                    { new Guid("e41bba46-749c-415f-acb3-c14a75d042af"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("6a65a7f2-4c50-4938-b037-af9d98a9a97f"), new Guid("38b6f8cf-3ca0-4c3c-973a-2897b0ff5afc") },
                    { new Guid("c1af4ab0-895e-4b75-b3b9-82035cd72d5c"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("6a65a7f2-4c50-4938-b037-af9d98a9a97f"), new Guid("9dde7c2f-d092-4f90-a598-921156fdbf4d") },
                    { new Guid("11bcba15-041d-4b6a-aa5d-520fca72f4b6"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("60bc8a87-0e8d-46c7-b3a7-183acdfe57e5"), new Guid("38b6f8cf-3ca0-4c3c-973a-2897b0ff5afc") },
                    { new Guid("71a9838b-a461-435e-84f7-5fbd4c36d485"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("60bc8a87-0e8d-46c7-b3a7-183acdfe57e5"), new Guid("6e9e3782-fe5b-407b-9f0b-364c2b572ad9") },
                    { new Guid("590d447d-cb8d-41c4-bd5c-57e56b84a795"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("895bcdc2-de6e-49f1-be96-fe4acacd3008"), new Guid("38b6f8cf-3ca0-4c3c-973a-2897b0ff5afc") },
                    { new Guid("8445fd74-76c7-4cba-a417-128e3f4f4461"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("895bcdc2-de6e-49f1-be96-fe4acacd3008"), new Guid("24b6f142-139a-4734-a421-3ed9dd4ea3b7") },
                    { new Guid("361bff18-2f44-430a-991a-5b59194b566a"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("895bcdc2-de6e-49f1-be96-fe4acacd3008"), new Guid("a046c91b-e230-4a00-abc0-325fe87b10e4") },
                    { new Guid("73fd68cb-5ec8-40c9-b846-244f3b90ed40"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("745dd70d-7ecf-4205-8f6d-37917f624f2f"), new Guid("38b6f8cf-3ca0-4c3c-973a-2897b0ff5afc") },
                    { new Guid("66c07cbb-0ca4-4995-913f-5f162ba6eb7a"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("745dd70d-7ecf-4205-8f6d-37917f624f2f"), new Guid("810c17b0-3a74-43a3-aa8e-026afe4af9d5") },
                    { new Guid("6df864f3-3ae1-4de4-bed2-660a2a9732df"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("6cac5f82-f157-4a3a-b0f4-edd4d766b46e"), new Guid("38b6f8cf-3ca0-4c3c-973a-2897b0ff5afc") },
                    { new Guid("d6f159fd-90f0-4027-a7d7-d0f984b71aa7"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("6cac5f82-f157-4a3a-b0f4-edd4d766b46e"), new Guid("6dea04e5-0974-40e0-8480-ba307ce4f4f3") },
                    { new Guid("10323be0-7ff6-4ad1-8b10-44da88d8c31f"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("ef24bb7e-b43c-4f88-bb1d-801f88b5c9c1"), new Guid("38b6f8cf-3ca0-4c3c-973a-2897b0ff5afc") },
                    { new Guid("ef363178-3de4-48ea-91a7-894c04c32326"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("ef24bb7e-b43c-4f88-bb1d-801f88b5c9c1"), new Guid("24b6f142-139a-4734-a421-3ed9dd4ea3b7") }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Group_TourId",
                table: "Group",
                column: "TourId");

            migrationBuilder.CreateIndex(
                name: "IX_GroupCost_CostTypeId",
                table: "GroupCost",
                column: "CostTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_GroupCost_GroupId",
                table: "GroupCost",
                column: "GroupId");

            migrationBuilder.CreateIndex(
                name: "IX_GroupDetail_GroupId",
                table: "GroupDetail",
                column: "GroupId");

            migrationBuilder.CreateIndex(
                name: "IX_GroupDetail_UserId",
                table: "GroupDetail",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_StaffGroupRole_GroupId",
                table: "StaffGroupRole",
                column: "GroupId");

            migrationBuilder.CreateIndex(
                name: "IX_StaffGroupRole_GroupRoleId",
                table: "StaffGroupRole",
                column: "GroupRoleId");

            migrationBuilder.CreateIndex(
                name: "IX_StaffGroupRole_StaffId",
                table: "StaffGroupRole",
                column: "StaffId");

            migrationBuilder.CreateIndex(
                name: "IX_TourDetail_TourId",
                table: "TourDetail",
                column: "TourId");

            migrationBuilder.CreateIndex(
                name: "IX_TourDetail_TouristAttractionId",
                table: "TourDetail",
                column: "TouristAttractionId");

            migrationBuilder.CreateIndex(
                name: "IX_TourPrice_TourId",
                table: "TourPrice",
                column: "TourId");

            migrationBuilder.CreateIndex(
                name: "IX_Tours_TourCategoryId",
                table: "Tours",
                column: "TourCategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "GroupCost");

            migrationBuilder.DropTable(
                name: "GroupDetail");

            migrationBuilder.DropTable(
                name: "StaffGroupRole");

            migrationBuilder.DropTable(
                name: "TourDetail");

            migrationBuilder.DropTable(
                name: "TourPrice");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "CostType");

            migrationBuilder.DropTable(
                name: "Group");

            migrationBuilder.DropTable(
                name: "GroupRole");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "TouristAttraction");

            migrationBuilder.DropTable(
                name: "Tours");

            migrationBuilder.DropTable(
                name: "TourCategories");
        }
    }
}

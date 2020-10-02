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
                    { "1b7a74dd-f604-4626-b81a-9fada14a022e", "53b88bad-145d-491d-842a-9aaa82c4e76d", "Admin", "admin" },
                    { "c74345a4-4f09-413a-9724-ab1870764f44", "37a6fdd0-c027-49f1-9d58-d57105453d65", "SuperAdmin", "superadmin" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "9284cfe6-dbac-4246-8572-0675da367200", 0, "fefead00-04b1-4cdc-b6fc-d5a40e7e39f8", "lilsuperadmin@gmail.com", true, "Super Admin", "Lil", false, null, "LILSUPERADMIN@GMAIL.COM", "LILSUPERADMIN@GMAIL.COM", "AQAAAAEAACcQAAAAEDUQhsY7dPceoeG2g8ysiblRVApFfR5YWtk5LlWRtN+BKQV+PNDNBj2MyUYsWd60LA==", null, false, "", false, "lilsuperadmin@gmail.com" },
                    { "a4dc2e96-2f92-4fef-beb5-cb9ce701a635", 0, "a8f2d45b-89ba-4eee-ba0b-ded410e9f0ed", "yungadmin@gmail.com", true, "Admin", "Yung", false, null, "YUNGADMIN@GMAIL.COM", "YUNGADMIN@GMAIL.COM", "AQAAAAEAACcQAAAAEIHT9WbSNL1XLrg6i636D4+MuSCYMOEBDQzSeacTsBUt1c+8eWjoTPgr1hZdTj0vvw==", null, false, "", false, "yungadmin@gmail.com" }
                });

            migrationBuilder.InsertData(
                table: "TourCategories",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "IsDeleted", "LastModifiedAt", "LastModifiedBy", "Name" },
                values: new object[,]
                {
                    { new Guid("2e555cec-ffed-481a-994a-84066911607a"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Teambuilding" },
                    { new Guid("982df058-6bb1-4dbb-a5b5-8904a9f9aaad"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Du lịch xanh" },
                    { new Guid("08f4c33d-6794-4c20-bb80-6b4841f9271c"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Du lịch MICE" },
                    { new Guid("b079a901-ee32-4fce-8777-72cd55317931"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Du lịch văn hóa" },
                    { new Guid("3b4eb5c4-681c-467a-bace-fde3e377c315"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Du lịch tham quan" },
                    { new Guid("9ef92a73-4ce9-45e2-b282-90d9dfbd9ea2"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Du lịch ẩm thực" }
                });

            migrationBuilder.InsertData(
                table: "TouristAttraction",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "Description", "IsDeleted", "LastModifiedAt", "LastModifiedBy", "Name" },
                values: new object[,]
                {
                    { new Guid("38121cd0-a251-41c2-bb7f-e9bb5b49a793"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aenean dui est, fringilla eu urna non, rhoncus tristique urna. Phasellus sed mauris eu metus sollicitudin gravida. Aliquam ut molestie orci. Suspendisse nec quam ut massa rutrum ullamcorper non eu elit. Nam ligula sapien, placerat nec ligula et, maximus sagittis est. Maecenas et ex nec nunc sagittis aliquam vitae vitae neque. Ut ut malesuada sapien, tincidunt auctor elit. Quisque volutpat urna at posuere maximus. Nunc felis lectus, bibendum ut quam id, porttitor vehicula turpis. Sed ac efficitur risus. Proin feugiat sit amet dui vel tempor.Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aenean dui est, fringilla eu urna non, rhoncus tristique urna. Phasellus sed mauris eu metus sollicitudin gravida. Aliquam ut molestie orci. Suspendisse nec quam ut massa rutrum ullamcorper non eu elit. Nam ligula sapien, placerat nec ligula et, maximus sagittis est. Maecenas et ex nec nunc sagittis aliquam vitae vitae neque. Ut ut malesuada sapien, tincidunt auctor elit. Quisque volutpat urna at posuere maximus. Nunc felis lectus, bibendum ut quam id, porttitor vehicula turpis. Sed ac efficitur risus. Proin feugiat sit amet dui vel tempor.", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Miền Tây" },
                    { new Guid("91201504-0f98-4e0b-a44a-8846d57538cf"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aenean dui est, fringilla eu urna non, rhoncus tristique urna. Phasellus sed mauris eu metus sollicitudin gravida. Aliquam ut molestie orci. Suspendisse nec quam ut massa rutrum ullamcorper non eu elit. Nam ligula sapien, placerat nec ligula et, maximus sagittis est. Maecenas et ex nec nunc sagittis aliquam vitae vitae neque. Ut ut malesuada sapien, tincidunt auctor elit. Quisque volutpat urna at posuere maximus. Nunc felis lectus, bibendum ut quam id, porttitor vehicula turpis. Sed ac efficitur risus. Proin feugiat sit amet dui vel tempor.Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aenean dui est, fringilla eu urna non, rhoncus tristique urna. Phasellus sed mauris eu metus sollicitudin gravida. Aliquam ut molestie orci. Suspendisse nec quam ut massa rutrum ullamcorper non eu elit. Nam ligula sapien, placerat nec ligula et, maximus sagittis est. Maecenas et ex nec nunc sagittis aliquam vitae vitae neque. Ut ut malesuada sapien, tincidunt auctor elit. Quisque volutpat urna at posuere maximus. Nunc felis lectus, bibendum ut quam id, porttitor vehicula turpis. Sed ac efficitur risus. Proin feugiat sit amet dui vel tempor.", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Phú Quốc" },
                    { new Guid("1bc6dcc9-2027-4262-8716-8ec5e021c914"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aenean dui est, fringilla eu urna non, rhoncus tristique urna. Phasellus sed mauris eu metus sollicitudin gravida. Aliquam ut molestie orci. Suspendisse nec quam ut massa rutrum ullamcorper non eu elit. Nam ligula sapien, placerat nec ligula et, maximus sagittis est. Maecenas et ex nec nunc sagittis aliquam vitae vitae neque. Ut ut malesuada sapien, tincidunt auctor elit. Quisque volutpat urna at posuere maximus. Nunc felis lectus, bibendum ut quam id, porttitor vehicula turpis. Sed ac efficitur risus. Proin feugiat sit amet dui vel tempor.Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aenean dui est, fringilla eu urna non, rhoncus tristique urna. Phasellus sed mauris eu metus sollicitudin gravida. Aliquam ut molestie orci. Suspendisse nec quam ut massa rutrum ullamcorper non eu elit. Nam ligula sapien, placerat nec ligula et, maximus sagittis est. Maecenas et ex nec nunc sagittis aliquam vitae vitae neque. Ut ut malesuada sapien, tincidunt auctor elit. Quisque volutpat urna at posuere maximus. Nunc felis lectus, bibendum ut quam id, porttitor vehicula turpis. Sed ac efficitur risus. Proin feugiat sit amet dui vel tempor.", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Hồ Tràm" },
                    { new Guid("003f5b27-d983-41ba-a49f-9ace955ed459"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aenean dui est, fringilla eu urna non, rhoncus tristique urna. Phasellus sed mauris eu metus sollicitudin gravida. Aliquam ut molestie orci. Suspendisse nec quam ut massa rutrum ullamcorper non eu elit. Nam ligula sapien, placerat nec ligula et, maximus sagittis est. Maecenas et ex nec nunc sagittis aliquam vitae vitae neque. Ut ut malesuada sapien, tincidunt auctor elit. Quisque volutpat urna at posuere maximus. Nunc felis lectus, bibendum ut quam id, porttitor vehicula turpis. Sed ac efficitur risus. Proin feugiat sit amet dui vel tempor.Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aenean dui est, fringilla eu urna non, rhoncus tristique urna. Phasellus sed mauris eu metus sollicitudin gravida. Aliquam ut molestie orci. Suspendisse nec quam ut massa rutrum ullamcorper non eu elit. Nam ligula sapien, placerat nec ligula et, maximus sagittis est. Maecenas et ex nec nunc sagittis aliquam vitae vitae neque. Ut ut malesuada sapien, tincidunt auctor elit. Quisque volutpat urna at posuere maximus. Nunc felis lectus, bibendum ut quam id, porttitor vehicula turpis. Sed ac efficitur risus. Proin feugiat sit amet dui vel tempor.", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Hạ Long" },
                    { new Guid("6cfe1db5-e777-4953-b76d-68ca1f829836"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aenean dui est, fringilla eu urna non, rhoncus tristique urna. Phasellus sed mauris eu metus sollicitudin gravida. Aliquam ut molestie orci. Suspendisse nec quam ut massa rutrum ullamcorper non eu elit. Nam ligula sapien, placerat nec ligula et, maximus sagittis est. Maecenas et ex nec nunc sagittis aliquam vitae vitae neque. Ut ut malesuada sapien, tincidunt auctor elit. Quisque volutpat urna at posuere maximus. Nunc felis lectus, bibendum ut quam id, porttitor vehicula turpis. Sed ac efficitur risus. Proin feugiat sit amet dui vel tempor.Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aenean dui est, fringilla eu urna non, rhoncus tristique urna. Phasellus sed mauris eu metus sollicitudin gravida. Aliquam ut molestie orci. Suspendisse nec quam ut massa rutrum ullamcorper non eu elit. Nam ligula sapien, placerat nec ligula et, maximus sagittis est. Maecenas et ex nec nunc sagittis aliquam vitae vitae neque. Ut ut malesuada sapien, tincidunt auctor elit. Quisque volutpat urna at posuere maximus. Nunc felis lectus, bibendum ut quam id, porttitor vehicula turpis. Sed ac efficitur risus. Proin feugiat sit amet dui vel tempor.", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Phan Thiết" },
                    { new Guid("f5a6dab5-f91c-47d6-abef-a1bec571e425"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aenean dui est, fringilla eu urna non, rhoncus tristique urna. Phasellus sed mauris eu metus sollicitudin gravida. Aliquam ut molestie orci. Suspendisse nec quam ut massa rutrum ullamcorper non eu elit. Nam ligula sapien, placerat nec ligula et, maximus sagittis est. Maecenas et ex nec nunc sagittis aliquam vitae vitae neque. Ut ut malesuada sapien, tincidunt auctor elit. Quisque volutpat urna at posuere maximus. Nunc felis lectus, bibendum ut quam id, porttitor vehicula turpis. Sed ac efficitur risus. Proin feugiat sit amet dui vel tempor.Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aenean dui est, fringilla eu urna non, rhoncus tristique urna. Phasellus sed mauris eu metus sollicitudin gravida. Aliquam ut molestie orci. Suspendisse nec quam ut massa rutrum ullamcorper non eu elit. Nam ligula sapien, placerat nec ligula et, maximus sagittis est. Maecenas et ex nec nunc sagittis aliquam vitae vitae neque. Ut ut malesuada sapien, tincidunt auctor elit. Quisque volutpat urna at posuere maximus. Nunc felis lectus, bibendum ut quam id, porttitor vehicula turpis. Sed ac efficitur risus. Proin feugiat sit amet dui vel tempor.", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "ĐBSCL" },
                    { new Guid("9390690b-bb79-4553-9578-65882a4d27d2"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aenean dui est, fringilla eu urna non, rhoncus tristique urna. Phasellus sed mauris eu metus sollicitudin gravida. Aliquam ut molestie orci. Suspendisse nec quam ut massa rutrum ullamcorper non eu elit. Nam ligula sapien, placerat nec ligula et, maximus sagittis est. Maecenas et ex nec nunc sagittis aliquam vitae vitae neque. Ut ut malesuada sapien, tincidunt auctor elit. Quisque volutpat urna at posuere maximus. Nunc felis lectus, bibendum ut quam id, porttitor vehicula turpis. Sed ac efficitur risus. Proin feugiat sit amet dui vel tempor.Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aenean dui est, fringilla eu urna non, rhoncus tristique urna. Phasellus sed mauris eu metus sollicitudin gravida. Aliquam ut molestie orci. Suspendisse nec quam ut massa rutrum ullamcorper non eu elit. Nam ligula sapien, placerat nec ligula et, maximus sagittis est. Maecenas et ex nec nunc sagittis aliquam vitae vitae neque. Ut ut malesuada sapien, tincidunt auctor elit. Quisque volutpat urna at posuere maximus. Nunc felis lectus, bibendum ut quam id, porttitor vehicula turpis. Sed ac efficitur risus. Proin feugiat sit amet dui vel tempor.", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Đông Bắc" },
                    { new Guid("ebff6f43-b2b5-43e2-8f60-6b95fb587be9"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aenean dui est, fringilla eu urna non, rhoncus tristique urna. Phasellus sed mauris eu metus sollicitudin gravida. Aliquam ut molestie orci. Suspendisse nec quam ut massa rutrum ullamcorper non eu elit. Nam ligula sapien, placerat nec ligula et, maximus sagittis est. Maecenas et ex nec nunc sagittis aliquam vitae vitae neque. Ut ut malesuada sapien, tincidunt auctor elit. Quisque volutpat urna at posuere maximus. Nunc felis lectus, bibendum ut quam id, porttitor vehicula turpis. Sed ac efficitur risus. Proin feugiat sit amet dui vel tempor.Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aenean dui est, fringilla eu urna non, rhoncus tristique urna. Phasellus sed mauris eu metus sollicitudin gravida. Aliquam ut molestie orci. Suspendisse nec quam ut massa rutrum ullamcorper non eu elit. Nam ligula sapien, placerat nec ligula et, maximus sagittis est. Maecenas et ex nec nunc sagittis aliquam vitae vitae neque. Ut ut malesuada sapien, tincidunt auctor elit. Quisque volutpat urna at posuere maximus. Nunc felis lectus, bibendum ut quam id, porttitor vehicula turpis. Sed ac efficitur risus. Proin feugiat sit amet dui vel tempor.", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Sapa" },
                    { new Guid("6e229ebf-7dd4-4a67-b075-d2c2893365d4"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aenean dui est, fringilla eu urna non, rhoncus tristique urna. Phasellus sed mauris eu metus sollicitudin gravida. Aliquam ut molestie orci. Suspendisse nec quam ut massa rutrum ullamcorper non eu elit. Nam ligula sapien, placerat nec ligula et, maximus sagittis est. Maecenas et ex nec nunc sagittis aliquam vitae vitae neque. Ut ut malesuada sapien, tincidunt auctor elit. Quisque volutpat urna at posuere maximus. Nunc felis lectus, bibendum ut quam id, porttitor vehicula turpis. Sed ac efficitur risus. Proin feugiat sit amet dui vel tempor.Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aenean dui est, fringilla eu urna non, rhoncus tristique urna. Phasellus sed mauris eu metus sollicitudin gravida. Aliquam ut molestie orci. Suspendisse nec quam ut massa rutrum ullamcorper non eu elit. Nam ligula sapien, placerat nec ligula et, maximus sagittis est. Maecenas et ex nec nunc sagittis aliquam vitae vitae neque. Ut ut malesuada sapien, tincidunt auctor elit. Quisque volutpat urna at posuere maximus. Nunc felis lectus, bibendum ut quam id, porttitor vehicula turpis. Sed ac efficitur risus. Proin feugiat sit amet dui vel tempor.", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Nha Trang" },
                    { new Guid("52570086-d700-41bf-a943-fde72be03d1e"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aenean dui est, fringilla eu urna non, rhoncus tristique urna. Phasellus sed mauris eu metus sollicitudin gravida. Aliquam ut molestie orci. Suspendisse nec quam ut massa rutrum ullamcorper non eu elit. Nam ligula sapien, placerat nec ligula et, maximus sagittis est. Maecenas et ex nec nunc sagittis aliquam vitae vitae neque. Ut ut malesuada sapien, tincidunt auctor elit. Quisque volutpat urna at posuere maximus. Nunc felis lectus, bibendum ut quam id, porttitor vehicula turpis. Sed ac efficitur risus. Proin feugiat sit amet dui vel tempor.Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aenean dui est, fringilla eu urna non, rhoncus tristique urna. Phasellus sed mauris eu metus sollicitudin gravida. Aliquam ut molestie orci. Suspendisse nec quam ut massa rutrum ullamcorper non eu elit. Nam ligula sapien, placerat nec ligula et, maximus sagittis est. Maecenas et ex nec nunc sagittis aliquam vitae vitae neque. Ut ut malesuada sapien, tincidunt auctor elit. Quisque volutpat urna at posuere maximus. Nunc felis lectus, bibendum ut quam id, porttitor vehicula turpis. Sed ac efficitur risus. Proin feugiat sit amet dui vel tempor.", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Đà Lạt" },
                    { new Guid("78fa82c4-95f0-42cf-a91a-4ad42e04adbf"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aenean dui est, fringilla eu urna non, rhoncus tristique urna. Phasellus sed mauris eu metus sollicitudin gravida. Aliquam ut molestie orci. Suspendisse nec quam ut massa rutrum ullamcorper non eu elit. Nam ligula sapien, placerat nec ligula et, maximus sagittis est. Maecenas et ex nec nunc sagittis aliquam vitae vitae neque. Ut ut malesuada sapien, tincidunt auctor elit. Quisque volutpat urna at posuere maximus. Nunc felis lectus, bibendum ut quam id, porttitor vehicula turpis. Sed ac efficitur risus. Proin feugiat sit amet dui vel tempor.Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aenean dui est, fringilla eu urna non, rhoncus tristique urna. Phasellus sed mauris eu metus sollicitudin gravida. Aliquam ut molestie orci. Suspendisse nec quam ut massa rutrum ullamcorper non eu elit. Nam ligula sapien, placerat nec ligula et, maximus sagittis est. Maecenas et ex nec nunc sagittis aliquam vitae vitae neque. Ut ut malesuada sapien, tincidunt auctor elit. Quisque volutpat urna at posuere maximus. Nunc felis lectus, bibendum ut quam id, porttitor vehicula turpis. Sed ac efficitur risus. Proin feugiat sit amet dui vel tempor.", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Ninh Bình" },
                    { new Guid("30b9c351-4348-477d-b4d7-2226f5a8f409"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aenean dui est, fringilla eu urna non, rhoncus tristique urna. Phasellus sed mauris eu metus sollicitudin gravida. Aliquam ut molestie orci. Suspendisse nec quam ut massa rutrum ullamcorper non eu elit. Nam ligula sapien, placerat nec ligula et, maximus sagittis est. Maecenas et ex nec nunc sagittis aliquam vitae vitae neque. Ut ut malesuada sapien, tincidunt auctor elit. Quisque volutpat urna at posuere maximus. Nunc felis lectus, bibendum ut quam id, porttitor vehicula turpis. Sed ac efficitur risus. Proin feugiat sit amet dui vel tempor.Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aenean dui est, fringilla eu urna non, rhoncus tristique urna. Phasellus sed mauris eu metus sollicitudin gravida. Aliquam ut molestie orci. Suspendisse nec quam ut massa rutrum ullamcorper non eu elit. Nam ligula sapien, placerat nec ligula et, maximus sagittis est. Maecenas et ex nec nunc sagittis aliquam vitae vitae neque. Ut ut malesuada sapien, tincidunt auctor elit. Quisque volutpat urna at posuere maximus. Nunc felis lectus, bibendum ut quam id, porttitor vehicula turpis. Sed ac efficitur risus. Proin feugiat sit amet dui vel tempor.", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Đắk Nông" },
                    { new Guid("6568c656-09a7-4d39-8610-a206e5b5b4bf"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aenean dui est, fringilla eu urna non, rhoncus tristique urna. Phasellus sed mauris eu metus sollicitudin gravida. Aliquam ut molestie orci. Suspendisse nec quam ut massa rutrum ullamcorper non eu elit. Nam ligula sapien, placerat nec ligula et, maximus sagittis est. Maecenas et ex nec nunc sagittis aliquam vitae vitae neque. Ut ut malesuada sapien, tincidunt auctor elit. Quisque volutpat urna at posuere maximus. Nunc felis lectus, bibendum ut quam id, porttitor vehicula turpis. Sed ac efficitur risus. Proin feugiat sit amet dui vel tempor.Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aenean dui est, fringilla eu urna non, rhoncus tristique urna. Phasellus sed mauris eu metus sollicitudin gravida. Aliquam ut molestie orci. Suspendisse nec quam ut massa rutrum ullamcorper non eu elit. Nam ligula sapien, placerat nec ligula et, maximus sagittis est. Maecenas et ex nec nunc sagittis aliquam vitae vitae neque. Ut ut malesuada sapien, tincidunt auctor elit. Quisque volutpat urna at posuere maximus. Nunc felis lectus, bibendum ut quam id, porttitor vehicula turpis. Sed ac efficitur risus. Proin feugiat sit amet dui vel tempor.", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Hà Nội" },
                    { new Guid("0903e245-e702-4f0b-971a-f22d552c9e82"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aenean dui est, fringilla eu urna non, rhoncus tristique urna. Phasellus sed mauris eu metus sollicitudin gravida. Aliquam ut molestie orci. Suspendisse nec quam ut massa rutrum ullamcorper non eu elit. Nam ligula sapien, placerat nec ligula et, maximus sagittis est. Maecenas et ex nec nunc sagittis aliquam vitae vitae neque. Ut ut malesuada sapien, tincidunt auctor elit. Quisque volutpat urna at posuere maximus. Nunc felis lectus, bibendum ut quam id, porttitor vehicula turpis. Sed ac efficitur risus. Proin feugiat sit amet dui vel tempor.Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aenean dui est, fringilla eu urna non, rhoncus tristique urna. Phasellus sed mauris eu metus sollicitudin gravida. Aliquam ut molestie orci. Suspendisse nec quam ut massa rutrum ullamcorper non eu elit. Nam ligula sapien, placerat nec ligula et, maximus sagittis est. Maecenas et ex nec nunc sagittis aliquam vitae vitae neque. Ut ut malesuada sapien, tincidunt auctor elit. Quisque volutpat urna at posuere maximus. Nunc felis lectus, bibendum ut quam id, porttitor vehicula turpis. Sed ac efficitur risus. Proin feugiat sit amet dui vel tempor.", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "TP. Hồ Chí Minh " },
                    { new Guid("f5ce1488-f02b-40bb-a197-6994f967e182"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aenean dui est, fringilla eu urna non, rhoncus tristique urna. Phasellus sed mauris eu metus sollicitudin gravida. Aliquam ut molestie orci. Suspendisse nec quam ut massa rutrum ullamcorper non eu elit. Nam ligula sapien, placerat nec ligula et, maximus sagittis est. Maecenas et ex nec nunc sagittis aliquam vitae vitae neque. Ut ut malesuada sapien, tincidunt auctor elit. Quisque volutpat urna at posuere maximus. Nunc felis lectus, bibendum ut quam id, porttitor vehicula turpis. Sed ac efficitur risus. Proin feugiat sit amet dui vel tempor.Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aenean dui est, fringilla eu urna non, rhoncus tristique urna. Phasellus sed mauris eu metus sollicitudin gravida. Aliquam ut molestie orci. Suspendisse nec quam ut massa rutrum ullamcorper non eu elit. Nam ligula sapien, placerat nec ligula et, maximus sagittis est. Maecenas et ex nec nunc sagittis aliquam vitae vitae neque. Ut ut malesuada sapien, tincidunt auctor elit. Quisque volutpat urna at posuere maximus. Nunc felis lectus, bibendum ut quam id, porttitor vehicula turpis. Sed ac efficitur risus. Proin feugiat sit amet dui vel tempor.", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Tây Nguyên" },
                    { new Guid("af459420-b316-4e25-9968-4774f20b157c"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aenean dui est, fringilla eu urna non, rhoncus tristique urna. Phasellus sed mauris eu metus sollicitudin gravida. Aliquam ut molestie orci. Suspendisse nec quam ut massa rutrum ullamcorper non eu elit. Nam ligula sapien, placerat nec ligula et, maximus sagittis est. Maecenas et ex nec nunc sagittis aliquam vitae vitae neque. Ut ut malesuada sapien, tincidunt auctor elit. Quisque volutpat urna at posuere maximus. Nunc felis lectus, bibendum ut quam id, porttitor vehicula turpis. Sed ac efficitur risus. Proin feugiat sit amet dui vel tempor.Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aenean dui est, fringilla eu urna non, rhoncus tristique urna. Phasellus sed mauris eu metus sollicitudin gravida. Aliquam ut molestie orci. Suspendisse nec quam ut massa rutrum ullamcorper non eu elit. Nam ligula sapien, placerat nec ligula et, maximus sagittis est. Maecenas et ex nec nunc sagittis aliquam vitae vitae neque. Ut ut malesuada sapien, tincidunt auctor elit. Quisque volutpat urna at posuere maximus. Nunc felis lectus, bibendum ut quam id, porttitor vehicula turpis. Sed ac efficitur risus. Proin feugiat sit amet dui vel tempor.", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Tây Ninh" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[,]
                {
                    { "9284cfe6-dbac-4246-8572-0675da367200", "c74345a4-4f09-413a-9724-ab1870764f44" },
                    { "a4dc2e96-2f92-4fef-beb5-cb9ce701a635", "1b7a74dd-f604-4626-b81a-9fada14a022e" }
                });

            migrationBuilder.InsertData(
                table: "Tours",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "IsDeleted", "LastModifiedAt", "LastModifiedBy", "Name", "Price", "Specification", "Status", "TourCategoryId" },
                values: new object[,]
                {
                    { new Guid("fe6058f5-ce44-4bdf-b87a-91af79a3ac59"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Du lịch Bảo Lộc - Hồ Tà Đùng - Đắk Nông - Khu Bảo Tồn Thiên Nhiên Nậm Nung", 2679000.0, @"Thời gian: 3 ngày 2 đêm Phương tiện: Đi về bằng xesản xuất trà và đồi chè Tâm Châu.
                 Dừng...", 1, new Guid("982df058-6bb1-4dbb-a5b5-8904a9f9aaad") },
                    { new Guid("376c5782-7e49-42ae-97e6-976b00d9598b"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Du lịch Đà Lạt - Hồ Tuyền Lâm - Đường Hầm Điêu Khắc", 2379000.0, "Thời gian: 3 ngày 2 đêm Phương tiện: Đi về bằng xem điêu khắc đất đỏ (Đà Lạt Star)  tái hiện...", 1, new Guid("982df058-6bb1-4dbb-a5b5-8904a9f9aaad") },
                    { new Guid("9dba882d-f0c3-47bc-90a4-0b2c06f87440"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Du lịch Phú Quốc [Suối Tranh - Tặng Vé Cáp Treo Vượt Biển & Công Viên Nước  Hòn Thơm]", 3879000.0, "Thời gian: 3 ngày 2 đêm Phương tiện: Hàng không Vietnam Airlinesnh  quý khách có thể đi dạo trong rừng, thư...", 1, new Guid("982df058-6bb1-4dbb-a5b5-8904a9f9aaad") },
                    { new Guid("9138a5c4-0229-43e1-a606-61b837a9e5bc"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Du lịch [Mùa Hoa Tam Giác Mạch] tại Hà Giang - Đồng Văn - Cao Bằng - Thác Bản Giốc - Pác Pó - Ba Bể", 9079000.0, "Thời gian: 6 ngày 5 đêm Phương tiện: Hàng không Vietnam Airlines Đồng Văn  Công viên địa chất toàn cầu....", 1, new Guid("9ef92a73-4ce9-45e2-b282-90d9dfbd9ea2") },
                    { new Guid("9157e1e2-e37a-496d-900f-2b71cc2b38b2"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Du lịch Đà Lạt - Thác Datanla - Đồi Chè Cầu Đất -Trang Trại Rau & Hoa - Thác Dambri", 3079000.0, "Thời gian: 4 ngày 3 đêm Phương tiện: Đi về bằng xebri  ngọn thác hùng vĩ tại cao nguyên Bảo Lộc...", 1, new Guid("9ef92a73-4ce9-45e2-b282-90d9dfbd9ea2") },
                    { new Guid("b72592a9-1a1b-4ecd-b206-733977b4939d"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Du lịch Hồ Tràm - Trải nghiệm đẳng cấp 5 sao The Grand Ho Tram Strip", 2379000.0, "Thời gian: 2 ngày 1 đêm Phương tiện: Đi về bằng xeụ 5 sao cao cấp tại The Grand Ho Tram Strip...", 1, new Guid("9ef92a73-4ce9-45e2-b282-90d9dfbd9ea2") },
                    { new Guid("c535c763-85da-4196-ab25-a686055227c9"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Du lịch Phan Thiết - Mũi Né - Làng Chài Xưa", 2379000.0, "Thời gian: 3 ngày 2 đêm Phương tiện: Đi về bằng xevàng dưới tác động của gió biển đã tạo nên...", 1, new Guid("9ef92a73-4ce9-45e2-b282-90d9dfbd9ea2") },
                    { new Guid("bcc47d7e-a324-4044-aaa9-161f64f36414"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Du lịch [mùa nước nổi] Cầu Cao Lãnh - Châu Đốc - Làng Cá Bè  - Rừng Tràm Trà Sư", 1979000.0, @"Thời gian: 2 ngày 1 đêm Phương tiện: Đi về bằng xe Xứ nổi tiếng hiển linh.
                 Tham quan Rừng Tràm...", 1, new Guid("9ef92a73-4ce9-45e2-b282-90d9dfbd9ea2") },
                    { new Guid("a2e2d574-44a5-4eba-9deb-60f766c88291"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Du lịch Mỹ Tho - Cần Thơ - Cà Mau - Bạc Liêu - Sóc Trăng", 3879000.0, "Thời gian: 4 ngày 3 đêm Phương tiện: Đi về bằng xethức trái cây theo mùa, nghe nhạc tài tử Nam...", 1, new Guid("b079a901-ee32-4fce-8777-72cd55317931") },
                    { new Guid("9a3e086f-5d7c-4dc9-a040-2ec60c7bf120"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Du lịch Hà Nội - Lào Cai - Sapa - Hạ Long", 7129000.0, @"Thời gian: 5 ngày 4 đêm Phương tiện: Hàng không Vietnam Airlinesn Cát Cát, ngắm toàn bộ cảnh Sapa từ Sân Mây
                ...", 1, new Guid("b079a901-ee32-4fce-8777-72cd55317931") },
                    { new Guid("7bb01144-6be2-48bb-80a6-700a55cd0f6f"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Du lịch Phan Thiết - Mũi Né - Lâu Đài Rượu Vang", 2739000.0, @"Thời gian: 3 ngày 2 đêm Phương tiện: Đi về bằng xean trưng bày nghệ thuật “Làng chài xưa”
                 Chụp hình...", 1, new Guid("b079a901-ee32-4fce-8777-72cd55317931") },
                    { new Guid("5250eec9-3e57-4e15-a24e-47ac4cc313d1"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Du lịch khám phá Cái Bè - Cần Thơ - Châu Đốc - Hà Tiên", 3679000.0, "Thời gian: 4 ngày 3 đêm Phương tiện: Đi về bằng xeNam bộ hơn trăm năm tuổi, theo lối kiến trúc...", 1, new Guid("b079a901-ee32-4fce-8777-72cd55317931") },
                    { new Guid("30a47133-e9d6-4cee-ac57-edac840f212e"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Du lịch Đà Lạt - Dambri - Đường Hầm Điêu Khắc - Langbiang", 3079000.0, "Thời gian: 4 ngày 3 đêm Phương tiện: Đi về bằng xeường Lâm Viên với không gian rộng lớn, thoáng mát hướng...", 1, new Guid("b079a901-ee32-4fce-8777-72cd55317931") },
                    { new Guid("8d30e8c3-eec8-4964-b055-92d9e7a885eb"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Du lịch Nha Trang - Hòn Lao - Dốc Lết - I Resort - Làng Yến Mai Sinh", 2979000.0, "Thời gian: 4 ngày 3 đêm Phương tiện: Đi về bằng xeịch Hòn Lao  đảo Khỉ, khu du lịch sinh...", 1, new Guid("3b4eb5c4-681c-467a-bace-fde3e377c315") },
                    { new Guid("46dc3e61-38ec-4840-81cf-4fab1742620f"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Du lịch [Mùa Hoa Tam Giác Mạch] Hà Giang - Đồng Văn - Cao Bằng - Thác Bản Giốc- Lạng Sơn", 7529000.0, "Thời gian: 5 ngày 4 đêm Phương tiện: Hàng không Vietnam Airlines Thanh  ngắm núi Tô Thị Vượt đèo Mã...", 1, new Guid("3b4eb5c4-681c-467a-bace-fde3e377c315") },
                    { new Guid("94098cf4-10c5-41fa-80c7-dabfd553d197"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Du lịch Buôn Ma Thuột - Buôn Đôn - Pleiku - Komtum", 4879000.0, @"Thời gian: 5 ngày 4 đêm Phương tiện: Đi về bằng xeay Nur hùng vĩ.
                 Tham quan cầu treo và ngắm...", 1, new Guid("3b4eb5c4-681c-467a-bace-fde3e377c315") },
                    { new Guid("73c5e6f2-6efa-47de-814a-0d126028b3a6"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Du lịch Nha Trang - Đà Lạt", 4279000.0, "Thời gian: 5 ngày 4 đêm Phương tiện: Đi về bằng xeVân hay còn gọi là Chùa Ốc, ngôi chùa làm...", 1, new Guid("3b4eb5c4-681c-467a-bace-fde3e377c315") },
                    { new Guid("b2a25863-1397-44f5-b714-51062a80e2b3"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Du lịch Hải Phòng - Hạ Long - Ninh Bình - Hà Nội - Lào Cai - Sapa - Đền Hùng", 8029000.0, "Thời gian: 6 ngày 5 đêm Phương tiện: Hàng không Vietnam Airlines Thăm quần thể di tích Bạch Đằng Giang với đền thờ các vị anh...A", 1, new Guid("3b4eb5c4-681c-467a-bace-fde3e377c315") },
                    { new Guid("d0d74687-9c9f-4f2a-8869-a9b5eea424d0"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Du lịch Tây Ninh - Tòa Thánh Tây Ninh - Núi Bà Đen - Hồ Dầu Tiếng", 1879000.0, "Thời gian: 2 ngày 1 đêm Phương tiện: Đi về bằng xeĐen ngon núi cao nhất Đông Nam Bộ&nbsp; chỉ mất...", 1, new Guid("982df058-6bb1-4dbb-a5b5-8904a9f9aaad") },
                    { new Guid("31a5d5a4-8457-4933-bd31-a44986a9fea2"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Du lịch [Mùa nước nổi] Cao Lãnh - Tràm Chim Tam Nông - Khu Du Lịch Đồng Sen", 1779000.0, "Thời gian: 2 ngày 1 đêm Viếng Khu Di tích Cụ Nguyễn Sinh Sắc (nhà sàn Bác Hồ, khu Lăng...", 1, new Guid("982df058-6bb1-4dbb-a5b5-8904a9f9aaad") }
                });

            migrationBuilder.InsertData(
                table: "TourDetail",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "IsDeleted", "LastModifiedAt", "LastModifiedBy", "TourId", "TouristAttractionId" },
                values: new object[,]
                {
                    { new Guid("4ed9aacf-17ab-443e-a77d-a9a5962925dc"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("b2a25863-1397-44f5-b714-51062a80e2b3"), new Guid("0903e245-e702-4f0b-971a-f22d552c9e82") },
                    { new Guid("120bb22b-c685-48c6-bff2-4b9a4d574e26"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("a2e2d574-44a5-4eba-9deb-60f766c88291"), new Guid("f5a6dab5-f91c-47d6-abef-a1bec571e425") },
                    { new Guid("0f30ce4b-1ac6-4e3c-b93f-149111a530c8"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("bcc47d7e-a324-4044-aaa9-161f64f36414"), new Guid("0903e245-e702-4f0b-971a-f22d552c9e82") },
                    { new Guid("0eb6ae88-3182-40a3-9057-5d3ffd1d58bb"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("bcc47d7e-a324-4044-aaa9-161f64f36414"), new Guid("38121cd0-a251-41c2-bb7f-e9bb5b49a793") },
                    { new Guid("01274586-48d5-4409-8c1e-af23ed9262e0"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("bcc47d7e-a324-4044-aaa9-161f64f36414"), new Guid("f5a6dab5-f91c-47d6-abef-a1bec571e425") },
                    { new Guid("197b9ee7-b8f4-42f5-929e-8591465672e1"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("c535c763-85da-4196-ab25-a686055227c9"), new Guid("0903e245-e702-4f0b-971a-f22d552c9e82") },
                    { new Guid("5c937149-efba-4dec-be8e-d8ab951e7c18"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("c535c763-85da-4196-ab25-a686055227c9"), new Guid("6cfe1db5-e777-4953-b76d-68ca1f829836") },
                    { new Guid("dacb0852-4ae8-4f76-994c-350a91f72d5e"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("b72592a9-1a1b-4ecd-b206-733977b4939d"), new Guid("0903e245-e702-4f0b-971a-f22d552c9e82") },
                    { new Guid("91579cc2-153d-4dfc-baac-3b32e13468ce"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("b72592a9-1a1b-4ecd-b206-733977b4939d"), new Guid("1bc6dcc9-2027-4262-8716-8ec5e021c914") },
                    { new Guid("5a400597-e594-45cb-8c73-5a19cc874bee"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("9157e1e2-e37a-496d-900f-2b71cc2b38b2"), new Guid("0903e245-e702-4f0b-971a-f22d552c9e82") },
                    { new Guid("617a3960-6926-4122-804c-f920e4a9a21b"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("a2e2d574-44a5-4eba-9deb-60f766c88291"), new Guid("38121cd0-a251-41c2-bb7f-e9bb5b49a793") },
                    { new Guid("388d093f-7cc8-474e-9105-bf9c7bddc9a7"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("9157e1e2-e37a-496d-900f-2b71cc2b38b2"), new Guid("52570086-d700-41bf-a943-fde72be03d1e") },
                    { new Guid("b0c21144-451a-4915-a99d-69e0d99b77d3"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("9138a5c4-0229-43e1-a606-61b837a9e5bc"), new Guid("9390690b-bb79-4553-9578-65882a4d27d2") },
                    { new Guid("ba7037c1-f9c3-4cd0-9bb0-33af43f3ab20"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("9dba882d-f0c3-47bc-90a4-0b2c06f87440"), new Guid("0903e245-e702-4f0b-971a-f22d552c9e82") },
                    { new Guid("42fed441-f1ec-438d-8d6c-d16ec866ffef"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("9dba882d-f0c3-47bc-90a4-0b2c06f87440"), new Guid("91201504-0f98-4e0b-a44a-8846d57538cf") },
                    { new Guid("cf94cc0a-cdca-4ead-ad5f-3fb3ea444a50"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("376c5782-7e49-42ae-97e6-976b00d9598b"), new Guid("0903e245-e702-4f0b-971a-f22d552c9e82") },
                    { new Guid("2fdc4c32-f9c5-455f-b368-3687a5a90263"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("376c5782-7e49-42ae-97e6-976b00d9598b"), new Guid("52570086-d700-41bf-a943-fde72be03d1e") },
                    { new Guid("0136bc13-17a4-4259-9727-b0118bf75de0"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("fe6058f5-ce44-4bdf-b87a-91af79a3ac59"), new Guid("0903e245-e702-4f0b-971a-f22d552c9e82") },
                    { new Guid("6b1d7786-c264-4230-9e57-b6007770b328"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("fe6058f5-ce44-4bdf-b87a-91af79a3ac59"), new Guid("30b9c351-4348-477d-b4d7-2226f5a8f409") },
                    { new Guid("2833dd27-a5f6-4f78-a9f6-765bd5a4a4ab"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("d0d74687-9c9f-4f2a-8869-a9b5eea424d0"), new Guid("0903e245-e702-4f0b-971a-f22d552c9e82") },
                    { new Guid("26a9d75c-f925-4150-af57-5801545f7b02"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("d0d74687-9c9f-4f2a-8869-a9b5eea424d0"), new Guid("af459420-b316-4e25-9968-4774f20b157c") },
                    { new Guid("9f0e34d0-76e4-473d-8132-f13c5c5c552b"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("9138a5c4-0229-43e1-a606-61b837a9e5bc"), new Guid("0903e245-e702-4f0b-971a-f22d552c9e82") },
                    { new Guid("c70c1330-dec0-4cb3-8a0d-094132780da5"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("a2e2d574-44a5-4eba-9deb-60f766c88291"), new Guid("0903e245-e702-4f0b-971a-f22d552c9e82") },
                    { new Guid("9724f258-a02c-4d2d-bcf2-b4e863ca4aab"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("9a3e086f-5d7c-4dc9-a040-2ec60c7bf120"), new Guid("ebff6f43-b2b5-43e2-8f60-6b95fb587be9") },
                    { new Guid("0c864aab-d726-47f5-8b4b-9f702b60db5b"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("9a3e086f-5d7c-4dc9-a040-2ec60c7bf120"), new Guid("003f5b27-d983-41ba-a49f-9ace955ed459") },
                    { new Guid("0440e285-6518-4874-84ba-51bfc797db71"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("b2a25863-1397-44f5-b714-51062a80e2b3"), new Guid("6568c656-09a7-4d39-8610-a206e5b5b4bf") },
                    { new Guid("4ca0c97e-7382-4b58-8f5e-8f2e7f5dd3a0"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("b2a25863-1397-44f5-b714-51062a80e2b3"), new Guid("ebff6f43-b2b5-43e2-8f60-6b95fb587be9") },
                    { new Guid("0aa104b2-6ad5-4830-9cc6-d215fabb04be"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("b2a25863-1397-44f5-b714-51062a80e2b3"), new Guid("78fa82c4-95f0-42cf-a91a-4ad42e04adbf") },
                    { new Guid("c1ff66d3-69e4-442b-b082-3ff5f2a217ef"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("73c5e6f2-6efa-47de-814a-0d126028b3a6"), new Guid("0903e245-e702-4f0b-971a-f22d552c9e82") },
                    { new Guid("d204dc0e-8d85-4c7d-a4cf-8052b56e15a4"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("73c5e6f2-6efa-47de-814a-0d126028b3a6"), new Guid("52570086-d700-41bf-a943-fde72be03d1e") },
                    { new Guid("78a773c6-80ca-46b1-813a-47ffbfbe6791"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("73c5e6f2-6efa-47de-814a-0d126028b3a6"), new Guid("6e229ebf-7dd4-4a67-b075-d2c2893365d4") },
                    { new Guid("81b87c5f-b527-4524-9577-10120c301c3a"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("94098cf4-10c5-41fa-80c7-dabfd553d197"), new Guid("0903e245-e702-4f0b-971a-f22d552c9e82") },
                    { new Guid("5a5f4194-e626-4f7d-89aa-1f63ee4206ab"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("94098cf4-10c5-41fa-80c7-dabfd553d197"), new Guid("f5ce1488-f02b-40bb-a197-6994f967e182") },
                    { new Guid("1f1d2baf-f2e7-4b99-982f-1fcb777dd589"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("46dc3e61-38ec-4840-81cf-4fab1742620f"), new Guid("0903e245-e702-4f0b-971a-f22d552c9e82") },
                    { new Guid("0593a38d-2101-466f-915c-740ef88bf1e2"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("46dc3e61-38ec-4840-81cf-4fab1742620f"), new Guid("9390690b-bb79-4553-9578-65882a4d27d2") },
                    { new Guid("942b53cb-f7b4-4f20-b981-70602401209c"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("8d30e8c3-eec8-4964-b055-92d9e7a885eb"), new Guid("0903e245-e702-4f0b-971a-f22d552c9e82") },
                    { new Guid("bbcf29cc-062a-433b-8104-5f3fa19b17fb"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("8d30e8c3-eec8-4964-b055-92d9e7a885eb"), new Guid("6e229ebf-7dd4-4a67-b075-d2c2893365d4") },
                    { new Guid("7500a0f9-256a-4e1a-9383-d69e261a1716"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("30a47133-e9d6-4cee-ac57-edac840f212e"), new Guid("0903e245-e702-4f0b-971a-f22d552c9e82") },
                    { new Guid("24a7f6d0-4666-4244-b04a-7fdfeccb3c7d"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("30a47133-e9d6-4cee-ac57-edac840f212e"), new Guid("52570086-d700-41bf-a943-fde72be03d1e") },
                    { new Guid("8e2071f4-9ab8-484e-b7cb-072ff5c74c62"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("5250eec9-3e57-4e15-a24e-47ac4cc313d1"), new Guid("0903e245-e702-4f0b-971a-f22d552c9e82") },
                    { new Guid("f7d465e7-1456-4eb1-840a-a24924599487"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("5250eec9-3e57-4e15-a24e-47ac4cc313d1"), new Guid("38121cd0-a251-41c2-bb7f-e9bb5b49a793") },
                    { new Guid("b24d51b4-150f-43eb-b74b-99031e68d5ab"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("5250eec9-3e57-4e15-a24e-47ac4cc313d1"), new Guid("f5a6dab5-f91c-47d6-abef-a1bec571e425") },
                    { new Guid("3dd736fe-0a04-4abb-9787-0ae93867ac13"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("7bb01144-6be2-48bb-80a6-700a55cd0f6f"), new Guid("0903e245-e702-4f0b-971a-f22d552c9e82") },
                    { new Guid("25637c86-485b-4d75-88da-f154a9a97fd1"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("7bb01144-6be2-48bb-80a6-700a55cd0f6f"), new Guid("6cfe1db5-e777-4953-b76d-68ca1f829836") },
                    { new Guid("48d443ac-c4b0-436c-bde1-113218962271"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("9a3e086f-5d7c-4dc9-a040-2ec60c7bf120"), new Guid("0903e245-e702-4f0b-971a-f22d552c9e82") },
                    { new Guid("50850789-13c6-41d2-b8b3-921b9004dc24"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("9a3e086f-5d7c-4dc9-a040-2ec60c7bf120"), new Guid("6568c656-09a7-4d39-8610-a206e5b5b4bf") },
                    { new Guid("8838ed08-23eb-472b-a2b9-2482cd160f6a"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("31a5d5a4-8457-4933-bd31-a44986a9fea2"), new Guid("0903e245-e702-4f0b-971a-f22d552c9e82") },
                    { new Guid("dc4dae0f-5b3f-40ba-a48a-1145c316cd54"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new Guid("31a5d5a4-8457-4933-bd31-a44986a9fea2"), new Guid("38121cd0-a251-41c2-bb7f-e9bb5b49a793") }
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

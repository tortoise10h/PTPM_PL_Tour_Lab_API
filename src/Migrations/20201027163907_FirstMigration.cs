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
                    LastName = table.Column<string>(nullable: true),
                    CreatedAt = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CostType",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
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
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
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
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
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
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
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
                    RoleId = table.Column<string>(nullable: false),
                    ApplicationUserId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
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
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: true),
                    LastModifiedAt = table.Column<DateTime>(nullable: false),
                    LastModifiedBy = table.Column<string>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Specification = table.Column<string>(nullable: true),
                    TourCategoryId = table.Column<int>(nullable: false),
                    Price = table.Column<long>(nullable: false),
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
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: true),
                    LastModifiedAt = table.Column<DateTime>(nullable: false),
                    LastModifiedBy = table.Column<string>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Price = table.Column<long>(nullable: false),
                    StartDate = table.Column<DateTime>(nullable: false),
                    EndDate = table.Column<DateTime>(nullable: false),
                    TourId = table.Column<int>(nullable: false),
                    Status = table.Column<int>(nullable: false, defaultValue: 1)
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
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: true),
                    LastModifiedAt = table.Column<DateTime>(nullable: false),
                    LastModifiedBy = table.Column<string>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    TourId = table.Column<int>(nullable: false),
                    Index = table.Column<int>(nullable: false),
                    TouristAttractionId = table.Column<int>(nullable: false)
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
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: true),
                    LastModifiedAt = table.Column<DateTime>(nullable: false),
                    LastModifiedBy = table.Column<string>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    TourId = table.Column<int>(nullable: false),
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
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: true),
                    LastModifiedAt = table.Column<DateTime>(nullable: false),
                    LastModifiedBy = table.Column<string>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    GroupId = table.Column<int>(nullable: false),
                    CostTypeId = table.Column<int>(nullable: false),
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
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: true),
                    LastModifiedAt = table.Column<DateTime>(nullable: false),
                    LastModifiedBy = table.Column<string>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    UserId = table.Column<string>(nullable: true),
                    GroupId = table.Column<int>(nullable: false),
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
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: true),
                    LastModifiedAt = table.Column<DateTime>(nullable: false),
                    LastModifiedBy = table.Column<string>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    StaffId = table.Column<string>(nullable: true),
                    GroupId = table.Column<int>(nullable: false),
                    GroupRoleId = table.Column<int>(nullable: false)
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
                    { "ace12b17-c89a-490d-9f6e-653e37c2b9c6", "dfe78684-9945-4f2e-830d-c5477c785607", "Admin", "admin" },
                    { "b5772a60-1833-43f8-805d-af8a8e4db572", "d7e1a783-b2d2-410e-8797-ec82e70c4f27", "SuperAdmin", "superadmin" },
                    { "1c01b40f-9d33-458f-af62-6df4403aebc0", "dc4d6e8c-7a7c-4a91-a664-03259bdd7260", "Customer", "customer" },
                    { "2942b32d-17a2-45aa-ba81-c67537ddbc63", "d4c44a99-2eb5-465f-948f-9d791ff0526e", "Staff", "staff" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CreatedAt", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "db41ae4f-ed07-456d-b7c9-1e36ebcbc0f9", 0, "79a8ca75-e33f-477f-80b6-a5176fc6f8ff", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "phantantrung@gmail.com", true, "Trung", "Phan Tấn", false, null, "PHANTANTRUNG@GMAIL.COM", "PHANTANTRUNG@GMAIL.COM", "AQAAAAEAACcQAAAAEB4wXNKO5hFDDzXvGrRq5KXTLXG0OrMuqQz3MMn/N4a12tcrMZZ+bPoQ1B1sniY0gQ==", null, false, "", false, "phantantrung@gmail.com" },
                    { "a28b269e-aa4e-41bf-9a25-06b24f351aa8", 0, "098cffe0-e2f4-482f-8c2a-75940fd602bf", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "truongtuantu@gmail.com", true, "Tú", "Trương Tuấn", false, null, "TRUONGTUANTU@GMAIL.COM", "TRUONGTUANTU@GMAIL.COM", "AQAAAAEAACcQAAAAECm7ZlayvA3I5neFk4L7KWVfKhNayEFOFkIV9fQDiK/vGe2SRLwziV1fl0cAm9IV5g==", null, false, "", false, "truongtuantu@gmail.com" },
                    { "e6639c6e-f09c-4365-a2af-a916035951fb", 0, "b4c243b3-1245-48b8-a63a-b8386fce05fb", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "truongthimaitram@gmail.com", true, "Trâm", "Trương Thị Mai", false, null, "TRUONGTHIMAITRAM@GMAIL.COM", "TRUONGTHIMAITRAM@GMAIL.COM", "AQAAAAEAACcQAAAAEDZNrjzwlL0npZPnKouW8/0IK0WxEeTQZpeS6agjYxW1GsjDqsXHOVJb5z3Kn5Wo8A==", null, false, "", false, "truongthimaitram@gmail.com" },
                    { "87566005-33f6-4f8a-8eee-a1d8ee352c5d", 0, "3ca6d1bb-74e7-4cdf-bf8e-b7f32660b5bc", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "nguyenbuuvinh@gmail.com", true, "Vinh", "Nguyễn Bửu", false, null, "NGUYENBUUVINH@GMAIL.COM", "NGUYENBUUVINH@GMAIL.COM", "AQAAAAEAACcQAAAAEDWatg6e4f4tHwt/owtf54yNvhM1/te0JYQQj2izhilgnuhwzf8Uqa1oikGEqt1SGA==", null, false, "", false, "nguyenbuuvinh@gmail.com" },
                    { "db6439e5-9220-4e8b-a86e-05cefb15c16d", 0, "0c0f1fd2-7cf3-42ca-afd5-6cd90a3dc26b", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "lequangduy@gmail.com", true, "Duy", "Lê Quang", false, null, "LEQUANGDUY@GMAIL.COM", "LEQUANGDUY@GMAIL.COM", "AQAAAAEAACcQAAAAEFG3zt8OcwGWp8kRtCQA+9J0yV/w6xdlwfaWMz6juF/w9sx4fNXi60b287WJHeuO2A==", null, false, "", false, "lequangduy@gmail.com" },
                    { "51b709d2-772e-4b78-b890-49b470d4041f", 0, "650c5e1a-496f-4ad1-840a-807a3d95fab2", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "duonghoanphong@gmail.com", true, "Phong", "Đường Hoán", false, null, "DUONGHOANPHONG@GMAIL.COM", "DUONGHOANPHONG@GMAIL.COM", "AQAAAAEAACcQAAAAEK08hJm5ueiTCy+tXferM3zahne52May0xrxromk2Yy/bnJjxt3qpRJzOmblfUMujw==", null, false, "", false, "duonghoanphong@gmail.com" },
                    { "6167f48d-4b49-47d3-a820-00326998e584", 0, "73462543-9f76-4f17-9753-49beff35bd4a", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "phungthanhdo@gmail.com", true, "Độ", "Phùng Thanh", false, null, "PHUNGTHANHDO@GMAIL.COM", "PHUNGTHANHDO@GMAIL.COM", "AQAAAAEAACcQAAAAEKvx5wH5GQFXoWI2Z553W8fCxgqrkDCJIKQy0w0mRYXoPyWDQjbcI7BimtkndIHUsg==", null, false, "", false, "phungthanhdo@gmail.com" },
                    { "3ec366d7-e4f9-4fab-b0e2-6837dbba3883", 0, "a8093518-0171-4a8b-b3e7-2a5b225ed743", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "buibichphuong@gmail.com", true, "Phương", "Bùi Bích", false, null, "BUIBICHPHUONG@GMAIL.COM", "BUIBICHPHUONG@GMAIL.COM", "AQAAAAEAACcQAAAAEBsJjjhq8VKv9nhm3VP7SBxteEVrhLjqeR/r5FEO8g4u3E1N2PMH26Fyl7x1IqeN8w==", null, false, "", false, "buibichphuong@gmail.com" },
                    { "6b3f1d35-84a9-47db-aa75-c77f2c047eff", 0, "958eabe5-4261-4bf9-9015-833e8530822d", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "tranphuongly@gmail.com", true, "Ly", "Trần Phương", false, null, "TRANPHUONGLY@GMAIL.COM", "TRANPHUONGLY@GMAIL.COM", "AQAAAAEAACcQAAAAEGgKSroUzE5CNpUh5g1DjLjy1htHfRYcB1oS4shnnyUFV40b1MSoMAChf5QR7nffeQ==", null, false, "", false, "tranphuongly@gmail.com" },
                    { "7bcae672-19f2-43b1-bc40-7f4b727e0329", 0, "41df37c7-57b6-4867-873e-fff11d6f1371", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "luongtulinh@gmail.com", true, "Linh", "Lường Tú", false, null, "LUONGTULINH@GMAIL.COM", "LUONGTULINH@GMAIL.COM", "AQAAAAEAACcQAAAAEMN9EBo09c+9E0X7Cl6XJuyTGrkq7n4pA8sq7SCjqeSOlJOBQmxUt+kTWWnx5R8mUA==", null, false, "", false, "luongtulinh@gmail.com" },
                    { "873a7bea-8be8-4282-8d92-ee73cd74d3d5", 0, "c62eb2d6-00ec-4916-94ec-7801577fe63b", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "malephixuan@gmail.com", true, "Xuân", "Mã Lệ Phi", false, null, "MALEPHIXUAN@GMAIL.COM", "MALEPHIXUAN@GMAIL.COM", "AQAAAAEAACcQAAAAEOxTL3N8zzwe9Qfr88bpKiZsWQPGDrSsSmVBTlh06ynuN/KhBW/4xjgSwyS3D0Yghw==", null, false, "", false, "malephixuan@gmail.com" },
                    { "fbd7814f-0a2a-46c1-9cb9-f0d144a10591", 0, "272577ec-abb1-4005-8dd7-0b313921fb8b", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "luubaominh@gmail.com", true, "Minh", "Lưu Bảo", false, null, "LUUBAOMINH@GMAIL.COM", "LUUBAOMINH@GMAIL.COM", "AQAAAAEAACcQAAAAEBcDdUCa4LXXNlqivPUzXf1Jgmmcw11z73OGglP041w3ZADq7A2XfgtCmiZBO8jU5A==", null, false, "", false, "luubaominh@gmail.com" },
                    { "2cdd39df-5acd-4071-ac15-b349dfc3bde3", 0, "84b64071-54a0-4dd5-919f-df50119dba60", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "nguyenhue@gmail.com", true, "Huệ", "Nguyễn", false, null, "NGUYENHUE@GMAIL.COM", "NGUYENHUE@GMAIL.COM", "AQAAAAEAACcQAAAAEHyJDlJ0gO9KYA7Oi+ENCy7pnm3I/cMgG3nIWmeJH7Z1+mMvxDRvhR1ywFGWA44Msw==", null, false, "", false, "nguyenhue@gmail.com" },
                    { "4670a25d-a2e0-40f6-95be-d2f6db396a24", 0, "745f494e-b102-48f8-b2f5-d2906889e880", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "chuvietdung@gmail.com", true, "Dũng", "Chu Việt", false, null, "CHUVIETDUNG@GMAIL.COM", "CHUVIETDUNG@GMAIL.COM", "AQAAAAEAACcQAAAAECuPOxCN2oG/qeY6Hmw0nbqjktk1WwhHFUmUyDonZogqwrcCDDH2p5gzGUMxnPU9Vw==", null, false, "", false, "chuvietdung@gmail.com" },
                    { "6dd937d8-526a-4608-8721-f1f952bb0e15", 0, "7fbc4cda-25ae-42ce-af04-c55ef6224dac", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "nguyenthanhlong@gmail.com", true, "Long", "Nguyễn Thành", false, null, "NGUYENTHANHLONG@GMAIL.COM", "NGUYENTHANHLONG@GMAIL.COM", "AQAAAAEAACcQAAAAEA7hG9bnq2uHY/qRLqG/Bzx/UiyWKbrg+INVmMD42QBf41C3G2gI+ZjmmzsJewohnw==", null, false, "", false, "nguyenthanhlong@gmail.com" },
                    { "1efae0cb-898c-4550-b3ae-af178f2716bb", 0, "b1ff201c-32c8-4133-9707-e1fbc5839d15", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "huynhtranthanh@gmail.com", true, "Thành", "Huỳnh Trấn", false, null, "HUYNHTRANTHANH@GMAIL.COM", "HUYNHTRANTHANH@GMAIL.COM", "AQAAAAEAACcQAAAAENZFVtrXt8URkIsymzHAZwVSxpIgssdHr1eGc6N6OGRT9S3V1qHyZr7PLfcv7CUMYQ==", null, false, "", false, "huynhtranthanh@gmail.com" },
                    { "3574ab93-3c65-4600-944b-26dfbfff4c38", 0, "666fa101-d7a5-4af5-a219-c10195eeeedc", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "caobaquat@gmail.com", true, "Quát", "Cao Bá", false, null, "CAOBAQUAT@GMAIL.COM", "CAOBAQUAT@GMAIL.COM", "AQAAAAEAACcQAAAAECezZcbu9ZlD7Rc/If6qZjZWLl3CqfSyCey9diWBCh75P4LdeZ27cwzTToCfgled/g==", null, false, "", false, "caobaquat@gmail.com" },
                    { "98243625-ccef-4384-a6c7-630220c6f23e", 0, "44a45575-be21-4201-a5ae-3bb96f499c39", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "truongthitramanh@gmail.com", true, "Anh", "Trương Thị Trâm", false, null, "TRUONGTHITRAMANH@GMAIL.COM", "TRUONGTHITRAMANH@GMAIL.COM", "AQAAAAEAACcQAAAAEL5qLf0R151nSqLh5UhHEjaJ5rm1k6Wf/BVHyGXMH56irhzh8FZb23tr3J4o1DjjCA==", null, false, "", false, "truongthitramanh@gmail.com" },
                    { "b1983ed1-48f5-4d06-91a9-2451daa4d454", 0, "c62bd532-33bd-4594-82f3-22e8dcf292b1", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "tranthaonguyen@gmail.com", true, "Nguyên", "Trần Thảo", false, null, "TRANTHAONGUYEN@GMAIL.COM", "TRANTHAONGUYEN@GMAIL.COM", "AQAAAAEAACcQAAAAEEPdJ1fP6G7hdzte2+jZ61Z8HBp2Kqpq83avFHoDSwIS6wN5FA3yIVmOwlOWc5auxQ==", null, false, "", false, "tranthaonguyen@gmail.com" },
                    { "d53c63e3-f060-4559-aada-ab94d9c11ad8", 0, "8e2d3645-83fc-48cc-98d8-bd11163df1f5", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "caothivananh@gmail.com", true, "Anh", "Cao Thị Vân", false, null, "CAOTHIVANANH@GMAIL.COM", "CAOTHIVANANH@GMAIL.COM", "AQAAAAEAACcQAAAAEJGS6r1DxfS3y4mHHVZAOycsv2tC4RRihv6cZS1+pak32n+eStdl2Hy8wWrZ71yZig==", null, false, "", false, "caothivananh@gmail.com" },
                    { "5a02dfdd-3493-4278-b9f0-8e4083bdaa88", 0, "7e62df6c-c528-47ba-8c77-21b520b79d73", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "nguyennhuloc@gmail.com", true, "Lộc", "Nguyễn Như", false, null, "NGUYENNHULOC@GMAIL.COM", "NGUYENNHULOC@GMAIL.COM", "AQAAAAEAACcQAAAAEEY/w33k/aW7B0iaH8/hygXaI5ANaXssd0b3FHDzcpXoMG/jeW/TpXNS1hKom2/pfQ==", null, false, "", false, "nguyennhuloc@gmail.com" },
                    { "5259a667-fc82-480d-8f4a-7fbb0fb37580", 0, "053a0cd3-c864-4fc7-88e8-1fa348a88764", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "nguyentrunghieu@gmail.com", true, "Hiếu", "Nguyễn Trung", false, null, "NGUYENTRUNGHIEU@GMAIL.COM", "NGUYENTRUNGHIEU@GMAIL.COM", "AQAAAAEAACcQAAAAEBwR2FFK++iQ0cUZz+5+SF5Gc8HQgwkqwcB7iRlz88Z3uP0rZPzBFXyjfi27Qviqhg==", null, false, "", false, "nguyentrunghieu@gmail.com" },
                    { "e2718569-01a6-41fc-ad97-c3103de8034d", 0, "7c7fda1c-323a-4e8b-97b1-e99258565aad", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "phamvinhson@gmail.com", true, "Sơn", "Phạm Vĩnh", false, null, "PHAMVINHSON@GMAIL.COM", "PHAMVINHSON@GMAIL.COM", "AQAAAAEAACcQAAAAEIGhHvwj25/Nz/VfgkRjcFgbid2wSy1MwNUkN7979rCiv4uvC2HSfsuBV0gqneaKfQ==", null, false, "", false, "phamvinhson@gmail.com" },
                    { "8597edeb-caa5-49ff-88ab-de2b5a54c656", 0, "90bd8b98-67c0-43be-af62-6f142b924304", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "trankieuloan@gmail.com", true, "Loan", "Trần Kiều", false, null, "TRANKIEULOAN@GMAIL.COM", "TRANKIEULOAN@GMAIL.COM", "AQAAAAEAACcQAAAAEB86sLbF67m/T3tErJwNnJFDx8CuTwAQP+O/9WRJ+9FDSO2WzHOwFIxliS7WA1X58g==", null, false, "", false, "trankieuloan@gmail.com" },
                    { "52e868d7-2bd2-4ee9-8217-84fc16a2a7e2", 0, "625a6ddc-13e3-49af-8f74-d890b05c046d", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "yungadmin@gmail.com", true, "Admin", "Yung", false, null, "YUNGADMIN@GMAIL.COM", "YUNGADMIN@GMAIL.COM", "AQAAAAEAACcQAAAAEIPmNHXMMFOP5KjUGGtdDVtaOfWQgXKwk/k8Qm43sUQYh+g9WMTw0o946/x8dqgGgw==", null, false, "", false, "yungadmin@gmail.com" },
                    { "a8b37916-2263-4877-8eb6-c31a1f175de7", 0, "26d99895-af54-4caf-9358-01e82b219a29", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "lilsuperadmin@gmail.com", true, "Super Admin", "Lil", false, null, "LILSUPERADMIN@GMAIL.COM", "LILSUPERADMIN@GMAIL.COM", "AQAAAAEAACcQAAAAEMVG95gXiJuXJto2uYowQeMIKSDZS3TSsH5TrZShcr8kAer61dpqx2Y1QWR1wWnfXg==", null, false, "", false, "lilsuperadmin@gmail.com" },
                    { "39587b99-dbd2-49da-884a-cd7047e02c9b", 0, "51c86661-7b60-48b6-975b-da66fd3eb03d", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "hoxuanhuong@gmail.com", true, "Hương", "Hồ Xuân", false, null, "HOXUANHUONG@GMAIL.COM", "HOXUANHUONG@GMAIL.COM", "AQAAAAEAACcQAAAAEKDu5zAbBQ9Cvz7WWvdkO5lXKLAXPRJpDBhMcPefu4oz2egDFr3Iwq4Yai8C7iAN0w==", null, false, "", false, "hoxuanhuong@gmail.com" }
                });

            migrationBuilder.InsertData(
                table: "TourCategories",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "IsDeleted", "LastModifiedAt", "LastModifiedBy", "Name" },
                values: new object[,]
                {
                    { 6, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Teambuilding" },
                    { 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Du lịch xanh" },
                    { 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Du lịch MICE" },
                    { 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Du lịch văn hóa" },
                    { 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Du lịch tham quan" },
                    { 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Du lịch ẩm thực" }
                });

            migrationBuilder.InsertData(
                table: "TouristAttraction",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "Description", "IsDeleted", "LastModifiedAt", "LastModifiedBy", "Name" },
                values: new object[,]
                {
                    { 14, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aenean dui est, fringilla eu urna non, rhoncus tristique urna. Phasellus sed mauris eu metus sollicitudin gravida. Aliquam ut molestie orci. Suspendisse nec quam ut massa rutrum ullamcorper non eu elit. Nam ligula sapien, placerat nec ligula et, maximus sagittis est. Maecenas et ex nec nunc sagittis aliquam vitae vitae neque. Ut ut malesuada sapien, tincidunt auctor elit. Quisque volutpat urna at posuere maximus. Nunc felis lectus, bibendum ut quam id, porttitor vehicula turpis. Sed ac efficitur risus. Proin feugiat sit amet dui vel tempor.Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aenean dui est, fringilla eu urna non, rhoncus tristique urna. Phasellus sed mauris eu metus sollicitudin gravida. Aliquam ut molestie orci. Suspendisse nec quam ut massa rutrum ullamcorper non eu elit. Nam ligula sapien, placerat nec ligula et, maximus sagittis est. Maecenas et ex nec nunc sagittis aliquam vitae vitae neque. Ut ut malesuada sapien, tincidunt auctor elit. Quisque volutpat urna at posuere maximus. Nunc felis lectus, bibendum ut quam id, porttitor vehicula turpis. Sed ac efficitur risus. Proin feugiat sit amet dui vel tempor.", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Phú Quốc" },
                    { 13, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aenean dui est, fringilla eu urna non, rhoncus tristique urna. Phasellus sed mauris eu metus sollicitudin gravida. Aliquam ut molestie orci. Suspendisse nec quam ut massa rutrum ullamcorper non eu elit. Nam ligula sapien, placerat nec ligula et, maximus sagittis est. Maecenas et ex nec nunc sagittis aliquam vitae vitae neque. Ut ut malesuada sapien, tincidunt auctor elit. Quisque volutpat urna at posuere maximus. Nunc felis lectus, bibendum ut quam id, porttitor vehicula turpis. Sed ac efficitur risus. Proin feugiat sit amet dui vel tempor.Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aenean dui est, fringilla eu urna non, rhoncus tristique urna. Phasellus sed mauris eu metus sollicitudin gravida. Aliquam ut molestie orci. Suspendisse nec quam ut massa rutrum ullamcorper non eu elit. Nam ligula sapien, placerat nec ligula et, maximus sagittis est. Maecenas et ex nec nunc sagittis aliquam vitae vitae neque. Ut ut malesuada sapien, tincidunt auctor elit. Quisque volutpat urna at posuere maximus. Nunc felis lectus, bibendum ut quam id, porttitor vehicula turpis. Sed ac efficitur risus. Proin feugiat sit amet dui vel tempor.", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Hồ Tràm" },
                    { 12, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aenean dui est, fringilla eu urna non, rhoncus tristique urna. Phasellus sed mauris eu metus sollicitudin gravida. Aliquam ut molestie orci. Suspendisse nec quam ut massa rutrum ullamcorper non eu elit. Nam ligula sapien, placerat nec ligula et, maximus sagittis est. Maecenas et ex nec nunc sagittis aliquam vitae vitae neque. Ut ut malesuada sapien, tincidunt auctor elit. Quisque volutpat urna at posuere maximus. Nunc felis lectus, bibendum ut quam id, porttitor vehicula turpis. Sed ac efficitur risus. Proin feugiat sit amet dui vel tempor.Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aenean dui est, fringilla eu urna non, rhoncus tristique urna. Phasellus sed mauris eu metus sollicitudin gravida. Aliquam ut molestie orci. Suspendisse nec quam ut massa rutrum ullamcorper non eu elit. Nam ligula sapien, placerat nec ligula et, maximus sagittis est. Maecenas et ex nec nunc sagittis aliquam vitae vitae neque. Ut ut malesuada sapien, tincidunt auctor elit. Quisque volutpat urna at posuere maximus. Nunc felis lectus, bibendum ut quam id, porttitor vehicula turpis. Sed ac efficitur risus. Proin feugiat sit amet dui vel tempor.", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Hạ Long" },
                    { 11, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aenean dui est, fringilla eu urna non, rhoncus tristique urna. Phasellus sed mauris eu metus sollicitudin gravida. Aliquam ut molestie orci. Suspendisse nec quam ut massa rutrum ullamcorper non eu elit. Nam ligula sapien, placerat nec ligula et, maximus sagittis est. Maecenas et ex nec nunc sagittis aliquam vitae vitae neque. Ut ut malesuada sapien, tincidunt auctor elit. Quisque volutpat urna at posuere maximus. Nunc felis lectus, bibendum ut quam id, porttitor vehicula turpis. Sed ac efficitur risus. Proin feugiat sit amet dui vel tempor.Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aenean dui est, fringilla eu urna non, rhoncus tristique urna. Phasellus sed mauris eu metus sollicitudin gravida. Aliquam ut molestie orci. Suspendisse nec quam ut massa rutrum ullamcorper non eu elit. Nam ligula sapien, placerat nec ligula et, maximus sagittis est. Maecenas et ex nec nunc sagittis aliquam vitae vitae neque. Ut ut malesuada sapien, tincidunt auctor elit. Quisque volutpat urna at posuere maximus. Nunc felis lectus, bibendum ut quam id, porttitor vehicula turpis. Sed ac efficitur risus. Proin feugiat sit amet dui vel tempor.", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Phan Thiết" },
                    { 10, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aenean dui est, fringilla eu urna non, rhoncus tristique urna. Phasellus sed mauris eu metus sollicitudin gravida. Aliquam ut molestie orci. Suspendisse nec quam ut massa rutrum ullamcorper non eu elit. Nam ligula sapien, placerat nec ligula et, maximus sagittis est. Maecenas et ex nec nunc sagittis aliquam vitae vitae neque. Ut ut malesuada sapien, tincidunt auctor elit. Quisque volutpat urna at posuere maximus. Nunc felis lectus, bibendum ut quam id, porttitor vehicula turpis. Sed ac efficitur risus. Proin feugiat sit amet dui vel tempor.Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aenean dui est, fringilla eu urna non, rhoncus tristique urna. Phasellus sed mauris eu metus sollicitudin gravida. Aliquam ut molestie orci. Suspendisse nec quam ut massa rutrum ullamcorper non eu elit. Nam ligula sapien, placerat nec ligula et, maximus sagittis est. Maecenas et ex nec nunc sagittis aliquam vitae vitae neque. Ut ut malesuada sapien, tincidunt auctor elit. Quisque volutpat urna at posuere maximus. Nunc felis lectus, bibendum ut quam id, porttitor vehicula turpis. Sed ac efficitur risus. Proin feugiat sit amet dui vel tempor.", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "ĐBSCL" },
                    { 9, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aenean dui est, fringilla eu urna non, rhoncus tristique urna. Phasellus sed mauris eu metus sollicitudin gravida. Aliquam ut molestie orci. Suspendisse nec quam ut massa rutrum ullamcorper non eu elit. Nam ligula sapien, placerat nec ligula et, maximus sagittis est. Maecenas et ex nec nunc sagittis aliquam vitae vitae neque. Ut ut malesuada sapien, tincidunt auctor elit. Quisque volutpat urna at posuere maximus. Nunc felis lectus, bibendum ut quam id, porttitor vehicula turpis. Sed ac efficitur risus. Proin feugiat sit amet dui vel tempor.Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aenean dui est, fringilla eu urna non, rhoncus tristique urna. Phasellus sed mauris eu metus sollicitudin gravida. Aliquam ut molestie orci. Suspendisse nec quam ut massa rutrum ullamcorper non eu elit. Nam ligula sapien, placerat nec ligula et, maximus sagittis est. Maecenas et ex nec nunc sagittis aliquam vitae vitae neque. Ut ut malesuada sapien, tincidunt auctor elit. Quisque volutpat urna at posuere maximus. Nunc felis lectus, bibendum ut quam id, porttitor vehicula turpis. Sed ac efficitur risus. Proin feugiat sit amet dui vel tempor.", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Miền Tây" },
                    { 8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aenean dui est, fringilla eu urna non, rhoncus tristique urna. Phasellus sed mauris eu metus sollicitudin gravida. Aliquam ut molestie orci. Suspendisse nec quam ut massa rutrum ullamcorper non eu elit. Nam ligula sapien, placerat nec ligula et, maximus sagittis est. Maecenas et ex nec nunc sagittis aliquam vitae vitae neque. Ut ut malesuada sapien, tincidunt auctor elit. Quisque volutpat urna at posuere maximus. Nunc felis lectus, bibendum ut quam id, porttitor vehicula turpis. Sed ac efficitur risus. Proin feugiat sit amet dui vel tempor.Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aenean dui est, fringilla eu urna non, rhoncus tristique urna. Phasellus sed mauris eu metus sollicitudin gravida. Aliquam ut molestie orci. Suspendisse nec quam ut massa rutrum ullamcorper non eu elit. Nam ligula sapien, placerat nec ligula et, maximus sagittis est. Maecenas et ex nec nunc sagittis aliquam vitae vitae neque. Ut ut malesuada sapien, tincidunt auctor elit. Quisque volutpat urna at posuere maximus. Nunc felis lectus, bibendum ut quam id, porttitor vehicula turpis. Sed ac efficitur risus. Proin feugiat sit amet dui vel tempor.", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Đông Bắc" },
                    { 7, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aenean dui est, fringilla eu urna non, rhoncus tristique urna. Phasellus sed mauris eu metus sollicitudin gravida. Aliquam ut molestie orci. Suspendisse nec quam ut massa rutrum ullamcorper non eu elit. Nam ligula sapien, placerat nec ligula et, maximus sagittis est. Maecenas et ex nec nunc sagittis aliquam vitae vitae neque. Ut ut malesuada sapien, tincidunt auctor elit. Quisque volutpat urna at posuere maximus. Nunc felis lectus, bibendum ut quam id, porttitor vehicula turpis. Sed ac efficitur risus. Proin feugiat sit amet dui vel tempor.Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aenean dui est, fringilla eu urna non, rhoncus tristique urna. Phasellus sed mauris eu metus sollicitudin gravida. Aliquam ut molestie orci. Suspendisse nec quam ut massa rutrum ullamcorper non eu elit. Nam ligula sapien, placerat nec ligula et, maximus sagittis est. Maecenas et ex nec nunc sagittis aliquam vitae vitae neque. Ut ut malesuada sapien, tincidunt auctor elit. Quisque volutpat urna at posuere maximus. Nunc felis lectus, bibendum ut quam id, porttitor vehicula turpis. Sed ac efficitur risus. Proin feugiat sit amet dui vel tempor.", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Tây Nguyên" },
                    { 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aenean dui est, fringilla eu urna non, rhoncus tristique urna. Phasellus sed mauris eu metus sollicitudin gravida. Aliquam ut molestie orci. Suspendisse nec quam ut massa rutrum ullamcorper non eu elit. Nam ligula sapien, placerat nec ligula et, maximus sagittis est. Maecenas et ex nec nunc sagittis aliquam vitae vitae neque. Ut ut malesuada sapien, tincidunt auctor elit. Quisque volutpat urna at posuere maximus. Nunc felis lectus, bibendum ut quam id, porttitor vehicula turpis. Sed ac efficitur risus. Proin feugiat sit amet dui vel tempor.Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aenean dui est, fringilla eu urna non, rhoncus tristique urna. Phasellus sed mauris eu metus sollicitudin gravida. Aliquam ut molestie orci. Suspendisse nec quam ut massa rutrum ullamcorper non eu elit. Nam ligula sapien, placerat nec ligula et, maximus sagittis est. Maecenas et ex nec nunc sagittis aliquam vitae vitae neque. Ut ut malesuada sapien, tincidunt auctor elit. Quisque volutpat urna at posuere maximus. Nunc felis lectus, bibendum ut quam id, porttitor vehicula turpis. Sed ac efficitur risus. Proin feugiat sit amet dui vel tempor.", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Đà Lạt" },
                    { 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aenean dui est, fringilla eu urna non, rhoncus tristique urna. Phasellus sed mauris eu metus sollicitudin gravida. Aliquam ut molestie orci. Suspendisse nec quam ut massa rutrum ullamcorper non eu elit. Nam ligula sapien, placerat nec ligula et, maximus sagittis est. Maecenas et ex nec nunc sagittis aliquam vitae vitae neque. Ut ut malesuada sapien, tincidunt auctor elit. Quisque volutpat urna at posuere maximus. Nunc felis lectus, bibendum ut quam id, porttitor vehicula turpis. Sed ac efficitur risus. Proin feugiat sit amet dui vel tempor.Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aenean dui est, fringilla eu urna non, rhoncus tristique urna. Phasellus sed mauris eu metus sollicitudin gravida. Aliquam ut molestie orci. Suspendisse nec quam ut massa rutrum ullamcorper non eu elit. Nam ligula sapien, placerat nec ligula et, maximus sagittis est. Maecenas et ex nec nunc sagittis aliquam vitae vitae neque. Ut ut malesuada sapien, tincidunt auctor elit. Quisque volutpat urna at posuere maximus. Nunc felis lectus, bibendum ut quam id, porttitor vehicula turpis. Sed ac efficitur risus. Proin feugiat sit amet dui vel tempor.", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Ninh Bình" },
                    { 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aenean dui est, fringilla eu urna non, rhoncus tristique urna. Phasellus sed mauris eu metus sollicitudin gravida. Aliquam ut molestie orci. Suspendisse nec quam ut massa rutrum ullamcorper non eu elit. Nam ligula sapien, placerat nec ligula et, maximus sagittis est. Maecenas et ex nec nunc sagittis aliquam vitae vitae neque. Ut ut malesuada sapien, tincidunt auctor elit. Quisque volutpat urna at posuere maximus. Nunc felis lectus, bibendum ut quam id, porttitor vehicula turpis. Sed ac efficitur risus. Proin feugiat sit amet dui vel tempor.Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aenean dui est, fringilla eu urna non, rhoncus tristique urna. Phasellus sed mauris eu metus sollicitudin gravida. Aliquam ut molestie orci. Suspendisse nec quam ut massa rutrum ullamcorper non eu elit. Nam ligula sapien, placerat nec ligula et, maximus sagittis est. Maecenas et ex nec nunc sagittis aliquam vitae vitae neque. Ut ut malesuada sapien, tincidunt auctor elit. Quisque volutpat urna at posuere maximus. Nunc felis lectus, bibendum ut quam id, porttitor vehicula turpis. Sed ac efficitur risus. Proin feugiat sit amet dui vel tempor.", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Sapa" },
                    { 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aenean dui est, fringilla eu urna non, rhoncus tristique urna. Phasellus sed mauris eu metus sollicitudin gravida. Aliquam ut molestie orci. Suspendisse nec quam ut massa rutrum ullamcorper non eu elit. Nam ligula sapien, placerat nec ligula et, maximus sagittis est. Maecenas et ex nec nunc sagittis aliquam vitae vitae neque. Ut ut malesuada sapien, tincidunt auctor elit. Quisque volutpat urna at posuere maximus. Nunc felis lectus, bibendum ut quam id, porttitor vehicula turpis. Sed ac efficitur risus. Proin feugiat sit amet dui vel tempor.Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aenean dui est, fringilla eu urna non, rhoncus tristique urna. Phasellus sed mauris eu metus sollicitudin gravida. Aliquam ut molestie orci. Suspendisse nec quam ut massa rutrum ullamcorper non eu elit. Nam ligula sapien, placerat nec ligula et, maximus sagittis est. Maecenas et ex nec nunc sagittis aliquam vitae vitae neque. Ut ut malesuada sapien, tincidunt auctor elit. Quisque volutpat urna at posuere maximus. Nunc felis lectus, bibendum ut quam id, porttitor vehicula turpis. Sed ac efficitur risus. Proin feugiat sit amet dui vel tempor.", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Hà Nội" },
                    { 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aenean dui est, fringilla eu urna non, rhoncus tristique urna. Phasellus sed mauris eu metus sollicitudin gravida. Aliquam ut molestie orci. Suspendisse nec quam ut massa rutrum ullamcorper non eu elit. Nam ligula sapien, placerat nec ligula et, maximus sagittis est. Maecenas et ex nec nunc sagittis aliquam vitae vitae neque. Ut ut malesuada sapien, tincidunt auctor elit. Quisque volutpat urna at posuere maximus. Nunc felis lectus, bibendum ut quam id, porttitor vehicula turpis. Sed ac efficitur risus. Proin feugiat sit amet dui vel tempor.Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aenean dui est, fringilla eu urna non, rhoncus tristique urna. Phasellus sed mauris eu metus sollicitudin gravida. Aliquam ut molestie orci. Suspendisse nec quam ut massa rutrum ullamcorper non eu elit. Nam ligula sapien, placerat nec ligula et, maximus sagittis est. Maecenas et ex nec nunc sagittis aliquam vitae vitae neque. Ut ut malesuada sapien, tincidunt auctor elit. Quisque volutpat urna at posuere maximus. Nunc felis lectus, bibendum ut quam id, porttitor vehicula turpis. Sed ac efficitur risus. Proin feugiat sit amet dui vel tempor.", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "TP. Hồ Chí Minh " },
                    { 15, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aenean dui est, fringilla eu urna non, rhoncus tristique urna. Phasellus sed mauris eu metus sollicitudin gravida. Aliquam ut molestie orci. Suspendisse nec quam ut massa rutrum ullamcorper non eu elit. Nam ligula sapien, placerat nec ligula et, maximus sagittis est. Maecenas et ex nec nunc sagittis aliquam vitae vitae neque. Ut ut malesuada sapien, tincidunt auctor elit. Quisque volutpat urna at posuere maximus. Nunc felis lectus, bibendum ut quam id, porttitor vehicula turpis. Sed ac efficitur risus. Proin feugiat sit amet dui vel tempor.Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aenean dui est, fringilla eu urna non, rhoncus tristique urna. Phasellus sed mauris eu metus sollicitudin gravida. Aliquam ut molestie orci. Suspendisse nec quam ut massa rutrum ullamcorper non eu elit. Nam ligula sapien, placerat nec ligula et, maximus sagittis est. Maecenas et ex nec nunc sagittis aliquam vitae vitae neque. Ut ut malesuada sapien, tincidunt auctor elit. Quisque volutpat urna at posuere maximus. Nunc felis lectus, bibendum ut quam id, porttitor vehicula turpis. Sed ac efficitur risus. Proin feugiat sit amet dui vel tempor.", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Đắk Nông" },
                    { 6, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aenean dui est, fringilla eu urna non, rhoncus tristique urna. Phasellus sed mauris eu metus sollicitudin gravida. Aliquam ut molestie orci. Suspendisse nec quam ut massa rutrum ullamcorper non eu elit. Nam ligula sapien, placerat nec ligula et, maximus sagittis est. Maecenas et ex nec nunc sagittis aliquam vitae vitae neque. Ut ut malesuada sapien, tincidunt auctor elit. Quisque volutpat urna at posuere maximus. Nunc felis lectus, bibendum ut quam id, porttitor vehicula turpis. Sed ac efficitur risus. Proin feugiat sit amet dui vel tempor.Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aenean dui est, fringilla eu urna non, rhoncus tristique urna. Phasellus sed mauris eu metus sollicitudin gravida. Aliquam ut molestie orci. Suspendisse nec quam ut massa rutrum ullamcorper non eu elit. Nam ligula sapien, placerat nec ligula et, maximus sagittis est. Maecenas et ex nec nunc sagittis aliquam vitae vitae neque. Ut ut malesuada sapien, tincidunt auctor elit. Quisque volutpat urna at posuere maximus. Nunc felis lectus, bibendum ut quam id, porttitor vehicula turpis. Sed ac efficitur risus. Proin feugiat sit amet dui vel tempor.", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Nha Trang" },
                    { 16, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aenean dui est, fringilla eu urna non, rhoncus tristique urna. Phasellus sed mauris eu metus sollicitudin gravida. Aliquam ut molestie orci. Suspendisse nec quam ut massa rutrum ullamcorper non eu elit. Nam ligula sapien, placerat nec ligula et, maximus sagittis est. Maecenas et ex nec nunc sagittis aliquam vitae vitae neque. Ut ut malesuada sapien, tincidunt auctor elit. Quisque volutpat urna at posuere maximus. Nunc felis lectus, bibendum ut quam id, porttitor vehicula turpis. Sed ac efficitur risus. Proin feugiat sit amet dui vel tempor.Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aenean dui est, fringilla eu urna non, rhoncus tristique urna. Phasellus sed mauris eu metus sollicitudin gravida. Aliquam ut molestie orci. Suspendisse nec quam ut massa rutrum ullamcorper non eu elit. Nam ligula sapien, placerat nec ligula et, maximus sagittis est. Maecenas et ex nec nunc sagittis aliquam vitae vitae neque. Ut ut malesuada sapien, tincidunt auctor elit. Quisque volutpat urna at posuere maximus. Nunc felis lectus, bibendum ut quam id, porttitor vehicula turpis. Sed ac efficitur risus. Proin feugiat sit amet dui vel tempor.", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Tây Ninh" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId", "ApplicationUserId" },
                values: new object[,]
                {
                    { "a8b37916-2263-4877-8eb6-c31a1f175de7", "b5772a60-1833-43f8-805d-af8a8e4db572", null },
                    { "873a7bea-8be8-4282-8d92-ee73cd74d3d5", "2942b32d-17a2-45aa-ba81-c67537ddbc63", null },
                    { "7bcae672-19f2-43b1-bc40-7f4b727e0329", "2942b32d-17a2-45aa-ba81-c67537ddbc63", null },
                    { "6b3f1d35-84a9-47db-aa75-c77f2c047eff", "2942b32d-17a2-45aa-ba81-c67537ddbc63", null },
                    { "4670a25d-a2e0-40f6-95be-d2f6db396a24", "2942b32d-17a2-45aa-ba81-c67537ddbc63", null },
                    { "51b709d2-772e-4b78-b890-49b470d4041f", "2942b32d-17a2-45aa-ba81-c67537ddbc63", null },
                    { "fbd7814f-0a2a-46c1-9cb9-f0d144a10591", "2942b32d-17a2-45aa-ba81-c67537ddbc63", null },
                    { "db6439e5-9220-4e8b-a86e-05cefb15c16d", "2942b32d-17a2-45aa-ba81-c67537ddbc63", null },
                    { "87566005-33f6-4f8a-8eee-a1d8ee352c5d", "2942b32d-17a2-45aa-ba81-c67537ddbc63", null },
                    { "e6639c6e-f09c-4365-a2af-a916035951fb", "2942b32d-17a2-45aa-ba81-c67537ddbc63", null },
                    { "a28b269e-aa4e-41bf-9a25-06b24f351aa8", "1c01b40f-9d33-458f-af62-6df4403aebc0", null },
                    { "db41ae4f-ed07-456d-b7c9-1e36ebcbc0f9", "1c01b40f-9d33-458f-af62-6df4403aebc0", null },
                    { "6167f48d-4b49-47d3-a820-00326998e584", "1c01b40f-9d33-458f-af62-6df4403aebc0", null },
                    { "3ec366d7-e4f9-4fab-b0e2-6837dbba3883", "2942b32d-17a2-45aa-ba81-c67537ddbc63", null },
                    { "39587b99-dbd2-49da-884a-cd7047e02c9b", "1c01b40f-9d33-458f-af62-6df4403aebc0", null },
                    { "2cdd39df-5acd-4071-ac15-b349dfc3bde3", "1c01b40f-9d33-458f-af62-6df4403aebc0", null },
                    { "52e868d7-2bd2-4ee9-8217-84fc16a2a7e2", "ace12b17-c89a-490d-9f6e-653e37c2b9c6", null },
                    { "8597edeb-caa5-49ff-88ab-de2b5a54c656", "1c01b40f-9d33-458f-af62-6df4403aebc0", null },
                    { "5259a667-fc82-480d-8f4a-7fbb0fb37580", "1c01b40f-9d33-458f-af62-6df4403aebc0", null },
                    { "5a02dfdd-3493-4278-b9f0-8e4083bdaa88", "1c01b40f-9d33-458f-af62-6df4403aebc0", null },
                    { "e2718569-01a6-41fc-ad97-c3103de8034d", "1c01b40f-9d33-458f-af62-6df4403aebc0", null },
                    { "b1983ed1-48f5-4d06-91a9-2451daa4d454", "1c01b40f-9d33-458f-af62-6df4403aebc0", null },
                    { "98243625-ccef-4384-a6c7-630220c6f23e", "1c01b40f-9d33-458f-af62-6df4403aebc0", null },
                    { "3574ab93-3c65-4600-944b-26dfbfff4c38", "1c01b40f-9d33-458f-af62-6df4403aebc0", null },
                    { "1efae0cb-898c-4550-b3ae-af178f2716bb", "1c01b40f-9d33-458f-af62-6df4403aebc0", null },
                    { "6dd937d8-526a-4608-8721-f1f952bb0e15", "1c01b40f-9d33-458f-af62-6df4403aebc0", null },
                    { "d53c63e3-f060-4559-aada-ab94d9c11ad8", "1c01b40f-9d33-458f-af62-6df4403aebc0", null }
                });

            migrationBuilder.InsertData(
                table: "Tours",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "IsDeleted", "LastModifiedAt", "LastModifiedBy", "Name", "Price", "Specification", "Status", "TourCategoryId" },
                values: new object[,]
                {
                    { 18, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Du lịch Bảo Lộc - Hồ Tà Đùng - Đắk Nông - Khu Bảo Tồn Thiên Nhiên Nậm Nung", 2679000L, @"Thời gian: 3 ngày 2 đêm Phương tiện: Đi về bằng xesản xuất trà và đồi chè Tâm Châu.
                 Dừng...", 1, 4 },
                    { 11, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Du lịch [mùa nước nổi] Cầu Cao Lãnh - Châu Đốc - Làng Cá Bè  - Rừng Tràm Trà Sư", 1979000L, @"Thời gian: 2 ngày 1 đêm Phương tiện: Đi về bằng xe Xứ nổi tiếng hiển linh.
                 Tham quan Rừng Tràm...", 1, 3 },
                    { 17, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Du lịch Đà Lạt - Hồ Tuyền Lâm - Đường Hầm Điêu Khắc", 2379000L, "Thời gian: 3 ngày 2 đêm Phương tiện: Đi về bằng xem điêu khắc đất đỏ (Đà Lạt Star)  tái hiện...", 1, 4 },
                    { 16, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Du lịch Phú Quốc [Suối Tranh - Tặng Vé Cáp Treo Vượt Biển & Công Viên Nước  Hòn Thơm]", 3879000L, "Thời gian: 3 ngày 2 đêm Phương tiện: Hàng không Vietnam Airlinesnh  quý khách có thể đi dạo trong rừng, thư...", 1, 4 },
                    { 15, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Du lịch [Mùa Hoa Tam Giác Mạch] tại Hà Giang - Đồng Văn - Cao Bằng - Thác Bản Giốc - Pác Pó - Ba Bể", 9079000L, "Thời gian: 6 ngày 5 đêm Phương tiện: Hàng không Vietnam Airlines Đồng Văn  Công viên địa chất toàn cầu....", 1, 3 },
                    { 14, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Du lịch Đà Lạt - Thác Datanla - Đồi Chè Cầu Đất -Trang Trại Rau & Hoa - Thác Dambri", 3079000L, "Thời gian: 4 ngày 3 đêm Phương tiện: Đi về bằng xebri  ngọn thác hùng vĩ tại cao nguyên Bảo Lộc...", 1, 3 },
                    { 13, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Du lịch Hồ Tràm - Trải nghiệm đẳng cấp 5 sao The Grand Ho Tram Strip", 2379000L, "Thời gian: 2 ngày 1 đêm Phương tiện: Đi về bằng xeụ 5 sao cao cấp tại The Grand Ho Tram Strip...", 1, 3 },
                    { 12, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Du lịch Phan Thiết - Mũi Né - Làng Chài Xưa", 2379000L, "Thời gian: 3 ngày 2 đêm Phương tiện: Đi về bằng xevàng dưới tác động của gió biển đã tạo nên...", 1, 3 },
                    { 10, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Du lịch Mỹ Tho - Cần Thơ - Cà Mau - Bạc Liêu - Sóc Trăng", 3879000L, "Thời gian: 4 ngày 3 đêm Phương tiện: Đi về bằng xethức trái cây theo mùa, nghe nhạc tài tử Nam...", 1, 2 },
                    { 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Du lịch [Mùa Hoa Tam Giác Mạch] Hà Giang - Đồng Văn - Cao Bằng - Thác Bản Giốc- Lạng Sơn", 7529000L, "Thời gian: 5 ngày 4 đêm Phương tiện: Hàng không Vietnam Airlines Thanh  ngắm núi Tô Thị Vượt đèo Mã...", 1, 1 },
                    { 8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Du lịch Phan Thiết - Mũi Né - Lâu Đài Rượu Vang", 2739000L, @"Thời gian: 3 ngày 2 đêm Phương tiện: Đi về bằng xean trưng bày nghệ thuật “Làng chài xưa”
                 Chụp hình...", 1, 2 },
                    { 7, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Du lịch khám phá Cái Bè - Cần Thơ - Châu Đốc - Hà Tiên", 3679000L, "Thời gian: 4 ngày 3 đêm Phương tiện: Đi về bằng xeNam bộ hơn trăm năm tuổi, theo lối kiến trúc...", 1, 2 },
                    { 6, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Du lịch Đà Lạt - Dambri - Đường Hầm Điêu Khắc - Langbiang", 3079000L, "Thời gian: 4 ngày 3 đêm Phương tiện: Đi về bằng xeường Lâm Viên với không gian rộng lớn, thoáng mát hướng...", 1, 2 },
                    { 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Du lịch Nha Trang - Hòn Lao - Dốc Lết - I Resort - Làng Yến Mai Sinh", 2979000L, "Thời gian: 4 ngày 3 đêm Phương tiện: Đi về bằng xeịch Hòn Lao  đảo Khỉ, khu du lịch sinh...", 1, 1 },
                    { 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Du lịch Buôn Ma Thuột - Buôn Đôn - Pleiku - Komtum", 4879000L, @"Thời gian: 5 ngày 4 đêm Phương tiện: Đi về bằng xeay Nur hùng vĩ.
                 Tham quan cầu treo và ngắm...", 1, 1 },
                    { 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Du lịch Nha Trang - Đà Lạt", 4279000L, "Thời gian: 5 ngày 4 đêm Phương tiện: Đi về bằng xeVân hay còn gọi là Chùa Ốc, ngôi chùa làm...", 1, 1 },
                    { 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Du lịch Hải Phòng - Hạ Long - Ninh Bình - Hà Nội - Lào Cai - Sapa - Đền Hùng", 8029000L, "Thời gian: 6 ngày 5 đêm Phương tiện: Hàng không Vietnam Airlines Thăm quần thể di tích Bạch Đằng Giang với đền thờ các vị anh...A", 1, 1 },
                    { 19, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Du lịch Tây Ninh - Tòa Thánh Tây Ninh - Núi Bà Đen - Hồ Dầu Tiếng", 1879000L, "Thời gian: 2 ngày 1 đêm Phương tiện: Đi về bằng xeĐen ngon núi cao nhất Đông Nam Bộ&nbsp; chỉ mất...", 1, 4 },
                    { 9, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Du lịch Hà Nội - Lào Cai - Sapa - Hạ Long", 7129000L, @"Thời gian: 5 ngày 4 đêm Phương tiện: Hàng không Vietnam Airlinesn Cát Cát, ngắm toàn bộ cảnh Sapa từ Sân Mây
                ...", 1, 2 },
                    { 20, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Du lịch [Mùa nước nổi] Cao Lãnh - Tràm Chim Tam Nông - Khu Du Lịch Đồng Sen", 1779000L, "Thời gian: 2 ngày 1 đêm Viếng Khu Di tích Cụ Nguyễn Sinh Sắc (nhà sàn Bác Hồ, khu Lăng...", 1, 4 }
                });

            migrationBuilder.InsertData(
                table: "TourDetail",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "Index", "IsDeleted", "LastModifiedAt", "LastModifiedBy", "TourId", "TouristAttractionId" },
                values: new object[,]
                {
                    { 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, 1 },
                    { 27, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 3, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 10, 10 },
                    { 28, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 11, 1 },
                    { 29, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 11, 9 },
                    { 30, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 3, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 11, 10 },
                    { 31, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 12, 1 },
                    { 32, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 12, 11 },
                    { 33, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 13, 1 },
                    { 34, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 13, 13 },
                    { 35, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 14, 1 },
                    { 26, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 10, 9 },
                    { 36, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 14, 5 },
                    { 38, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 15, 8 },
                    { 39, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 16, 1 },
                    { 40, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 16, 14 },
                    { 41, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 17, 1 },
                    { 42, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 17, 5 },
                    { 43, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 18, 1 },
                    { 44, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 18, 15 },
                    { 45, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 19, 1 },
                    { 46, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 19, 16 },
                    { 37, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 15, 1 },
                    { 25, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 10, 1 },
                    { 24, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 4, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 9, 3 },
                    { 23, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 3, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 9, 12 },
                    { 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, 2 },
                    { 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 3, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, 3 },
                    { 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 4, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, 4 },
                    { 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2, 1 },
                    { 6, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2, 5 },
                    { 7, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 3, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2, 6 },
                    { 8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 3, 1 },
                    { 9, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 3, 7 },
                    { 10, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 4, 1 },
                    { 11, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 4, 8 },
                    { 12, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 5, 1 },
                    { 13, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 5, 6 },
                    { 14, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 6, 1 },
                    { 15, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 6, 5 },
                    { 16, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 7, 1 },
                    { 17, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 7, 9 },
                    { 18, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 3, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 7, 10 },
                    { 19, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 8, 1 },
                    { 20, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 8, 11 },
                    { 21, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 9, 1 },
                    { 22, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 9, 2 },
                    { 47, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 20, 1 },
                    { 48, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 20, 9 }
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
                name: "IX_AspNetUserRoles_ApplicationUserId",
                table: "AspNetUserRoles",
                column: "ApplicationUserId");

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

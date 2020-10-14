using Microsoft.EntityFrameworkCore.Migrations;

namespace src.Migrations
{
    public partial class AddTourDetailIndex : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "56a66fb7-a205-4889-941d-717122af9120", "13512338-bf10-4c70-9c15-baeaea46c977" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "8ffc1f45-6309-4977-bb75-06cf3f354a92", "be50c86b-5bfe-409b-84e4-d4667813bbc1" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "13512338-bf10-4c70-9c15-baeaea46c977");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "be50c86b-5bfe-409b-84e4-d4667813bbc1");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "56a66fb7-a205-4889-941d-717122af9120");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8ffc1f45-6309-4977-bb75-06cf3f354a92");

            migrationBuilder.AddColumn<int>(
                name: "Index",
                table: "TourDetail",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "8dd733ba-4a9a-46ba-ad3c-7be6148be60f", "1663c3d8-2614-4b96-ba86-ec53c9005439", "Admin", "admin" },
                    { "d47b5f6d-075f-4310-ba3c-99f467cbeb70", "4f523714-a9dd-4d70-9d44-904f670125eb", "SuperAdmin", "superadmin" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "104bd736-429a-4cc5-b06b-0dbad193f2f2", 0, "676ccc7c-fdd8-440e-95e7-cde4ab0ddf24", "lilsuperadmin@gmail.com", true, "Super Admin", "Lil", false, null, "LILSUPERADMIN@GMAIL.COM", "LILSUPERADMIN@GMAIL.COM", "AQAAAAEAACcQAAAAECQMKrQtrHZyiC0V/iLfE2IQPKV4qUQHh/xUdrmpIRTlgr6xRhu4kww9agPTBl8vlg==", null, false, "", false, "lilsuperadmin@gmail.com" },
                    { "bc3e91ea-352b-429d-a01b-fec29d2c83d8", 0, "cc62766e-7980-42bc-9b89-3e9cd3ec9d25", "yungadmin@gmail.com", true, "Admin", "Yung", false, null, "YUNGADMIN@GMAIL.COM", "YUNGADMIN@GMAIL.COM", "AQAAAAEAACcQAAAAEDY2s/ggnGUj0fwosKu90Lqot+p+ZgamAj6xS+JGOxYmx1iX7P7/LE1ChiSarSVCEg==", null, false, "", false, "yungadmin@gmail.com" }
                });

            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "Id",
                keyValue: 1,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "Id",
                keyValue: 2,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "Id",
                keyValue: 3,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "Id",
                keyValue: 4,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "Id",
                keyValue: 5,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "Id",
                keyValue: 6,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "Id",
                keyValue: 7,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "Id",
                keyValue: 8,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "Id",
                keyValue: 9,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "Id",
                keyValue: 10,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "Id",
                keyValue: 11,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "Id",
                keyValue: 12,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "Id",
                keyValue: 13,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "Id",
                keyValue: 14,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "Id",
                keyValue: 15,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "Id",
                keyValue: 16,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "Id",
                keyValue: 17,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "Id",
                keyValue: 18,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "Id",
                keyValue: 19,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "Id",
                keyValue: 20,
                column: "Status",
                value: 1);

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { "104bd736-429a-4cc5-b06b-0dbad193f2f2", "d47b5f6d-075f-4310-ba3c-99f467cbeb70" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { "bc3e91ea-352b-429d-a01b-fec29d2c83d8", "8dd733ba-4a9a-46ba-ad3c-7be6148be60f" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "104bd736-429a-4cc5-b06b-0dbad193f2f2", "d47b5f6d-075f-4310-ba3c-99f467cbeb70" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "bc3e91ea-352b-429d-a01b-fec29d2c83d8", "8dd733ba-4a9a-46ba-ad3c-7be6148be60f" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8dd733ba-4a9a-46ba-ad3c-7be6148be60f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d47b5f6d-075f-4310-ba3c-99f467cbeb70");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "104bd736-429a-4cc5-b06b-0dbad193f2f2");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bc3e91ea-352b-429d-a01b-fec29d2c83d8");

            migrationBuilder.DropColumn(
                name: "Index",
                table: "TourDetail");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "be50c86b-5bfe-409b-84e4-d4667813bbc1", "3026e349-85c6-4f9b-ac45-7c625bf959e8", "Admin", "admin" },
                    { "13512338-bf10-4c70-9c15-baeaea46c977", "ece4a625-3406-48d4-90d9-470f89c14c78", "SuperAdmin", "superadmin" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "56a66fb7-a205-4889-941d-717122af9120", 0, "fce35df6-5b66-4647-b142-79fe004512ef", "lilsuperadmin@gmail.com", true, "Super Admin", "Lil", false, null, "LILSUPERADMIN@GMAIL.COM", "LILSUPERADMIN@GMAIL.COM", "AQAAAAEAACcQAAAAEDzld0fCv0cX0l2+9AiHYo6nOIXiTeRDgAq6ryx7BiQj9/P+fQZlx0UP4EUHlNghSQ==", null, false, "", false, "lilsuperadmin@gmail.com" },
                    { "8ffc1f45-6309-4977-bb75-06cf3f354a92", 0, "4846cae3-b43e-44c3-810b-49eaff55377e", "yungadmin@gmail.com", true, "Admin", "Yung", false, null, "YUNGADMIN@GMAIL.COM", "YUNGADMIN@GMAIL.COM", "AQAAAAEAACcQAAAAEC7732+4m2uJ8rsoV2JRWMwhmyMa/k8d4BSLZ7ynKeSH+/YpAjyx3ri3szs89jDD+w==", null, false, "", false, "yungadmin@gmail.com" }
                });

            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "Id",
                keyValue: 1,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "Id",
                keyValue: 2,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "Id",
                keyValue: 3,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "Id",
                keyValue: 4,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "Id",
                keyValue: 5,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "Id",
                keyValue: 6,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "Id",
                keyValue: 7,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "Id",
                keyValue: 8,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "Id",
                keyValue: 9,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "Id",
                keyValue: 10,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "Id",
                keyValue: 11,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "Id",
                keyValue: 12,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "Id",
                keyValue: 13,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "Id",
                keyValue: 14,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "Id",
                keyValue: 15,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "Id",
                keyValue: 16,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "Id",
                keyValue: 17,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "Id",
                keyValue: 18,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "Id",
                keyValue: 19,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "Id",
                keyValue: 20,
                column: "Status",
                value: 1);

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { "56a66fb7-a205-4889-941d-717122af9120", "13512338-bf10-4c70-9c15-baeaea46c977" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { "8ffc1f45-6309-4977-bb75-06cf3f354a92", "be50c86b-5bfe-409b-84e4-d4667813bbc1" });
        }
    }
}

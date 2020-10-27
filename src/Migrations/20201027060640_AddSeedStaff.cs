using Microsoft.EntityFrameworkCore.Migrations;

namespace src.Migrations
{
    public partial class AddSeedStaff : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "0ffe9754-a1bf-4a29-9f4a-bb0a19853659", "4fea1aae-fd2a-44c7-a9b7-b49225a86d11" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "1976ae1a-ee6b-4bd9-a227-8ba9ee30b98a", "4fea1aae-fd2a-44c7-a9b7-b49225a86d11" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "2084507e-92df-4fa5-89e2-3c2f9428c364", "4fea1aae-fd2a-44c7-a9b7-b49225a86d11" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "27d469b4-9729-48ad-8715-9d264dd3bd9f", "4fea1aae-fd2a-44c7-a9b7-b49225a86d11" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "463a356e-e478-4681-8439-9e86d6f8e251", "4fea1aae-fd2a-44c7-a9b7-b49225a86d11" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "5bb1996c-6b75-4eb0-b089-3d08289c9d9d", "3b5324ce-1a69-4f29-89be-4f8d7607c2dd" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "5eabfe78-7a28-4fa7-a1fc-64fe0b421dd4", "4fea1aae-fd2a-44c7-a9b7-b49225a86d11" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "629cc1fd-6b5f-43e7-85b7-4574e5c08074", "4fea1aae-fd2a-44c7-a9b7-b49225a86d11" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "6ce4b4fe-9acc-4fc7-a767-e0ce435b072f", "4fea1aae-fd2a-44c7-a9b7-b49225a86d11" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "6dbd52b8-5c39-4afd-9c72-c1f425e9b1e0", "4fea1aae-fd2a-44c7-a9b7-b49225a86d11" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "938b7a45-e9ad-458b-b53f-720775ac0cc1", "4fea1aae-fd2a-44c7-a9b7-b49225a86d11" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "974f51d3-16f7-4a13-87fa-fb1f37e0cfbb", "4fea1aae-fd2a-44c7-a9b7-b49225a86d11" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "aa2110ef-7238-4639-86a9-49446256e7d4", "4fea1aae-fd2a-44c7-a9b7-b49225a86d11" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "f7e7d713-17e4-46e7-aef3-117064451eba", "4fea1aae-fd2a-44c7-a9b7-b49225a86d11" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "f81d71c4-6218-45b1-b094-c49973cfdcb9", "4fea1aae-fd2a-44c7-a9b7-b49225a86d11" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "fba1dd86-ed04-4630-9593-46ec71f617a2", "bfd279fd-a9f1-4e9d-aa1f-01b3f75a51ce" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "ff23da13-07c0-471b-b545-1552843c9e89", "4fea1aae-fd2a-44c7-a9b7-b49225a86d11" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3b5324ce-1a69-4f29-89be-4f8d7607c2dd");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4fea1aae-fd2a-44c7-a9b7-b49225a86d11");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bfd279fd-a9f1-4e9d-aa1f-01b3f75a51ce");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0ffe9754-a1bf-4a29-9f4a-bb0a19853659");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1976ae1a-ee6b-4bd9-a227-8ba9ee30b98a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2084507e-92df-4fa5-89e2-3c2f9428c364");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "27d469b4-9729-48ad-8715-9d264dd3bd9f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "463a356e-e478-4681-8439-9e86d6f8e251");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5bb1996c-6b75-4eb0-b089-3d08289c9d9d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5eabfe78-7a28-4fa7-a1fc-64fe0b421dd4");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "629cc1fd-6b5f-43e7-85b7-4574e5c08074");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6ce4b4fe-9acc-4fc7-a767-e0ce435b072f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6dbd52b8-5c39-4afd-9c72-c1f425e9b1e0");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "938b7a45-e9ad-458b-b53f-720775ac0cc1");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "974f51d3-16f7-4a13-87fa-fb1f37e0cfbb");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "aa2110ef-7238-4639-86a9-49446256e7d4");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f7e7d713-17e4-46e7-aef3-117064451eba");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f81d71c4-6218-45b1-b094-c49973cfdcb9");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fba1dd86-ed04-4630-9593-46ec71f617a2");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ff23da13-07c0-471b-b545-1552843c9e89");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "b8e1e6cf-f352-41f8-b9f7-92e06f10c5d0", "f014838a-5474-428f-a9db-1b3023a6f926", "Admin", "admin" },
                    { "a6de085e-0e1c-4a12-88d1-9a0170295d4e", "b742fe20-4554-4cfb-91a5-0441260e81d0", "SuperAdmin", "superadmin" },
                    { "78f19d50-d0be-4156-8d43-7e11411c212a", "3dde34da-d6d2-429a-ab63-5ec2ebd94520", "Customer", "customer" },
                    { "6ec8065b-2625-4823-b5f5-9c3800aa46ea", "b3eb4894-9f2c-413b-992c-e602631dbd04", "Staff", "staff" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "d38b71de-46f6-4a64-af41-ff69da635c3a", 0, "f48823fd-5010-429b-a84c-20abf4f48c98", "phantantrung@gmail.com", true, "Trung", "Phan Tấn", false, null, "PHANTANTRUNG@GMAIL.COM", "PHANTANTRUNG@GMAIL.COM", "AQAAAAEAACcQAAAAEEGeQckT6lm0fSfGalcFMtxP5PTOrBwv+YWAWBQmfHXqDTOP0krP6EE7EiJVROSOrQ==", null, false, "", false, "phantantrung@gmail.com" },
                    { "b1376c4c-cdec-4be1-a2f6-b879b8a3a1e7", 0, "57ab396e-e2d9-445e-9610-bcc128617a9a", "truongtuantu@gmail.com", true, "Tú", "Trương Tuấn", false, null, "TRUONGTUANTU@GMAIL.COM", "TRUONGTUANTU@GMAIL.COM", "AQAAAAEAACcQAAAAEIVB1Kn32oZ2b6gBNecrdvSHfTynShhUGaorjo14KIfvwWmjU0dUA8oNS8zxwXz/5Q==", null, false, "", false, "truongtuantu@gmail.com" },
                    { "1b36fa5c-6c33-4525-b17b-c2aefc395312", 0, "8d158823-8bd3-446f-baf0-a8bcaba87ec9", "truongthimaitram@gmail.com", true, "Trâm", "Trương Thị Mai", false, null, "TRUONGTHIMAITRAM@GMAIL.COM", "TRUONGTHIMAITRAM@GMAIL.COM", "AQAAAAEAACcQAAAAEFJgw3SRsNMB/oq/i9Rd6Yve4oRpT/jx/khdRhiGOifxEzGGy2LmSr/FfZpBSKfe4Q==", null, false, "", false, "truongthimaitram@gmail.com" },
                    { "178c7f02-9147-459c-bf80-cdbe2ce53ef2", 0, "12fd2882-5f1f-4a23-95fb-4fe6f9b3bab5", "nguyenbuuvinh@gmail.com", true, "Vinh", "Nguyễn Bửu", false, null, "NGUYENBUUVINH@GMAIL.COM", "NGUYENBUUVINH@GMAIL.COM", "AQAAAAEAACcQAAAAEHVssY05eYoau1zvg6bFCjQe1IWFFNiA2a6RLMhuX8UKOOwoQervluYF4pgQch27ZA==", null, false, "", false, "nguyenbuuvinh@gmail.com" },
                    { "2e18b3e5-492a-4a95-b140-53e3f838fe7d", 0, "2860dc0b-44a2-4c48-9288-f8ec09b75ccd", "lequangduy@gmail.com", true, "Duy", "Lê Quang", false, null, "LEQUANGDUY@GMAIL.COM", "LEQUANGDUY@GMAIL.COM", "AQAAAAEAACcQAAAAELEDfVSf8CQ9A8O57LtQZHmczQ7T8tsWEclDAmvn51JynQUXpASi2ECXGRsdhl1+nA==", null, false, "", false, "lequangduy@gmail.com" },
                    { "8aa9522a-f40b-43ac-a0ac-530d22581767", 0, "73743e84-d1c9-4375-b04e-af3fc972cfb0", "chuvietdung@gmail.com", true, "Dũng", "Chu Việt", false, null, "CHUVIETDUNG@GMAIL.COM", "CHUVIETDUNG@GMAIL.COM", "AQAAAAEAACcQAAAAEP4KRk7w7dn02OMJK8Dpyf3aNs42f0IZijTv9qxHW9kCm2Ri1u8ubrfQV0hun+AzDw==", null, false, "", false, "chuvietdung@gmail.com" },
                    { "842edac8-b013-4a9d-a43b-d1893f92bbae", 0, "2d2202a9-47d0-49d4-8a3b-9e35504ae0cf", "phungthanhdo@gmail.com", true, "Độ", "Phùng Thanh", false, null, "PHUNGTHANHDO@GMAIL.COM", "PHUNGTHANHDO@GMAIL.COM", "AQAAAAEAACcQAAAAENLK5Oha4Bw+/JrAxTFGxfP+ehvC9YPzlS4aexBmyoJnGlhcQ7OpdPXlt/9PZv7pfA==", null, false, "", false, "phungthanhdo@gmail.com" },
                    { "89a6ab91-a903-42cf-a9ed-342c3303c599", 0, "ecc0b1af-7141-49af-a89b-c759bbb4dc89", "buibichphuong@gmail.com", true, "Phương", "Bùi Bích", false, null, "BUIBICHPHUONG@GMAIL.COM", "BUIBICHPHUONG@GMAIL.COM", "AQAAAAEAACcQAAAAEL0Rhfanf3qKxndT3C9OAFjSkz6lg40mNWcG5ij29Uw5auDBpBugFuXfS+wgw5FaGw==", null, false, "", false, "buibichphuong@gmail.com" },
                    { "b8aa10f3-56ef-4bdf-a478-849297020388", 0, "f3c77fff-668b-4ccb-89d9-5e5c69f650bd", "tranphuongly@gmail.com", true, "Ly", "Trần Phương", false, null, "TRANPHUONGLY@GMAIL.COM", "TRANPHUONGLY@GMAIL.COM", "AQAAAAEAACcQAAAAENqxmFH+9O/4yWB0mnnk/MIMhwbjroqDGBwbitoQOC2qzzE1nbzaFCLB1lFS8AQlSw==", null, false, "", false, "tranphuongly@gmail.com" },
                    { "e6ab0a4a-ba9d-49e2-9e71-11385d94f02a", 0, "a5173c9a-c5f4-427a-9136-4ca9b0a46848", "luongtulinh@gmail.com", true, "Linh", "Lường Tú", false, null, "LUONGTULINH@GMAIL.COM", "LUONGTULINH@GMAIL.COM", "AQAAAAEAACcQAAAAEH8f8xwtTRb3CCqygLfm8+TPKfKV8f1BJqfnZiW5wUs9hWjEqZpbu0LHUDlc3Fv8MA==", null, false, "", false, "luongtulinh@gmail.com" },
                    { "5fe83d80-dbad-4a1c-aa4f-ff166fd45d8c", 0, "50e189fd-e8b7-49db-a6a1-3071f881878d", "malephixuan@gmail.com", true, "Xuân", "Mã Lệ Phi", false, null, "MALEPHIXUAN@GMAIL.COM", "MALEPHIXUAN@GMAIL.COM", "AQAAAAEAACcQAAAAEFF/U9+O9lBtzcATz1vA0P6OYPh0dk1bci51N3gya/EDADIJ3qKIUGOyx9id2w1SUw==", null, false, "", false, "malephixuan@gmail.com" },
                    { "99b50aa5-f4ea-4a2b-bebf-bf39089c848c", 0, "16af4416-a521-4ead-ba9d-721f4944aa8e", "luubaominh@gmail.com", true, "Minh", "Lưu Bảo", false, null, "LUUBAOMINH@GMAIL.COM", "LUUBAOMINH@GMAIL.COM", "AQAAAAEAACcQAAAAENOF8ipw+akgiL+x5h680MBWZ0+lcAz5BvtKFOTNG/2cCFwPBBloqwF60YdNiF/gqA==", null, false, "", false, "luubaominh@gmail.com" },
                    { "183ead64-e86a-4177-a112-38a7b7063eb6", 0, "5889db3c-cc1d-439d-8ae3-7727a72c33e5", "nguyenhue@gmail.com", true, "Huệ", "Nguyễn", false, null, "NGUYENHUE@GMAIL.COM", "NGUYENHUE@GMAIL.COM", "AQAAAAEAACcQAAAAEJ4FKJzIfrK/5w1peV2GfSOLy7DR3VczSXGeS/njaKzxdkus5O/hIC7fdvFPBnN2Qg==", null, false, "", false, "nguyenhue@gmail.com" },
                    { "95b366de-8bf5-4281-a545-dd9eb18639a2", 0, "af6ed8cf-4d0d-4170-87b1-0ef263eb6579", "duonghoanphong@gmail.com", true, "Phong", "Đường Hoán", false, null, "DUONGHOANPHONG@GMAIL.COM", "DUONGHOANPHONG@GMAIL.COM", "AQAAAAEAACcQAAAAEIzi3Vmo6TPvHRrwfUCBB9U/dDL/bd/gcLZsYtpQ1l35Fx4rLNcOIGwc2GKvY7OGog==", null, false, "", false, "duonghoanphong@gmail.com" },
                    { "8c2614be-55ea-4443-98e5-eb14bf7d5f4b", 0, "f7fe22d0-a7bc-4b05-a993-8162551165c6", "nguyenthanhlong@gmail.com", true, "Long", "Nguyễn Thành", false, null, "NGUYENTHANHLONG@GMAIL.COM", "NGUYENTHANHLONG@GMAIL.COM", "AQAAAAEAACcQAAAAEEVSfTF7X/t64NJKVEtbDDiUrJAVYu6P8QGxv+X9/VhiO13o6Iu0si5MFmZ4rsA4BA==", null, false, "", false, "nguyenthanhlong@gmail.com" },
                    { "3152e310-1de7-464f-9465-e04498d4074d", 0, "c5b84232-771b-4ac2-9499-386c0a54bf96", "huynhtranthanh@gmail.com", true, "Thành", "Huỳnh Trấn", false, null, "HUYNHTRANTHANH@GMAIL.COM", "HUYNHTRANTHANH@GMAIL.COM", "AQAAAAEAACcQAAAAELamyFRd9RWVE+9sMmJYJ969dOR6BkWc8IJFWCeKBIilDd54SLp0MfrSkaj2arWDbA==", null, false, "", false, "huynhtranthanh@gmail.com" },
                    { "8adfe452-61d5-495a-83af-4170df7e664c", 0, "95b0d7e4-5414-49ce-84e1-27bb48769a6e", "caobaquat@gmail.com", true, "Quát", "Cao Bá", false, null, "CAOBAQUAT@GMAIL.COM", "CAOBAQUAT@GMAIL.COM", "AQAAAAEAACcQAAAAEKT/q+/0STb4o8Y72csLh/YU6a+9HngVJDToj7xmrZturQgMdpT0a7P8oJufCkjmLQ==", null, false, "", false, "caobaquat@gmail.com" },
                    { "d9c82783-590f-4ed2-a922-e026a747c68b", 0, "d822db49-fb5f-4728-aaeb-fd9a4cedd743", "truongthitramanh@gmail.com", true, "Anh", "Trương Thị Trâm", false, null, "TRUONGTHITRAMANH@GMAIL.COM", "TRUONGTHITRAMANH@GMAIL.COM", "AQAAAAEAACcQAAAAEAcG+Gf+JXSudBxEmH74isESnwgsJa/V1Naif5shT1SXyRboSYVj4pQwXiNBwF8ufw==", null, false, "", false, "truongthitramanh@gmail.com" },
                    { "f326e92b-df61-458e-b0d8-4f5051627533", 0, "3f952b71-695f-4ead-b514-d379abe7888d", "tranthaonguyen@gmail.com", true, "Nguyên", "Trần Thảo", false, null, "TRANTHAONGUYEN@GMAIL.COM", "TRANTHAONGUYEN@GMAIL.COM", "AQAAAAEAACcQAAAAEDpUadvYDIhpaY8wqHyRrBLznwQBGSwoNMktP/gmaMawH7AOEkw9SWVaQocROoguiQ==", null, false, "", false, "tranthaonguyen@gmail.com" },
                    { "863ba332-92c5-4af6-b30b-5bc52efc55c1", 0, "8bbecedd-9f3c-4079-bd01-acb973fd05ad", "caothivananh@gmail.com", true, "Anh", "Cao Thị Vân", false, null, "CAOTHIVANANH@GMAIL.COM", "CAOTHIVANANH@GMAIL.COM", "AQAAAAEAACcQAAAAEClZP8fXZkzarA0LB+laxCjwOuGbwqhkUex/qq3MEE5ALfJBjMi6X6kgo6ieBe4B/g==", null, false, "", false, "caothivananh@gmail.com" },
                    { "0f050691-a852-4575-b5e4-112ecc52bc07", 0, "cad24d79-b0b4-4b62-9200-fbc72a531ec0", "nguyennhuloc@gmail.com", true, "Lộc", "Nguyễn Như", false, null, "NGUYENNHULOC@GMAIL.COM", "NGUYENNHULOC@GMAIL.COM", "AQAAAAEAACcQAAAAENzRurf/BGUZM1GluVNf7ic/4ZChCCbf+t68a7WeWKTqo+odwklvITyceaYTvy3pKw==", null, false, "", false, "nguyennhuloc@gmail.com" },
                    { "be841763-2cd6-4e65-b5a5-aa144cca8ad6", 0, "6a2a9e30-4112-42fb-a2b7-1cf6400a8ac8", "hoxuanhuong@gmail.com", true, "Hương", "Hồ Xuân", false, null, "HOXUANHUONG@GMAIL.COM", "HOXUANHUONG@GMAIL.COM", "AQAAAAEAACcQAAAAELZ7eXQXOj0WP041lhu8u9QF5bmLRPscYfNvMxHxf9Q8P4Ig6SCB/KJ4u1xRkMzAiA==", null, false, "", false, "hoxuanhuong@gmail.com" },
                    { "2a741a67-dc3d-4350-9171-5315b8b37efc", 0, "09c08ea1-c572-4764-a73c-99edc8b85cc2", "nguyentrunghieu@gmail.com", true, "Hiếu", "Nguyễn Trung", false, null, "NGUYENTRUNGHIEU@GMAIL.COM", "NGUYENTRUNGHIEU@GMAIL.COM", "AQAAAAEAACcQAAAAEJ13n1iMz6dMJqgJQHPfwQ+6qI7UclgIA15Y4R/iXNAA9tY+fYT+A4updHvT/aZe7w==", null, false, "", false, "nguyentrunghieu@gmail.com" },
                    { "38f0eb81-d0df-4f1f-9ac3-96789c41a8a9", 0, "223586ee-61a6-4eb1-bc3b-cace229fec1f", "phamvinhson@gmail.com", true, "Sơn", "Phạm Vĩnh", false, null, "PHAMVINHSON@GMAIL.COM", "PHAMVINHSON@GMAIL.COM", "AQAAAAEAACcQAAAAEJt6cCW3WbnmOU4381FAj9qzUNJdZ7NNwHzKDeFpnjDEL/TiWw/RgrfzyxJ5jgqLfg==", null, false, "", false, "phamvinhson@gmail.com" },
                    { "c9f8c5c8-7561-41a9-91ad-77f711c37fd3", 0, "6919c533-af08-4645-b41f-b608d51a88f4", "trankieuloan@gmail.com", true, "Loan", "Trần Kiều", false, null, "TRANKIEULOAN@GMAIL.COM", "TRANKIEULOAN@GMAIL.COM", "AQAAAAEAACcQAAAAEATY5SVnptpUZz5NKaCqELX7xYc8/mN1sDTveT1Q1e4dzJuEGvjJs3BJotfclg/W2A==", null, false, "", false, "trankieuloan@gmail.com" },
                    { "513a7079-65ce-4496-9315-ae65b69a733e", 0, "c22137b3-c73e-4504-8eb6-936e9eeefe97", "yungadmin@gmail.com", true, "Admin", "Yung", false, null, "YUNGADMIN@GMAIL.COM", "YUNGADMIN@GMAIL.COM", "AQAAAAEAACcQAAAAEDn9fc/EC0wDWLEUgjdrUXD5mogNYxdtg03guvS5lkrWimhP1Y+s0moL5n9IlTvfDQ==", null, false, "", false, "yungadmin@gmail.com" },
                    { "3400e7f9-76d1-4589-80d1-d7d8a10c8b50", 0, "13017515-0e13-4dee-b3b3-f57041f8ce29", "lilsuperadmin@gmail.com", true, "Super Admin", "Lil", false, null, "LILSUPERADMIN@GMAIL.COM", "LILSUPERADMIN@GMAIL.COM", "AQAAAAEAACcQAAAAEGgifTJupRO706mwDL9lszV90iANGrexID05sgE8QYAuVaTAE5n1vWBvwoTvWPjjzQ==", null, false, "", false, "lilsuperadmin@gmail.com" }
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
                values: new object[,]
                {
                    { "3400e7f9-76d1-4589-80d1-d7d8a10c8b50", "a6de085e-0e1c-4a12-88d1-9a0170295d4e" },
                    { "b8aa10f3-56ef-4bdf-a478-849297020388", "6ec8065b-2625-4823-b5f5-9c3800aa46ea" },
                    { "89a6ab91-a903-42cf-a9ed-342c3303c599", "6ec8065b-2625-4823-b5f5-9c3800aa46ea" },
                    { "8aa9522a-f40b-43ac-a0ac-530d22581767", "6ec8065b-2625-4823-b5f5-9c3800aa46ea" },
                    { "95b366de-8bf5-4281-a545-dd9eb18639a2", "6ec8065b-2625-4823-b5f5-9c3800aa46ea" },
                    { "99b50aa5-f4ea-4a2b-bebf-bf39089c848c", "6ec8065b-2625-4823-b5f5-9c3800aa46ea" },
                    { "2e18b3e5-492a-4a95-b140-53e3f838fe7d", "6ec8065b-2625-4823-b5f5-9c3800aa46ea" },
                    { "178c7f02-9147-459c-bf80-cdbe2ce53ef2", "6ec8065b-2625-4823-b5f5-9c3800aa46ea" },
                    { "1b36fa5c-6c33-4525-b17b-c2aefc395312", "6ec8065b-2625-4823-b5f5-9c3800aa46ea" },
                    { "b1376c4c-cdec-4be1-a2f6-b879b8a3a1e7", "78f19d50-d0be-4156-8d43-7e11411c212a" },
                    { "d38b71de-46f6-4a64-af41-ff69da635c3a", "78f19d50-d0be-4156-8d43-7e11411c212a" },
                    { "842edac8-b013-4a9d-a43b-d1893f92bbae", "78f19d50-d0be-4156-8d43-7e11411c212a" },
                    { "e6ab0a4a-ba9d-49e2-9e71-11385d94f02a", "6ec8065b-2625-4823-b5f5-9c3800aa46ea" },
                    { "183ead64-e86a-4177-a112-38a7b7063eb6", "78f19d50-d0be-4156-8d43-7e11411c212a" },
                    { "8c2614be-55ea-4443-98e5-eb14bf7d5f4b", "78f19d50-d0be-4156-8d43-7e11411c212a" },
                    { "3152e310-1de7-464f-9465-e04498d4074d", "78f19d50-d0be-4156-8d43-7e11411c212a" },
                    { "8adfe452-61d5-495a-83af-4170df7e664c", "78f19d50-d0be-4156-8d43-7e11411c212a" },
                    { "d9c82783-590f-4ed2-a922-e026a747c68b", "78f19d50-d0be-4156-8d43-7e11411c212a" },
                    { "f326e92b-df61-458e-b0d8-4f5051627533", "78f19d50-d0be-4156-8d43-7e11411c212a" },
                    { "863ba332-92c5-4af6-b30b-5bc52efc55c1", "78f19d50-d0be-4156-8d43-7e11411c212a" },
                    { "0f050691-a852-4575-b5e4-112ecc52bc07", "78f19d50-d0be-4156-8d43-7e11411c212a" },
                    { "2a741a67-dc3d-4350-9171-5315b8b37efc", "78f19d50-d0be-4156-8d43-7e11411c212a" },
                    { "38f0eb81-d0df-4f1f-9ac3-96789c41a8a9", "78f19d50-d0be-4156-8d43-7e11411c212a" },
                    { "c9f8c5c8-7561-41a9-91ad-77f711c37fd3", "78f19d50-d0be-4156-8d43-7e11411c212a" },
                    { "513a7079-65ce-4496-9315-ae65b69a733e", "b8e1e6cf-f352-41f8-b9f7-92e06f10c5d0" },
                    { "be841763-2cd6-4e65-b5a5-aa144cca8ad6", "78f19d50-d0be-4156-8d43-7e11411c212a" },
                    { "5fe83d80-dbad-4a1c-aa4f-ff166fd45d8c", "6ec8065b-2625-4823-b5f5-9c3800aa46ea" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "0f050691-a852-4575-b5e4-112ecc52bc07", "78f19d50-d0be-4156-8d43-7e11411c212a" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "178c7f02-9147-459c-bf80-cdbe2ce53ef2", "6ec8065b-2625-4823-b5f5-9c3800aa46ea" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "183ead64-e86a-4177-a112-38a7b7063eb6", "78f19d50-d0be-4156-8d43-7e11411c212a" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "1b36fa5c-6c33-4525-b17b-c2aefc395312", "6ec8065b-2625-4823-b5f5-9c3800aa46ea" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "2a741a67-dc3d-4350-9171-5315b8b37efc", "78f19d50-d0be-4156-8d43-7e11411c212a" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "2e18b3e5-492a-4a95-b140-53e3f838fe7d", "6ec8065b-2625-4823-b5f5-9c3800aa46ea" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "3152e310-1de7-464f-9465-e04498d4074d", "78f19d50-d0be-4156-8d43-7e11411c212a" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "3400e7f9-76d1-4589-80d1-d7d8a10c8b50", "a6de085e-0e1c-4a12-88d1-9a0170295d4e" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "38f0eb81-d0df-4f1f-9ac3-96789c41a8a9", "78f19d50-d0be-4156-8d43-7e11411c212a" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "513a7079-65ce-4496-9315-ae65b69a733e", "b8e1e6cf-f352-41f8-b9f7-92e06f10c5d0" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "5fe83d80-dbad-4a1c-aa4f-ff166fd45d8c", "6ec8065b-2625-4823-b5f5-9c3800aa46ea" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "842edac8-b013-4a9d-a43b-d1893f92bbae", "78f19d50-d0be-4156-8d43-7e11411c212a" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "863ba332-92c5-4af6-b30b-5bc52efc55c1", "78f19d50-d0be-4156-8d43-7e11411c212a" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "89a6ab91-a903-42cf-a9ed-342c3303c599", "6ec8065b-2625-4823-b5f5-9c3800aa46ea" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "8aa9522a-f40b-43ac-a0ac-530d22581767", "6ec8065b-2625-4823-b5f5-9c3800aa46ea" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "8adfe452-61d5-495a-83af-4170df7e664c", "78f19d50-d0be-4156-8d43-7e11411c212a" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "8c2614be-55ea-4443-98e5-eb14bf7d5f4b", "78f19d50-d0be-4156-8d43-7e11411c212a" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "95b366de-8bf5-4281-a545-dd9eb18639a2", "6ec8065b-2625-4823-b5f5-9c3800aa46ea" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "99b50aa5-f4ea-4a2b-bebf-bf39089c848c", "6ec8065b-2625-4823-b5f5-9c3800aa46ea" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "b1376c4c-cdec-4be1-a2f6-b879b8a3a1e7", "78f19d50-d0be-4156-8d43-7e11411c212a" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "b8aa10f3-56ef-4bdf-a478-849297020388", "6ec8065b-2625-4823-b5f5-9c3800aa46ea" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "be841763-2cd6-4e65-b5a5-aa144cca8ad6", "78f19d50-d0be-4156-8d43-7e11411c212a" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "c9f8c5c8-7561-41a9-91ad-77f711c37fd3", "78f19d50-d0be-4156-8d43-7e11411c212a" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "d38b71de-46f6-4a64-af41-ff69da635c3a", "78f19d50-d0be-4156-8d43-7e11411c212a" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "d9c82783-590f-4ed2-a922-e026a747c68b", "78f19d50-d0be-4156-8d43-7e11411c212a" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "e6ab0a4a-ba9d-49e2-9e71-11385d94f02a", "6ec8065b-2625-4823-b5f5-9c3800aa46ea" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "f326e92b-df61-458e-b0d8-4f5051627533", "78f19d50-d0be-4156-8d43-7e11411c212a" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6ec8065b-2625-4823-b5f5-9c3800aa46ea");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "78f19d50-d0be-4156-8d43-7e11411c212a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a6de085e-0e1c-4a12-88d1-9a0170295d4e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b8e1e6cf-f352-41f8-b9f7-92e06f10c5d0");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0f050691-a852-4575-b5e4-112ecc52bc07");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "178c7f02-9147-459c-bf80-cdbe2ce53ef2");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "183ead64-e86a-4177-a112-38a7b7063eb6");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1b36fa5c-6c33-4525-b17b-c2aefc395312");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2a741a67-dc3d-4350-9171-5315b8b37efc");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2e18b3e5-492a-4a95-b140-53e3f838fe7d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3152e310-1de7-464f-9465-e04498d4074d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3400e7f9-76d1-4589-80d1-d7d8a10c8b50");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "38f0eb81-d0df-4f1f-9ac3-96789c41a8a9");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "513a7079-65ce-4496-9315-ae65b69a733e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5fe83d80-dbad-4a1c-aa4f-ff166fd45d8c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "842edac8-b013-4a9d-a43b-d1893f92bbae");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "863ba332-92c5-4af6-b30b-5bc52efc55c1");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "89a6ab91-a903-42cf-a9ed-342c3303c599");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8aa9522a-f40b-43ac-a0ac-530d22581767");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8adfe452-61d5-495a-83af-4170df7e664c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8c2614be-55ea-4443-98e5-eb14bf7d5f4b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "95b366de-8bf5-4281-a545-dd9eb18639a2");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "99b50aa5-f4ea-4a2b-bebf-bf39089c848c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b1376c4c-cdec-4be1-a2f6-b879b8a3a1e7");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b8aa10f3-56ef-4bdf-a478-849297020388");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "be841763-2cd6-4e65-b5a5-aa144cca8ad6");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c9f8c5c8-7561-41a9-91ad-77f711c37fd3");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d38b71de-46f6-4a64-af41-ff69da635c3a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d9c82783-590f-4ed2-a922-e026a747c68b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e6ab0a4a-ba9d-49e2-9e71-11385d94f02a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f326e92b-df61-458e-b0d8-4f5051627533");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "3b5324ce-1a69-4f29-89be-4f8d7607c2dd", "59807ca2-06e3-4e6e-bc28-fe002347d277", "Admin", "admin" },
                    { "bfd279fd-a9f1-4e9d-aa1f-01b3f75a51ce", "20f6adeb-4dcf-4174-8f87-6dfceb8db2a4", "SuperAdmin", "superadmin" },
                    { "4fea1aae-fd2a-44c7-a9b7-b49225a86d11", "192ec49c-9fff-4b28-9a0b-1bf0e70ff0f1", "Customer", "customer" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "6dbd52b8-5c39-4afd-9c72-c1f425e9b1e0", 0, "7cfd2c9c-9f0f-4b89-8be9-7e5cbc224a95", "phantantrung@gmail.com", true, "Trung", "Phan Tấn", false, null, "PHANTANTRUNG@GMAIL.COM", "PHANTANTRUNG@GMAIL.COM", "AQAAAAEAACcQAAAAED/csjZ/fxBG6gwnnKzg7xXcupoBBzQ6YUtg9YV7ChUt4W05UNrM2QemUlothHUXZg==", null, false, "", false, "phantantrung@gmail.com" },
                    { "6ce4b4fe-9acc-4fc7-a767-e0ce435b072f", 0, "123c43f5-fd39-47e6-85d8-f0cfe51b39d6", "phungthanhdo@gmail.com", true, "Độ", "Phùng Thanh", false, null, "PHUNGTHANHDO@GMAIL.COM", "PHUNGTHANHDO@GMAIL.COM", "AQAAAAEAACcQAAAAEHuHy8DiqTe0fMXN+E3skF0U6v7NTksP+epaI2b/5KH6VAj2Zp5Hok77tenKVqpl/Q==", null, false, "", false, "phungthanhdo@gmail.com" },
                    { "5eabfe78-7a28-4fa7-a1fc-64fe0b421dd4", 0, "3efd5509-9215-49b3-bed3-8f009a446aac", "nguyenhue@gmail.com", true, "Huệ", "Nguyễn", false, null, "NGUYENHUE@GMAIL.COM", "NGUYENHUE@GMAIL.COM", "AQAAAAEAACcQAAAAED31fpUK41slJHR5AZ2g0gmVSFBhxQ0Lidx3ZxlkvHjalRamxxcL4znaa0xP6Mc7oA==", null, false, "", false, "nguyenhue@gmail.com" },
                    { "1976ae1a-ee6b-4bd9-a227-8ba9ee30b98a", 0, "180f5ca5-31a4-43cc-9f7a-fb2e8d8de06d", "hoxuanhuong@gmail.com", true, "Hương", "Hồ Xuân", false, null, "HOXUANHUONG@GMAIL.COM", "HOXUANHUONG@GMAIL.COM", "AQAAAAEAACcQAAAAEKum35LKaLHjKJYnMxKlTrHYvj3M5kCaq+WTbOtFYdDvuuUXwC66JOXmxy9tOZTwWA==", null, false, "", false, "hoxuanhuong@gmail.com" },
                    { "974f51d3-16f7-4a13-87fa-fb1f37e0cfbb", 0, "ef90bace-38f7-4066-a09a-dca21919f117", "nguyenthanhlong@gmail.com", true, "Long", "Nguyễn Thành", false, null, "NGUYENTHANHLONG@GMAIL.COM", "NGUYENTHANHLONG@GMAIL.COM", "AQAAAAEAACcQAAAAECLp8kmszc0uTClLSgK5VcMYm8SR4BeQNSVdhh+yp3vcSKIoFrEji2OtPtukvNLKNQ==", null, false, "", false, "nguyenthanhlong@gmail.com" },
                    { "f81d71c4-6218-45b1-b094-c49973cfdcb9", 0, "e45fb137-9a6a-408e-92d2-6eacc37f75ef", "huynhtranthanh@gmail.com", true, "Thành", "Huỳnh Trấn", false, null, "HUYNHTRANTHANH@GMAIL.COM", "HUYNHTRANTHANH@GMAIL.COM", "AQAAAAEAACcQAAAAEKA/CQ5J+KyTmobQxJi5iYCB0msFWFQWz4AYmS4bywJFdlx2fcDpvQ/o8+Y0xOcfLw==", null, false, "", false, "huynhtranthanh@gmail.com" },
                    { "629cc1fd-6b5f-43e7-85b7-4574e5c08074", 0, "0850ccfc-78cf-4027-98e6-b062a8b82f68", "caobaquat@gmail.com", true, "Quát", "Cao Bá", false, null, "CAOBAQUAT@GMAIL.COM", "CAOBAQUAT@GMAIL.COM", "AQAAAAEAACcQAAAAEKrbOHCkBBH4ElBF9XS2qg13bZwfoR7MVAaAINKMnE7lkJb6FMzs2PeLd60TfWG30w==", null, false, "", false, "caobaquat@gmail.com" },
                    { "463a356e-e478-4681-8439-9e86d6f8e251", 0, "c93de8b0-57e1-432f-bb01-19200cd6ac7c", "truongthitramanh@gmail.com", true, "Anh", "Trương Thị Trâm", false, null, "TRUONGTHITRAMANH@GMAIL.COM", "TRUONGTHITRAMANH@GMAIL.COM", "AQAAAAEAACcQAAAAEK28sCGsFgX4NbTHhR9PxPZWwo/tmhfYsVr8wAXIc97/Vv2WdYS21z+mowTJu30DWA==", null, false, "", false, "truongthitramanh@gmail.com" },
                    { "27d469b4-9729-48ad-8715-9d264dd3bd9f", 0, "a4450def-ec5c-4557-9b40-6da806ec6350", "truongtuantu@gmail.com", true, "Tú", "Trương Tuấn", false, null, "TRUONGTUANTU@GMAIL.COM", "TRUONGTUANTU@GMAIL.COM", "AQAAAAEAACcQAAAAEPjkDtI6J5DCjO8pTA1G70mOwgazV9+hQNWqCysSW0POaqAGO9E/4Uj7ut6Wh4zCnw==", null, false, "", false, "truongtuantu@gmail.com" },
                    { "2084507e-92df-4fa5-89e2-3c2f9428c364", 0, "e4d393cf-4dc0-4a50-9b78-57c7f7d69dee", "caothivananh@gmail.com", true, "Anh", "Cao Thị Vân", false, null, "CAOTHIVANANH@GMAIL.COM", "CAOTHIVANANH@GMAIL.COM", "AQAAAAEAACcQAAAAEFCq0pzZfioz6vlt0LcUklwvYTiBqco4xdX7y+RowO2CpivxBEVrff6vaW3S7E2kiQ==", null, false, "", false, "caothivananh@gmail.com" },
                    { "938b7a45-e9ad-458b-b53f-720775ac0cc1", 0, "4ea1c72a-8ca7-4e17-8847-888d9a343133", "nguyennhuloc@gmail.com", true, "Lộc", "Nguyễn Như", false, null, "NGUYENNHULOC@GMAIL.COM", "NGUYENNHULOC@GMAIL.COM", "AQAAAAEAACcQAAAAEBQ6zCb5Adb7eRpAiGotfNSVb2AKyyOwMyMt1caBR/LFPVtC0Abpa3EciugNJGk9fg==", null, false, "", false, "nguyennhuloc@gmail.com" },
                    { "f7e7d713-17e4-46e7-aef3-117064451eba", 0, "820555eb-8110-4302-a232-ea9eeb56cab4", "nguyentrunghieu@gmail.com", true, "Hiếu", "Nguyễn Trung", false, null, "NGUYENTRUNGHIEU@GMAIL.COM", "NGUYENTRUNGHIEU@GMAIL.COM", "AQAAAAEAACcQAAAAEFIE0sTWt/4nbjK2GI48s9wTOc/WskRHN6n93Nai0DvUhVD3fFoDah1QZbtqcTO+zg==", null, false, "", false, "nguyentrunghieu@gmail.com" },
                    { "aa2110ef-7238-4639-86a9-49446256e7d4", 0, "ec22d7cf-1ec2-48a0-a7b4-f80f7b3b9c64", "phamvinhson@gmail.com", true, "Sơn", "Phạm Vĩnh", false, null, "PHAMVINHSON@GMAIL.COM", "PHAMVINHSON@GMAIL.COM", "AQAAAAEAACcQAAAAEO6yHiI8oQZ9svdybtkdmQ0lWOuXC5SfquYdrNg7g4s4hxx4DIqV0Y9pfn2b/fmYzw==", null, false, "", false, "phamvinhson@gmail.com" },
                    { "ff23da13-07c0-471b-b545-1552843c9e89", 0, "c2bfdfad-41a6-4967-ac0b-ab9b40bba2f4", "trankieuloan@gmail.com", true, "Loan", "Trần Kiều", false, null, "TRANKIEULOAN@GMAIL.COM", "TRANKIEULOAN@GMAIL.COM", "AQAAAAEAACcQAAAAEDXjAIp+a7iEp222JQZldBK/KANiE3Ojtg14bx3yTAX+i3XiB523sSJfknDWc9ATqw==", null, false, "", false, "trankieuloan@gmail.com" },
                    { "5bb1996c-6b75-4eb0-b089-3d08289c9d9d", 0, "1b691973-e42e-41ba-afa1-80d4cc39a395", "yungadmin@gmail.com", true, "Admin", "Yung", false, null, "YUNGADMIN@GMAIL.COM", "YUNGADMIN@GMAIL.COM", "AQAAAAEAACcQAAAAEBMBhczdfgp9GJSKXu6MBmavPYQbgPWMqvJHekQWudTPW3eYJqAJdv48ob/N+QfRug==", null, false, "", false, "yungadmin@gmail.com" },
                    { "fba1dd86-ed04-4630-9593-46ec71f617a2", 0, "36a2992e-ad9c-4b08-bbe7-308430ee9b7a", "lilsuperadmin@gmail.com", true, "Super Admin", "Lil", false, null, "LILSUPERADMIN@GMAIL.COM", "LILSUPERADMIN@GMAIL.COM", "AQAAAAEAACcQAAAAEHxhmKdj00gBxbVay1QJvsVUQLAmjneNvtw2seSAJWz4LZQcEGnMiHj+TrWIvOecpQ==", null, false, "", false, "lilsuperadmin@gmail.com" },
                    { "0ffe9754-a1bf-4a29-9f4a-bb0a19853659", 0, "021c978a-37ab-4cdf-b439-9a53c224b736", "tranthaonguyen@gmail.com", true, "Nguyên", "Trần Thảo", false, null, "TRANTHAONGUYEN@GMAIL.COM", "TRANTHAONGUYEN@GMAIL.COM", "AQAAAAEAACcQAAAAEARmVN+p1jr674Gw4+rbUn7oJoR+c/Lj5TNEt1NbCj3Su0OZkK5zZcumRlrXzlb30A==", null, false, "", false, "tranthaonguyen@gmail.com" }
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
                values: new object[,]
                {
                    { "fba1dd86-ed04-4630-9593-46ec71f617a2", "bfd279fd-a9f1-4e9d-aa1f-01b3f75a51ce" },
                    { "6ce4b4fe-9acc-4fc7-a767-e0ce435b072f", "4fea1aae-fd2a-44c7-a9b7-b49225a86d11" },
                    { "5eabfe78-7a28-4fa7-a1fc-64fe0b421dd4", "4fea1aae-fd2a-44c7-a9b7-b49225a86d11" },
                    { "1976ae1a-ee6b-4bd9-a227-8ba9ee30b98a", "4fea1aae-fd2a-44c7-a9b7-b49225a86d11" },
                    { "974f51d3-16f7-4a13-87fa-fb1f37e0cfbb", "4fea1aae-fd2a-44c7-a9b7-b49225a86d11" },
                    { "f81d71c4-6218-45b1-b094-c49973cfdcb9", "4fea1aae-fd2a-44c7-a9b7-b49225a86d11" },
                    { "629cc1fd-6b5f-43e7-85b7-4574e5c08074", "4fea1aae-fd2a-44c7-a9b7-b49225a86d11" },
                    { "6dbd52b8-5c39-4afd-9c72-c1f425e9b1e0", "4fea1aae-fd2a-44c7-a9b7-b49225a86d11" },
                    { "463a356e-e478-4681-8439-9e86d6f8e251", "4fea1aae-fd2a-44c7-a9b7-b49225a86d11" },
                    { "2084507e-92df-4fa5-89e2-3c2f9428c364", "4fea1aae-fd2a-44c7-a9b7-b49225a86d11" },
                    { "938b7a45-e9ad-458b-b53f-720775ac0cc1", "4fea1aae-fd2a-44c7-a9b7-b49225a86d11" },
                    { "f7e7d713-17e4-46e7-aef3-117064451eba", "4fea1aae-fd2a-44c7-a9b7-b49225a86d11" },
                    { "aa2110ef-7238-4639-86a9-49446256e7d4", "4fea1aae-fd2a-44c7-a9b7-b49225a86d11" },
                    { "ff23da13-07c0-471b-b545-1552843c9e89", "4fea1aae-fd2a-44c7-a9b7-b49225a86d11" },
                    { "5bb1996c-6b75-4eb0-b089-3d08289c9d9d", "3b5324ce-1a69-4f29-89be-4f8d7607c2dd" },
                    { "0ffe9754-a1bf-4a29-9f4a-bb0a19853659", "4fea1aae-fd2a-44c7-a9b7-b49225a86d11" },
                    { "27d469b4-9729-48ad-8715-9d264dd3bd9f", "4fea1aae-fd2a-44c7-a9b7-b49225a86d11" }
                });
        }
    }
}

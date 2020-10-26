using Microsoft.EntityFrameworkCore.Migrations;

namespace src.Migrations
{
    public partial class ConfigApplicationUserKey : Migration
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

            migrationBuilder.AddColumn<string>(
                name: "ApplicationUserId",
                table: "AspNetUserRoles",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "ec8b09b4-979d-48de-8074-abfc9632deee", "cd822195-1074-41ba-a542-bdf396071321", "Admin", "admin" },
                    { "dfacdcdc-24d7-4739-8a6a-0ee19c4ca32a", "6b5b80a5-c205-4dc2-b389-aa9c30c18deb", "SuperAdmin", "superadmin" },
                    { "85718ab0-fc3d-4e3a-b299-da6e39c54164", "8f588b49-0b7b-4eb6-bf1b-7711d01e85de", "Customer", "customer" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "d7147e37-c00f-48d7-a414-ea7fe2d3301d", 0, "dfe0771e-54d1-49a9-9c07-71892b4b4144", "phantantrung@gmail.com", true, "Trung", "Phan Tấn", false, null, "PHANTANTRUNG@GMAIL.COM", "PHANTANTRUNG@GMAIL.COM", "AQAAAAEAACcQAAAAEFNARzNOX7el3yc9Y6/rrA50B2WCgQ8GJ2UvD1HRMzH/pYC1AwEH3YPG7oXfT45Gdw==", null, false, "", false, "phantantrung@gmail.com" },
                    { "37da9a7f-ecb0-4ecc-833b-de60a726975a", 0, "b7d0a1a4-dcb7-439e-b03c-d9dc1f5b4782", "phungthanhdo@gmail.com", true, "Độ", "Phùng Thanh", false, null, "PHUNGTHANHDO@GMAIL.COM", "PHUNGTHANHDO@GMAIL.COM", "AQAAAAEAACcQAAAAELNH0gv/VxQiR83E4LhshFcCBKrcGdx1XyQLQnP2PzszGKiyQ5887rVYWot1lp+sGA==", null, false, "", false, "phungthanhdo@gmail.com" },
                    { "00543225-d5be-43ff-9dd4-83eea93be8b3", 0, "0514b9a1-0e2e-486b-9951-ed396d5b8bbd", "nguyenhue@gmail.com", true, "Huệ", "Nguyễn", false, null, "NGUYENHUE@GMAIL.COM", "NGUYENHUE@GMAIL.COM", "AQAAAAEAACcQAAAAENTTMJf8LijeEDdL4n07SwuWe2l8C4Cw5orsUE9IaldUH6+r6YXNOUAobnMMkw8Ojg==", null, false, "", false, "nguyenhue@gmail.com" },
                    { "8da3202b-52b3-4d64-b067-df469d4b7f9f", 0, "1e305340-31e9-4f81-b36f-7d2dd3f28093", "hoxuanhuong@gmail.com", true, "Hương", "Hồ Xuân", false, null, "HOXUANHUONG@GMAIL.COM", "HOXUANHUONG@GMAIL.COM", "AQAAAAEAACcQAAAAEEpUY1Cy5wAErZehg+QuIzt7UYXWfDWUhOfDM49v48GHamvJmFPOV+pXREC4rYfDWQ==", null, false, "", false, "hoxuanhuong@gmail.com" },
                    { "5ab3a357-2637-4e5e-bc03-e11a41266ca9", 0, "b720bab8-c8c0-47f7-9db6-f0d78b4e188b", "nguyenthanhlong@gmail.com", true, "Long", "Nguyễn Thành", false, null, "NGUYENTHANHLONG@GMAIL.COM", "NGUYENTHANHLONG@GMAIL.COM", "AQAAAAEAACcQAAAAEAAM+nU69CpvfF9oPNE+7nBk0XpdGSc+9SSl07Lw6QI3h5QMARDt0GD+t/zcJR9qsg==", null, false, "", false, "nguyenthanhlong@gmail.com" },
                    { "7b44b351-57d7-41a9-a848-0502c1533948", 0, "15dc6c18-19b4-4d98-9b77-fe3dfcae46e4", "huynhtranthanh@gmail.com", true, "Thành", "Huỳnh Trấn", false, null, "HUYNHTRANTHANH@GMAIL.COM", "HUYNHTRANTHANH@GMAIL.COM", "AQAAAAEAACcQAAAAEJK503v5OMAM0fue/qlQIee5f3RlY2GsDDPVnY10l0tED9a4utEiwRI0og2Ije+H4g==", null, false, "", false, "huynhtranthanh@gmail.com" },
                    { "9974e4a6-1b1e-4ed8-acea-d733859ce89f", 0, "524af477-3a9b-4c25-b4ef-52ec117757fe", "caobaquat@gmail.com", true, "Quát", "Cao Bá", false, null, "CAOBAQUAT@GMAIL.COM", "CAOBAQUAT@GMAIL.COM", "AQAAAAEAACcQAAAAEHL9AYxWTqUtHIyAVPZ3HCd6y1KTBCUR+qyn+EoR37m9wcOG0cESWxvcbFKCtYxSJw==", null, false, "", false, "caobaquat@gmail.com" },
                    { "24863c09-f962-4f85-8c94-dd9a6be73901", 0, "7cb2862e-6ef2-441e-b347-c9b85658f3a8", "truongthitramanh@gmail.com", true, "Anh", "Trương Thị Trâm", false, null, "TRUONGTHITRAMANH@GMAIL.COM", "TRUONGTHITRAMANH@GMAIL.COM", "AQAAAAEAACcQAAAAEGnroWdjWUHO4ltwy0SmZaVsRM+f4KARgxGG7dBuzvJ8yiQh/bPdL4UsGFEdhHwlZA==", null, false, "", false, "truongthitramanh@gmail.com" },
                    { "1ba997cd-d3c8-41df-bf32-9edf2a2a3899", 0, "3852b88e-7619-4e56-8737-c345d3375687", "truongtuantu@gmail.com", true, "Tú", "Trương Tuấn", false, null, "TRUONGTUANTU@GMAIL.COM", "TRUONGTUANTU@GMAIL.COM", "AQAAAAEAACcQAAAAEGXmAD1nA9t8tUEQPDQCxqW+QwrexXRmgdo8dLlE8V98fFEn5PsfzZ1F/VPaInnaNw==", null, false, "", false, "truongtuantu@gmail.com" },
                    { "edd203d0-ab94-4b31-a32d-7b5e19b714db", 0, "75a87403-a034-4259-93d5-3a7b58a10fea", "caothivananh@gmail.com", true, "Anh", "Cao Thị Vân", false, null, "CAOTHIVANANH@GMAIL.COM", "CAOTHIVANANH@GMAIL.COM", "AQAAAAEAACcQAAAAEGf4h45d2t8cGL2cvKvjC8wQmdASTecZYrnENlKq0I7oU39mjJNTMqDbXmhXyb0BdQ==", null, false, "", false, "caothivananh@gmail.com" },
                    { "eae76a7a-459a-4416-808a-56f227d7d606", 0, "6c6aa8e4-2930-49dc-a2eb-ff11f292d2c8", "nguyennhuloc@gmail.com", true, "Lộc", "Nguyễn Như", false, null, "NGUYENNHULOC@GMAIL.COM", "NGUYENNHULOC@GMAIL.COM", "AQAAAAEAACcQAAAAEMjX2ulefW6sWFGKYlRsxmv4aexiXuGTZiJPWV2m3w8xDBXaEwsJAq0PlzplyWPesw==", null, false, "", false, "nguyennhuloc@gmail.com" },
                    { "5bc75b4b-9c38-42e3-ac08-4ae9d7f1a1ac", 0, "c19eac21-8ae8-4298-b584-d27de7ff4b9c", "nguyentrunghieu@gmail.com", true, "Hiếu", "Nguyễn Trung", false, null, "NGUYENTRUNGHIEU@GMAIL.COM", "NGUYENTRUNGHIEU@GMAIL.COM", "AQAAAAEAACcQAAAAEJ8NViYlfUmAsgZ9m1msM3I+ElM3rGNXF9lOEgu0882YrjXluP22UCr5YnCfHIm7vQ==", null, false, "", false, "nguyentrunghieu@gmail.com" },
                    { "b8823ed2-d455-46e5-9a32-e75d38bdc2bf", 0, "49a3b8db-7302-48de-a882-8145f047d342", "phamvinhson@gmail.com", true, "Sơn", "Phạm Vĩnh", false, null, "PHAMVINHSON@GMAIL.COM", "PHAMVINHSON@GMAIL.COM", "AQAAAAEAACcQAAAAEI2PAklymvJi2gzVbFD6LjyrXfiQZf5UIZTuPDraJMBXx/N7oHWf7waHg/y6yk1CJQ==", null, false, "", false, "phamvinhson@gmail.com" },
                    { "0aec58b6-1768-45d8-b0e0-53691a388f45", 0, "8603bab3-8be1-4e8c-93d9-80028a563fd3", "trankieuloan@gmail.com", true, "Loan", "Trần Kiều", false, null, "TRANKIEULOAN@GMAIL.COM", "TRANKIEULOAN@GMAIL.COM", "AQAAAAEAACcQAAAAECf/l2Xqb40A+ydS9n1r6LmBl6mF3mRgEfhRzGxBMMcSOOxTgl5wSK1gg8umgR55fA==", null, false, "", false, "trankieuloan@gmail.com" },
                    { "2daba73a-1aa7-4274-bae9-f67043021541", 0, "e75d37bf-a3ee-4daa-8cdf-860ed6757c75", "yungadmin@gmail.com", true, "Admin", "Yung", false, null, "YUNGADMIN@GMAIL.COM", "YUNGADMIN@GMAIL.COM", "AQAAAAEAACcQAAAAEBeV41EQ4zijZhE3IeHr7uTQiRJUmQGhbOhFNe3TuA78AxmNTTazpOlbsCBLNJowDA==", null, false, "", false, "yungadmin@gmail.com" },
                    { "41e509b9-f78e-4e99-a67f-a2f917fef06e", 0, "367acc67-2dc5-4708-a4c5-191b8e8b5978", "lilsuperadmin@gmail.com", true, "Super Admin", "Lil", false, null, "LILSUPERADMIN@GMAIL.COM", "LILSUPERADMIN@GMAIL.COM", "AQAAAAEAACcQAAAAEAxY8fqEYvAp5HUoWx6sFPxTvN6268oska4u3YJO19oAy/MtioybvS0YD0NNqjuCVA==", null, false, "", false, "lilsuperadmin@gmail.com" },
                    { "9fb9bc98-ca1c-4d93-b21c-b1a1f1d0050b", 0, "9a329a20-45db-4bca-bda0-e893c13a8f0e", "tranthaonguyen@gmail.com", true, "Nguyên", "Trần Thảo", false, null, "TRANTHAONGUYEN@GMAIL.COM", "TRANTHAONGUYEN@GMAIL.COM", "AQAAAAEAACcQAAAAEFt+Vr9YzZ6foB2LbSA8HpDQsNToOausThYd4VASvfaNdVJlcIaXXQjLGU8owdHtmA==", null, false, "", false, "tranthaonguyen@gmail.com" }
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
                columns: new[] { "UserId", "RoleId", "ApplicationUserId" },
                values: new object[,]
                {
                    { "41e509b9-f78e-4e99-a67f-a2f917fef06e", "dfacdcdc-24d7-4739-8a6a-0ee19c4ca32a", null },
                    { "37da9a7f-ecb0-4ecc-833b-de60a726975a", "85718ab0-fc3d-4e3a-b299-da6e39c54164", null },
                    { "00543225-d5be-43ff-9dd4-83eea93be8b3", "85718ab0-fc3d-4e3a-b299-da6e39c54164", null },
                    { "8da3202b-52b3-4d64-b067-df469d4b7f9f", "85718ab0-fc3d-4e3a-b299-da6e39c54164", null },
                    { "5ab3a357-2637-4e5e-bc03-e11a41266ca9", "85718ab0-fc3d-4e3a-b299-da6e39c54164", null },
                    { "7b44b351-57d7-41a9-a848-0502c1533948", "85718ab0-fc3d-4e3a-b299-da6e39c54164", null },
                    { "9974e4a6-1b1e-4ed8-acea-d733859ce89f", "85718ab0-fc3d-4e3a-b299-da6e39c54164", null },
                    { "d7147e37-c00f-48d7-a414-ea7fe2d3301d", "85718ab0-fc3d-4e3a-b299-da6e39c54164", null },
                    { "24863c09-f962-4f85-8c94-dd9a6be73901", "85718ab0-fc3d-4e3a-b299-da6e39c54164", null },
                    { "edd203d0-ab94-4b31-a32d-7b5e19b714db", "85718ab0-fc3d-4e3a-b299-da6e39c54164", null },
                    { "eae76a7a-459a-4416-808a-56f227d7d606", "85718ab0-fc3d-4e3a-b299-da6e39c54164", null },
                    { "5bc75b4b-9c38-42e3-ac08-4ae9d7f1a1ac", "85718ab0-fc3d-4e3a-b299-da6e39c54164", null },
                    { "b8823ed2-d455-46e5-9a32-e75d38bdc2bf", "85718ab0-fc3d-4e3a-b299-da6e39c54164", null },
                    { "0aec58b6-1768-45d8-b0e0-53691a388f45", "85718ab0-fc3d-4e3a-b299-da6e39c54164", null },
                    { "2daba73a-1aa7-4274-bae9-f67043021541", "ec8b09b4-979d-48de-8074-abfc9632deee", null },
                    { "9fb9bc98-ca1c-4d93-b21c-b1a1f1d0050b", "85718ab0-fc3d-4e3a-b299-da6e39c54164", null },
                    { "1ba997cd-d3c8-41df-bf32-9edf2a2a3899", "85718ab0-fc3d-4e3a-b299-da6e39c54164", null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_ApplicationUserId",
                table: "AspNetUserRoles",
                column: "ApplicationUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserRoles_AspNetUsers_ApplicationUserId",
                table: "AspNetUserRoles",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserRoles_AspNetUsers_ApplicationUserId",
                table: "AspNetUserRoles");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUserRoles_ApplicationUserId",
                table: "AspNetUserRoles");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "00543225-d5be-43ff-9dd4-83eea93be8b3", "85718ab0-fc3d-4e3a-b299-da6e39c54164" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "0aec58b6-1768-45d8-b0e0-53691a388f45", "85718ab0-fc3d-4e3a-b299-da6e39c54164" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "1ba997cd-d3c8-41df-bf32-9edf2a2a3899", "85718ab0-fc3d-4e3a-b299-da6e39c54164" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "24863c09-f962-4f85-8c94-dd9a6be73901", "85718ab0-fc3d-4e3a-b299-da6e39c54164" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "2daba73a-1aa7-4274-bae9-f67043021541", "ec8b09b4-979d-48de-8074-abfc9632deee" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "37da9a7f-ecb0-4ecc-833b-de60a726975a", "85718ab0-fc3d-4e3a-b299-da6e39c54164" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "41e509b9-f78e-4e99-a67f-a2f917fef06e", "dfacdcdc-24d7-4739-8a6a-0ee19c4ca32a" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "5ab3a357-2637-4e5e-bc03-e11a41266ca9", "85718ab0-fc3d-4e3a-b299-da6e39c54164" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "5bc75b4b-9c38-42e3-ac08-4ae9d7f1a1ac", "85718ab0-fc3d-4e3a-b299-da6e39c54164" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "7b44b351-57d7-41a9-a848-0502c1533948", "85718ab0-fc3d-4e3a-b299-da6e39c54164" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "8da3202b-52b3-4d64-b067-df469d4b7f9f", "85718ab0-fc3d-4e3a-b299-da6e39c54164" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "9974e4a6-1b1e-4ed8-acea-d733859ce89f", "85718ab0-fc3d-4e3a-b299-da6e39c54164" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "9fb9bc98-ca1c-4d93-b21c-b1a1f1d0050b", "85718ab0-fc3d-4e3a-b299-da6e39c54164" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "b8823ed2-d455-46e5-9a32-e75d38bdc2bf", "85718ab0-fc3d-4e3a-b299-da6e39c54164" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "d7147e37-c00f-48d7-a414-ea7fe2d3301d", "85718ab0-fc3d-4e3a-b299-da6e39c54164" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "eae76a7a-459a-4416-808a-56f227d7d606", "85718ab0-fc3d-4e3a-b299-da6e39c54164" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "edd203d0-ab94-4b31-a32d-7b5e19b714db", "85718ab0-fc3d-4e3a-b299-da6e39c54164" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "85718ab0-fc3d-4e3a-b299-da6e39c54164");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "dfacdcdc-24d7-4739-8a6a-0ee19c4ca32a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ec8b09b4-979d-48de-8074-abfc9632deee");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00543225-d5be-43ff-9dd4-83eea93be8b3");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0aec58b6-1768-45d8-b0e0-53691a388f45");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1ba997cd-d3c8-41df-bf32-9edf2a2a3899");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "24863c09-f962-4f85-8c94-dd9a6be73901");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2daba73a-1aa7-4274-bae9-f67043021541");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "37da9a7f-ecb0-4ecc-833b-de60a726975a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "41e509b9-f78e-4e99-a67f-a2f917fef06e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5ab3a357-2637-4e5e-bc03-e11a41266ca9");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5bc75b4b-9c38-42e3-ac08-4ae9d7f1a1ac");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7b44b351-57d7-41a9-a848-0502c1533948");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8da3202b-52b3-4d64-b067-df469d4b7f9f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9974e4a6-1b1e-4ed8-acea-d733859ce89f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9fb9bc98-ca1c-4d93-b21c-b1a1f1d0050b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b8823ed2-d455-46e5-9a32-e75d38bdc2bf");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d7147e37-c00f-48d7-a414-ea7fe2d3301d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "eae76a7a-459a-4416-808a-56f227d7d606");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "edd203d0-ab94-4b31-a32d-7b5e19b714db");

            migrationBuilder.DropColumn(
                name: "ApplicationUserId",
                table: "AspNetUserRoles");

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

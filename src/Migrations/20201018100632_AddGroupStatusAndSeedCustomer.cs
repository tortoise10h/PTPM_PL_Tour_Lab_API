using Microsoft.EntityFrameworkCore.Migrations;

namespace src.Migrations
{
    public partial class AddGroupStatusAndSeedCustomer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<int>(
                name: "Status",
                table: "Group",
                nullable: false,
                defaultValue: 1);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "a80f1527-b44c-4778-882b-25930022f689", "d158ad72-92be-4181-9e9a-a307f99301e0", "Admin", "admin" },
                    { "5994a25a-6200-42d2-854b-f976ac97d4f3", "174b003f-8e9d-4f23-b2b1-99de125d5ef9", "SuperAdmin", "superadmin" },
                    { "c655e426-9602-44b5-8ee0-b6850c5c1092", "839193ba-f4de-4b04-84e7-58f84bc81ca6", "Customer", "customer" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "a94c038b-d692-4ee5-b9d7-e7fd5fdc4bf2", 0, "2694f97f-3a01-41bf-a92f-6b81e475b04a", "phantantrung@gmail.com", true, "Trung", "Phan Tấn", false, null, "PHANTANTRUNG@GMAIL.COM", "PHANTANTRUNG@GMAIL.COM", "AQAAAAEAACcQAAAAEC3N2nUtydl7b5Wbypi6PaybKWFjvKr2i9Z0A96XFw63RE+760carYK3VQqpSRBjkg==", null, false, "", false, "phantantrung@gmail.com" },
                    { "bc20f244-c073-4ae0-8ff1-762d227191c4", 0, "cd45aa22-a017-4b3f-a8b6-bf1a3f6e9c60", "phungthanhdo@gmail.com", true, "Độ", "Phùng Thanh", false, null, "PHUNGTHANHDO@GMAIL.COM", "PHUNGTHANHDO@GMAIL.COM", "AQAAAAEAACcQAAAAEKK3F6pn/anMOhlPZ0nL2IKGTU+l8OmwSrNpBs40fRmBmLBa1QCo9gGu3P6soXFVZA==", null, false, "", false, "phungthanhdo@gmail.com" },
                    { "81f0b640-b683-49ba-a5f2-b7fa19b50630", 0, "ac423f99-0eec-4185-92dc-0a91d7f40061", "nguyenhue@gmail.com", true, "Huệ", "Nguyễn", false, null, "NGUYENHUE@GMAIL.COM", "NGUYENHUE@GMAIL.COM", "AQAAAAEAACcQAAAAEMf1CLfPgs5fhMDCuLrghUc4K5O/ooqkcYqXbPjDSqiJ/UA9BKrvrJYZVUiFsjotAw==", null, false, "", false, "nguyenhue@gmail.com" },
                    { "78964b24-d075-4c4d-b2f1-9d9ab7dc2912", 0, "86f6dba4-ba8a-4880-887c-41b36e79cd4a", "hoxuanhuong@gmail.com", true, "Hương", "Hồ Xuân", false, null, "HOXUANHUONG@GMAIL.COM", "HOXUANHUONG@GMAIL.COM", "AQAAAAEAACcQAAAAEOrvoCFAoP+a6UcAfsQm9IrM2zP20hAZsdILh+E373LBrfEkCF2Ow+IwsP6E/1j6ng==", null, false, "", false, "hoxuanhuong@gmail.com" },
                    { "8551ca5c-da02-4c67-8286-1b30e8a261cb", 0, "adc294fc-6dad-42f3-8dd1-f73b1a10256e", "nguyenthanhlong@gmail.com", true, "Long", "Nguyễn Thành", false, null, "NGUYENTHANHLONG@GMAIL.COM", "NGUYENTHANHLONG@GMAIL.COM", "AQAAAAEAACcQAAAAEMnztnzZeDbuPE9LQ5kNFbUGHYVgoBG3Dvt435yiLwab6OcKphLqCL4ZphBmGLSRIw==", null, false, "", false, "nguyenthanhlong@gmail.com" },
                    { "d82eb626-d9c7-4611-8964-b7797ac8dbfa", 0, "54ec00d9-b500-45a3-86ea-876ff842fd65", "huynhtranthanh@gmail.com", true, "Thành", "Huỳnh Trấn", false, null, "HUYNHTRANTHANH@GMAIL.COM", "HUYNHTRANTHANH@GMAIL.COM", "AQAAAAEAACcQAAAAEK3RtXcOQif8FQDomoclEMKyP0A0x8HTzD7pNcNHIFMwjQIydzVxHK+2cV6YPJv8EQ==", null, false, "", false, "huynhtranthanh@gmail.com" },
                    { "d58a231f-95da-41b6-9088-258dc4234a39", 0, "f55a57f0-ec8c-4ab6-8d58-5b3a26c19e1c", "caobaquat@gmail.com", true, "Quát", "Cao Bá", false, null, "CAOBAQUAT@GMAIL.COM", "CAOBAQUAT@GMAIL.COM", "AQAAAAEAACcQAAAAEEil6trPQoVZq2ow3eF/UCNpIZl6WKqXGqV/tIQ/TtjsvNhV0fzHDOtTIRc6O6tdOQ==", null, false, "", false, "caobaquat@gmail.com" },
                    { "faf7c2ca-ec10-4dfd-89e0-04d1d9de8513", 0, "73beb342-b5eb-4d51-b567-9e0320618603", "truongthitramanh@gmail.com", true, "Anh", "Trương Thị Trâm", false, null, "TRUONGTHITRAMANH@GMAIL.COM", "TRUONGTHITRAMANH@GMAIL.COM", "AQAAAAEAACcQAAAAENjvCJ7G2bGrtsMwzszLhVYEtpky1Lu/nKIHRNgG1ZgCFJYsfGeVUf5YBVLMLD9f1A==", null, false, "", false, "truongthitramanh@gmail.com" },
                    { "49922f24-34ab-4b08-bd52-5077ae48591d", 0, "9433ea55-35e4-4fa9-9a17-99ac31b6c5ca", "truongtuantu@gmail.com", true, "Tú", "Trương Tuấn", false, null, "TRUONGTUANTU@GMAIL.COM", "TRUONGTUANTU@GMAIL.COM", "AQAAAAEAACcQAAAAEPLZbknelDVG0MTwBvIL9cGDjDxkS8uOmnh2J4gUj9Fme0zB5sB7KUQv0eiDjxgBAg==", null, false, "", false, "truongtuantu@gmail.com" },
                    { "08388af1-6d56-433d-8e5b-dc0f7fb6ba63", 0, "b1b465a8-63ed-47e2-a198-d32d218e422e", "caothivananh@gmail.com", true, "Anh", "Cao Thị Vân", false, null, "CAOTHIVANANH@GMAIL.COM", "CAOTHIVANANH@GMAIL.COM", "AQAAAAEAACcQAAAAEEk6hFkFOLOANbfwPaSLfdwYoto8FJx/WPwAIsyzceobXAxBlLEq8ndD9dHswvlr4A==", null, false, "", false, "caothivananh@gmail.com" },
                    { "bd38abe0-b2e2-4ec2-a622-b65ba592f611", 0, "5e78d7a1-4060-4ec7-900c-ddb9b3e933a0", "nguyennhuloc@gmail.com", true, "Lộc", "Nguyễn Như", false, null, "NGUYENNHULOC@GMAIL.COM", "NGUYENNHULOC@GMAIL.COM", "AQAAAAEAACcQAAAAEFObAQ3iGpA1h6iqKnwhUeIUeyQuFOv2GhGY/2/S9sPArenXAbBo59xqhT73nYxbBw==", null, false, "", false, "nguyennhuloc@gmail.com" },
                    { "6a6b6d35-a43b-43c6-8732-c083448feb7e", 0, "374fbf6e-2046-4dc8-9e52-c1fbf2a21a4c", "nguyentrunghieu@gmail.com", true, "Hiếu", "Nguyễn Trung", false, null, "NGUYENTRUNGHIEU@GMAIL.COM", "NGUYENTRUNGHIEU@GMAIL.COM", "AQAAAAEAACcQAAAAECiR4HeDX3VNaRtDgqw6ryRkCcwB1K85OTdP8p8yfm0QO6y29DAUN09XvzpJcJzqyg==", null, false, "", false, "nguyentrunghieu@gmail.com" },
                    { "7bf3cb2f-36d2-4c85-9047-4aeb6771d454", 0, "6f051e9a-8f6e-457e-9cb1-716c6d69c608", "phamvinhson@gmail.com", true, "Sơn", "Phạm Vĩnh", false, null, "PHAMVINHSON@GMAIL.COM", "PHAMVINHSON@GMAIL.COM", "AQAAAAEAACcQAAAAEPCXdeTTlQ3gtPCGcThIy8C2ZMUSbKcJCYVSmla439XPFpVp9BvUy9g3FaaPsuttNg==", null, false, "", false, "phamvinhson@gmail.com" },
                    { "5370a1ff-b473-494f-bfe3-d627e3b15438", 0, "232ea0ca-04ad-4560-8441-340cec5c877a", "trankieuloan@gmail.com", true, "Loan", "Trần Kiều", false, null, "TRANKIEULOAN@GMAIL.COM", "TRANKIEULOAN@GMAIL.COM", "AQAAAAEAACcQAAAAEDOMxZFG3c3UHRi9SVM/f5k37V/BXX5TiYfpE522jV80H9SyED65wSkA3X/fh8rZdg==", null, false, "", false, "trankieuloan@gmail.com" },
                    { "19a74a34-48a2-4b09-aeef-7a1cf39efdaf", 0, "d31ac76a-1fe2-4c92-8131-d458c82083ec", "yungadmin@gmail.com", true, "Admin", "Yung", false, null, "YUNGADMIN@GMAIL.COM", "YUNGADMIN@GMAIL.COM", "AQAAAAEAACcQAAAAEPpB3TcpQ2pw5CSA25ufd28KgF834iQacfjY9gJaiCL0Tna2Yf64ZV3EZTZrfThC3g==", null, false, "", false, "yungadmin@gmail.com" },
                    { "68486725-5157-40a5-bd04-4f44542266a7", 0, "c25d2b3b-ec68-4f1d-a124-30b891d53f24", "lilsuperadmin@gmail.com", true, "Super Admin", "Lil", false, null, "LILSUPERADMIN@GMAIL.COM", "LILSUPERADMIN@GMAIL.COM", "AQAAAAEAACcQAAAAEC0+6g+dzXa1YAdhxNjcRdBSyo5q2PQKJJNp4BurcWH7XysSQJ4cCXjzCS4UCD3n6Q==", null, false, "", false, "lilsuperadmin@gmail.com" },
                    { "a3b0bb77-033a-4485-a5b6-8ef3089a3b4b", 0, "c52c1f1e-0d1b-41d3-8cd4-336af00535b4", "tranthaonguyen@gmail.com", true, "Nguyên", "Trần Thảo", false, null, "TRANTHAONGUYEN@GMAIL.COM", "TRANTHAONGUYEN@GMAIL.COM", "AQAAAAEAACcQAAAAEMYH830k2ds4Fe8dWcMKJUvNFEKFddX3afc9mDeiUS7rOuA1u79JYVYD9MdAq0AXnA==", null, false, "", false, "tranthaonguyen@gmail.com" }
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
                    { "68486725-5157-40a5-bd04-4f44542266a7", "5994a25a-6200-42d2-854b-f976ac97d4f3" },
                    { "bc20f244-c073-4ae0-8ff1-762d227191c4", "c655e426-9602-44b5-8ee0-b6850c5c1092" },
                    { "81f0b640-b683-49ba-a5f2-b7fa19b50630", "c655e426-9602-44b5-8ee0-b6850c5c1092" },
                    { "78964b24-d075-4c4d-b2f1-9d9ab7dc2912", "c655e426-9602-44b5-8ee0-b6850c5c1092" },
                    { "8551ca5c-da02-4c67-8286-1b30e8a261cb", "c655e426-9602-44b5-8ee0-b6850c5c1092" },
                    { "d82eb626-d9c7-4611-8964-b7797ac8dbfa", "c655e426-9602-44b5-8ee0-b6850c5c1092" },
                    { "d58a231f-95da-41b6-9088-258dc4234a39", "c655e426-9602-44b5-8ee0-b6850c5c1092" },
                    { "a94c038b-d692-4ee5-b9d7-e7fd5fdc4bf2", "c655e426-9602-44b5-8ee0-b6850c5c1092" },
                    { "faf7c2ca-ec10-4dfd-89e0-04d1d9de8513", "c655e426-9602-44b5-8ee0-b6850c5c1092" },
                    { "08388af1-6d56-433d-8e5b-dc0f7fb6ba63", "c655e426-9602-44b5-8ee0-b6850c5c1092" },
                    { "bd38abe0-b2e2-4ec2-a622-b65ba592f611", "c655e426-9602-44b5-8ee0-b6850c5c1092" },
                    { "6a6b6d35-a43b-43c6-8732-c083448feb7e", "c655e426-9602-44b5-8ee0-b6850c5c1092" },
                    { "7bf3cb2f-36d2-4c85-9047-4aeb6771d454", "c655e426-9602-44b5-8ee0-b6850c5c1092" },
                    { "5370a1ff-b473-494f-bfe3-d627e3b15438", "c655e426-9602-44b5-8ee0-b6850c5c1092" },
                    { "19a74a34-48a2-4b09-aeef-7a1cf39efdaf", "a80f1527-b44c-4778-882b-25930022f689" },
                    { "a3b0bb77-033a-4485-a5b6-8ef3089a3b4b", "c655e426-9602-44b5-8ee0-b6850c5c1092" },
                    { "49922f24-34ab-4b08-bd52-5077ae48591d", "c655e426-9602-44b5-8ee0-b6850c5c1092" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "08388af1-6d56-433d-8e5b-dc0f7fb6ba63", "c655e426-9602-44b5-8ee0-b6850c5c1092" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "19a74a34-48a2-4b09-aeef-7a1cf39efdaf", "a80f1527-b44c-4778-882b-25930022f689" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "49922f24-34ab-4b08-bd52-5077ae48591d", "c655e426-9602-44b5-8ee0-b6850c5c1092" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "5370a1ff-b473-494f-bfe3-d627e3b15438", "c655e426-9602-44b5-8ee0-b6850c5c1092" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "68486725-5157-40a5-bd04-4f44542266a7", "5994a25a-6200-42d2-854b-f976ac97d4f3" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "6a6b6d35-a43b-43c6-8732-c083448feb7e", "c655e426-9602-44b5-8ee0-b6850c5c1092" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "78964b24-d075-4c4d-b2f1-9d9ab7dc2912", "c655e426-9602-44b5-8ee0-b6850c5c1092" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "7bf3cb2f-36d2-4c85-9047-4aeb6771d454", "c655e426-9602-44b5-8ee0-b6850c5c1092" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "81f0b640-b683-49ba-a5f2-b7fa19b50630", "c655e426-9602-44b5-8ee0-b6850c5c1092" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "8551ca5c-da02-4c67-8286-1b30e8a261cb", "c655e426-9602-44b5-8ee0-b6850c5c1092" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "a3b0bb77-033a-4485-a5b6-8ef3089a3b4b", "c655e426-9602-44b5-8ee0-b6850c5c1092" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "a94c038b-d692-4ee5-b9d7-e7fd5fdc4bf2", "c655e426-9602-44b5-8ee0-b6850c5c1092" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "bc20f244-c073-4ae0-8ff1-762d227191c4", "c655e426-9602-44b5-8ee0-b6850c5c1092" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "bd38abe0-b2e2-4ec2-a622-b65ba592f611", "c655e426-9602-44b5-8ee0-b6850c5c1092" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "d58a231f-95da-41b6-9088-258dc4234a39", "c655e426-9602-44b5-8ee0-b6850c5c1092" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "d82eb626-d9c7-4611-8964-b7797ac8dbfa", "c655e426-9602-44b5-8ee0-b6850c5c1092" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "faf7c2ca-ec10-4dfd-89e0-04d1d9de8513", "c655e426-9602-44b5-8ee0-b6850c5c1092" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5994a25a-6200-42d2-854b-f976ac97d4f3");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a80f1527-b44c-4778-882b-25930022f689");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c655e426-9602-44b5-8ee0-b6850c5c1092");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "08388af1-6d56-433d-8e5b-dc0f7fb6ba63");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "19a74a34-48a2-4b09-aeef-7a1cf39efdaf");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "49922f24-34ab-4b08-bd52-5077ae48591d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5370a1ff-b473-494f-bfe3-d627e3b15438");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "68486725-5157-40a5-bd04-4f44542266a7");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6a6b6d35-a43b-43c6-8732-c083448feb7e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "78964b24-d075-4c4d-b2f1-9d9ab7dc2912");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7bf3cb2f-36d2-4c85-9047-4aeb6771d454");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "81f0b640-b683-49ba-a5f2-b7fa19b50630");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8551ca5c-da02-4c67-8286-1b30e8a261cb");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a3b0bb77-033a-4485-a5b6-8ef3089a3b4b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a94c038b-d692-4ee5-b9d7-e7fd5fdc4bf2");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bc20f244-c073-4ae0-8ff1-762d227191c4");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bd38abe0-b2e2-4ec2-a622-b65ba592f611");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d58a231f-95da-41b6-9088-258dc4234a39");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d82eb626-d9c7-4611-8964-b7797ac8dbfa");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "faf7c2ca-ec10-4dfd-89e0-04d1d9de8513");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "Group");

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
    }
}

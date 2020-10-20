using Microsoft.EntityFrameworkCore.Migrations;

namespace src.Migrations
{
    public partial class ChangeTourPriceFromDoubleToLong : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<long>(
                name: "Price",
                table: "Tours",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "07bdc189-5436-4e2d-bf2b-93dc12b574b8", "d4172c62-41b1-4ec4-956c-a91fe8a5b704", "Admin", "admin" },
                    { "f4f586db-115b-410d-bb62-91911882d01c", "71a2cc4b-6c45-4fa1-86df-e2bb9e35097c", "SuperAdmin", "superadmin" },
                    { "69dc0c54-0495-4716-b5e7-8483636ab76f", "3c9ad2bd-8694-432d-b64a-a66f121c2f00", "Customer", "customer" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "927896de-bd2c-4ec2-97ae-58c1e71a351f", 0, "cbeeb3d6-a27a-41df-846c-0e026188911b", "phantantrung@gmail.com", true, "Trung", "Phan Tấn", false, null, "PHANTANTRUNG@GMAIL.COM", "PHANTANTRUNG@GMAIL.COM", "AQAAAAEAACcQAAAAEO5WsTYSmMpVpm9X9sn1dPhDSd0A9F2P7vUpcKpdCpALsIsg8P7XfhSKwlIKL8yjZw==", null, false, "", false, "phantantrung@gmail.com" },
                    { "c3cbf61e-0e73-4ead-b60f-d5a57560394a", 0, "feabdfb8-e152-42d7-adfa-b45e0feb0c92", "phungthanhdo@gmail.com", true, "Độ", "Phùng Thanh", false, null, "PHUNGTHANHDO@GMAIL.COM", "PHUNGTHANHDO@GMAIL.COM", "AQAAAAEAACcQAAAAEFXLJjj6aiMzewmvNniXYtjri8Nv+qgI9ty5iTdZBc4ltkgI6NShDewvAEnEZtRUUQ==", null, false, "", false, "phungthanhdo@gmail.com" },
                    { "6a73fb23-9285-4e68-acee-17d189d75906", 0, "ed1ad0c5-8000-4c4c-8788-927a38941015", "nguyenhue@gmail.com", true, "Huệ", "Nguyễn", false, null, "NGUYENHUE@GMAIL.COM", "NGUYENHUE@GMAIL.COM", "AQAAAAEAACcQAAAAECTyartDWNYv7AQgEbXKlmfpyaoAVfg4agKPeIhVkTC9+vkuCpLuTUfGJzwCISFS4Q==", null, false, "", false, "nguyenhue@gmail.com" },
                    { "2fbf8524-33fa-4403-834f-443b4f00a4be", 0, "fdbaf613-3c02-48e2-b07f-f0b4241e7ca4", "hoxuanhuong@gmail.com", true, "Hương", "Hồ Xuân", false, null, "HOXUANHUONG@GMAIL.COM", "HOXUANHUONG@GMAIL.COM", "AQAAAAEAACcQAAAAELLjh9oJNwhKhy8Oy5k5hzpg7xoXpmduXw1ZB2kUbwQW/23M2HcgP/YXO+peiuAXsQ==", null, false, "", false, "hoxuanhuong@gmail.com" },
                    { "88282915-a492-4c29-a8ba-2d8b6fddf022", 0, "1f0d3107-e090-4058-89df-12c97101ad6a", "nguyenthanhlong@gmail.com", true, "Long", "Nguyễn Thành", false, null, "NGUYENTHANHLONG@GMAIL.COM", "NGUYENTHANHLONG@GMAIL.COM", "AQAAAAEAACcQAAAAEEnDh+riZnJk0PuEtJe3f1OMDXqUvDXygt1Y/v9nD6WMpvCu6HI0P/JgIp54Z0PAbQ==", null, false, "", false, "nguyenthanhlong@gmail.com" },
                    { "602415e6-5846-4a60-a048-9b8692003936", 0, "20806228-0e24-49bd-8520-1f576ee43446", "huynhtranthanh@gmail.com", true, "Thành", "Huỳnh Trấn", false, null, "HUYNHTRANTHANH@GMAIL.COM", "HUYNHTRANTHANH@GMAIL.COM", "AQAAAAEAACcQAAAAEGgsqq2WI8wMBqxzfePCElnVPMdGpDWzAIK8o1dTBz6N+pRwHwv2IYW7K3BHBU/yBQ==", null, false, "", false, "huynhtranthanh@gmail.com" },
                    { "d5e882e7-ab4e-4489-a5ac-937c8507f831", 0, "6a23ba32-6eaa-4102-b21b-fc2d792fd6de", "caobaquat@gmail.com", true, "Quát", "Cao Bá", false, null, "CAOBAQUAT@GMAIL.COM", "CAOBAQUAT@GMAIL.COM", "AQAAAAEAACcQAAAAEE2R/Amt2MQ9rhWZqEUW/QRhNNK+2GQw8X54Y8a0QPDkz9HZApphbVeaRGy2r/D8bQ==", null, false, "", false, "caobaquat@gmail.com" },
                    { "40ec0e6a-e81d-4a89-ac58-19491efe39a5", 0, "e32f9226-135e-4467-bf0d-7420bf05d25c", "truongthitramanh@gmail.com", true, "Anh", "Trương Thị Trâm", false, null, "TRUONGTHITRAMANH@GMAIL.COM", "TRUONGTHITRAMANH@GMAIL.COM", "AQAAAAEAACcQAAAAEO0OWkFWxK0hzGaIMGLdy75ESr4DXDMxPonmgdAIhNCLkrhF4SB6f7NMYDr7AtRlVw==", null, false, "", false, "truongthitramanh@gmail.com" },
                    { "50a1e147-59a5-4565-83c6-a7b152dd4b12", 0, "49a36a5c-8a35-4d6f-a22d-91e4d7f7fc3d", "truongtuantu@gmail.com", true, "Tú", "Trương Tuấn", false, null, "TRUONGTUANTU@GMAIL.COM", "TRUONGTUANTU@GMAIL.COM", "AQAAAAEAACcQAAAAEMBcqCPrjJR3eLX5mHO6AKrfgSGXXhSu3fR5IUz/rEdgE2D5ufmEv4Ke8tgHXJNdSg==", null, false, "", false, "truongtuantu@gmail.com" },
                    { "383180f4-9ad2-41e1-9237-f1df5a2f63de", 0, "03f70451-f1fc-4d73-af51-3a97f849a5b0", "caothivananh@gmail.com", true, "Anh", "Cao Thị Vân", false, null, "CAOTHIVANANH@GMAIL.COM", "CAOTHIVANANH@GMAIL.COM", "AQAAAAEAACcQAAAAEDV2XPYN5yLBN/0Y0gOhdDL9AgEC4sWpshHMg204z0c4K4A4nmOtoZKwB+drym5CmQ==", null, false, "", false, "caothivananh@gmail.com" },
                    { "80684771-c685-471f-a6f9-c43ed16ddd52", 0, "bb1b9f99-cc64-4efe-9804-340f21eb2db7", "nguyennhuloc@gmail.com", true, "Lộc", "Nguyễn Như", false, null, "NGUYENNHULOC@GMAIL.COM", "NGUYENNHULOC@GMAIL.COM", "AQAAAAEAACcQAAAAEO0FHZyvPUn65ONlIXckzhLgdiE9KvmArDXHdhSEawT3frVWiT6aBbja7E2XQB4/Ew==", null, false, "", false, "nguyennhuloc@gmail.com" },
                    { "c983eca4-bb5b-474e-8215-bba4976014f2", 0, "df0a5ab1-65fc-4e12-be9a-ea3987c645f7", "nguyentrunghieu@gmail.com", true, "Hiếu", "Nguyễn Trung", false, null, "NGUYENTRUNGHIEU@GMAIL.COM", "NGUYENTRUNGHIEU@GMAIL.COM", "AQAAAAEAACcQAAAAELVjVmXwmAOUUaexHbC1xfXKRrYMWJvNcYvvLjj2Aj3QE8isk3SCb1f7EsJQMu1A6w==", null, false, "", false, "nguyentrunghieu@gmail.com" },
                    { "7c98afbc-08fb-49f5-860f-ab8c5460ce6f", 0, "c592f519-0d0b-4a34-895d-eb6a6f4dbd9c", "phamvinhson@gmail.com", true, "Sơn", "Phạm Vĩnh", false, null, "PHAMVINHSON@GMAIL.COM", "PHAMVINHSON@GMAIL.COM", "AQAAAAEAACcQAAAAEDjG5stoq2BeETFzeFP2KR6ELeA5DTrWGs4F4tkU55J4lv35EbJqsXeKGYzrPnKguQ==", null, false, "", false, "phamvinhson@gmail.com" },
                    { "018d2e36-e99d-4c54-9f64-b389378b857b", 0, "710bb320-3a09-4780-a0cf-a61f6d5ddce0", "trankieuloan@gmail.com", true, "Loan", "Trần Kiều", false, null, "TRANKIEULOAN@GMAIL.COM", "TRANKIEULOAN@GMAIL.COM", "AQAAAAEAACcQAAAAEJE5YHZdAlZHGQmCSlTqGV+ay8Bp5HvKbXiEPja6YNkPRcF4yi3PQPiQL/YWMFjQdA==", null, false, "", false, "trankieuloan@gmail.com" },
                    { "29754f5d-4739-47be-a686-e1452807b3a1", 0, "f0916e14-72b3-4f57-920f-ecded7565866", "yungadmin@gmail.com", true, "Admin", "Yung", false, null, "YUNGADMIN@GMAIL.COM", "YUNGADMIN@GMAIL.COM", "AQAAAAEAACcQAAAAEA5EYwArDumxrUixF5usq0uJN1XfteIk4DbN8VeEMGWXw913d0fDrNxpXyXRGJgIKg==", null, false, "", false, "yungadmin@gmail.com" },
                    { "7911d80e-3906-48c0-98a6-8689812fd917", 0, "e73b9c43-2784-4c72-9107-fdb13d5558bc", "lilsuperadmin@gmail.com", true, "Super Admin", "Lil", false, null, "LILSUPERADMIN@GMAIL.COM", "LILSUPERADMIN@GMAIL.COM", "AQAAAAEAACcQAAAAEEPT9CqutpHVLCCNrIfnIaGHmAlOyeftsAsrDP3WYX27QCcNiBCST968EUUvBVXpUA==", null, false, "", false, "lilsuperadmin@gmail.com" },
                    { "eaf0294e-7940-43ae-9868-b4c020af70e8", 0, "d48b2fdf-7fa9-407f-97bc-335b16841329", "tranthaonguyen@gmail.com", true, "Nguyên", "Trần Thảo", false, null, "TRANTHAONGUYEN@GMAIL.COM", "TRANTHAONGUYEN@GMAIL.COM", "AQAAAAEAACcQAAAAEPggIF00FEfEu9jCFVi3D5lvPMLZhhoVcDT4cOyq7WGSVJhZAtXtHx9LMqr8+W+yQA==", null, false, "", false, "tranthaonguyen@gmail.com" }
                });

            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Price", "Status" },
                values: new object[] { 8029000L, 1 });

            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Price", "Status" },
                values: new object[] { 4279000L, 1 });

            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Price", "Status" },
                values: new object[] { 4879000L, 1 });

            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Price", "Status" },
                values: new object[] { 7529000L, 1 });

            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Price", "Status" },
                values: new object[] { 2979000L, 1 });

            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Price", "Status" },
                values: new object[] { 3079000L, 1 });

            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Price", "Status" },
                values: new object[] { 3679000L, 1 });

            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Price", "Status" },
                values: new object[] { 2739000L, 1 });

            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Price", "Status" },
                values: new object[] { 7129000L, 1 });

            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Price", "Status" },
                values: new object[] { 3879000L, 1 });

            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Price", "Status" },
                values: new object[] { 1979000L, 1 });

            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Price", "Status" },
                values: new object[] { 2379000L, 1 });

            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Price", "Status" },
                values: new object[] { 2379000L, 1 });

            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Price", "Status" },
                values: new object[] { 3079000L, 1 });

            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Price", "Status" },
                values: new object[] { 9079000L, 1 });

            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Price", "Status" },
                values: new object[] { 3879000L, 1 });

            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Price", "Status" },
                values: new object[] { 2379000L, 1 });

            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Price", "Status" },
                values: new object[] { 2679000L, 1 });

            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Price", "Status" },
                values: new object[] { 1879000L, 1 });

            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Price", "Status" },
                values: new object[] { 1779000L, 1 });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[,]
                {
                    { "7911d80e-3906-48c0-98a6-8689812fd917", "f4f586db-115b-410d-bb62-91911882d01c" },
                    { "c3cbf61e-0e73-4ead-b60f-d5a57560394a", "69dc0c54-0495-4716-b5e7-8483636ab76f" },
                    { "6a73fb23-9285-4e68-acee-17d189d75906", "69dc0c54-0495-4716-b5e7-8483636ab76f" },
                    { "2fbf8524-33fa-4403-834f-443b4f00a4be", "69dc0c54-0495-4716-b5e7-8483636ab76f" },
                    { "88282915-a492-4c29-a8ba-2d8b6fddf022", "69dc0c54-0495-4716-b5e7-8483636ab76f" },
                    { "602415e6-5846-4a60-a048-9b8692003936", "69dc0c54-0495-4716-b5e7-8483636ab76f" },
                    { "d5e882e7-ab4e-4489-a5ac-937c8507f831", "69dc0c54-0495-4716-b5e7-8483636ab76f" },
                    { "927896de-bd2c-4ec2-97ae-58c1e71a351f", "69dc0c54-0495-4716-b5e7-8483636ab76f" },
                    { "40ec0e6a-e81d-4a89-ac58-19491efe39a5", "69dc0c54-0495-4716-b5e7-8483636ab76f" },
                    { "383180f4-9ad2-41e1-9237-f1df5a2f63de", "69dc0c54-0495-4716-b5e7-8483636ab76f" },
                    { "80684771-c685-471f-a6f9-c43ed16ddd52", "69dc0c54-0495-4716-b5e7-8483636ab76f" },
                    { "c983eca4-bb5b-474e-8215-bba4976014f2", "69dc0c54-0495-4716-b5e7-8483636ab76f" },
                    { "7c98afbc-08fb-49f5-860f-ab8c5460ce6f", "69dc0c54-0495-4716-b5e7-8483636ab76f" },
                    { "018d2e36-e99d-4c54-9f64-b389378b857b", "69dc0c54-0495-4716-b5e7-8483636ab76f" },
                    { "29754f5d-4739-47be-a686-e1452807b3a1", "07bdc189-5436-4e2d-bf2b-93dc12b574b8" },
                    { "eaf0294e-7940-43ae-9868-b4c020af70e8", "69dc0c54-0495-4716-b5e7-8483636ab76f" },
                    { "50a1e147-59a5-4565-83c6-a7b152dd4b12", "69dc0c54-0495-4716-b5e7-8483636ab76f" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "018d2e36-e99d-4c54-9f64-b389378b857b", "69dc0c54-0495-4716-b5e7-8483636ab76f" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "29754f5d-4739-47be-a686-e1452807b3a1", "07bdc189-5436-4e2d-bf2b-93dc12b574b8" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "2fbf8524-33fa-4403-834f-443b4f00a4be", "69dc0c54-0495-4716-b5e7-8483636ab76f" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "383180f4-9ad2-41e1-9237-f1df5a2f63de", "69dc0c54-0495-4716-b5e7-8483636ab76f" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "40ec0e6a-e81d-4a89-ac58-19491efe39a5", "69dc0c54-0495-4716-b5e7-8483636ab76f" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "50a1e147-59a5-4565-83c6-a7b152dd4b12", "69dc0c54-0495-4716-b5e7-8483636ab76f" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "602415e6-5846-4a60-a048-9b8692003936", "69dc0c54-0495-4716-b5e7-8483636ab76f" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "6a73fb23-9285-4e68-acee-17d189d75906", "69dc0c54-0495-4716-b5e7-8483636ab76f" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "7911d80e-3906-48c0-98a6-8689812fd917", "f4f586db-115b-410d-bb62-91911882d01c" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "7c98afbc-08fb-49f5-860f-ab8c5460ce6f", "69dc0c54-0495-4716-b5e7-8483636ab76f" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "80684771-c685-471f-a6f9-c43ed16ddd52", "69dc0c54-0495-4716-b5e7-8483636ab76f" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "88282915-a492-4c29-a8ba-2d8b6fddf022", "69dc0c54-0495-4716-b5e7-8483636ab76f" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "927896de-bd2c-4ec2-97ae-58c1e71a351f", "69dc0c54-0495-4716-b5e7-8483636ab76f" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "c3cbf61e-0e73-4ead-b60f-d5a57560394a", "69dc0c54-0495-4716-b5e7-8483636ab76f" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "c983eca4-bb5b-474e-8215-bba4976014f2", "69dc0c54-0495-4716-b5e7-8483636ab76f" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "d5e882e7-ab4e-4489-a5ac-937c8507f831", "69dc0c54-0495-4716-b5e7-8483636ab76f" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "eaf0294e-7940-43ae-9868-b4c020af70e8", "69dc0c54-0495-4716-b5e7-8483636ab76f" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "07bdc189-5436-4e2d-bf2b-93dc12b574b8");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "69dc0c54-0495-4716-b5e7-8483636ab76f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f4f586db-115b-410d-bb62-91911882d01c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "018d2e36-e99d-4c54-9f64-b389378b857b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "29754f5d-4739-47be-a686-e1452807b3a1");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2fbf8524-33fa-4403-834f-443b4f00a4be");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "383180f4-9ad2-41e1-9237-f1df5a2f63de");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "40ec0e6a-e81d-4a89-ac58-19491efe39a5");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "50a1e147-59a5-4565-83c6-a7b152dd4b12");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "602415e6-5846-4a60-a048-9b8692003936");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6a73fb23-9285-4e68-acee-17d189d75906");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7911d80e-3906-48c0-98a6-8689812fd917");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7c98afbc-08fb-49f5-860f-ab8c5460ce6f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "80684771-c685-471f-a6f9-c43ed16ddd52");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "88282915-a492-4c29-a8ba-2d8b6fddf022");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "927896de-bd2c-4ec2-97ae-58c1e71a351f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c3cbf61e-0e73-4ead-b60f-d5a57560394a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c983eca4-bb5b-474e-8215-bba4976014f2");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d5e882e7-ab4e-4489-a5ac-937c8507f831");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "eaf0294e-7940-43ae-9868-b4c020af70e8");

            migrationBuilder.AlterColumn<double>(
                name: "Price",
                table: "Tours",
                type: "float",
                nullable: false,
                oldClrType: typeof(long));

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
                columns: new[] { "Price", "Status" },
                values: new object[] { 8029000.0, 1 });

            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Price", "Status" },
                values: new object[] { 4279000.0, 1 });

            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Price", "Status" },
                values: new object[] { 4879000.0, 1 });

            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Price", "Status" },
                values: new object[] { 7529000.0, 1 });

            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Price", "Status" },
                values: new object[] { 2979000.0, 1 });

            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Price", "Status" },
                values: new object[] { 3079000.0, 1 });

            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Price", "Status" },
                values: new object[] { 3679000.0, 1 });

            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Price", "Status" },
                values: new object[] { 2739000.0, 1 });

            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Price", "Status" },
                values: new object[] { 7129000.0, 1 });

            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Price", "Status" },
                values: new object[] { 3879000.0, 1 });

            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Price", "Status" },
                values: new object[] { 1979000.0, 1 });

            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Price", "Status" },
                values: new object[] { 2379000.0, 1 });

            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Price", "Status" },
                values: new object[] { 2379000.0, 1 });

            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Price", "Status" },
                values: new object[] { 3079000.0, 1 });

            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Price", "Status" },
                values: new object[] { 9079000.0, 1 });

            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Price", "Status" },
                values: new object[] { 3879000.0, 1 });

            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Price", "Status" },
                values: new object[] { 2379000.0, 1 });

            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Price", "Status" },
                values: new object[] { 2679000.0, 1 });

            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Price", "Status" },
                values: new object[] { 1879000.0, 1 });

            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Price", "Status" },
                values: new object[] { 1779000.0, 1 });

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
    }
}

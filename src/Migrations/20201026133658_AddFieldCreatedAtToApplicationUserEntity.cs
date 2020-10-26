using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace src.Migrations
{
    public partial class AddFieldCreatedAtToApplicationUserEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "7ab70f76-573a-407f-8244-70475790079a", "a025f601-e7e8-4aa2-ac10-9632a609f367", "Admin", "admin" },
                    { "0617945f-6bcc-4140-9dbf-782ddeb07747", "d7b4fd9f-fe32-45e0-ab14-d7c7dc5c4d39", "SuperAdmin", "superadmin" },
                    { "39c92a96-0475-40ef-8f11-53287a2adc52", "cbbe1d2a-4323-440e-9336-81a7f4595168", "Customer", "customer" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CreatedAt", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "465fc1c9-3191-4b9d-adda-de1cdb7b2445", 0, "cbd7f55b-ffa3-44bd-a4a0-f1c5f6676ae1", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "phantantrung@gmail.com", true, "Trung", "Phan Tấn", false, null, "PHANTANTRUNG@GMAIL.COM", "PHANTANTRUNG@GMAIL.COM", "AQAAAAEAACcQAAAAEGCR6b2Itd9kcfBwTKeP+cI07ns2ofY5A304/l7d2k0KQIjXW/LGn/JvzScUylcI6g==", null, false, "", false, "phantantrung@gmail.com" },
                    { "4c5a81e5-14c4-426c-8bfd-9dd2b1d3a750", 0, "ca9a33dc-645b-4b63-af0f-d950d5ed9b75", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "phungthanhdo@gmail.com", true, "Độ", "Phùng Thanh", false, null, "PHUNGTHANHDO@GMAIL.COM", "PHUNGTHANHDO@GMAIL.COM", "AQAAAAEAACcQAAAAEBj3EzIuPg05mVZHf08O9gr0BFqPXeJQnXOeonSOhWJ/mijebRXELJoYe+P+cCOXYA==", null, false, "", false, "phungthanhdo@gmail.com" },
                    { "642bbe35-6573-45d1-a668-aed5f32ebee4", 0, "393830eb-5f36-42fa-959d-ca11026d205b", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "nguyenhue@gmail.com", true, "Huệ", "Nguyễn", false, null, "NGUYENHUE@GMAIL.COM", "NGUYENHUE@GMAIL.COM", "AQAAAAEAACcQAAAAEG0XI7pyg3TUSSLAjVzbE4ktR3UF2IZQ7zmsQm5CvBiNzxgpDm4aFH/8fA239V46zw==", null, false, "", false, "nguyenhue@gmail.com" },
                    { "7ea13f41-eafe-4f40-b5eb-08b299e9b7d5", 0, "f3e9c02c-fe60-4a0b-913e-dc11c4fba98b", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "hoxuanhuong@gmail.com", true, "Hương", "Hồ Xuân", false, null, "HOXUANHUONG@GMAIL.COM", "HOXUANHUONG@GMAIL.COM", "AQAAAAEAACcQAAAAEFscufBMcrLLT3J3BdlgDwaGRh7btPCEVYFKBoy1nnDDlardaZZD4EI1A9nzacyRrA==", null, false, "", false, "hoxuanhuong@gmail.com" },
                    { "c7566421-b5e0-48c1-88d4-70a06cae2911", 0, "a13347cb-7b6e-47cc-a009-18f6c0092226", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "nguyenthanhlong@gmail.com", true, "Long", "Nguyễn Thành", false, null, "NGUYENTHANHLONG@GMAIL.COM", "NGUYENTHANHLONG@GMAIL.COM", "AQAAAAEAACcQAAAAEMTTRZEtJacUJxX2XMg7/dgj3PxqAN465wuARDBShwriXcE9A27+IoXssP8lWvmeMQ==", null, false, "", false, "nguyenthanhlong@gmail.com" },
                    { "62126d28-83fb-47fd-a670-a071b1e7cfbf", 0, "e968e164-e35d-4c19-9d72-eb7b86faec41", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "huynhtranthanh@gmail.com", true, "Thành", "Huỳnh Trấn", false, null, "HUYNHTRANTHANH@GMAIL.COM", "HUYNHTRANTHANH@GMAIL.COM", "AQAAAAEAACcQAAAAEHwlVJpTuPwVwQnoju93Po/Ho3ngaEGIRQUBp98j4bifhVl1En4WLlC75pksgM4STA==", null, false, "", false, "huynhtranthanh@gmail.com" },
                    { "0b0ad29d-9db7-4d15-bedf-57e2d222e2d2", 0, "aaf5e117-b378-455c-a946-2d593d3583fc", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "caobaquat@gmail.com", true, "Quát", "Cao Bá", false, null, "CAOBAQUAT@GMAIL.COM", "CAOBAQUAT@GMAIL.COM", "AQAAAAEAACcQAAAAEF8ZnFOV3xLe5oQEBkz6LGd+YGVTfcHv8JcK9sjmMg4jua1Jn/EcQr7U+ltPxj9gdg==", null, false, "", false, "caobaquat@gmail.com" },
                    { "344934f0-8e5e-43c9-b960-cd581fa0ea7f", 0, "a9deaec0-74d4-45dd-9e60-753c3943c3cf", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "truongthitramanh@gmail.com", true, "Anh", "Trương Thị Trâm", false, null, "TRUONGTHITRAMANH@GMAIL.COM", "TRUONGTHITRAMANH@GMAIL.COM", "AQAAAAEAACcQAAAAEKuQdECXzWbnNY1AHXwjLXvw8jJDPVSucSx0P0VBRIUv9gMALUEaAMSIhcg6lVFF4g==", null, false, "", false, "truongthitramanh@gmail.com" },
                    { "2a9368a9-2789-483b-8bd3-c3236d1878ce", 0, "98802373-acb7-4902-a899-dc20f8d8a0ff", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "truongtuantu@gmail.com", true, "Tú", "Trương Tuấn", false, null, "TRUONGTUANTU@GMAIL.COM", "TRUONGTUANTU@GMAIL.COM", "AQAAAAEAACcQAAAAEBOSV5wFnfvqlhYuM4KE643vVkp2RTFp0FIVwf9VzFYimxoLMrAicjRTtRyAo2b1gA==", null, false, "", false, "truongtuantu@gmail.com" },
                    { "ec7d3bf8-b6ca-48fd-b517-6901034fa778", 0, "ad5fcb05-ffe0-43af-b923-4f7c38b6a0c0", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "caothivananh@gmail.com", true, "Anh", "Cao Thị Vân", false, null, "CAOTHIVANANH@GMAIL.COM", "CAOTHIVANANH@GMAIL.COM", "AQAAAAEAACcQAAAAEFitDJZnbeUJqnvB6TA3W0+NWiH9tsUhiVT207JSLB8Ubdt439ICN8ICOPYwOlBppw==", null, false, "", false, "caothivananh@gmail.com" },
                    { "22117787-c5c4-4287-b94d-7202e37548b9", 0, "46a13c96-302a-4a39-ad32-e76dff7bd7ef", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "nguyennhuloc@gmail.com", true, "Lộc", "Nguyễn Như", false, null, "NGUYENNHULOC@GMAIL.COM", "NGUYENNHULOC@GMAIL.COM", "AQAAAAEAACcQAAAAEHhw+zan2ceemqdVZfVkO9PIqVOi9jBcDLMJmD8Lme9dwQP1H0I/ii+ivulcjDw8pA==", null, false, "", false, "nguyennhuloc@gmail.com" },
                    { "e3cca0a8-5fe7-4dcc-8e9a-92f0f25df0c6", 0, "245a61c4-ca80-48d9-9390-6ed5058b7331", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "nguyentrunghieu@gmail.com", true, "Hiếu", "Nguyễn Trung", false, null, "NGUYENTRUNGHIEU@GMAIL.COM", "NGUYENTRUNGHIEU@GMAIL.COM", "AQAAAAEAACcQAAAAEB7RWtz1CaSpoYhCIPftPKDEUU9m7eixt1kvbuIzorkjmyL35YJT4L4vBCcDZ2GG1A==", null, false, "", false, "nguyentrunghieu@gmail.com" },
                    { "4be408bd-a660-4ca2-882c-08ef52ad4f42", 0, "a5f7cf84-a8cb-4d96-923d-b49ec64487bb", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "phamvinhson@gmail.com", true, "Sơn", "Phạm Vĩnh", false, null, "PHAMVINHSON@GMAIL.COM", "PHAMVINHSON@GMAIL.COM", "AQAAAAEAACcQAAAAEOVIZQ8dQgVpBO+LA0chDmPc+cyOVPd1Paluji41V2UXPtxo6POZ1zZ4USQLlimVLQ==", null, false, "", false, "phamvinhson@gmail.com" },
                    { "c3140bfe-1f41-44e5-b8a6-7165d9ccb3a8", 0, "ec2669f8-2fef-43f1-a5f5-fa4f265e1b61", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "trankieuloan@gmail.com", true, "Loan", "Trần Kiều", false, null, "TRANKIEULOAN@GMAIL.COM", "TRANKIEULOAN@GMAIL.COM", "AQAAAAEAACcQAAAAEFQAHxmdlB3gbDZBs+OgvXqqG2WaUZ1fWIYtPj3LC/8cS89nclnDaU14jpOrOdGnOw==", null, false, "", false, "trankieuloan@gmail.com" },
                    { "1b3d1492-691e-4c52-b69a-6cca2f6dd254", 0, "dd46589e-f89f-459c-b670-94aef63dc8a5", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "yungadmin@gmail.com", true, "Admin", "Yung", false, null, "YUNGADMIN@GMAIL.COM", "YUNGADMIN@GMAIL.COM", "AQAAAAEAACcQAAAAEORjkAHJWIDtqz+9+3eFH3ZpedBiAuhs0ptNP/xzcWZbSOuMxn2V2o8V1wQUZ/8U5A==", null, false, "", false, "yungadmin@gmail.com" },
                    { "b2fb4303-829e-4403-8c78-5ab8e480d1f1", 0, "5788c619-fe2f-40b9-909b-f5060d7c9f4c", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "lilsuperadmin@gmail.com", true, "Super Admin", "Lil", false, null, "LILSUPERADMIN@GMAIL.COM", "LILSUPERADMIN@GMAIL.COM", "AQAAAAEAACcQAAAAEPpVoAcI1nxt1Zu4wMNvXof5wH6+mjz0TXsCqdU0rGHoi1YpUQA3EKcjBvQA7i1XUw==", null, false, "", false, "lilsuperadmin@gmail.com" },
                    { "d6e04c3d-fbca-4649-9a2a-034e9528d839", 0, "1e547c08-b26d-468c-88db-932456a73cb1", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "tranthaonguyen@gmail.com", true, "Nguyên", "Trần Thảo", false, null, "TRANTHAONGUYEN@GMAIL.COM", "TRANTHAONGUYEN@GMAIL.COM", "AQAAAAEAACcQAAAAEPbOfKxmYhltqwhTG39c2JYUZsqyOJSR8ACfSuELPKuYjQ/Kmq9Tu9HdD9F4aK35TA==", null, false, "", false, "tranthaonguyen@gmail.com" }
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
                    { "b2fb4303-829e-4403-8c78-5ab8e480d1f1", "0617945f-6bcc-4140-9dbf-782ddeb07747", null },
                    { "4c5a81e5-14c4-426c-8bfd-9dd2b1d3a750", "39c92a96-0475-40ef-8f11-53287a2adc52", null },
                    { "642bbe35-6573-45d1-a668-aed5f32ebee4", "39c92a96-0475-40ef-8f11-53287a2adc52", null },
                    { "7ea13f41-eafe-4f40-b5eb-08b299e9b7d5", "39c92a96-0475-40ef-8f11-53287a2adc52", null },
                    { "c7566421-b5e0-48c1-88d4-70a06cae2911", "39c92a96-0475-40ef-8f11-53287a2adc52", null },
                    { "62126d28-83fb-47fd-a670-a071b1e7cfbf", "39c92a96-0475-40ef-8f11-53287a2adc52", null },
                    { "0b0ad29d-9db7-4d15-bedf-57e2d222e2d2", "39c92a96-0475-40ef-8f11-53287a2adc52", null },
                    { "465fc1c9-3191-4b9d-adda-de1cdb7b2445", "39c92a96-0475-40ef-8f11-53287a2adc52", null },
                    { "344934f0-8e5e-43c9-b960-cd581fa0ea7f", "39c92a96-0475-40ef-8f11-53287a2adc52", null },
                    { "ec7d3bf8-b6ca-48fd-b517-6901034fa778", "39c92a96-0475-40ef-8f11-53287a2adc52", null },
                    { "22117787-c5c4-4287-b94d-7202e37548b9", "39c92a96-0475-40ef-8f11-53287a2adc52", null },
                    { "e3cca0a8-5fe7-4dcc-8e9a-92f0f25df0c6", "39c92a96-0475-40ef-8f11-53287a2adc52", null },
                    { "4be408bd-a660-4ca2-882c-08ef52ad4f42", "39c92a96-0475-40ef-8f11-53287a2adc52", null },
                    { "c3140bfe-1f41-44e5-b8a6-7165d9ccb3a8", "39c92a96-0475-40ef-8f11-53287a2adc52", null },
                    { "1b3d1492-691e-4c52-b69a-6cca2f6dd254", "7ab70f76-573a-407f-8244-70475790079a", null },
                    { "d6e04c3d-fbca-4649-9a2a-034e9528d839", "39c92a96-0475-40ef-8f11-53287a2adc52", null },
                    { "2a9368a9-2789-483b-8bd3-c3236d1878ce", "39c92a96-0475-40ef-8f11-53287a2adc52", null }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "0b0ad29d-9db7-4d15-bedf-57e2d222e2d2", "39c92a96-0475-40ef-8f11-53287a2adc52" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "1b3d1492-691e-4c52-b69a-6cca2f6dd254", "7ab70f76-573a-407f-8244-70475790079a" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "22117787-c5c4-4287-b94d-7202e37548b9", "39c92a96-0475-40ef-8f11-53287a2adc52" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "2a9368a9-2789-483b-8bd3-c3236d1878ce", "39c92a96-0475-40ef-8f11-53287a2adc52" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "344934f0-8e5e-43c9-b960-cd581fa0ea7f", "39c92a96-0475-40ef-8f11-53287a2adc52" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "465fc1c9-3191-4b9d-adda-de1cdb7b2445", "39c92a96-0475-40ef-8f11-53287a2adc52" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "4be408bd-a660-4ca2-882c-08ef52ad4f42", "39c92a96-0475-40ef-8f11-53287a2adc52" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "4c5a81e5-14c4-426c-8bfd-9dd2b1d3a750", "39c92a96-0475-40ef-8f11-53287a2adc52" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "62126d28-83fb-47fd-a670-a071b1e7cfbf", "39c92a96-0475-40ef-8f11-53287a2adc52" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "642bbe35-6573-45d1-a668-aed5f32ebee4", "39c92a96-0475-40ef-8f11-53287a2adc52" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "7ea13f41-eafe-4f40-b5eb-08b299e9b7d5", "39c92a96-0475-40ef-8f11-53287a2adc52" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "b2fb4303-829e-4403-8c78-5ab8e480d1f1", "0617945f-6bcc-4140-9dbf-782ddeb07747" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "c3140bfe-1f41-44e5-b8a6-7165d9ccb3a8", "39c92a96-0475-40ef-8f11-53287a2adc52" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "c7566421-b5e0-48c1-88d4-70a06cae2911", "39c92a96-0475-40ef-8f11-53287a2adc52" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "d6e04c3d-fbca-4649-9a2a-034e9528d839", "39c92a96-0475-40ef-8f11-53287a2adc52" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "e3cca0a8-5fe7-4dcc-8e9a-92f0f25df0c6", "39c92a96-0475-40ef-8f11-53287a2adc52" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "ec7d3bf8-b6ca-48fd-b517-6901034fa778", "39c92a96-0475-40ef-8f11-53287a2adc52" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0617945f-6bcc-4140-9dbf-782ddeb07747");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "39c92a96-0475-40ef-8f11-53287a2adc52");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7ab70f76-573a-407f-8244-70475790079a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0b0ad29d-9db7-4d15-bedf-57e2d222e2d2");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1b3d1492-691e-4c52-b69a-6cca2f6dd254");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "22117787-c5c4-4287-b94d-7202e37548b9");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2a9368a9-2789-483b-8bd3-c3236d1878ce");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "344934f0-8e5e-43c9-b960-cd581fa0ea7f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "465fc1c9-3191-4b9d-adda-de1cdb7b2445");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4be408bd-a660-4ca2-882c-08ef52ad4f42");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4c5a81e5-14c4-426c-8bfd-9dd2b1d3a750");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62126d28-83fb-47fd-a670-a071b1e7cfbf");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "642bbe35-6573-45d1-a668-aed5f32ebee4");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7ea13f41-eafe-4f40-b5eb-08b299e9b7d5");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b2fb4303-829e-4403-8c78-5ab8e480d1f1");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c3140bfe-1f41-44e5-b8a6-7165d9ccb3a8");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c7566421-b5e0-48c1-88d4-70a06cae2911");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d6e04c3d-fbca-4649-9a2a-034e9528d839");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e3cca0a8-5fe7-4dcc-8e9a-92f0f25df0c6");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ec7d3bf8-b6ca-48fd-b517-6901034fa778");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "AspNetUsers");

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
        }
    }
}

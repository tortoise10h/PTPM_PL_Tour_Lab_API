using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace src.Migrations
{
    public partial class AddPhoneNumberToUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "1efae0cb-898c-4550-b3ae-af178f2716bb", "1c01b40f-9d33-458f-af62-6df4403aebc0" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "2cdd39df-5acd-4071-ac15-b349dfc3bde3", "1c01b40f-9d33-458f-af62-6df4403aebc0" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "3574ab93-3c65-4600-944b-26dfbfff4c38", "1c01b40f-9d33-458f-af62-6df4403aebc0" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "39587b99-dbd2-49da-884a-cd7047e02c9b", "1c01b40f-9d33-458f-af62-6df4403aebc0" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "3ec366d7-e4f9-4fab-b0e2-6837dbba3883", "2942b32d-17a2-45aa-ba81-c67537ddbc63" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "4670a25d-a2e0-40f6-95be-d2f6db396a24", "2942b32d-17a2-45aa-ba81-c67537ddbc63" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "51b709d2-772e-4b78-b890-49b470d4041f", "2942b32d-17a2-45aa-ba81-c67537ddbc63" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "5259a667-fc82-480d-8f4a-7fbb0fb37580", "1c01b40f-9d33-458f-af62-6df4403aebc0" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "52e868d7-2bd2-4ee9-8217-84fc16a2a7e2", "ace12b17-c89a-490d-9f6e-653e37c2b9c6" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "5a02dfdd-3493-4278-b9f0-8e4083bdaa88", "1c01b40f-9d33-458f-af62-6df4403aebc0" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "6167f48d-4b49-47d3-a820-00326998e584", "1c01b40f-9d33-458f-af62-6df4403aebc0" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "6b3f1d35-84a9-47db-aa75-c77f2c047eff", "2942b32d-17a2-45aa-ba81-c67537ddbc63" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "6dd937d8-526a-4608-8721-f1f952bb0e15", "1c01b40f-9d33-458f-af62-6df4403aebc0" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "7bcae672-19f2-43b1-bc40-7f4b727e0329", "2942b32d-17a2-45aa-ba81-c67537ddbc63" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "8597edeb-caa5-49ff-88ab-de2b5a54c656", "1c01b40f-9d33-458f-af62-6df4403aebc0" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "873a7bea-8be8-4282-8d92-ee73cd74d3d5", "2942b32d-17a2-45aa-ba81-c67537ddbc63" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "87566005-33f6-4f8a-8eee-a1d8ee352c5d", "2942b32d-17a2-45aa-ba81-c67537ddbc63" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "98243625-ccef-4384-a6c7-630220c6f23e", "1c01b40f-9d33-458f-af62-6df4403aebc0" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "a28b269e-aa4e-41bf-9a25-06b24f351aa8", "1c01b40f-9d33-458f-af62-6df4403aebc0" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "a8b37916-2263-4877-8eb6-c31a1f175de7", "b5772a60-1833-43f8-805d-af8a8e4db572" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "b1983ed1-48f5-4d06-91a9-2451daa4d454", "1c01b40f-9d33-458f-af62-6df4403aebc0" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "d53c63e3-f060-4559-aada-ab94d9c11ad8", "1c01b40f-9d33-458f-af62-6df4403aebc0" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "db41ae4f-ed07-456d-b7c9-1e36ebcbc0f9", "1c01b40f-9d33-458f-af62-6df4403aebc0" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "db6439e5-9220-4e8b-a86e-05cefb15c16d", "2942b32d-17a2-45aa-ba81-c67537ddbc63" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "e2718569-01a6-41fc-ad97-c3103de8034d", "1c01b40f-9d33-458f-af62-6df4403aebc0" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "e6639c6e-f09c-4365-a2af-a916035951fb", "2942b32d-17a2-45aa-ba81-c67537ddbc63" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "fbd7814f-0a2a-46c1-9cb9-f0d144a10591", "2942b32d-17a2-45aa-ba81-c67537ddbc63" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1c01b40f-9d33-458f-af62-6df4403aebc0");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2942b32d-17a2-45aa-ba81-c67537ddbc63");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ace12b17-c89a-490d-9f6e-653e37c2b9c6");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b5772a60-1833-43f8-805d-af8a8e4db572");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1efae0cb-898c-4550-b3ae-af178f2716bb");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2cdd39df-5acd-4071-ac15-b349dfc3bde3");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3574ab93-3c65-4600-944b-26dfbfff4c38");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "39587b99-dbd2-49da-884a-cd7047e02c9b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3ec366d7-e4f9-4fab-b0e2-6837dbba3883");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4670a25d-a2e0-40f6-95be-d2f6db396a24");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "51b709d2-772e-4b78-b890-49b470d4041f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5259a667-fc82-480d-8f4a-7fbb0fb37580");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "52e868d7-2bd2-4ee9-8217-84fc16a2a7e2");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5a02dfdd-3493-4278-b9f0-8e4083bdaa88");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6167f48d-4b49-47d3-a820-00326998e584");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6b3f1d35-84a9-47db-aa75-c77f2c047eff");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6dd937d8-526a-4608-8721-f1f952bb0e15");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7bcae672-19f2-43b1-bc40-7f4b727e0329");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8597edeb-caa5-49ff-88ab-de2b5a54c656");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "873a7bea-8be8-4282-8d92-ee73cd74d3d5");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "87566005-33f6-4f8a-8eee-a1d8ee352c5d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "98243625-ccef-4384-a6c7-630220c6f23e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a28b269e-aa4e-41bf-9a25-06b24f351aa8");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a8b37916-2263-4877-8eb6-c31a1f175de7");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b1983ed1-48f5-4d06-91a9-2451daa4d454");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d53c63e3-f060-4559-aada-ab94d9c11ad8");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "db41ae4f-ed07-456d-b7c9-1e36ebcbc0f9");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "db6439e5-9220-4e8b-a86e-05cefb15c16d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e2718569-01a6-41fc-ad97-c3103de8034d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e6639c6e-f09c-4365-a2af-a916035951fb");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fbd7814f-0a2a-46c1-9cb9-f0d144a10591");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "8753c7be-2304-4691-b2e7-06e6489d0bf0", "7098a23b-5f32-47d7-af1d-6f77203c5741", "Admin", "admin" },
                    { "2017fb68-8553-49df-ae89-7f6a7fe18dbe", "449dbdd3-13e2-4a41-ba93-88340edb24b8", "SuperAdmin", "superadmin" },
                    { "7d2a99cf-91ec-40a3-a2f0-f7dec390b36e", "73a14fe0-61b8-47dc-8834-4d7a7c065660", "Customer", "customer" },
                    { "3ee45d6f-e566-47dc-b6f5-4c0646fc914e", "c6d41972-5a94-484f-935d-098575c85816", "Staff", "staff" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CreatedAt", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "0bde3b4e-6e9f-495b-b614-7fdaa48889e9", 0, "a2e292f6-a393-4afa-b959-3b60d82c1f37", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "phantantrung@gmail.com", true, "Trung", "Phan Tấn", false, null, "PHANTANTRUNG@GMAIL.COM", "PHANTANTRUNG@GMAIL.COM", "AQAAAAEAACcQAAAAEFrjiG7ESbUeZZimhi6nN6YsLltWowOpbuyMKJmWo/vnefoIlNmOxp3Ekoayxufy0w==", "0901234576", false, "", false, "phantantrung@gmail.com" },
                    { "d3240fe9-e7f0-4c51-afdc-050a71516ca6", 0, "3668b4de-ee41-43c9-99f5-a1a9c3da1dcb", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "truongtuantu@gmail.com", true, "Tú", "Trương Tuấn", false, null, "TRUONGTUANTU@GMAIL.COM", "TRUONGTUANTU@GMAIL.COM", "AQAAAAEAACcQAAAAEBLk9CTJKdiyxX8/XQlofA2XP93Ig3BOqXSqAG1vPw0sQV3Ffi3pY6Xhc3YFhxiraA==", "0901234577", false, "", false, "truongtuantu@gmail.com" },
                    { "88c5b08b-72ab-4ba3-ae2d-08a3c174fcce", 0, "7600771b-4757-4a11-8883-67f0a2a22e09", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "truongthimaitram@gmail.com", true, "Trâm", "Trương Thị Mai", false, null, "TRUONGTHIMAITRAM@GMAIL.COM", "TRUONGTHIMAITRAM@GMAIL.COM", "AQAAAAEAACcQAAAAEKc7S2m2o6NDKQTkm6VNL9a9NqHF+1VYuvk7UDbUZAGT5PPfTggNks0X80P9Bq/mWg==", "0901234578", false, "", false, "truongthimaitram@gmail.com" },
                    { "f7ef30e0-963e-4ff8-ab65-97d2078e19c2", 0, "0b640910-ad0f-4781-b99a-3fef3917bee8", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "nguyenbuuvinh@gmail.com", true, "Vinh", "Nguyễn Bửu", false, null, "NGUYENBUUVINH@GMAIL.COM", "NGUYENBUUVINH@GMAIL.COM", "AQAAAAEAACcQAAAAEFwNFY9jeS354fGvgvPBiRqVnIEC73PEydKwo6LV8+HQtGvyvQcx+J3pA0cX1dALhg==", "0901234579", false, "", false, "nguyenbuuvinh@gmail.com" },
                    { "4b3b1bd5-23e0-40ec-93d2-f0fa54858bea", 0, "0756b69f-326b-45ad-8d41-fe1d6fff4d95", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "lequangduy@gmail.com", true, "Duy", "Lê Quang", false, null, "LEQUANGDUY@GMAIL.COM", "LEQUANGDUY@GMAIL.COM", "AQAAAAEAACcQAAAAEKJ6UNAy2ITxAHoKsXjBjDQENNoCJb5pIyj+dOPiiATJRyGI3ca7vADbsuKORQm5KQ==", "0901234580", false, "", false, "lequangduy@gmail.com" },
                    { "645bc057-328d-43c8-b168-faa17989766c", 0, "78a92bc1-973a-439c-b131-1b0a929a843c", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "chuvietdung@gmail.com", true, "Dũng", "Chu Việt", false, null, "CHUVIETDUNG@GMAIL.COM", "CHUVIETDUNG@GMAIL.COM", "AQAAAAEAACcQAAAAEPRIdFZ4wtDC3WZp0I38VkQUDZNkNY0greiTOCYm2bjgKlDvFyo+kgS4/EdA6zHojQ==", "0901234583", false, "", false, "chuvietdung@gmail.com" },
                    { "e4aff09b-3d36-49e7-adbf-74ef57bfb150", 0, "95bae2d4-e420-4ed6-8236-dad67b14efee", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "phungthanhdo@gmail.com", true, "Độ", "Phùng Thanh", false, null, "PHUNGTHANHDO@GMAIL.COM", "PHUNGTHANHDO@GMAIL.COM", "AQAAAAEAACcQAAAAEIjaHx9273cI4YvKatM1k8a7Jz29pL97PSqSWGtpiNXHTLuHWzzi1USG5uOxzbzYNg==", "0901234575", false, "", false, "phungthanhdo@gmail.com" },
                    { "2ada955f-8b38-4da9-b1a1-ac6efada6879", 0, "0007d83b-32e6-4d14-ad0e-75af0d5a3667", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "buibichphuong@gmail.com", true, "Phương", "Bùi Bích", false, null, "BUIBICHPHUONG@GMAIL.COM", "BUIBICHPHUONG@GMAIL.COM", "AQAAAAEAACcQAAAAEFnBb7i0Q8wSe6f2asVyEwwtsB5T6/gD+s2yGiIvF9MWHXnYX7dF7k+2qd398fn7+w==", "0901234584", false, "", false, "buibichphuong@gmail.com" },
                    { "1f2c5c0f-122b-46fb-a0ad-fcb8f93ba472", 0, "a09569a6-af3d-49c5-a5b5-262a839cf966", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "tranphuongly@gmail.com", true, "Ly", "Trần Phương", false, null, "TRANPHUONGLY@GMAIL.COM", "TRANPHUONGLY@GMAIL.COM", "AQAAAAEAACcQAAAAENW/1CgY/F8QncRjzPh432poUMMmXqoi3PP/UZNxGlSznnhNtuPD+U+NXab+YvAI9w==", "0901234585", false, "", false, "tranphuongly@gmail.com" },
                    { "1bf11639-ba05-4891-ab7a-267004845922", 0, "d7cbc8e8-af0f-477b-87ff-a516537ea936", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "luongtulinh@gmail.com", true, "Linh", "Lường Tú", false, null, "LUONGTULINH@GMAIL.COM", "LUONGTULINH@GMAIL.COM", "AQAAAAEAACcQAAAAEM+BSpWCi/W5iKieln4n6JW45RcrNRQRwwxngX8XNun+M9AR/GeZ61/mZkXwabcWbw==", "0901234586", false, "", false, "luongtulinh@gmail.com" },
                    { "ab6c1365-82b2-4f35-b7bb-c9bf7a4c512c", 0, "8283d126-6322-4d50-ae51-49492bf24625", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "malephixuan@gmail.com", true, "Xuân", "Mã Lệ Phi", false, null, "MALEPHIXUAN@GMAIL.COM", "MALEPHIXUAN@GMAIL.COM", "AQAAAAEAACcQAAAAEObIXqnb/imoRiNvlTqeqzUtdxk/hopLcY8arXBY5+IYLhkdJU5t+MXaYH3TWLhlLQ==", "0901234587", false, "", false, "malephixuan@gmail.com" },
                    { "10643f67-7bc5-4a57-badc-cae5b1a37927", 0, "817e3cc7-9b99-47df-adba-7b3032ed3c0a", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "luubaominh@gmail.com", true, "Minh", "Lưu Bảo", false, null, "LUUBAOMINH@GMAIL.COM", "LUUBAOMINH@GMAIL.COM", "AQAAAAEAACcQAAAAEP+jf7gvQA0YUsAYAx996G65H82NlPgt+v6XfcA2MIQpzCxWZ1M1mHB9gm9k7vedog==", "0901234581", false, "", false, "luubaominh@gmail.com" },
                    { "ebf1406e-4f88-460c-ae71-40a34a0ccc08", 0, "0586b68a-f07e-4320-89ac-b72f6bb6e874", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "nguyenhue@gmail.com", true, "Huệ", "Nguyễn", false, null, "NGUYENHUE@GMAIL.COM", "NGUYENHUE@GMAIL.COM", "AQAAAAEAACcQAAAAEHMGQs1bvsrFtCDSQCiFKHEKqyZbh0z77pitH40RP/V0Ipe6l0bDjCPtkpO9xIDWpQ==", "0901234574", false, "", false, "nguyenhue@gmail.com" },
                    { "37ff3771-05cf-402c-9ad0-416dcc51f191", 0, "498ef1bc-6cc9-43ff-9b46-4082f2b2e580", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "duonghoanphong@gmail.com", true, "Phong", "Đường Hoán", false, null, "DUONGHOANPHONG@GMAIL.COM", "DUONGHOANPHONG@GMAIL.COM", "AQAAAAEAACcQAAAAEJnc2V3mCxDIyv7V7hNMzc4F5KMhMfKdYHDJO0Mefp7SLiyLCM1QprAazlhGQuRbcg==", "0901234582", false, "", false, "duonghoanphong@gmail.com" },
                    { "7bf9f275-5808-4447-ac3e-24de1b288157", 0, "936d3166-608c-4291-98a8-6ed1094926e0", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "nguyenthanhlong@gmail.com", true, "Long", "Nguyễn Thành", false, null, "NGUYENTHANHLONG@GMAIL.COM", "NGUYENTHANHLONG@GMAIL.COM", "AQAAAAEAACcQAAAAEDf8k9ssowAvBqM0iTYS+zAB4zWvMlUwN6NziDJwSif1ZlfXX/dYMQm8+Qdc+KYi4g==", "0901234572", false, "", false, "nguyenthanhlong@gmail.com" },
                    { "57573921-df6f-48e5-a42a-0d8d22ae118b", 0, "8fa22fda-acd2-4ce1-9380-acf1f9b52d6f", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "huynhtranthanh@gmail.com", true, "Thành", "Huỳnh Trấn", false, null, "HUYNHTRANTHANH@GMAIL.COM", "HUYNHTRANTHANH@GMAIL.COM", "AQAAAAEAACcQAAAAEJyAeGUfY0W7MKsIzG7IuKNGHj2O83reE8y8s50T+4h3/77GIDBAfckc0YPYBURLjg==", "0901234571", false, "", false, "huynhtranthanh@gmail.com" },
                    { "52a45713-a71e-43ef-9e34-79e679ced3c1", 0, "7c3a84fe-5a4c-40cc-b0f2-c1058f14fca3", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "caobaquat@gmail.com", true, "Quát", "Cao Bá", false, null, "CAOBAQUAT@GMAIL.COM", "CAOBAQUAT@GMAIL.COM", "AQAAAAEAACcQAAAAEBRMd1XmbW2OfUOzhCYf0/ulJebWIensVXL3I/ShqWIC7u7Q173rETrITMRxGtKBWw==", "0901234570", false, "", false, "caobaquat@gmail.com" },
                    { "d8325ccc-9ae2-4c8a-b056-dfdf2ba991ac", 0, "75c085e9-af64-4576-88b0-809af3a0295f", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "truongthitramanh@gmail.com", true, "Anh", "Trương Thị Trâm", false, null, "TRUONGTHITRAMANH@GMAIL.COM", "TRUONGTHITRAMANH@GMAIL.COM", "AQAAAAEAACcQAAAAEFVMwP2aes/qpT9wcftwXH3EGqt4p7pvm5ATcXzvmXURjsqW2XNqDD4vZl40O/eCSg==", "0901234569", false, "", false, "truongthitramanh@gmail.com" },
                    { "586a13c0-237f-451f-b0ba-e019a8c61aa2", 0, "100bcc11-04d7-4013-bafa-5674c4fffef5", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "tranthaonguyen@gmail.com", true, "Nguyên", "Trần Thảo", false, null, "TRANTHAONGUYEN@GMAIL.COM", "TRANTHAONGUYEN@GMAIL.COM", "AQAAAAEAACcQAAAAEDQ4ZLQSjYwSh+l34vuL0LpjLVyGzgPkiG+uAI5RoxlWV25slOO4xKhZQ5WfDE3ZzA==", "0901234568", false, "", false, "tranthaonguyen@gmail.com" },
                    { "d3fdde6f-d788-439b-acc3-4ca847123bd0", 0, "2201a033-9eda-488a-ad1c-97699d2dbbd0", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "caothivananh@gmail.com", true, "Anh", "Cao Thị Vân", false, null, "CAOTHIVANANH@GMAIL.COM", "CAOTHIVANANH@GMAIL.COM", "AQAAAAEAACcQAAAAEEztsQS99K1n9y6B1PjkeXP1N2D0LDrqYdJJ9dtnrhDEjy8TJQpL+EAGVWYwAO3OFw==", "0901234567", false, "", false, "caothivananh@gmail.com" },
                    { "1cb378c1-d00b-4129-8713-565dad58c8c0", 0, "3cf32462-ac3c-4802-a32e-96415fad4a55", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "nguyennhuloc@gmail.com", true, "Lộc", "Nguyễn Như", false, null, "NGUYENNHULOC@GMAIL.COM", "NGUYENNHULOC@GMAIL.COM", "AQAAAAEAACcQAAAAEBgi/sI4EgFwb2p2OkQ9sJjwUxLO+2C3PNKEanthA8fyHlSP4VNMLHy4ikwLnzWfxA==", "0901234566", false, "", false, "nguyennhuloc@gmail.com" },
                    { "04fc2ae9-9a01-4009-97b4-c46fef6eb76c", 0, "3fe2ce4d-888e-4758-a2d1-ebacd46a9bb2", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "hoxuanhuong@gmail.com", true, "Hương", "Hồ Xuân", false, null, "HOXUANHUONG@GMAIL.COM", "HOXUANHUONG@GMAIL.COM", "AQAAAAEAACcQAAAAEGkcw93gzrqTcLjDtcWT5DccVJ8I5vBP93isHL6QvoREUHpQ232bJG79wURycTw0eg==", "0901234573", false, "", false, "hoxuanhuong@gmail.com" },
                    { "cf223a22-9ad1-49e1-b675-de130d941a06", 0, "7f6e1b80-ae22-40d0-96f4-b35272981177", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "nguyentrunghieu@gmail.com", true, "Hiếu", "Nguyễn Trung", false, null, "NGUYENTRUNGHIEU@GMAIL.COM", "NGUYENTRUNGHIEU@GMAIL.COM", "AQAAAAEAACcQAAAAELGjXqw+pgUtcWQiUyuV+rM3uhGnFHs3adQedPMW1jZVznF5wuidYj8MqlyxsBOaYw==", "0901234565", false, "", false, "nguyentrunghieu@gmail.com" },
                    { "6bf492d4-a6de-478d-9306-0bc45579b662", 0, "856571a3-c68f-4eb9-98c2-46b2dda4fcc9", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "phamvinhson@gmail.com", true, "Sơn", "Phạm Vĩnh", false, null, "PHAMVINHSON@GMAIL.COM", "PHAMVINHSON@GMAIL.COM", "AQAAAAEAACcQAAAAEOoPPPChX2egOtQSHKShb9yPQc38/naqs+dIl6KyjEUzSwv9pvGXvTI9dGZtDQsk3Q==", "0901234564", false, "", false, "phamvinhson@gmail.com" },
                    { "98796cd8-75a0-405e-8451-7358f89b103f", 0, "a4b5c3c8-7265-4603-93a2-ab59e6eb763b", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "trankieuloan@gmail.com", true, "Loan", "Trần Kiều", false, null, "TRANKIEULOAN@GMAIL.COM", "TRANKIEULOAN@GMAIL.COM", "AQAAAAEAACcQAAAAEFceHcwA+zrjwSQeuf7+V2Z25Vj6c4/IHoKR6z/6o0fR/Kx4EfsP3q3hj+/bJ0peJA==", "0901234563", false, "", false, "trankieuloan@gmail.com" },
                    { "90b56e08-aca4-4288-92a8-1ad0d481179d", 0, "ec32823c-12c1-4a73-8a93-0faddefdf8a2", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "yungadmin@gmail.com", true, "Admin", "Yung", false, null, "YUNGADMIN@GMAIL.COM", "YUNGADMIN@GMAIL.COM", "AQAAAAEAACcQAAAAEE4FqoFg8X0M6rCiJsfAr72uljlaSO3G/uDuDVHw/0GyFHFjO63hw+fGrUpVqJJsIw==", "0901234562", false, "", false, "yungadmin@gmail.com" },
                    { "88632ff5-383f-40e1-b643-955295be03d9", 0, "49b38674-80d2-4b96-81d5-c20857dc7a7a", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "lilsuperadmin@gmail.com", true, "Super Admin", "Lil", false, null, "LILSUPERADMIN@GMAIL.COM", "LILSUPERADMIN@GMAIL.COM", "AQAAAAEAACcQAAAAEC+9J+g3aifAVjimt9IWh8vVbqIUdzHsHpOy1bNEpryqt54rskp2yptJXfm3sfCtig==", "0901234561", false, "", false, "lilsuperadmin@gmail.com" }
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
                    { "88632ff5-383f-40e1-b643-955295be03d9", "2017fb68-8553-49df-ae89-7f6a7fe18dbe", null },
                    { "1f2c5c0f-122b-46fb-a0ad-fcb8f93ba472", "3ee45d6f-e566-47dc-b6f5-4c0646fc914e", null },
                    { "2ada955f-8b38-4da9-b1a1-ac6efada6879", "3ee45d6f-e566-47dc-b6f5-4c0646fc914e", null },
                    { "645bc057-328d-43c8-b168-faa17989766c", "3ee45d6f-e566-47dc-b6f5-4c0646fc914e", null },
                    { "37ff3771-05cf-402c-9ad0-416dcc51f191", "3ee45d6f-e566-47dc-b6f5-4c0646fc914e", null },
                    { "10643f67-7bc5-4a57-badc-cae5b1a37927", "3ee45d6f-e566-47dc-b6f5-4c0646fc914e", null },
                    { "4b3b1bd5-23e0-40ec-93d2-f0fa54858bea", "3ee45d6f-e566-47dc-b6f5-4c0646fc914e", null },
                    { "f7ef30e0-963e-4ff8-ab65-97d2078e19c2", "3ee45d6f-e566-47dc-b6f5-4c0646fc914e", null },
                    { "88c5b08b-72ab-4ba3-ae2d-08a3c174fcce", "3ee45d6f-e566-47dc-b6f5-4c0646fc914e", null },
                    { "d3240fe9-e7f0-4c51-afdc-050a71516ca6", "7d2a99cf-91ec-40a3-a2f0-f7dec390b36e", null },
                    { "0bde3b4e-6e9f-495b-b614-7fdaa48889e9", "7d2a99cf-91ec-40a3-a2f0-f7dec390b36e", null },
                    { "e4aff09b-3d36-49e7-adbf-74ef57bfb150", "7d2a99cf-91ec-40a3-a2f0-f7dec390b36e", null },
                    { "1bf11639-ba05-4891-ab7a-267004845922", "3ee45d6f-e566-47dc-b6f5-4c0646fc914e", null },
                    { "ebf1406e-4f88-460c-ae71-40a34a0ccc08", "7d2a99cf-91ec-40a3-a2f0-f7dec390b36e", null },
                    { "7bf9f275-5808-4447-ac3e-24de1b288157", "7d2a99cf-91ec-40a3-a2f0-f7dec390b36e", null },
                    { "57573921-df6f-48e5-a42a-0d8d22ae118b", "7d2a99cf-91ec-40a3-a2f0-f7dec390b36e", null },
                    { "52a45713-a71e-43ef-9e34-79e679ced3c1", "7d2a99cf-91ec-40a3-a2f0-f7dec390b36e", null },
                    { "d8325ccc-9ae2-4c8a-b056-dfdf2ba991ac", "7d2a99cf-91ec-40a3-a2f0-f7dec390b36e", null },
                    { "586a13c0-237f-451f-b0ba-e019a8c61aa2", "7d2a99cf-91ec-40a3-a2f0-f7dec390b36e", null },
                    { "d3fdde6f-d788-439b-acc3-4ca847123bd0", "7d2a99cf-91ec-40a3-a2f0-f7dec390b36e", null },
                    { "1cb378c1-d00b-4129-8713-565dad58c8c0", "7d2a99cf-91ec-40a3-a2f0-f7dec390b36e", null },
                    { "cf223a22-9ad1-49e1-b675-de130d941a06", "7d2a99cf-91ec-40a3-a2f0-f7dec390b36e", null },
                    { "6bf492d4-a6de-478d-9306-0bc45579b662", "7d2a99cf-91ec-40a3-a2f0-f7dec390b36e", null },
                    { "98796cd8-75a0-405e-8451-7358f89b103f", "7d2a99cf-91ec-40a3-a2f0-f7dec390b36e", null },
                    { "90b56e08-aca4-4288-92a8-1ad0d481179d", "8753c7be-2304-4691-b2e7-06e6489d0bf0", null },
                    { "04fc2ae9-9a01-4009-97b4-c46fef6eb76c", "7d2a99cf-91ec-40a3-a2f0-f7dec390b36e", null },
                    { "ab6c1365-82b2-4f35-b7bb-c9bf7a4c512c", "3ee45d6f-e566-47dc-b6f5-4c0646fc914e", null }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "04fc2ae9-9a01-4009-97b4-c46fef6eb76c", "7d2a99cf-91ec-40a3-a2f0-f7dec390b36e" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "0bde3b4e-6e9f-495b-b614-7fdaa48889e9", "7d2a99cf-91ec-40a3-a2f0-f7dec390b36e" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "10643f67-7bc5-4a57-badc-cae5b1a37927", "3ee45d6f-e566-47dc-b6f5-4c0646fc914e" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "1bf11639-ba05-4891-ab7a-267004845922", "3ee45d6f-e566-47dc-b6f5-4c0646fc914e" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "1cb378c1-d00b-4129-8713-565dad58c8c0", "7d2a99cf-91ec-40a3-a2f0-f7dec390b36e" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "1f2c5c0f-122b-46fb-a0ad-fcb8f93ba472", "3ee45d6f-e566-47dc-b6f5-4c0646fc914e" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "2ada955f-8b38-4da9-b1a1-ac6efada6879", "3ee45d6f-e566-47dc-b6f5-4c0646fc914e" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "37ff3771-05cf-402c-9ad0-416dcc51f191", "3ee45d6f-e566-47dc-b6f5-4c0646fc914e" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "4b3b1bd5-23e0-40ec-93d2-f0fa54858bea", "3ee45d6f-e566-47dc-b6f5-4c0646fc914e" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "52a45713-a71e-43ef-9e34-79e679ced3c1", "7d2a99cf-91ec-40a3-a2f0-f7dec390b36e" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "57573921-df6f-48e5-a42a-0d8d22ae118b", "7d2a99cf-91ec-40a3-a2f0-f7dec390b36e" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "586a13c0-237f-451f-b0ba-e019a8c61aa2", "7d2a99cf-91ec-40a3-a2f0-f7dec390b36e" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "645bc057-328d-43c8-b168-faa17989766c", "3ee45d6f-e566-47dc-b6f5-4c0646fc914e" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "6bf492d4-a6de-478d-9306-0bc45579b662", "7d2a99cf-91ec-40a3-a2f0-f7dec390b36e" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "7bf9f275-5808-4447-ac3e-24de1b288157", "7d2a99cf-91ec-40a3-a2f0-f7dec390b36e" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "88632ff5-383f-40e1-b643-955295be03d9", "2017fb68-8553-49df-ae89-7f6a7fe18dbe" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "88c5b08b-72ab-4ba3-ae2d-08a3c174fcce", "3ee45d6f-e566-47dc-b6f5-4c0646fc914e" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "90b56e08-aca4-4288-92a8-1ad0d481179d", "8753c7be-2304-4691-b2e7-06e6489d0bf0" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "98796cd8-75a0-405e-8451-7358f89b103f", "7d2a99cf-91ec-40a3-a2f0-f7dec390b36e" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "ab6c1365-82b2-4f35-b7bb-c9bf7a4c512c", "3ee45d6f-e566-47dc-b6f5-4c0646fc914e" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "cf223a22-9ad1-49e1-b675-de130d941a06", "7d2a99cf-91ec-40a3-a2f0-f7dec390b36e" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "d3240fe9-e7f0-4c51-afdc-050a71516ca6", "7d2a99cf-91ec-40a3-a2f0-f7dec390b36e" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "d3fdde6f-d788-439b-acc3-4ca847123bd0", "7d2a99cf-91ec-40a3-a2f0-f7dec390b36e" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "d8325ccc-9ae2-4c8a-b056-dfdf2ba991ac", "7d2a99cf-91ec-40a3-a2f0-f7dec390b36e" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "e4aff09b-3d36-49e7-adbf-74ef57bfb150", "7d2a99cf-91ec-40a3-a2f0-f7dec390b36e" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "ebf1406e-4f88-460c-ae71-40a34a0ccc08", "7d2a99cf-91ec-40a3-a2f0-f7dec390b36e" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "f7ef30e0-963e-4ff8-ab65-97d2078e19c2", "3ee45d6f-e566-47dc-b6f5-4c0646fc914e" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2017fb68-8553-49df-ae89-7f6a7fe18dbe");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3ee45d6f-e566-47dc-b6f5-4c0646fc914e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7d2a99cf-91ec-40a3-a2f0-f7dec390b36e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8753c7be-2304-4691-b2e7-06e6489d0bf0");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "04fc2ae9-9a01-4009-97b4-c46fef6eb76c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0bde3b4e-6e9f-495b-b614-7fdaa48889e9");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "10643f67-7bc5-4a57-badc-cae5b1a37927");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1bf11639-ba05-4891-ab7a-267004845922");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1cb378c1-d00b-4129-8713-565dad58c8c0");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1f2c5c0f-122b-46fb-a0ad-fcb8f93ba472");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2ada955f-8b38-4da9-b1a1-ac6efada6879");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "37ff3771-05cf-402c-9ad0-416dcc51f191");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4b3b1bd5-23e0-40ec-93d2-f0fa54858bea");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "52a45713-a71e-43ef-9e34-79e679ced3c1");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "57573921-df6f-48e5-a42a-0d8d22ae118b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "586a13c0-237f-451f-b0ba-e019a8c61aa2");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "645bc057-328d-43c8-b168-faa17989766c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6bf492d4-a6de-478d-9306-0bc45579b662");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7bf9f275-5808-4447-ac3e-24de1b288157");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "88632ff5-383f-40e1-b643-955295be03d9");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "88c5b08b-72ab-4ba3-ae2d-08a3c174fcce");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "90b56e08-aca4-4288-92a8-1ad0d481179d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "98796cd8-75a0-405e-8451-7358f89b103f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ab6c1365-82b2-4f35-b7bb-c9bf7a4c512c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cf223a22-9ad1-49e1-b675-de130d941a06");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d3240fe9-e7f0-4c51-afdc-050a71516ca6");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d3fdde6f-d788-439b-acc3-4ca847123bd0");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d8325ccc-9ae2-4c8a-b056-dfdf2ba991ac");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e4aff09b-3d36-49e7-adbf-74ef57bfb150");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ebf1406e-4f88-460c-ae71-40a34a0ccc08");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f7ef30e0-963e-4ff8-ab65-97d2078e19c2");

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
                    { "4670a25d-a2e0-40f6-95be-d2f6db396a24", 0, "745f494e-b102-48f8-b2f5-d2906889e880", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "chuvietdung@gmail.com", true, "Dũng", "Chu Việt", false, null, "CHUVIETDUNG@GMAIL.COM", "CHUVIETDUNG@GMAIL.COM", "AQAAAAEAACcQAAAAECuPOxCN2oG/qeY6Hmw0nbqjktk1WwhHFUmUyDonZogqwrcCDDH2p5gzGUMxnPU9Vw==", null, false, "", false, "chuvietdung@gmail.com" },
                    { "6167f48d-4b49-47d3-a820-00326998e584", 0, "73462543-9f76-4f17-9753-49beff35bd4a", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "phungthanhdo@gmail.com", true, "Độ", "Phùng Thanh", false, null, "PHUNGTHANHDO@GMAIL.COM", "PHUNGTHANHDO@GMAIL.COM", "AQAAAAEAACcQAAAAEKvx5wH5GQFXoWI2Z553W8fCxgqrkDCJIKQy0w0mRYXoPyWDQjbcI7BimtkndIHUsg==", null, false, "", false, "phungthanhdo@gmail.com" },
                    { "3ec366d7-e4f9-4fab-b0e2-6837dbba3883", 0, "a8093518-0171-4a8b-b3e7-2a5b225ed743", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "buibichphuong@gmail.com", true, "Phương", "Bùi Bích", false, null, "BUIBICHPHUONG@GMAIL.COM", "BUIBICHPHUONG@GMAIL.COM", "AQAAAAEAACcQAAAAEBsJjjhq8VKv9nhm3VP7SBxteEVrhLjqeR/r5FEO8g4u3E1N2PMH26Fyl7x1IqeN8w==", null, false, "", false, "buibichphuong@gmail.com" },
                    { "6b3f1d35-84a9-47db-aa75-c77f2c047eff", 0, "958eabe5-4261-4bf9-9015-833e8530822d", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "tranphuongly@gmail.com", true, "Ly", "Trần Phương", false, null, "TRANPHUONGLY@GMAIL.COM", "TRANPHUONGLY@GMAIL.COM", "AQAAAAEAACcQAAAAEGgKSroUzE5CNpUh5g1DjLjy1htHfRYcB1oS4shnnyUFV40b1MSoMAChf5QR7nffeQ==", null, false, "", false, "tranphuongly@gmail.com" },
                    { "7bcae672-19f2-43b1-bc40-7f4b727e0329", 0, "41df37c7-57b6-4867-873e-fff11d6f1371", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "luongtulinh@gmail.com", true, "Linh", "Lường Tú", false, null, "LUONGTULINH@GMAIL.COM", "LUONGTULINH@GMAIL.COM", "AQAAAAEAACcQAAAAEMN9EBo09c+9E0X7Cl6XJuyTGrkq7n4pA8sq7SCjqeSOlJOBQmxUt+kTWWnx5R8mUA==", null, false, "", false, "luongtulinh@gmail.com" },
                    { "873a7bea-8be8-4282-8d92-ee73cd74d3d5", 0, "c62eb2d6-00ec-4916-94ec-7801577fe63b", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "malephixuan@gmail.com", true, "Xuân", "Mã Lệ Phi", false, null, "MALEPHIXUAN@GMAIL.COM", "MALEPHIXUAN@GMAIL.COM", "AQAAAAEAACcQAAAAEOxTL3N8zzwe9Qfr88bpKiZsWQPGDrSsSmVBTlh06ynuN/KhBW/4xjgSwyS3D0Yghw==", null, false, "", false, "malephixuan@gmail.com" },
                    { "fbd7814f-0a2a-46c1-9cb9-f0d144a10591", 0, "272577ec-abb1-4005-8dd7-0b313921fb8b", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "luubaominh@gmail.com", true, "Minh", "Lưu Bảo", false, null, "LUUBAOMINH@GMAIL.COM", "LUUBAOMINH@GMAIL.COM", "AQAAAAEAACcQAAAAEBcDdUCa4LXXNlqivPUzXf1Jgmmcw11z73OGglP041w3ZADq7A2XfgtCmiZBO8jU5A==", null, false, "", false, "luubaominh@gmail.com" },
                    { "2cdd39df-5acd-4071-ac15-b349dfc3bde3", 0, "84b64071-54a0-4dd5-919f-df50119dba60", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "nguyenhue@gmail.com", true, "Huệ", "Nguyễn", false, null, "NGUYENHUE@GMAIL.COM", "NGUYENHUE@GMAIL.COM", "AQAAAAEAACcQAAAAEHyJDlJ0gO9KYA7Oi+ENCy7pnm3I/cMgG3nIWmeJH7Z1+mMvxDRvhR1ywFGWA44Msw==", null, false, "", false, "nguyenhue@gmail.com" },
                    { "51b709d2-772e-4b78-b890-49b470d4041f", 0, "650c5e1a-496f-4ad1-840a-807a3d95fab2", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "duonghoanphong@gmail.com", true, "Phong", "Đường Hoán", false, null, "DUONGHOANPHONG@GMAIL.COM", "DUONGHOANPHONG@GMAIL.COM", "AQAAAAEAACcQAAAAEK08hJm5ueiTCy+tXferM3zahne52May0xrxromk2Yy/bnJjxt3qpRJzOmblfUMujw==", null, false, "", false, "duonghoanphong@gmail.com" },
                    { "6dd937d8-526a-4608-8721-f1f952bb0e15", 0, "7fbc4cda-25ae-42ce-af04-c55ef6224dac", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "nguyenthanhlong@gmail.com", true, "Long", "Nguyễn Thành", false, null, "NGUYENTHANHLONG@GMAIL.COM", "NGUYENTHANHLONG@GMAIL.COM", "AQAAAAEAACcQAAAAEA7hG9bnq2uHY/qRLqG/Bzx/UiyWKbrg+INVmMD42QBf41C3G2gI+ZjmmzsJewohnw==", null, false, "", false, "nguyenthanhlong@gmail.com" },
                    { "1efae0cb-898c-4550-b3ae-af178f2716bb", 0, "b1ff201c-32c8-4133-9707-e1fbc5839d15", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "huynhtranthanh@gmail.com", true, "Thành", "Huỳnh Trấn", false, null, "HUYNHTRANTHANH@GMAIL.COM", "HUYNHTRANTHANH@GMAIL.COM", "AQAAAAEAACcQAAAAENZFVtrXt8URkIsymzHAZwVSxpIgssdHr1eGc6N6OGRT9S3V1qHyZr7PLfcv7CUMYQ==", null, false, "", false, "huynhtranthanh@gmail.com" },
                    { "3574ab93-3c65-4600-944b-26dfbfff4c38", 0, "666fa101-d7a5-4af5-a219-c10195eeeedc", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "caobaquat@gmail.com", true, "Quát", "Cao Bá", false, null, "CAOBAQUAT@GMAIL.COM", "CAOBAQUAT@GMAIL.COM", "AQAAAAEAACcQAAAAECezZcbu9ZlD7Rc/If6qZjZWLl3CqfSyCey9diWBCh75P4LdeZ27cwzTToCfgled/g==", null, false, "", false, "caobaquat@gmail.com" },
                    { "98243625-ccef-4384-a6c7-630220c6f23e", 0, "44a45575-be21-4201-a5ae-3bb96f499c39", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "truongthitramanh@gmail.com", true, "Anh", "Trương Thị Trâm", false, null, "TRUONGTHITRAMANH@GMAIL.COM", "TRUONGTHITRAMANH@GMAIL.COM", "AQAAAAEAACcQAAAAEL5qLf0R151nSqLh5UhHEjaJ5rm1k6Wf/BVHyGXMH56irhzh8FZb23tr3J4o1DjjCA==", null, false, "", false, "truongthitramanh@gmail.com" },
                    { "b1983ed1-48f5-4d06-91a9-2451daa4d454", 0, "c62bd532-33bd-4594-82f3-22e8dcf292b1", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "tranthaonguyen@gmail.com", true, "Nguyên", "Trần Thảo", false, null, "TRANTHAONGUYEN@GMAIL.COM", "TRANTHAONGUYEN@GMAIL.COM", "AQAAAAEAACcQAAAAEEPdJ1fP6G7hdzte2+jZ61Z8HBp2Kqpq83avFHoDSwIS6wN5FA3yIVmOwlOWc5auxQ==", null, false, "", false, "tranthaonguyen@gmail.com" },
                    { "d53c63e3-f060-4559-aada-ab94d9c11ad8", 0, "8e2d3645-83fc-48cc-98d8-bd11163df1f5", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "caothivananh@gmail.com", true, "Anh", "Cao Thị Vân", false, null, "CAOTHIVANANH@GMAIL.COM", "CAOTHIVANANH@GMAIL.COM", "AQAAAAEAACcQAAAAEJGS6r1DxfS3y4mHHVZAOycsv2tC4RRihv6cZS1+pak32n+eStdl2Hy8wWrZ71yZig==", null, false, "", false, "caothivananh@gmail.com" },
                    { "5a02dfdd-3493-4278-b9f0-8e4083bdaa88", 0, "7e62df6c-c528-47ba-8c77-21b520b79d73", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "nguyennhuloc@gmail.com", true, "Lộc", "Nguyễn Như", false, null, "NGUYENNHULOC@GMAIL.COM", "NGUYENNHULOC@GMAIL.COM", "AQAAAAEAACcQAAAAEEY/w33k/aW7B0iaH8/hygXaI5ANaXssd0b3FHDzcpXoMG/jeW/TpXNS1hKom2/pfQ==", null, false, "", false, "nguyennhuloc@gmail.com" },
                    { "39587b99-dbd2-49da-884a-cd7047e02c9b", 0, "51c86661-7b60-48b6-975b-da66fd3eb03d", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "hoxuanhuong@gmail.com", true, "Hương", "Hồ Xuân", false, null, "HOXUANHUONG@GMAIL.COM", "HOXUANHUONG@GMAIL.COM", "AQAAAAEAACcQAAAAEKDu5zAbBQ9Cvz7WWvdkO5lXKLAXPRJpDBhMcPefu4oz2egDFr3Iwq4Yai8C7iAN0w==", null, false, "", false, "hoxuanhuong@gmail.com" },
                    { "5259a667-fc82-480d-8f4a-7fbb0fb37580", 0, "053a0cd3-c864-4fc7-88e8-1fa348a88764", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "nguyentrunghieu@gmail.com", true, "Hiếu", "Nguyễn Trung", false, null, "NGUYENTRUNGHIEU@GMAIL.COM", "NGUYENTRUNGHIEU@GMAIL.COM", "AQAAAAEAACcQAAAAEBwR2FFK++iQ0cUZz+5+SF5Gc8HQgwkqwcB7iRlz88Z3uP0rZPzBFXyjfi27Qviqhg==", null, false, "", false, "nguyentrunghieu@gmail.com" },
                    { "e2718569-01a6-41fc-ad97-c3103de8034d", 0, "7c7fda1c-323a-4e8b-97b1-e99258565aad", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "phamvinhson@gmail.com", true, "Sơn", "Phạm Vĩnh", false, null, "PHAMVINHSON@GMAIL.COM", "PHAMVINHSON@GMAIL.COM", "AQAAAAEAACcQAAAAEIGhHvwj25/Nz/VfgkRjcFgbid2wSy1MwNUkN7979rCiv4uvC2HSfsuBV0gqneaKfQ==", null, false, "", false, "phamvinhson@gmail.com" },
                    { "8597edeb-caa5-49ff-88ab-de2b5a54c656", 0, "90bd8b98-67c0-43be-af62-6f142b924304", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "trankieuloan@gmail.com", true, "Loan", "Trần Kiều", false, null, "TRANKIEULOAN@GMAIL.COM", "TRANKIEULOAN@GMAIL.COM", "AQAAAAEAACcQAAAAEB86sLbF67m/T3tErJwNnJFDx8CuTwAQP+O/9WRJ+9FDSO2WzHOwFIxliS7WA1X58g==", null, false, "", false, "trankieuloan@gmail.com" },
                    { "52e868d7-2bd2-4ee9-8217-84fc16a2a7e2", 0, "625a6ddc-13e3-49af-8f74-d890b05c046d", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "yungadmin@gmail.com", true, "Admin", "Yung", false, null, "YUNGADMIN@GMAIL.COM", "YUNGADMIN@GMAIL.COM", "AQAAAAEAACcQAAAAEIPmNHXMMFOP5KjUGGtdDVtaOfWQgXKwk/k8Qm43sUQYh+g9WMTw0o946/x8dqgGgw==", null, false, "", false, "yungadmin@gmail.com" },
                    { "a8b37916-2263-4877-8eb6-c31a1f175de7", 0, "26d99895-af54-4caf-9358-01e82b219a29", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "lilsuperadmin@gmail.com", true, "Super Admin", "Lil", false, null, "LILSUPERADMIN@GMAIL.COM", "LILSUPERADMIN@GMAIL.COM", "AQAAAAEAACcQAAAAEMVG95gXiJuXJto2uYowQeMIKSDZS3TSsH5TrZShcr8kAer61dpqx2Y1QWR1wWnfXg==", null, false, "", false, "lilsuperadmin@gmail.com" }
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
                    { "a8b37916-2263-4877-8eb6-c31a1f175de7", "b5772a60-1833-43f8-805d-af8a8e4db572", null },
                    { "6b3f1d35-84a9-47db-aa75-c77f2c047eff", "2942b32d-17a2-45aa-ba81-c67537ddbc63", null },
                    { "3ec366d7-e4f9-4fab-b0e2-6837dbba3883", "2942b32d-17a2-45aa-ba81-c67537ddbc63", null },
                    { "4670a25d-a2e0-40f6-95be-d2f6db396a24", "2942b32d-17a2-45aa-ba81-c67537ddbc63", null },
                    { "51b709d2-772e-4b78-b890-49b470d4041f", "2942b32d-17a2-45aa-ba81-c67537ddbc63", null },
                    { "fbd7814f-0a2a-46c1-9cb9-f0d144a10591", "2942b32d-17a2-45aa-ba81-c67537ddbc63", null },
                    { "db6439e5-9220-4e8b-a86e-05cefb15c16d", "2942b32d-17a2-45aa-ba81-c67537ddbc63", null },
                    { "87566005-33f6-4f8a-8eee-a1d8ee352c5d", "2942b32d-17a2-45aa-ba81-c67537ddbc63", null },
                    { "e6639c6e-f09c-4365-a2af-a916035951fb", "2942b32d-17a2-45aa-ba81-c67537ddbc63", null },
                    { "a28b269e-aa4e-41bf-9a25-06b24f351aa8", "1c01b40f-9d33-458f-af62-6df4403aebc0", null },
                    { "db41ae4f-ed07-456d-b7c9-1e36ebcbc0f9", "1c01b40f-9d33-458f-af62-6df4403aebc0", null },
                    { "6167f48d-4b49-47d3-a820-00326998e584", "1c01b40f-9d33-458f-af62-6df4403aebc0", null },
                    { "7bcae672-19f2-43b1-bc40-7f4b727e0329", "2942b32d-17a2-45aa-ba81-c67537ddbc63", null },
                    { "2cdd39df-5acd-4071-ac15-b349dfc3bde3", "1c01b40f-9d33-458f-af62-6df4403aebc0", null },
                    { "6dd937d8-526a-4608-8721-f1f952bb0e15", "1c01b40f-9d33-458f-af62-6df4403aebc0", null },
                    { "1efae0cb-898c-4550-b3ae-af178f2716bb", "1c01b40f-9d33-458f-af62-6df4403aebc0", null },
                    { "3574ab93-3c65-4600-944b-26dfbfff4c38", "1c01b40f-9d33-458f-af62-6df4403aebc0", null },
                    { "98243625-ccef-4384-a6c7-630220c6f23e", "1c01b40f-9d33-458f-af62-6df4403aebc0", null },
                    { "b1983ed1-48f5-4d06-91a9-2451daa4d454", "1c01b40f-9d33-458f-af62-6df4403aebc0", null },
                    { "d53c63e3-f060-4559-aada-ab94d9c11ad8", "1c01b40f-9d33-458f-af62-6df4403aebc0", null },
                    { "5a02dfdd-3493-4278-b9f0-8e4083bdaa88", "1c01b40f-9d33-458f-af62-6df4403aebc0", null },
                    { "5259a667-fc82-480d-8f4a-7fbb0fb37580", "1c01b40f-9d33-458f-af62-6df4403aebc0", null },
                    { "e2718569-01a6-41fc-ad97-c3103de8034d", "1c01b40f-9d33-458f-af62-6df4403aebc0", null },
                    { "8597edeb-caa5-49ff-88ab-de2b5a54c656", "1c01b40f-9d33-458f-af62-6df4403aebc0", null },
                    { "52e868d7-2bd2-4ee9-8217-84fc16a2a7e2", "ace12b17-c89a-490d-9f6e-653e37c2b9c6", null },
                    { "39587b99-dbd2-49da-884a-cd7047e02c9b", "1c01b40f-9d33-458f-af62-6df4403aebc0", null },
                    { "873a7bea-8be8-4282-8d92-ee73cd74d3d5", "2942b32d-17a2-45aa-ba81-c67537ddbc63", null }
                });
        }
    }
}

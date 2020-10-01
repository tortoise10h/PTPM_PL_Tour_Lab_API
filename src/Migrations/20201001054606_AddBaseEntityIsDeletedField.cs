using Microsoft.EntityFrameworkCore.Migrations;

namespace src.Migrations
{
    public partial class AddBaseEntityIsDeletedField : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Tours",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "TourPrice",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "TouristAttraction",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "TourDetail",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "TourCategories",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "StaffGroupRole",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "GroupRole",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "GroupDetail",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "GroupCost",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Group",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "CostType",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Tours");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "TourPrice");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "TouristAttraction");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "TourDetail");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "TourCategories");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "StaffGroupRole");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "GroupRole");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "GroupDetail");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "GroupCost");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Group");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "CostType");
        }
    }
}

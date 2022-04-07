using Microsoft.EntityFrameworkCore.Migrations;

namespace Heart_Disease_Prediction.Migrations
{
    public partial class enisial2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Prediction",
                table: "states",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<float>(
                name: "Probability",
                table: "states",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "Score",
                table: "states",
                nullable: false,
                defaultValue: 0f);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Prediction",
                table: "states");

            migrationBuilder.DropColumn(
                name: "Probability",
                table: "states");

            migrationBuilder.DropColumn(
                name: "Score",
                table: "states");
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

namespace Heart_Disease_Prediction.Migrations
{
    public partial class addNAme : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "states",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "states");
        }
    }
}

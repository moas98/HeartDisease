using Microsoft.EntityFrameworkCore.Migrations;

namespace Heart_Disease_Prediction.Migrations
{
    public partial class enisial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "states",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Age = table.Column<float>(nullable: false),
                    Sex = table.Column<float>(nullable: false),
                    Cp = table.Column<float>(nullable: false),
                    TrestBps = table.Column<float>(nullable: false),
                    Chol = table.Column<float>(nullable: false),
                    Fbs = table.Column<float>(nullable: false),
                    RestEcg = table.Column<float>(nullable: false),
                    Thalac = table.Column<float>(nullable: false),
                    Exang = table.Column<float>(nullable: false),
                    OldPeak = table.Column<float>(nullable: false),
                    Slope = table.Column<float>(nullable: false),
                    Ca = table.Column<float>(nullable: false),
                    Thal = table.Column<float>(nullable: false),
                    Label = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_states", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "states");
        }
    }
}

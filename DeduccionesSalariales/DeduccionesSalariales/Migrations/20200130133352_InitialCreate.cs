using Microsoft.EntityFrameworkCore.Migrations;

namespace DeduccionesSalariales.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Deductions",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    RelativeDeduction = table.Column<double>(nullable: false),
                    AbsoluteDeduction = table.Column<decimal>(nullable: false),
                    FromSalary = table.Column<decimal>(nullable: false),
                    UntilSalary = table.Column<decimal>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Deductions", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Deductions");
        }
    }
}

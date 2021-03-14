using Microsoft.EntityFrameworkCore.Migrations;

namespace StockManager.Domain.Migrations
{
    public partial class _20210303 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Unique_No",
                columns: table => new
                {
                    Unique_No = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Unique_No", x => x.Unique_No);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Unique_No");
        }
    }
}

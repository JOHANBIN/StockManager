using Microsoft.EntityFrameworkCore.Migrations;

namespace StockManager.Domain.Migrations
{
    public partial class _202103032 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Prefix",
                table: "Unique_No",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Prefix",
                table: "Unique_No");
        }
    }
}

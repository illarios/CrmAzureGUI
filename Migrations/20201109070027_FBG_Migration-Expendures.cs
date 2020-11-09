using Microsoft.EntityFrameworkCore.Migrations;

namespace CrmAzureGUI.Migrations
{
    public partial class FBG_MigrationExpendures : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "Expendures",
                table: "Customer",
                nullable: false,
                defaultValue: 0m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Expendures",
                table: "Customer");
        }
    }
}

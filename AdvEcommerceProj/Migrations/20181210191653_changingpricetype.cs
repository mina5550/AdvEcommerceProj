using Microsoft.EntityFrameworkCore.Migrations;

namespace AdvEcommerceProj.Migrations
{
    public partial class changingpricetype : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "Price",
                table: "products",
                nullable: false,
                oldClrType: typeof(int));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Price",
                table: "products",
                nullable: false,
                oldClrType: typeof(decimal));
        }
    }
}

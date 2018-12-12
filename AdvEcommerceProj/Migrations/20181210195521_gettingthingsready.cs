using Microsoft.EntityFrameworkCore.Migrations;

namespace AdvEcommerceProj.Migrations
{
    public partial class gettingthingsready : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_products_supplier_Supplierid",
                table: "products");

            migrationBuilder.RenameColumn(
                name: "Supplierid",
                table: "products",
                newName: "supplierid");

            migrationBuilder.RenameIndex(
                name: "IX_products_Supplierid",
                table: "products",
                newName: "IX_products_supplierid");

            migrationBuilder.AddForeignKey(
                name: "FK_products_supplier_supplierid",
                table: "products",
                column: "supplierid",
                principalTable: "supplier",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_products_supplier_supplierid",
                table: "products");

            migrationBuilder.RenameColumn(
                name: "supplierid",
                table: "products",
                newName: "Supplierid");

            migrationBuilder.RenameIndex(
                name: "IX_products_supplierid",
                table: "products",
                newName: "IX_products_Supplierid");

            migrationBuilder.AddForeignKey(
                name: "FK_products_supplier_Supplierid",
                table: "products",
                column: "Supplierid",
                principalTable: "supplier",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}

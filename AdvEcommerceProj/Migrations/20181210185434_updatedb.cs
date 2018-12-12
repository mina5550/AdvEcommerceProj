using Microsoft.EntityFrameworkCore.Migrations;

namespace AdvEcommerceProj.Migrations
{
    public partial class updatedb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_products_psupplier_Supplierid",
                table: "products");

            migrationBuilder.DropPrimaryKey(
                name: "PK_psupplier",
                table: "psupplier");

            migrationBuilder.RenameTable(
                name: "psupplier",
                newName: "supplier");

            migrationBuilder.AddPrimaryKey(
                name: "PK_supplier",
                table: "supplier",
                column: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_products_supplier_Supplierid",
                table: "products",
                column: "Supplierid",
                principalTable: "supplier",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_products_supplier_Supplierid",
                table: "products");

            migrationBuilder.DropPrimaryKey(
                name: "PK_supplier",
                table: "supplier");

            migrationBuilder.RenameTable(
                name: "supplier",
                newName: "psupplier");

            migrationBuilder.AddPrimaryKey(
                name: "PK_psupplier",
                table: "psupplier",
                column: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_products_psupplier_Supplierid",
                table: "products",
                column: "Supplierid",
                principalTable: "psupplier",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

namespace AdvEcommerceProj.Migrations
{
    public partial class makingsureofeverything : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "phone",
                table: "psupplier",
                newName: "Phone");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "psupplier",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "address",
                table: "psupplier",
                newName: "Address");

            migrationBuilder.RenameColumn(
                name: "stock",
                table: "products",
                newName: "Stock");

            migrationBuilder.RenameColumn(
                name: "price",
                table: "products",
                newName: "Price");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "products",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "quantity",
                table: "order",
                newName: "Quantity");

            migrationBuilder.RenameColumn(
                name: "phone",
                table: "customers",
                newName: "Phone");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "customers",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "age",
                table: "customers",
                newName: "Age");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Phone",
                table: "psupplier",
                newName: "phone");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "psupplier",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "Address",
                table: "psupplier",
                newName: "address");

            migrationBuilder.RenameColumn(
                name: "Stock",
                table: "products",
                newName: "stock");

            migrationBuilder.RenameColumn(
                name: "Price",
                table: "products",
                newName: "price");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "products",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "Quantity",
                table: "order",
                newName: "quantity");

            migrationBuilder.RenameColumn(
                name: "Phone",
                table: "customers",
                newName: "phone");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "customers",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "Age",
                table: "customers",
                newName: "age");
        }
    }
}

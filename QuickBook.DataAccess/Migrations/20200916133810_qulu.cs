using Microsoft.EntityFrameworkCore.Migrations;

namespace QuickBook.DataAccess.Migrations
{
    public partial class qulu : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "InvoiceNr",
                table: "Invoices",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "InvoiceNr",
                table: "Invoices",
                type: "int",
                nullable: false,
                oldClrType: typeof(string));
        }
    }
}

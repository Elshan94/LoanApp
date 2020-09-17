using Microsoft.EntityFrameworkCore.Migrations;

namespace QuickBook.DataAccess.Migrations
{
    public partial class @new : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Invoices_LoanId",
                table: "Invoices");

            migrationBuilder.CreateIndex(
                name: "IX_Invoices_LoanId",
                table: "Invoices",
                column: "LoanId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Invoices_LoanId",
                table: "Invoices");

            migrationBuilder.CreateIndex(
                name: "IX_Invoices_LoanId",
                table: "Invoices",
                column: "LoanId",
                unique: true);
        }
    }
}

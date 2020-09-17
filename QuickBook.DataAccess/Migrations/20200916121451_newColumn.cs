using Microsoft.EntityFrameworkCore.Migrations;

namespace QuickBook.DataAccess.Migrations
{
    public partial class newColumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "MonthlyInterestRate",
                table: "Loans",
                nullable: false,
                defaultValue: 0m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MonthlyInterestRate",
                table: "Loans");
        }
    }
}

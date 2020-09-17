using Microsoft.EntityFrameworkCore.Migrations;

namespace QuickBook.DataAccess.Migrations
{
    public partial class SeedingCustomerData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Clients",
                columns: new[] { "Id", "FirstName", "LastName", "TelephoneNumber" },
                values: new object[] { 1L, "Corrado", "Soprano", "1241" });

            migrationBuilder.InsertData(
                table: "Clients",
                columns: new[] { "Id", "FirstName", "LastName", "TelephoneNumber" },
                values: new object[] { 2L, "Johhny", "Sack", "666" });

            migrationBuilder.InsertData(
                table: "Clients",
                columns: new[] { "Id", "FirstName", "LastName", "TelephoneNumber" },
                values: new object[] { 3L, "Chris", "Moltisanti", "111" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 3L);
        }
    }
}

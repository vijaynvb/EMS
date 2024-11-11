using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EMSApi.Migrations
{
    public partial class inseremploeedata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "Age", "DepartmentId", "Name" },
                values: new object[] { 1, 12, 1, "vijay" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}

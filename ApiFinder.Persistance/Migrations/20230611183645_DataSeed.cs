using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApiFinder.Persistance.Migrations
{
    public partial class DataSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "ApiInformations",
                columns: new[] { "Id", "Name", "ServerType", "Status", "Url" },
                values: new object[,]
                {
                    { 1, "Address", 1, 3, "test" },
                    { 2, "Address", 2, 3, "prod" }
                });

            migrationBuilder.InsertData(
                table: "ServerType",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Test" },
                    { 2, "Production" }
                });

            migrationBuilder.InsertData(
                table: "Status",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Online" },
                    { 2, "Offline" },
                    { 3, "Not defined" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ApiInformations",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ApiInformations",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ServerType",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ServerType",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Status",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Status",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Status",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}

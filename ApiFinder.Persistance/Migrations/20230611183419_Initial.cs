using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApiFinder.Persistance.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ApiInformations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    ServerType = table.Column<int>(type: "int", nullable: false),
                    Url = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApiInformations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ServerType",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ServerType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Status",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Status", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ApiInformationHistoryList",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ApiInformationId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    ServerTypeId = table.Column<int>(type: "int", nullable: false),
                    Url = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    StatusId = table.Column<int>(type: "int", nullable: false),
                    CheckingTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ErrorDescription = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApiInformationHistoryList", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ApiInformationHistoryList_ApiInformations_ApiInformationId",
                        column: x => x.ApiInformationId,
                        principalTable: "ApiInformations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ApiInformationHistoryList_ApiInformationId",
                table: "ApiInformationHistoryList",
                column: "ApiInformationId");

            migrationBuilder.CreateIndex(
                name: "IX_ApiInformationHistoryList_Id",
                table: "ApiInformationHistoryList",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_ApiInformationHistoryList_ServerTypeId",
                table: "ApiInformationHistoryList",
                column: "ServerTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_ApiInformations_Id",
                table: "ApiInformations",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_ServerType_Id",
                table: "ServerType",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Status_Id",
                table: "Status",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ApiInformationHistoryList");

            migrationBuilder.DropTable(
                name: "ServerType");

            migrationBuilder.DropTable(
                name: "Status");

            migrationBuilder.DropTable(
                name: "ApiInformations");
        }
    }
}

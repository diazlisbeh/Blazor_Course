using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Blazor_Course.Migrations
{
    public partial class AddData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategotyId", "CategoryName" },
                values: new object[,]
                {
                    { "ASH", "Aseo Hogar" },
                    { "SCH", "Escolares" },
                    { "TEC", "Tecnologies" },
                    { "VDI", "Video Juegos" }
                });

            migrationBuilder.InsertData(
                table: "Wherehouses",
                columns: new[] { "WherehoueseId", "WherehoueseName" },
                values: new object[,]
                {
                    { "3f8b179d-9317-4984-b956-2b3b294287d9", "Oeste" },
                    { "ae089ea0-7b6d-4f29-9ac6-195f51b0d4e1", "Este" },
                    { "bf7e3026-c51f-4617-b7b1-3fc54f5d4392", "Principal" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategotyId",
                keyValue: "ASH");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategotyId",
                keyValue: "SCH");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategotyId",
                keyValue: "TEC");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategotyId",
                keyValue: "VDI");

            migrationBuilder.DeleteData(
                table: "Wherehouses",
                keyColumn: "WherehoueseId",
                keyValue: "3f8b179d-9317-4984-b956-2b3b294287d9");

            migrationBuilder.DeleteData(
                table: "Wherehouses",
                keyColumn: "WherehoueseId",
                keyValue: "ae089ea0-7b6d-4f29-9ac6-195f51b0d4e1");

            migrationBuilder.DeleteData(
                table: "Wherehouses",
                keyColumn: "WherehoueseId",
                keyValue: "bf7e3026-c51f-4617-b7b1-3fc54f5d4392");
        }
    }
}

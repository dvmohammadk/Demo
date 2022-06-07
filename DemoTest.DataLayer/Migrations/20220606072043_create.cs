using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DemoTest.DataLayer.Migrations
{
    public partial class create : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Tilte = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Type = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    Color = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Color", "Price", "Tilte", "Type" },
                values: new object[,]
                {
                    { new Guid("e6fdc218-40f0-442e-a484-4849ee41eabe"), 0, 0.0, null, 2 },
                    { new Guid("4dddcff6-6b63-4b49-abdf-bc4b67828689"), 1, 0.0, null, 0 },
                    { new Guid("94477d1a-7d4b-41b3-9d98-b6886b2bf453"), 3, 0.0, null, 2 },
                    { new Guid("f5d5bb09-4040-4d07-8db6-e51cb6fcba48"), 0, 0.0, null, 1 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}

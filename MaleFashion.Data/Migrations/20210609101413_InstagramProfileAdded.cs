using Microsoft.EntityFrameworkCore.Migrations;

namespace MaleFashion.Data.Migrations
{
    public partial class InstagramProfileAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Discount_ProductId",
                table: "Discount");

            migrationBuilder.CreateTable(
                name: "InstagramProfile",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InstagramUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Hastag = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhotoUrl1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhotoUrl2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhotoUrl3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhotoUrl4 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhotoUrl5 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhotoUrl6 = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InstagramProfile", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Discount_ProductId",
                table: "Discount",
                column: "ProductId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "InstagramProfile");

            migrationBuilder.DropIndex(
                name: "IX_Discount_ProductId",
                table: "Discount");

            migrationBuilder.CreateIndex(
                name: "IX_Discount_ProductId",
                table: "Discount",
                column: "ProductId");
        }
    }
}

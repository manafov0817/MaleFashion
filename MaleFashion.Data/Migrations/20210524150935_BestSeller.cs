using Microsoft.EntityFrameworkCore.Migrations;

namespace MaleFashion.Data.Migrations
{
    public partial class BestSeller : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "BestSeller");

            migrationBuilder.CreateTable(
                name: "HotSales",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    BestSellerId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HotSales", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HotSales_BestSeller_BestSellerId",
                        column: x => x.BestSellerId,
                        principalTable: "BestSeller",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HotSales_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "NewArrivals",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    BestSellerId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NewArrivals", x => x.Id);
                    table.ForeignKey(
                        name: "FK_NewArrivals_BestSeller_BestSellerId",
                        column: x => x.BestSellerId,
                        principalTable: "BestSeller",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_NewArrivals_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_HotSales_BestSellerId",
                table: "HotSales",
                column: "BestSellerId");

            migrationBuilder.CreateIndex(
                name: "IX_HotSales_ProductId",
                table: "HotSales",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_NewArrivals_BestSellerId",
                table: "NewArrivals",
                column: "BestSellerId");

            migrationBuilder.CreateIndex(
                name: "IX_NewArrivals_ProductId",
                table: "NewArrivals",
                column: "ProductId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HotSales");

            migrationBuilder.DropTable(
                name: "NewArrivals");

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "BestSeller",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}

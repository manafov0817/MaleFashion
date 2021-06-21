using Microsoft.EntityFrameworkCore.Migrations;

namespace MaleFashion.Data.Migrations
{
    public partial class DealOfTheWeekAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_BrandsModels_BrandsModelId",
                table: "Products");

            migrationBuilder.AlterColumn<int>(
                name: "BrandsModelId",
                table: "Products",
                type: "int",
                nullable: true,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "DealOfTheWeeks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DealOfTheWeeks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DealOfTheWeeks_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DealOfTheWeeks_ProductId",
                table: "DealOfTheWeeks",
                column: "ProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_BrandsModels_BrandsModelId",
                table: "Products",
                column: "BrandsModelId",
                principalTable: "BrandsModels",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_BrandsModels_BrandsModelId",
                table: "Products");

            migrationBuilder.DropTable(
                name: "DealOfTheWeeks");

            migrationBuilder.AlterColumn<int>(
                name: "BrandsModelId",
                table: "Products",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_BrandsModels_BrandsModelId",
                table: "Products",
                column: "BrandsModelId",
                principalTable: "BrandsModels",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}

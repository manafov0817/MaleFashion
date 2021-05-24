using Microsoft.EntityFrameworkCore.Migrations;

namespace MaleFashion.Data.Migrations
{
    public partial class HeroAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductMainCategories_ProductMainCategories_ProductMainCategoryProductId_ProductMainCategoryMainCategoryId",
                table: "ProductMainCategories");

            migrationBuilder.DropIndex(
                name: "IX_ProductMainCategories_ProductMainCategoryProductId_ProductMainCategoryMainCategoryId",
                table: "ProductMainCategories");

            migrationBuilder.DropColumn(
                name: "ProductMainCategoryMainCategoryId",
                table: "ProductMainCategories");

            migrationBuilder.DropColumn(
                name: "ProductMainCategoryProductId",
                table: "ProductMainCategories");

            migrationBuilder.AddColumn<int>(
                name: "BrandsModelId",
                table: "Products",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Heros",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Header = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Heros", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_BrandsModelId",
                table: "Products",
                column: "BrandsModelId");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_BrandsModels_BrandsModelId",
                table: "Products",
                column: "BrandsModelId",
                principalTable: "BrandsModels",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_BrandsModels_BrandsModelId",
                table: "Products");

            migrationBuilder.DropTable(
                name: "Heros");

            migrationBuilder.DropIndex(
                name: "IX_Products_BrandsModelId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "BrandsModelId",
                table: "Products");

            migrationBuilder.AddColumn<int>(
                name: "ProductMainCategoryMainCategoryId",
                table: "ProductMainCategories",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ProductMainCategoryProductId",
                table: "ProductMainCategories",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ProductMainCategories_ProductMainCategoryProductId_ProductMainCategoryMainCategoryId",
                table: "ProductMainCategories",
                columns: new[] { "ProductMainCategoryProductId", "ProductMainCategoryMainCategoryId" });

            migrationBuilder.AddForeignKey(
                name: "FK_ProductMainCategories_ProductMainCategories_ProductMainCategoryProductId_ProductMainCategoryMainCategoryId",
                table: "ProductMainCategories",
                columns: new[] { "ProductMainCategoryProductId", "ProductMainCategoryMainCategoryId" },
                principalTable: "ProductMainCategories",
                principalColumns: new[] { "ProductId", "MainCategoryId" },
                onDelete: ReferentialAction.Restrict);
        }
    }
}

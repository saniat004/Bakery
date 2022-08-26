using Microsoft.EntityFrameworkCore.Migrations;

namespace SaniatsCakeShop.Migrations
{
    public partial class _1827891 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Cakes",
                keyColumn: "CakeId",
                keyValue: 1);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Cakes",
                columns: new[] { "CakeId", "AllergyInformation", "Calorie", "CategoryId", "ImageThumbnailUrl", "ImageUrl", "InStock", "IsCakeOfTheWeek", "LongDescription", "Name", "NutritionName", "Price", "Protein", "ShortDescription", "fiber", "magnesium", "niacin" },
                values: new object[] { 1, "", "352 calories", 1, "https://i.imgur.com/lbEcaUo.jpeg", "https://i.ytimg.com/vi/dh6GgbgQ5j0/maxresdefault.jpg", true, true, "A delicious soft and light vanilla sponge cake filled with homemade fruit filling and topped with delicious fresh fruits and freshly whipped cream.", "FRESH FRUIT CAKE", "Nutrition Info : Per 100 grams", 8.95m, "0.72 grams", " ", " 0.24 grams", "0.34 grams ", " 0.14 grams" });
        }
    }
}

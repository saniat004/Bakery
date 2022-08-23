using Microsoft.EntityFrameworkCore.Migrations;

namespace SaniatsCakeShop.Migrations
{
    public partial class migration10087238 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Cakes",
                keyColumn: "CakeId",
                keyValue: 2,
                column: "LongDescription",
                value: "String1\r\nString2\r\nString3");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Cakes",
                keyColumn: "CakeId",
                keyValue: 2,
                column: "LongDescription",
                value: "Baking a delicious (and pretty!) cake from scratch doesn't need to be complicated. With a few staple pantry ingredients, some whipped cream and your favorite fresh fruits, you can make a delicious cake that the entire family will enjoy. \n <br> Nutrition Information : \n  35 calories \n  7.3 grams carbohydrates \n 7.3 grams carbohydrates \n 0.7 grams protein \n  0.4 grams fiber \n 0.7 milligrams niacin \n 11.8 milligrams magnesium ");
        }
    }
}

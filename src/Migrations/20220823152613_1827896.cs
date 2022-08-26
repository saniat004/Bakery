using Microsoft.EntityFrameworkCore.Migrations;

namespace SaniatsCakeShop.Migrations
{
    public partial class _1827896 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Cakes",
                keyColumn: "CakeId",
                keyValue: 1,
                column: "LongDescription",
                value: "A delicious soft and light vanilla sponge cake filled with homemade fruit filling and topped with delicious fresh fruits and freshly whipped cream.");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Cakes",
                keyColumn: "CakeId",
                keyValue: 1,
                column: "LongDescription",
                value: "A delicious soft and light vanilla sponge cake filled with homemade fruit filling and topped with delicious fresh fruits and freshly whipped cream. \n Nutrition Information : \n  35 calories \n  7.3 grams carbohydrates \n 7.3 grams carbohydrates \n 0.7 grams protein \n  0.4 grams fiber \n 0.7 milligrams niacin \n 11.8 milligrams magnesium");
        }
    }
}

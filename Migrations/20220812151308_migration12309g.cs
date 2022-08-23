using Microsoft.EntityFrameworkCore.Migrations;

namespace SaniatsCakeShop.Migrations
{
    public partial class migration12309g : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cakes_NutritionInfos_NutritionInfoId",
                table: "Cakes");

            migrationBuilder.DropTable(
                name: "NutritionInfos");

            migrationBuilder.DropIndex(
                name: "IX_Cakes_NutritionInfoId",
                table: "Cakes");

            migrationBuilder.DropColumn(
                name: "NutritionInfoId",
                table: "Cakes");

            migrationBuilder.AddColumn<string>(
                name: "Calorie",
                table: "Cakes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NutritionName",
                table: "Cakes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Protein",
                table: "Cakes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "fiber",
                table: "Cakes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "magnesium",
                table: "Cakes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "niacin",
                table: "Cakes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Cakes",
                keyColumn: "CakeId",
                keyValue: 1,
                columns: new[] { "Calorie", "NutritionName", "Protein", "fiber", "magnesium", "niacin" },
                values: new object[] { "352 calories", "Nutrition Info : Per 100 grams", "0.72 grams", " 0.24 grams", "0.34 grams ", " 0.14 grams" });

            migrationBuilder.UpdateData(
                table: "Cakes",
                keyColumn: "CakeId",
                keyValue: 2,
                columns: new[] { "Calorie", "LongDescription", "NutritionName", "Protein", "fiber", "magnesium", "niacin" },
                values: new object[] { "97 calories", "Baking a delicious (and pretty!) cake from scratch doesn't need to be complicated. With a few staple pantry ingredients, some whipped cream and your favorite fresh fruits, you can make a delicious cake that the entire family will enjoy.", "Nutrition Info : Per 100 grams", "0.72 grams", " 0.24 grams", "30.4 grams ", " 0.24 grams" });

            migrationBuilder.UpdateData(
                table: "Cakes",
                keyColumn: "CakeId",
                keyValue: 3,
                columns: new[] { "Calorie", "LongDescription", "NutritionName", "Protein", "fiber", "magnesium", "niacin" },
                values: new object[] { "3513 calories", "This type of sponge cake is made with whole eggs(no separation); this technique is a bit more involved as opposed to the Biscuit.Eggs are mixed with sugar and heated over simmering water then whipped. You must ensure that you constantly whip the egg mixture so the eggs don’t cook and become scrambled eggs. Make sure the bowl you’re mixing in doesn’t come into contact with the water in the pot below.The pot of water should not come to a boil; it should simmer.Whisk the egg mixture on top of the water about 3 to 5 minutes; until the bowl is warm to the touch or until it gets to about 110°-120°F / 43°-49°C.Whipping the eggs over heat allows them to whip to a greater volume.After the eggs and sugar have doubled or almost tripled in volume; add some melted butter and fold gently – then add the flour and fold. The eggs are used as the raising agents; this is why you need them to double or triple in volume.", "Nutrition Info : Per 100 grams", "0.97 grams", " 0.42 grams", "0.234 grams ", " 0.44 grams" });

            migrationBuilder.UpdateData(
                table: "Cakes",
                keyColumn: "CakeId",
                keyValue: 4,
                columns: new[] { "Calorie", "NutritionName", "Protein", "fiber", "magnesium", "niacin" },
                values: new object[] { "523 calories", "Nutrition Info : Per 100 grams", "0.72 grams", " 0.44 grams", "0.64 grams ", " 0.14 grams" });

            migrationBuilder.UpdateData(
                table: "Cakes",
                keyColumn: "CakeId",
                keyValue: 5,
                columns: new[] { "Calorie", "NutritionName", "Protein", "fiber", "magnesium", "niacin" },
                values: new object[] { "352 calories", "Nutrition Info : Per 100 grams", "0.17 grams", " 0.24 grams", "0.24 grams ", " 0.14 grams" });

            migrationBuilder.UpdateData(
                table: "Cakes",
                keyColumn: "CakeId",
                keyValue: 6,
                columns: new[] { "Calorie", "NutritionName", "Protein", "fiber", "magnesium", "niacin" },
                values: new object[] { "351 calories", "Nutrition Info : Per 100 grams", "0.72 grams", " 0.42 grams", "0.24 grams ", " 0.41 grams" });

            migrationBuilder.UpdateData(
                table: "Cakes",
                keyColumn: "CakeId",
                keyValue: 7,
                columns: new[] { "Calorie", "NutritionName", "Protein", "fiber", "magnesium", "niacin" },
                values: new object[] { "352 calories", "Nutrition Info : Per 100 grams", "0.72 grams", " 0.34 grams", "0.4 grams ", " 0.14 grams" });

            migrationBuilder.UpdateData(
                table: "Cakes",
                keyColumn: "CakeId",
                keyValue: 8,
                columns: new[] { "Calorie", "NutritionName", "Protein", "fiber", "magnesium", "niacin" },
                values: new object[] { "3225 calories", "Nutrition Info : Per 100 grams", "0.71 grams", " 0.42 grams", "0.41 grams ", " 0.42 grams" });

            migrationBuilder.UpdateData(
                table: "Cakes",
                keyColumn: "CakeId",
                keyValue: 9,
                columns: new[] { "Calorie", "NutritionName", "Protein", "fiber", "magnesium", "niacin" },
                values: new object[] { "3521 calories", "Nutrition Info : Per 100 grams", "0.72 grams", " 0.42 grams", "0.41 grams ", " 0.43 grams" });

            migrationBuilder.UpdateData(
                table: "Cakes",
                keyColumn: "CakeId",
                keyValue: 10,
                columns: new[] { "Calorie", "NutritionName", "Protein", "fiber", "magnesium", "niacin" },
                values: new object[] { "351 calories", "Nutrition Info : Per 100 grams", "0.73 grams", " 0.45 grams", "0.44 grams ", " 0.42 grams" });

            migrationBuilder.UpdateData(
                table: "Cakes",
                keyColumn: "CakeId",
                keyValue: 11,
                columns: new[] { "Calorie", "NutritionName", "Protein", "fiber", "magnesium", "niacin" },
                values: new object[] { "3524 calories", "Nutrition Info : Per 100 grams", "0.237 grams", " 0.344 grams", "0.24 grams ", " 0.444 grams" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Calorie",
                table: "Cakes");

            migrationBuilder.DropColumn(
                name: "NutritionName",
                table: "Cakes");

            migrationBuilder.DropColumn(
                name: "Protein",
                table: "Cakes");

            migrationBuilder.DropColumn(
                name: "fiber",
                table: "Cakes");

            migrationBuilder.DropColumn(
                name: "magnesium",
                table: "Cakes");

            migrationBuilder.DropColumn(
                name: "niacin",
                table: "Cakes");

            migrationBuilder.AddColumn<int>(
                name: "NutritionInfoId",
                table: "Cakes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "NutritionInfos",
                columns: table => new
                {
                    NutritionInfoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Calorie = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Protein = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    fiber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    magnesium = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    niacin = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NutritionInfos", x => x.NutritionInfoId);
                });

            migrationBuilder.InsertData(
                table: "NutritionInfos",
                columns: new[] { "NutritionInfoId", "Calorie", "Name", "Protein", "fiber", "magnesium", "niacin" },
                values: new object[] { 1, "35 calories", "Nutrition Info : Per 100 grams", "0.7 grams", " 0.4 grams", "0.4 grams ", " 0.4 grams" });

            migrationBuilder.UpdateData(
                table: "Cakes",
                keyColumn: "CakeId",
                keyValue: 1,
                column: "NutritionInfoId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Cakes",
                keyColumn: "CakeId",
                keyValue: 2,
                columns: new[] { "LongDescription", "NutritionInfoId" },
                values: new object[] { "String1\r\nString2\r\nString3", 1 });

            migrationBuilder.UpdateData(
                table: "Cakes",
                keyColumn: "CakeId",
                keyValue: 3,
                columns: new[] { "LongDescription", "NutritionInfoId" },
                values: new object[] { "This type of sponge cake is made with whole eggs(no separation); this technique is a bit more involved as opposed to the Biscuit.Eggs are mixed with sugar and heated over simmering water then whipped. You must ensure that you constantly whip the egg mixture so the eggs don’t cook and become scrambled eggs. Make sure the bowl you’re mixing in doesn’t come into contact with the water in the pot below.The pot of water should not come to a boil; it should simmer.Whisk the egg mixture on top of the water about 3 to 5 minutes; until the bowl is warm to the touch or until it gets to about 110°-120°F / 43°-49°C.Whipping the eggs over heat allows them to whip to a greater volume.After the eggs and sugar have doubled or almost tripled in volume; add some melted butter and fold gently – then add the flour and fold. The eggs are used as the raising agents; this is why you need them to double or triple in volume.\r\nNutrition Information :\r\n35 calories", 1 });

            migrationBuilder.UpdateData(
                table: "Cakes",
                keyColumn: "CakeId",
                keyValue: 4,
                column: "NutritionInfoId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Cakes",
                keyColumn: "CakeId",
                keyValue: 5,
                column: "NutritionInfoId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Cakes",
                keyColumn: "CakeId",
                keyValue: 6,
                column: "NutritionInfoId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Cakes",
                keyColumn: "CakeId",
                keyValue: 7,
                column: "NutritionInfoId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Cakes",
                keyColumn: "CakeId",
                keyValue: 8,
                column: "NutritionInfoId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Cakes",
                keyColumn: "CakeId",
                keyValue: 9,
                column: "NutritionInfoId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Cakes",
                keyColumn: "CakeId",
                keyValue: 10,
                column: "NutritionInfoId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Cakes",
                keyColumn: "CakeId",
                keyValue: 11,
                column: "NutritionInfoId",
                value: 1);

            migrationBuilder.CreateIndex(
                name: "IX_Cakes_NutritionInfoId",
                table: "Cakes",
                column: "NutritionInfoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Cakes_NutritionInfos_NutritionInfoId",
                table: "Cakes",
                column: "NutritionInfoId",
                principalTable: "NutritionInfos",
                principalColumn: "NutritionInfoId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

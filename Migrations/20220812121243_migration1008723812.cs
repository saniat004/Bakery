using Microsoft.EntityFrameworkCore.Migrations;

namespace SaniatsCakeShop.Migrations
{
    public partial class migration1008723812 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Calorie = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Protein = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    niacin = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    fiber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    magnesium = table.Column<string>(type: "nvarchar(max)", nullable: true)
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
                column: "NutritionInfoId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Cakes",
                keyColumn: "CakeId",
                keyValue: 3,
                column: "NutritionInfoId",
                value: 1);

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

        protected override void Down(MigrationBuilder migrationBuilder)
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
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

namespace SaniatsCakeShop.Migrations
{
    public partial class migration1008 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderDetails_Cakes_PieId",
                table: "OrderDetails");

            migrationBuilder.RenameColumn(
                name: "PieId",
                table: "OrderDetails",
                newName: "CakeId");

            migrationBuilder.RenameIndex(
                name: "IX_OrderDetails_PieId",
                table: "OrderDetails",
                newName: "IX_OrderDetails_CakeId");

            migrationBuilder.UpdateData(
                table: "Cakes",
                keyColumn: "CakeId",
                keyValue: 1,
                column: "LongDescription",
                value: "System.String[]");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderDetails_Cakes_CakeId",
                table: "OrderDetails",
                column: "CakeId",
                principalTable: "Cakes",
                principalColumn: "CakeId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderDetails_Cakes_CakeId",
                table: "OrderDetails");

            migrationBuilder.RenameColumn(
                name: "CakeId",
                table: "OrderDetails",
                newName: "PieId");

            migrationBuilder.RenameIndex(
                name: "IX_OrderDetails_CakeId",
                table: "OrderDetails",
                newName: "IX_OrderDetails_PieId");

            migrationBuilder.UpdateData(
                table: "Cakes",
                keyColumn: "CakeId",
                keyValue: 1,
                column: "LongDescription",
                value: "A delicious soft and light vanilla sponge cake filled with homemade fruit filling and topped with delicious fresh fruits and freshly whipped cream. \n Nutrition Information : \n  35 calories \n  7.3 grams carbohydrates \n 7.3 grams carbohydrates \n 0.7 grams protein \n  0.4 grams fiber \n 0.7 milligrams niacin \n 11.8 milligrams magnesium");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderDetails_Cakes_PieId",
                table: "OrderDetails",
                column: "PieId",
                principalTable: "Cakes",
                principalColumn: "CakeId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SaniatsCakeShop.Migrations
{
    public partial class migration0223 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    OrderId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    AddressLine1 = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    AddressLine2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ZipCode = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    City = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    State = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    Country = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    OrderTotal = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    OrderPlaced = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.OrderId);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Cakes",
                columns: table => new
                {
                    CakeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ShortDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LongDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AllergyInformation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageThumbnailUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsCakeOfTheWeek = table.Column<bool>(type: "bit", nullable: false),
                    InStock = table.Column<bool>(type: "bit", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cakes", x => x.CakeId);
                    table.ForeignKey(
                        name: "FK_Cakes_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrderDetails",
                columns: table => new
                {
                    OrderDetailId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderId = table.Column<int>(type: "int", nullable: false),
                    PieId = table.Column<int>(type: "int", nullable: false),
                    Amount = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderDetails", x => x.OrderDetailId);
                    table.ForeignKey(
                        name: "FK_OrderDetails_Cakes_PieId",
                        column: x => x.PieId,
                        principalTable: "Cakes",
                        principalColumn: "CakeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderDetails_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "OrderId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ShoppingCartItems",
                columns: table => new
                {
                    ShoppingCartItemId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CakeId = table.Column<int>(type: "int", nullable: true),
                    Amount = table.Column<int>(type: "int", nullable: false),
                    ShoppingCartId = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShoppingCartItems", x => x.ShoppingCartItemId);
                    table.ForeignKey(
                        name: "FK_ShoppingCartItems_Cakes_CakeId",
                        column: x => x.CakeId,
                        principalTable: "Cakes",
                        principalColumn: "CakeId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName", "Description" },
                values: new object[,]
                {
                    { 1, "Fruit cakes", null },
                    { 3, "Pound cakes", null },
                    { 4, "Sponge cakes", null },
                    { 5, "Genoise cakes", null },
                    { 7, "Baked Flourless cakes", null },
                    { 8, "Chiffon  cakes", null }
                });

            migrationBuilder.InsertData(
                table: "Cakes",
                columns: new[] { "CakeId", "AllergyInformation", "CategoryId", "ImageThumbnailUrl", "ImageUrl", "InStock", "IsCakeOfTheWeek", "LongDescription", "Name", "Price", "ShortDescription" },
                values: new object[,]
                {
                    { 1, "", 1, "https://i.imgur.com/lbEcaUo.jpeg", "https://i.ytimg.com/vi/dh6GgbgQ5j0/maxresdefault.jpg", true, true, "A delicious soft and light vanilla sponge cake filled with homemade fruit filling and topped with delicious fresh fruits and freshly whipped cream. \n Nutrition Information : \n  35 calories \n  7.3 grams carbohydrates \n 7.3 grams carbohydrates \n 0.7 grams protein \n  0.4 grams fiber \n 0.7 milligrams niacin \n 11.8 milligrams magnesium", "FRESH FRUIT CAKE", 8.95m, " " },
                    { 2, "", 1, "https://i.imgur.com/pSpITQh.jpeg", "https://jennakateathome.com/wp-content/uploads/2022/02/fresh-fruit-cake-27-1.jpg", true, false, "Baking a delicious (and pretty!) cake from scratch doesn't need to be complicated. With a few staple pantry ingredients, some whipped cream and your favorite fresh fruits, you can make a delicious cake that the entire family will enjoy. \n Nutrition Information : \n  35 calories \n  7.3 grams carbohydrates \n 7.3 grams carbohydrates \n 0.7 grams protein \n  0.4 grams fiber \n 0.7 milligrams niacin \n 11.8 milligrams magnesium ", "Fresh Berry Cream Cake", 18.95m, " " },
                    { 9, "", 3, "https://i.imgur.com/bRx0mVn.jpg", "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fstatic.onecms.io%2Fwp-content%2Fuploads%2Fsites%2F24%2F1970%2F01%2F2341302_butte_054_2_0_1.jpg", true, true, "We took the traditional pound cake recipe and gave it a stunning, triple-chocolate twist. This cake means business. A duo of glazes—one creamy chocolate, the other subtle buttermilk—comes together atop this dreamy confection. It's indulgent and, we admit, so much fun to eat and serve. Chocolate enthusiasts will be over the moon for this recipe, but it has enough unexpected flavor—thanks to the addition of the buttermilk glaze—that you'll also win over the harder-to-please dessert eaters at the table. Warning: You—and they—won't be able to resist a second slice.", "Triple-Chocolate Buttermilk Pound Cake", 15.95m, "" },
                    { 10, "", 3, "https://i.imgur.com/dWW8B1n.jpeg", "https://www.pauladeenmagazine.com/wp-content/uploads/2019/04/p2.jpg", true, false, "Cream cheese, buttermilk, and strawberry glaze team up to create a delicious pound cake", "Strawberry Swirl Pound Cake", 15.95m, "" },
                    { 4, "", 4, "https://i.imgur.com/Hq2Wkjw.jpeg", "https://www.breadtalk.com.sg/wp-content/uploads/2020/07/Hersheys-Love-scaled.jpg", true, false, "This type of sponge cake contains both the egg white and yolks in the recipe. They are however first separated; whipped separately (egg whites and sugar to make a meringue) then mixed back together. In this type of Sponge cake; the eggs are the raising agent in the recipe. Chemical raising agents are not used in this recipe traditionally", "Biscuit", 11.95m, "" },
                    { 11, "", 4, "https://i.imgur.com/cNEGnwd.jpeg", "https://projectveganbaking.com/wp-content/uploads/2020/06/IMG_6434_Fotor-copy.jpg", false, false, "Joconde is a light and airy sponge cake that you can use to make many types of desserts. Joconde does not have a lot of fat in it and is considered to be a healthy version of a traditional cake. ", "Joconde cake", 1.95m, "" },
                    { 3, "", 5, "https://i.imgur.com/cHoyUc4.jpeg", "https://amaribakery.files.wordpress.com/2018/06/fraisier-cake.jpg", true, false, "This type of sponge cake is made with whole eggs(no separation); this technique is a bit more involved as opposed to the Biscuit.Eggs are mixed with sugar and heated over simmering water then whipped. You must ensure that you constantly whip the egg mixture so the eggs don’t cook and become scrambled eggs. Make sure the bowl you’re mixing in doesn’t come into contact with the water in the pot below.The pot of water should not come to a boil; it should simmer.Whisk the egg mixture on top of the water about 3 to 5 minutes; until the bowl is warm to the touch or until it gets to about 110°-120°F / 43°-49°C.Whipping the eggs over heat allows them to whip to a greater volume.After the eggs and sugar have doubled or almost tripled in volume; add some melted butter and fold gently – then add the flour and fold. The eggs are used as the raising agents; this is why you need them to double or triple in volume.\r\nNutrition Information :\r\n35 calories", "Fraisier cake", 11.95m, "" },
                    { 6, "", 7, "https://i.imgur.com/8OCaqUk.jpeg", "https://www.kingarthurbaking.com/sites/default/files/styles/featured_image/public/recipe_legacy/4179-3-large.jpg?itok=dphbBuMQ", true, false, "This flourless cake, featuring both chocolate and cocoa, is rich, rich, RICH! A thick icing of chocolate ganache glaze takes it over the top. Depending on how you observe Passover, this cake can make a great addition to your Seder since it contains neither flour nor leavening; and of course, it's also ideal for those looking to avoid gluten.", "Flourless Chocolate Cake", 17.95m, "" },
                    { 7, "", 7, "https://i.imgur.com/0QocoJX.jpeg", "https://d3lp4xedbqa8a5.cloudfront.net/s3/digital-cougar-assets/Gt/2018/05/23/15958/GT1805_Grains_Fennel_spiced_semolina_cake_with_yoghurtA.jpg?width=922&height=768&mode=crop&anchor=topcenter&quality=75", false, false, "This combination of citrus, sugar and spice makes for an unbeatable afternoon-tea treat.", "Fennel-spiced semolina cake with yoghurt", 11.95m, "" },
                    { 8, "", 7, "https://i.imgur.com/nbXFNdC.jpeg", "https://d3lp4xedbqa8a5.cloudfront.net/s3/digital-cougar-assets/Gt/2018/07/03/15967/chocolate-coconut-date-slab.jpg?width=922&height=768&mode=crop&anchor=topcenter&quality=75", true, true, "A layer of coconut ganache over this fudgy slab keeps it rich and creamy, but dairy-free, while raw cacoa and dates steer it firmly away from corner-store chocolate bar territory.", "Chocolate, coconut and date slab", 12.95m, "" },
                    { 5, "", 8, "https://i.imgur.com/zQWRNN0.jpeg", "https://amaribakery.files.wordpress.com/2018/06/vanilla-slice-plain-of-chiffon-by-amari.png?w=446&h=446", true, false, "This sponge cake contains both a fat and a chemical raising agent; oil and baking powder, in the ingredients list. The eggs are also separated; the whites are beaten until stiff. All the other ingredients are combined in another bowl to make a smooth batter like a pancake batter; the beaten egg whites are then folded into the ‘pancake’ batter.  The result after this mixing process is of a lighter sponge cake texture, but with a rich flavor like butter/oil cakes. These cakes are generally layered and filled with fillings and frostings. They don’t always require decoration especially when used in Chiffon cake pans or Bundt pans; you can just dust some icing sugar on top or drizzle a little bit of glaze. You can however decorate with whipped cream or meringue butter-creams if you prefer.", "Chiffon cakes by Amari", 13.95m, "" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Cakes_CategoryId",
                table: "Cakes",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_OrderId",
                table: "OrderDetails",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_PieId",
                table: "OrderDetails",
                column: "PieId");

            migrationBuilder.CreateIndex(
                name: "IX_ShoppingCartItems_CakeId",
                table: "ShoppingCartItems",
                column: "CakeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "OrderDetails");

            migrationBuilder.DropTable(
                name: "ShoppingCartItems");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Cakes");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}

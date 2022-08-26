using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
//using SaniatsCakeShop.Auth;

namespace SaniatsCakeShop.Models
{
    public class AppDbContext : IdentityDbContext<IdentityUser>

    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Cake> Cakes { get; set; }
        public DbSet<ShoppingCartItem> ShoppingCartItems { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }

     

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

     
            //seed categories


            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 1, CategoryName = "Fruit cakes" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 3, CategoryName = "Pound cakes" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 4, CategoryName = "Sponge cakes" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 5, CategoryName = "Genoise cakes" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 7, CategoryName = "Baked Flourless cakes" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 8, CategoryName = "Chiffon  cakes" });

            //seed cakes

            modelBuilder.Entity<Cake>().HasData(new Cake
            {
                CakeId = 1,
                Name = "FRESH FRUIT CAKE",
                Price = 8.95M,
                ShortDescription = " ",

                LongDescription =
                    "A delicious soft and light vanilla sponge cake filled with homemade fruit filling and topped with delicious fresh fruits and freshly whipped cream.",


                CategoryId = 1,
                ImageUrl = "https://i.ytimg.com/vi/dh6GgbgQ5j0/maxresdefault.jpg",
                InStock = true,
                IsCakeOfTheWeek = true,
                ImageThumbnailUrl = "https://i.imgur.com/lbEcaUo.jpeg",
                AllergyInformation = "",
                NutritionName = "Nutrition Info : Per 100 grams",

                Calorie = "352 calories",
                Protein = "0.72 grams",
                fiber = " 0.24 grams",
                niacin = " 0.14 grams",
                magnesium = "0.34 grams "
                
            });

            modelBuilder.Entity<Cake>().HasData(new Cake
            {
                CakeId = 2,
                Name = "Fresh Berry Cream Cake",
                Price = 18.95M,
                ShortDescription = " ",

                LongDescription =
                  
                "Baking a delicious (and pretty!) cake from scratch doesn't need to be complicated. With a few staple pantry ingredients, some whipped cream and your favorite fresh fruits, you can make a delicious cake that the entire family will enjoy.",




                CategoryId = 1,
                ImageUrl = "https://jennakateathome.com/wp-content/uploads/2022/02/fresh-fruit-cake-27-1.jpg",
                InStock = true,
                IsCakeOfTheWeek = false,
                ImageThumbnailUrl =
                    "https://i.imgur.com/pSpITQh.jpeg",
                AllergyInformation = "",
                NutritionName = "Nutrition Info : Per 100 grams",

                Calorie = "97 calories",
                Protein = "0.72 grams",
                fiber = " 0.24 grams",
                niacin = " 0.24 grams",
                magnesium = "30.4 grams ",
            });

            modelBuilder.Entity<Cake>().HasData(new Cake
            {
                CakeId = 3,
                Name = "Fraisier cake",
                Price = 11.95M,
                ShortDescription = "",
                LongDescription = "This type of sponge cake is made with whole eggs(no separation); this technique is a bit more involved as opposed to the Biscuit.Eggs are mixed with sugar and heated over simmering water then whipped. You must ensure that you constantly whip the egg mixture so the eggs don’t cook and become scrambled eggs. Make sure the bowl you’re mixing in doesn’t come into contact with the water in the pot below.The pot of water should not come to a boil; it should simmer.Whisk the egg mixture on top of the water about 3 to 5 minutes; until the bowl is warm to the touch or until it gets to about 110°-120°F / 43°-49°C.Whipping the eggs over heat allows them to whip to a greater volume.After the eggs and sugar have doubled or almost tripled in volume; add some melted butter and fold gently – then add the flour and fold. The eggs are used as the raising agents; this is why you need them to double or triple in volume.",



                CategoryId = 5,
                ImageUrl = "https://amaribakery.files.wordpress.com/2018/06/fraisier-cake.jpg",
                InStock = true,
                IsCakeOfTheWeek = false,
                ImageThumbnailUrl = "https://i.imgur.com/cHoyUc4.jpeg",
                AllergyInformation = "",
                NutritionName = "Nutrition Info : Per 100 grams",

                Calorie = "3513 calories",
                Protein = "0.97 grams",
                fiber = " 0.42 grams",
                niacin = " 0.44 grams",
                magnesium = "0.234 grams ",
            });

            modelBuilder.Entity<Cake>().HasData(new Cake
            {
                CakeId = 4,
                Name = "Biscuit",
                Price = 11.95M,
                ShortDescription = "",
                LongDescription = "This type of sponge cake contains both the egg white and yolks in the recipe. They are however first separated; whipped separately (egg whites and sugar to make a meringue) then mixed back together. In this type of Sponge cake; the eggs are the raising agent in the recipe. Chemical raising agents are not used in this recipe traditionally",
                CategoryId = 4,
                ImageUrl = "https://www.breadtalk.com.sg/wp-content/uploads/2020/07/Hersheys-Love-scaled.jpg",
                InStock = true,
                IsCakeOfTheWeek = false,
                ImageThumbnailUrl = "https://i.imgur.com/Hq2Wkjw.jpeg",
                AllergyInformation = "",
                NutritionName = "Nutrition Info : Per 100 grams",

                Calorie = "523 calories",
                Protein = "0.72 grams",
                fiber = " 0.44 grams",
                niacin = " 0.14 grams",
                magnesium = "0.64 grams "
            });

            modelBuilder.Entity<Cake>().HasData(new Cake
            {
                CakeId = 5,
                Name = "Chiffon cakes by Amari",
                Price = 13.95M,
                ShortDescription =
                "",
                LongDescription =
                    "This sponge cake contains both a fat and a chemical raising agent; oil and baking powder, in the ingredients list. The eggs are also separated; the whites are beaten until stiff. All the other ingredients are combined in another bowl to make a smooth batter like a pancake batter; the beaten egg whites are then folded into the ‘pancake’ batter.  The result after this mixing process is of a lighter sponge cake texture, but with a rich flavor like butter/oil cakes. These cakes are generally layered and filled with fillings and frostings. They don’t always require decoration especially when used in Chiffon cake pans or Bundt pans; you can just dust some icing sugar on top or drizzle a little bit of glaze. You can however decorate with whipped cream or meringue butter-creams if you prefer.",
                CategoryId = 8,
                ImageUrl = "https://amaribakery.files.wordpress.com/2018/06/vanilla-slice-plain-of-chiffon-by-amari.png?w=446&h=446",
                InStock = true,
                IsCakeOfTheWeek = false,
                ImageThumbnailUrl =
                    "https://i.imgur.com/zQWRNN0.jpeg",
                AllergyInformation = "",
                NutritionName = "Nutrition Info : Per 100 grams",

                Calorie = "352 calories",
                Protein = "0.17 grams",
                fiber = " 0.24 grams",
                niacin = " 0.14 grams",
                magnesium = "0.24 grams "
            });

            modelBuilder.Entity<Cake>().HasData(new Cake
            {
                CakeId = 6,
                Name = "Flourless Chocolate Cake",
                Price = 17.95M,
                ShortDescription =
                "",
                LongDescription =
                "This flourless cake, featuring both chocolate and cocoa, is rich, rich, RICH! A thick icing of chocolate ganache glaze takes it over the top. Depending on how you observe Passover, this cake can make a great addition to your Seder since it contains neither flour nor leavening; and of course, it's also ideal for those looking to avoid gluten.",
                CategoryId = 7,
                ImageUrl = "https://www.kingarthurbaking.com/sites/default/files/styles/featured_image/public/recipe_legacy/4179-3-large.jpg?itok=dphbBuMQ",
                InStock = true,
                IsCakeOfTheWeek = false,
                ImageThumbnailUrl = "https://i.imgur.com/8OCaqUk.jpeg",
                AllergyInformation = "",
                NutritionName = "Nutrition Info : Per 100 grams",

                Calorie = "351 calories",
                Protein = "0.72 grams",
                fiber = " 0.42 grams",
                niacin = " 0.41 grams",
                magnesium = "0.24 grams "
            });

            modelBuilder.Entity<Cake>().HasData(new Cake
            {
                CakeId = 7,
                Name = "Fennel-spiced semolina cake with yoghurt",
                Price = 11.95M,
                ShortDescription =
                 "",
                LongDescription =
                "This combination of citrus, sugar and spice makes for an unbeatable afternoon-tea treat.",
                CategoryId = 7,
                ImageUrl = "https://d3lp4xedbqa8a5.cloudfront.net/s3/digital-cougar-assets/Gt/2018/05/23/15958/GT1805_Grains_Fennel_spiced_semolina_cake_with_yoghurtA.jpg?width=922&height=768&mode=crop&anchor=topcenter&quality=75",
                InStock = false,
                IsCakeOfTheWeek = false,
                ImageThumbnailUrl = "https://i.imgur.com/0QocoJX.jpeg",
                AllergyInformation = "",
                NutritionName = "Nutrition Info : Per 100 grams",

                Calorie = "352 calories",
                Protein = "0.72 grams",
                fiber = " 0.34 grams",
                niacin = " 0.14 grams",
                magnesium = "0.4 grams "
            });

            modelBuilder.Entity<Cake>().HasData(new Cake
            {
                CakeId = 8,
                Name = "Chocolate, coconut and date slab",
                Price = 12.95M,
                ShortDescription =
                  "",
                LongDescription =
                "A layer of coconut ganache over this fudgy slab keeps it rich and creamy, but dairy-free, while raw cacoa and dates steer it firmly away from corner-store chocolate bar territory.",
                CategoryId = 7,
                ImageUrl = "https://d3lp4xedbqa8a5.cloudfront.net/s3/digital-cougar-assets/Gt/2018/07/03/15967/chocolate-coconut-date-slab.jpg?width=922&height=768&mode=crop&anchor=topcenter&quality=75",
                InStock = true,
                IsCakeOfTheWeek = true,
                ImageThumbnailUrl = "https://i.imgur.com/nbXFNdC.jpeg",
                AllergyInformation = "",
                NutritionName = "Nutrition Info : Per 100 grams",

                Calorie = "3225 calories",
                Protein = "0.71 grams",
                fiber = " 0.42 grams",
                niacin = " 0.42 grams",
                magnesium = "0.41 grams "
            });


            modelBuilder.Entity<Cake>().HasData(new Cake
            {
                CakeId = 9,
                Name = "Triple-Chocolate Buttermilk Pound Cake",
                Price = 15.95M,
                ShortDescription =
                  "",
                LongDescription =
                "We took the traditional pound cake recipe and gave it a stunning, triple-chocolate twist. This cake means business. A duo of glazes—one creamy chocolate, the other subtle buttermilk—comes together atop this dreamy confection. It's indulgent and, we admit, so much fun to eat and serve. Chocolate enthusiasts will be over the moon for this recipe, but it has enough unexpected flavor—thanks to the addition of the buttermilk glaze—that you'll also win over the harder-to-please dessert eaters at the table. Warning: You—and they—won't be able to resist a second slice.",
                CategoryId = 3,
                ImageUrl = "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fstatic.onecms.io%2Fwp-content%2Fuploads%2Fsites%2F24%2F1970%2F01%2F2341302_butte_054_2_0_1.jpg",
                InStock = true,
                IsCakeOfTheWeek = true,
                ImageThumbnailUrl = "https://i.imgur.com/bRx0mVn.jpg",
                AllergyInformation = "",
                NutritionName = "Nutrition Info : Per 100 grams",

                Calorie = "3521 calories",
                Protein = "0.72 grams",
                fiber = " 0.42 grams",
                niacin = " 0.43 grams",
                magnesium = "0.41 grams "
            });

            modelBuilder.Entity<Cake>().HasData(new Cake
            {
                CakeId = 10,
                Name = "Strawberry Swirl Pound Cake",
                Price = 15.95M,
                ShortDescription =
                  "",
                LongDescription =
                "Cream cheese, buttermilk, and strawberry glaze team up to create a delicious pound cake",
                CategoryId = 3,
                ImageUrl = "https://www.pauladeenmagazine.com/wp-content/uploads/2019/04/p2.jpg",
                InStock = true,
                IsCakeOfTheWeek = false,
                ImageThumbnailUrl = "https://i.imgur.com/dWW8B1n.jpeg",
                AllergyInformation = "",
                NutritionName = "Nutrition Info : Per 100 grams",

                Calorie = "351 calories",
                Protein = "0.73 grams",
                fiber = " 0.45 grams",
                niacin = " 0.42 grams",
                magnesium = "0.44 grams "
            }); 

            modelBuilder.Entity<Cake>().HasData(new Cake
            {
                CakeId = 11,
                Name = "Joconde cake",
                Price = 1.95M,
                ShortDescription =
                  "",
                LongDescription =
                "Joconde is a light and airy sponge cake that you can use to make many types of desserts. Joconde does not have a lot of fat in it and is considered to be a healthy version of a traditional cake. ",
                CategoryId = 4,
                ImageUrl = "https://projectveganbaking.com/wp-content/uploads/2020/06/IMG_6434_Fotor-copy.jpg",
                InStock = false,
                IsCakeOfTheWeek = false,
                ImageThumbnailUrl =
                    "https://i.imgur.com/cNEGnwd.jpeg",
                AllergyInformation = "",
                NutritionName = "Nutrition Info : Per 100 grams",

                Calorie = "3524 calories",
                Protein = "0.237 grams",
                fiber = " 0.344 grams",
                niacin = " 0.444 grams",
                magnesium = "0.24 grams "
            });
            
       
            
        }
    }
}

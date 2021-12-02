using System;
using System.Linq;
using DataLayer.Backend;
using DataLayer.Data;
using DataLayer.Model;
using Xunit;

namespace TestSuite
{
    //TODO skapa indipendecy injection
    public class RestaurantTests
    {
        private RestaurantBackend restaurantBackend;
        private AdminBackend adminBackend;

        public RestaurantTests()
        {
            restaurantBackend = new RestaurantBackend();
            adminBackend = new AdminBackend();
        }

        [Fact]
        void TestShowRestaurantSoldBoxes()
        {
            adminBackend.CreateAndSeedDb();
            using var context = new FoodResQCtx();

            //Hämta ett befinligt resturang objekt  från databasen
            Restaurant restaurant = context.Restaurants.Find(1);

            //säkerställ att den resturangen finns
            Assert.NotNull(restaurant);

            var result = restaurantBackend.ShowSoldBoxes(restaurant);

            //Kolla så att innehållet i listan stämmer
            Assert.Equal("Fried Rice",result[0].Name);
            Assert.Equal("Meat",result[1].Type);
            Assert.NotNull(result[1].customer);
        }

        [Fact]
        void TestShowRestaurantUnsoldBoxes()
        {
            adminBackend.CreateAndSeedDb();
            using var context = new FoodResQCtx();

            //Hämta ett befinligt resturang objekt  från databasen
            Restaurant restaurant = context.Restaurants.Find(1);

            //Säkerställ att den resturangen finns
            Assert.NotNull(restaurant);

            var result = restaurantBackend.ShowUnsoldBoxes(restaurant);

            //Kolla så att innehållet i listan stämmer
            Assert.Equal("Grilled Rice", result[0].Name);
            Assert.Null(result[0].customer);
        }

        [Fact]
        void TestAddNewFoodBox()
        {
            //säkerställ att databasen existerar och är seedad.

            adminBackend.CreateAndSeedDb();
            using var context = new FoodResQCtx();

            //Säkerställ att det inte finns nångon sådan matlåda i databasen
            var query = context.Foodboxes.Where(f => f.Name == "AddedName" && f.Type == "AddedType");
            var NotaddedFoodbox = query.FirstOrDefault();

            Assert.Null(NotaddedFoodbox);

            //Hämta ett befinligt resturang objekt från databasen
            Restaurant restaurant = context.Restaurants.Find(1);

            //Säkerställ att den resturangen finns
            Assert.NotNull(restaurant);

            //Använd metoden för att lägga till önskad matlåda i databasen
            restaurantBackend.AddFoodBox("AddedName", "AddedType", 14, restaurant);

            //Leta på nytt efter den matlådan
            query = context.Foodboxes.Where(f => f.Name == "AddedName" && f.Type == "AddedType");
            var addedFoodbox = query.FirstOrDefault();

            //Kolla så att den nu finns
            Assert.NotNull(addedFoodbox);
            Assert.Equal("AddedName", addedFoodbox.Name);
            Assert.Null(addedFoodbox.customer);
        }

        [Fact]
        void TestLoginRestaurant()
        {
            adminBackend.CreateAndSeedDb();
            using var context = new FoodResQCtx();

            var SucssesLogin = restaurantBackend.LoginRestaurant("Res1", "123");
            Assert.Equal("Theos Ricehouse", SucssesLogin.Name);
            
            Exception exeption = Assert.ThrowsAny<Exception>(() => restaurantBackend.LoginRestaurant("InvalidUsername", "123"));
            Assert.Equal("Username not found!", exeption.Message);

            exeption = Assert.ThrowsAny<Exception>(() => restaurantBackend.LoginRestaurant("Res1", "WrongPassword"));
            Assert.Equal("Invalid password!", exeption.Message);
        }
    }
}
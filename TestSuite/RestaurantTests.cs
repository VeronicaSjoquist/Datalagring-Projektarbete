using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using DataLayer.Backend;
using DataLayer.Data;
using DataLayer.Model;
using Microsoft.EntityFrameworkCore.Migrations.Operations;
using Xunit;

namespace TestSuite
{
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
        void ShowRestaurantSoldBoxesTest()
        {
            adminBackend.CreateAndSeedDb();
            
            var result = restaurantBackend.ShowSoldBoxes(1);

            Assert.Equal("Fried Rice",result[0].Name);
            Assert.Equal("Meat",result[1].Type);
            Assert.NotNull(result[1].customer);
        }

        [Fact]
        void AddNewFoodBoxTest()
        {
            adminBackend.CreateAndSeedDb();
            using var context = new FoodResQCtx();

            //säkerställ att det inte finns nångon sådan matlåda i databasen
            var query = context.Foodboxes.Where(f => f.Name == "AddedName" && f.Type == "AddedType");
            var NotaddedFoodbox = query.FirstOrDefault();

            Assert.Null(NotaddedFoodbox);

            // Använd metoden för att lägga till önskad matlåda i databasen
            restaurantBackend.AddFoodBox("AddedName","AddedType",14,1);

            // Leta på nytt efter den matlådan
            query = context.Foodboxes.Where(f => f.Name == "AddedName" && f.Type == "AddedType");
            var addedFoodbox = query.FirstOrDefault();

            // kolla så allt stämmer
            Assert.NotNull(addedFoodbox);
            Assert.Equal("AddedName", addedFoodbox.Name);
            Assert.Null(addedFoodbox.customer);
            

        }

        [Fact]
        void LoginRestaurantTest()
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
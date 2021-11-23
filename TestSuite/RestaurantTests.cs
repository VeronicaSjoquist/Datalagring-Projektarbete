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
        private RestaurantBackend resturantBackend;
        private AdminBackend adminBackend;

        public RestaurantTests()
        {
            resturantBackend = new RestaurantBackend();
            adminBackend = new AdminBackend();
        }

        [Fact]
        void ShowRestaurantSoldBoxesTest()
        {
            adminBackend.CreateAndSeedDb();

            var result = new List<FoodBox>();

            foreach (var foodbox in resturantBackend.ShowSoldBoxes(1))
            {
                result.Add(foodbox);
            }

            Assert.Equal("Fried Rice",result[0].Name);
            Assert.Equal("Meat",result[1].Type);
            Assert.NotNull(result[1].customer);
        }

        [Fact]
        void AddNewFoodBoxTest()
        {
            adminBackend.CreateAndSeedDb();
            using var context = new FoodResQCtx();

            resturantBackend.AddFoodBox("AddedName","AddedType",14,1);

            var query = context.Foodboxes.Where(f => f.Name == "AddedName" && f.Type == "AddedType");
            var addedFoodbox = query.First();

            Assert.Equal("AddedName", addedFoodbox.Name);
            Assert.Null(addedFoodbox.customer);
        }

        [Fact]
        void LoginRestaurantTest()
        {
            adminBackend.CreateAndSeedDb();
            using var context = new FoodResQCtx();

            var SucssesLogin = resturantBackend.LoginRestaurant("Res1", "123");
            Assert.Equal("Theos Ricehouse", SucssesLogin.Name);
            
            Exception exeption = Assert.ThrowsAny<Exception>(() => resturantBackend.LoginRestaurant("InvalidUsername", "123"));
            Assert.Equal("Username not found!", exeption.Message);

            exeption = Assert.ThrowsAny<Exception>(() => resturantBackend.LoginRestaurant("Res1", "WrongPassword"));
            Assert.Equal("Invalid password!", exeption.Message);

        }
    }
}
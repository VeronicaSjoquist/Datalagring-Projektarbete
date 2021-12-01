using System;
using System.Linq;
using DataLayer.Backend;
using DataLayer.Data;
using Microsoft.EntityFrameworkCore;
using Xunit;

namespace TestSuite
{
    public class AdminTests
    {
        private AdminBackend admin;

        public AdminTests()
        {
            admin = new AdminBackend();
        }

        [Fact]
        public void TestCreateAndSeed()
        {
            using (var ctx = new FoodResQCtx())
            {
                var customers = ctx.Customers;
                var restaurants = ctx.Restaurants;
                var foodboxes = ctx.Foodboxes;

                ctx.Database.EnsureDeleted();

                Assert.ThrowsAny<Exception>(() => Assert.Empty(customers));

                ctx.Database.EnsureCreated();

                Assert.Empty(customers);
                Assert.Empty(restaurants);
                Assert.Empty(foodboxes);

                admin.CreateAndSeedDb();

                Assert.NotEmpty(customers);
                Assert.NotEmpty(restaurants);
                Assert.NotEmpty(foodboxes);
            }
        }

        [Fact]
        public void TestShowAllRestaurants()
        {
            using (var ctx = new FoodResQCtx())
            {
                ctx.Database.EnsureDeleted();
                ctx.Database.EnsureCreated();

                var restaurants = admin.ShowAllRestaurants();

                Assert.Empty(restaurants);

                admin.CreateAndSeedDb();

                restaurants = admin.ShowAllRestaurants();

                Assert.NotEmpty(restaurants);
                Assert.Equal("Theos Ricehouse", restaurants[0].Name);
            }
        }

        [Fact]
        public void TestShowAllCustomers()
        {
            using (var ctx = new FoodResQCtx())
            {
                ctx.Database.EnsureDeleted();
                ctx.Database.EnsureCreated();

                var customers = admin.ShowAllCustomers();

                Assert.Empty(customers);

                admin.CreateAndSeedDb();

                customers = admin.ShowAllCustomers();

                Assert.NotEmpty(customers);
                Assert.Equal("Theo", customers[0].Name);
            }
        }

        [Fact]
        public void TestAddNewRestaurant()
        {
            admin.CreateAndSeedDb();

            using (var ctx = new FoodResQCtx())
            {
                var query = ctx.Restaurants
                    .Where(e => e.Name == "newRestaurant");

                var notAdded = query.FirstOrDefault();

                Assert.Null(notAdded);

                admin.AddRestaurant("newRestaurant");

                query = ctx.Restaurants
                    .Where(e => e.Name == "newRestaurant");

                var addedRestaurant = query.FirstOrDefault();

                Assert.NotNull(addedRestaurant);
                Assert.Equal("newRestaurant", addedRestaurant.Name);
            }
        }
    }
}
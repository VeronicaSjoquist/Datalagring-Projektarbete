using DataLayer.Backend;
using DataLayer.Data;
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
            admin.CreateAndSeedDb();

            using (var ctx = new FoodResQCtx())
            {
                var customers = ctx.Customers;
                var restaurants = ctx.Restaurants;
                var foodboxes = ctx.Foodboxes;

                Assert.NotEmpty(customers);
                Assert.NotEmpty(restaurants);
                Assert.NotEmpty(foodboxes);
            }
        }

        [Fact]
        public void TestShowAllRestaurants()
        {
            admin.CreateAndSeedDb();

            var restaurants = admin.ShowAllRestaurants();

            Assert.NotEmpty(restaurants);
            Assert.Equal("Theos Ricehouse", restaurants[0].Name);
        }

        [Fact]
        public void TestShowAllCustomers()
        {
            admin.CreateAndSeedDb();

            var customers = admin.ShowAllCustomers();

            Assert.NotEmpty(customers);
            Assert.Equal("Theo", customers[0].Name);
        }
    }
}
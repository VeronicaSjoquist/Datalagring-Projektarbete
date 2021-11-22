using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using DataLayer.Backend;
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
        public void Test1()
        {
            adminBackend.CreateAndSeedDb();

            var result = new List<FoodBox>();

            foreach (var foodbox in resturantBackend.ShowSoldBoxes(1))
            {
                result.Add(foodbox);
            }

            Assert.Equal("Fried Rice",result[0].Name);
            Assert.NotEqual("",result[1].Name);

        }
    }
}
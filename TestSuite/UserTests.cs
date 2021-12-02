using System.Collections.Generic;
using System.Linq;
using DataLayer.Backend;
using DataLayer.Data;
using DataLayer.Model;
using Microsoft.EntityFrameworkCore;
using Xunit;

namespace TestSuite
{
    public class UserTests
    {
        [Fact]
        public void TestUnsoldFoodboxes()
        {
            AdminBackend adminBackend = new AdminBackend();
            UserBackend userBackend = new UserBackend();

            adminBackend.CreateAndSeedDb();

            List<FoodBox> test = userBackend.ListUnsoldFoodBoxesOnType("Fish");

            Assert.Null(test[0].customer);
            Assert.Null(test[1].customer);
            Assert.Null(test[2].customer);

            List<FoodBox> meatTest = userBackend.ListUnsoldFoodBoxesOnType("Meat");

            Assert.Equal("Köttfärssås", meatTest[0].Name);
        }

        [Fact]
        public void TestBuyFoodBox()
        {
            AdminBackend adminBackend = new AdminBackend();
            UserBackend userBackend = new UserBackend();

            adminBackend.CreateAndSeedDb();

            using (var ctx = new FoodResQCtx())
            {
                var foodBox = ctx.Foodboxes.Find(3);
                Assert.Null(foodBox.customer);
            }

            userBackend.BuyFoodBox(3, 1);

            using (var ctx = new FoodResQCtx())
            {
                var query = ctx.Foodboxes
                    .Include(e => e.customer)
                    .Where(e => e.ID == 3);

                var foodBox = query.FirstOrDefault();
                Assert.Equal(1, foodBox.customer.ID);
            }
        }
    }
}
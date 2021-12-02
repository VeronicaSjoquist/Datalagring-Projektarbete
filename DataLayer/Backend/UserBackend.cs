using System.Collections.Generic;
using System.Linq;
using DataLayer.Data;
using DataLayer.Model;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Backend
{
    public class UserBackend
    {
        //En metod för att köpa ett givet lunchlåde objekt
        public void BuyFoodBox(int foodboxId, int customerId)
        {
            using (var ctx = new FoodResQCtx())
            {
                var customer = ctx.Customers.Find(customerId);

                var foodBox = ctx.Foodboxes.Find(foodboxId);

                if (foodBox == null)
                {
                    return;
                }

                foodBox.customer = customer;

                ctx.SaveChanges();
            }
        }

        //En metod för att få ut en lista på alla oköpta matlådor i alla restauranger av en viss typ (kött/fisk/vegan), sorterade på pris lägst först.
        public List<FoodBox> ListUnsoldFoodBoxesOnType(string type)
        {
            using (var ctx = new FoodResQCtx())
            {
                var query = ctx.Foodboxes
                    .Include(e => e.restaurant)
                    .Include(e => e.customer)
                    .Where(e => e.customer == null && e.Type == type)
                    .OrderBy(e => e.Price);

                return query.ToList();
            }
        }

        //En metod för att lista oköpta boxar av alla typer i en viss restaurang, sorterade på pris lägst först.
        public List<FoodBox> ListUnsoldFoodBoxesOnRestaurant(string restaurantName)
        {
            using (var ctx = new FoodResQCtx())
            {
                var query = ctx.Foodboxes
                    .Include(e => e.restaurant)
                    .Include(e => e.customer)
                    .Where(e => e.customer == null && e.restaurant.Name == restaurantName)
                    .OrderBy(e => e.Price);

                return query.ToList();
            }
        }

        //En metod för att lista köphistoriken hos en kund.
        public List<FoodBox> ListOfCustomerHistory(int customerId)
        {
            using (var ctx = new FoodResQCtx())
            {
                var query = ctx.Foodboxes
                    .Include(e => e.restaurant)
                    .Include(e => e.customer)
                    .Where(e => e.customer.ID == customerId);

                return query.ToList();
            }
        }
    }
}
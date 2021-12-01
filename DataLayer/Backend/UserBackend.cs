using System;
using System.Collections.Generic;
using System.Linq;
using DataLayer.Data;
using DataLayer.Model;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Backend
{
    public class UserBackend
    {
        //En metod för att få ut en lista på alla oköpta matlådor i alla restauranger, sorterade på pris lägst först. Parameter: typ av matlåda (kött/fisk/vego)
        public List<FoodBox> UnsoldFoodBoxes(string type)
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

        //Joakims extra metod för att lista efter Restaurang

        public List<FoodBox> listUnsoldonRestaurant(string nameof)
        {
            using (var ctx = new FoodResQCtx())
            {
                var query = ctx.Foodboxes
                    .Include(e => e.restaurant)
                    .Include(e => e.customer)
                    .Where(e => e.customer == null && e.restaurant.Name == nameof)
                    .OrderBy(e => e.Price);

                return query.ToList();
            }
        }

        public List<Customer> userList()
        {
            using (var ctx = new FoodResQCtx())
            {
                var query = ctx.Customers;

                return query.ToList();
            }
        }

        public List<FoodBox> listofCustomerBuys(int customerId)
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
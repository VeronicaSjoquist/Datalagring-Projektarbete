using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer.Data;
using DataLayer.Model;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Backend
{
    public class RestaurantBackend
    {
        //En metod för att få en lista över alla sålda matlådor för ett restaurang objekt
        public List<FoodBox> ShowSoldBoxes(int RestaurantId)
        {
            using (var ctx = new FoodResQCtx())
            {
                var query = ctx.Foodboxes
                    .Where(e => e.customer != null && e.restaurant.ID == RestaurantId)
                    .Include(e=>e.customer)
                    .Include(e=>e.restaurant);

                return query.ToList();
            }
        }

        //TODO includerade customer och resturant för lite roligare test
        
        //En metod för att lägga till ett nytt matlådeobjekt för en restaurang
        public void AddFoodBox(string name, string type, decimal price, int restaurantId)
        {
            using (var ctx = new FoodResQCtx())
            {
                var restaurant = ctx.Restaurants.Find(restaurantId);

                if (restaurant == null)
                {
                    return;
                }

                var foodBox = new FoodBox()
                {
                    Name = name, Type = type, Price = price, restaurant = restaurant
                };

                ctx.Foodboxes.Add(foodBox);
                ctx.SaveChanges();
            }
        }

        public Restaurant LoginRestaurant(string Username, string password)
        {
            using var ctx = new FoodResQCtx();

            //query restrant
            var query = ctx.Restaurants.Where(r => r.Username == Username)
                .Include(r=>r.FoodBoxes);

            //Find resturant
            var resturant = query.FirstOrDefault();
            
            // check username exist
            if (resturant == null) throw new Exception("Username not found!");
            
            // check password match
            if(resturant.Password != password) throw new Exception("Invalid password!");

            return resturant;

        }
    }
}
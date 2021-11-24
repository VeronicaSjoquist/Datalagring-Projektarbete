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
        //TODO includerade customer och resturant för lite roligare test OCH ändrade till att ta in ett resturaurant objekt
        public List<FoodBox> ShowSoldBoxes(Restaurant restaurant)
        {
            using (var ctx = new FoodResQCtx())
            {
                var query = ctx.Foodboxes
                    .Where(e => e.customer != null && e.restaurant == restaurant)
                    .Include(e=>e.customer)
                    .Include(e=>e.restaurant);

                return query.ToList();
            }
        }

        
        //En metod för att lägga till ett nytt matlådeobjekt för en restaurang
        //TODO ändrade så metoden tog in ett resturang objekt istället för int. Kommer underlätta för frontend
        public void AddFoodBox(string name, string type, decimal price, Restaurant restaurant)
        {
            using (var ctx = new FoodResQCtx())
            {
               var foodBox = new FoodBox()
                {
                    Name = name, Type = type, Price = price, restaurant = restaurant
                };

                ctx.Update(restaurant);
                ctx.Foodboxes.Add(foodBox);
                ctx.SaveChanges();
            }
        }

        //TODO Extra metod för att kunna logga in en restaurang
        public Restaurant LoginRestaurant(string username, string password)
        {
            using var ctx = new FoodResQCtx();

            //query restrant based on username
            var query = ctx.Restaurants.Where(r => r.Username == username)
                .Include(r=>r.FoodBoxes);

            //Create copie of the resturant objekt found in the database
            var resturant = query.FirstOrDefault();
            
            // check username exist
            if (resturant == null) throw new Exception("Username not found!");
            
            // check password match
            if (resturant.Password != password) throw new Exception("Invalid password!");

            return resturant;

        }
    }
}
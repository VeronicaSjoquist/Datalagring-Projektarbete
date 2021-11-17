using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer.Data;
using DataLayer.Model;

namespace DataLayer.Backend
{
    public class RestaurantBackend
    {
        //En metod för att få en lista över alla sålda matlådor för ett restaurang objekt
        public List<FoodBox> ShowSoldBoxes(int index)
        {
            using (var ctx = new FoodResQCtx())
            {
                var query = ctx.Foodboxes
                    .Where(e => e.customer != null && e.restaurant.ID == index);

                return query.ToList();
            }
        }
        
        //En metod för att lägga till ett nytt matlådeobjekt för en restaurang

        public void AddFoodBox(string name, string type, decimal price, int restaurantId)
        {
            using (var ctx = new FoodResQCtx())
            {
                var query = ctx.Restaurants.Where(e => e.ID == restaurantId);

                var restaurant = query.FirstOrDefault();

                var foodBox = new FoodBox()
                {
                    Name = name, Type = type, Price = price, restaurant = restaurant
                };

                ctx.Add(foodBox);
                ctx.SaveChanges();
            }
        }
    }
}

//Ersätt "restaurant.sql" med en klass "RestaurantBackend.cs" som har följande:


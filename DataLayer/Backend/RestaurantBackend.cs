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
        public List<FoodBox> ShowSoldBoxes(int RestaurantId)
        {
            using (var ctx = new FoodResQCtx())
            {
                var query = ctx.Foodboxes
                    .Where(e => e.customer != null && e.restaurant.ID == RestaurantId);

                return query.ToList();
            }
        }
        
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
    }
}
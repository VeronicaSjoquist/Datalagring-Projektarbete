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
        //*Klar* En metod för att få en lista över alla sålda matlådor för ett restaurang objekt
        public List<FoodBox> ShowSoldBoxes(int index)
        {
            using (var ctx = new FoodResQCtx())
            {
                var query = ctx.Foodboxes
                    .Where(e => e.customer != null && e.restaurant.ID == index);

                return query.ToList();
            }
        }
    }
}

//Ersätt "restaurant.sql" med en klass "RestaurantBackend.cs" som har följande:

//TODO En metod för att lägga till ett nytt matlådeobjekt för en restaurang
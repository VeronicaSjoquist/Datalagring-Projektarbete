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
                    .Where(e => e.customer == null && e.Type == type)
                    .OrderBy(e => e.Price);

                return query.ToList();
            }
        }

        //TODO En metod för att köpa ett givet lunchlåde objekt
    }
}

//Ersätt "user.sql" med en klass "UserBackend.cs" som har följande:
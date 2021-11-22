using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer.Data;
using DataLayer.Model;

namespace DataLayer.Backend
{
    public class AdminBackend
    {
        //En metod för att se alla användare
        public List<Customer> ShowAllCustomers()
        {
            using (var ctx = new FoodResQCtx())
            {
                var query = ctx.Customers;

                return query.ToList();
            }
        }

        //En metod för att kunna ta bort en användare utifrån användarnamn
        public void RemoveCustomer(string customerName)
        {
            using (var ctx = new FoodResQCtx())
            {
                var query = ctx.Customers
                    .Where(e => e.Name == customerName);
                var customer = query.FirstOrDefault();

                if (customer == null)
                {
                    return;
                }

                customer.Name = null;
                ctx.SaveChanges();
            }
        }

        //En metod för att se alla restauranger
        public List<Restaurant> ShowAllRestaurants()
        {
            using (var ctx = new FoodResQCtx())
            {
                var query = ctx.Restaurants;

                return query.ToList();
            }
        }

        //En metod för att kunna lägga till ett nytt restaurang
        public void AddRestaurant(string name)
        {
            using (var ctx = new FoodResQCtx())
            {
                var restaurant = new Restaurant
                {
                    Name = name
                };

                ctx.Add(restaurant);
                ctx.SaveChanges();
            }
        }

        //En metod för att skapa om och seeda databasen
        public void CreateAndSeedDb()
        {
            using (var ctx = new FoodResQCtx())
            {
                ctx.Database.EnsureDeleted();
                ctx.SaveChanges();
                ctx.Database.EnsureCreated();

                var customers = new List<Customer>
                {
                    new Customer{Name = "Theo", Username = "Cus1", Password = "123"},
                    new Customer{Name = "Kim", Username = "Cus2", Password = "123"},
                    new Customer{Name = "Veronica", Username = "Cus3", Password = "123"},
                };

                ctx.AddRange(customers);
                ctx.SaveChanges();

                var restaurants = new List<Restaurant>
                {
                    new Restaurant {Name = "Theos Ricehouse", Username = "Res1", Password = "123"},
                    new Restaurant {Name = "Kanelbulle Kim", Username = "Res2", Password = "123"},
                    new Restaurant {Name = "Veronicas Köttfärssås", Username = "Res3", Password = "123"}
                };

                ctx.AddRange(restaurants);
                ctx.SaveChanges();

                var foodboxes = new List<FoodBox>
                {
                    new FoodBox{customer = customers[0], restaurant = restaurants[0], Name = "Fried Rice", Type = "Vegan", Price = 59},
                    new FoodBox{customer = customers[1], restaurant = restaurants[0], Name = "Cooked Rice", Type = "Meat", Price = 69},
                    new FoodBox{customer = null, restaurant = restaurants[0], Name = "Grilled Rice", Type = "Fish", Price = 79},

                    new FoodBox{customer = customers[1], restaurant = restaurants[1], Name = "Kanelbulle", Type = "Vegan", Price = 59},
                    new FoodBox{customer = customers[0], restaurant = restaurants[1], Name = "Pizzarulle", Type = "Meat", Price = 69},
                    new FoodBox{customer = null, restaurant = restaurants[1], Name = "Sushirulle", Type = "Fish", Price = 79},

                    new FoodBox{customer = customers[0], restaurant = restaurants[2], Name = "Soyfärssås", Type = "Vegan", Price = 59},
                    new FoodBox{customer = null, restaurant = restaurants[2], Name = "Köttfärssås", Type = "Meat", Price = 69},
                    new FoodBox{customer = null, restaurant = restaurants[2], Name = "Fiskfärssås", Type = "Fish", Price = 43}
                };

                ctx.AddRange(foodboxes);
                ctx.SaveChanges();
            }
        }
    }
}
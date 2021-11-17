using System;
using DataLayer.Backend;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var admin = new AdminBackend();

            admin.CreateAndSeedDb();

            Console.WriteLine("Database created and seeded, press Enter to continue.");
            Console.ReadLine();

            var restaurant = new RestaurantBackend();

            Console.WriteLine("Sold foodboxes for selected restaurant:");

            foreach (var foodBox in restaurant.ShowSoldBoxes(1))
            {
                Console.WriteLine($"Food: {foodBox.Name}, Type: {foodBox.Type}, Price {foodBox.Price}");
            }

            Console.WriteLine("\nPress Enter to continue");
            Console.ReadLine();

            restaurant.AddFoodBox("Fooood", "Vegan", 49, 1);

            Console.WriteLine("New foodbox added to selected restaurant");

            Console.WriteLine("\nPress Enter to continue");
            Console.ReadLine();

            var user = new UserBackend();

            Console.WriteLine("Unsold foodboxes for selected type:");

            foreach (var foodbox in user.UnsoldFoodBoxes("Fish"))
            {
                Console.WriteLine($"Food: {foodbox.Name}, Restaurant: {foodbox.restaurant.Name}, Price {foodbox.Price}");
            }

            Console.WriteLine("\nPress Enter to continue");
            Console.ReadLine();

            user.BuyFoodBox(8,1);

            Console.WriteLine("Selected foodbox has been punchased");

            Console.WriteLine("\nPress Enter to continue");
            Console.ReadLine();

            Console.WriteLine("Customers:");

            foreach (var customer in admin.ShowAllCustomers())
            {
                Console.WriteLine($"ID: {customer.ID}\tName: {customer.Name}");
            }

            Console.WriteLine("\nPress Enter to continue");
            Console.ReadLine();

            Console.WriteLine("Restaurants:");

            foreach (var restaurants in admin.ShowAllRestaurants())
            {
                Console.WriteLine($"ID: {restaurants.ID}\tName: {restaurants.Name}");
            }

            Console.WriteLine("\nPress Enter to continue");
            Console.ReadLine();
            
            admin.RemoveCustomer("Veronica");

            Console.WriteLine("Selected customer has been removed");

            Console.WriteLine("\nPress Enter to continue");
            Console.ReadLine();

            admin.AddRestaurant("Jons Kebab");

            Console.WriteLine("New restaurant har been added");

            Console.WriteLine("\nPress Enter to exit");
            Console.ReadLine();
        }
    }
}
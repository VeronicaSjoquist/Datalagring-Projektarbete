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
                Console.WriteLine($"ID: {customer.ID} \tName: {customer.Name}");
            }

            Console.WriteLine("\nPress Enter to continue");
            Console.ReadLine();
        }
    }
}

/*
Lägg även till ett körbart Console App projekt som går att steppa igenom
där du testar att anropa alla hjälpmetoder i Backend projektet. 
Börja med Admin metoden för att skapa om och seeda databasen.


Console App projekt:
- Använder alla metoder minst en gång.
- Går att steppa igenom.
*/
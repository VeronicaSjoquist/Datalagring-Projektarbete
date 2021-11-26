using DataLayer.Backend;

var admin = new AdminBackend();

while (true)
{
    Console.ForegroundColor = ConsoleColor.DarkGreen;
    Console.Clear();
    Console.WriteLine("Welcome to Food Rescue: Admin site.\n");
    Console.WriteLine("Choose from the following options what you would like to do:\n");

    Console.WriteLine(@"[0] Exit program");
    Console.WriteLine(@"[1] Restart database");
    Console.WriteLine(@"[2] Show all customers");
    Console.WriteLine(@"[3] Show all restaurants");
    Console.WriteLine(@"[4] Add new restaurant");
    Console.Write("\nOption: ");

    var option = Console.ReadLine();

    if (option == "0")
    {
        break;
    }

    if (option == "1")
    {
        Console.Clear();
        admin.CreateAndSeedDb();

        Console.WriteLine("Database has been restarted and seeded!\n");
        Console.WriteLine("Press Enter to return to menu...");
        Console.ReadLine();
    }

    if (option == "2")
    {
        Console.Clear();
        Console.WriteLine("Customers:\n");

        foreach (var customer in admin.ShowAllCustomers())
        {
            Console.WriteLine($"ID: {customer.ID}\tName: {customer.Name}");
        }

        Console.WriteLine("\nPress Enter to return to menu...");
        Console.ReadLine();
    }

    if (option == "3")
    {
        Console.Clear();
        Console.WriteLine("Restaurants:\n");

        foreach (var restaurants in admin.ShowAllRestaurants())
        {
            Console.WriteLine($"ID: {restaurants.ID}\tName: {restaurants.Name}");
        }

        Console.WriteLine("\nPress Enter to return to menu...");
        Console.ReadLine();
    }

    if (option == "4")
    {
        Console.Clear();
        Console.WriteLine("Type in the name of the restaurant you want to add:\n");
        Console.Write("Name: ");
        var restaurant = Console.ReadLine();

        admin.AddRestaurant(restaurant);

        Console.WriteLine($"\nThe restaurant \"{restaurant}\" has been added\n");

        Console.WriteLine("\nPress Enter to return to menu...");
        Console.ReadLine();
    }

    else
    {
        Console.Clear();
        Console.WriteLine("Please choose a valid option, press Enter key to try again");
        Console.ReadLine();
    }
}
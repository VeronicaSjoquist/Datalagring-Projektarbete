using DataLayer.Backend;

var admin = new AdminBackend();

admin.CreateAndSeedDb();

Console.WriteLine("Database created and seeded, press Enter to continue.");
Console.ReadLine();
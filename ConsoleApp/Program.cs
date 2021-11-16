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
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
using System;

namespace Stew
{
    internal class Program
    {
        static void Main(string [] args)
        {
            Database database = new Database();

            int currentDate = 2004;

            database.ShowExpiredStews(currentDate);

            Console.ReadKey();
        }
    }
}

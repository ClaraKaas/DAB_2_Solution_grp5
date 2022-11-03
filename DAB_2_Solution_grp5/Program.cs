using System.Linq;
using System;
using Microsoft.EntityFrameworkCore;
using DAB_2_Solution_grp5.Data;




namespace DAB_2_Solution_grp5.Data
{
    class Program
    {
        static void Main()
        {
            MyDbContext db = new MyDbContext();

            

            Console.WriteLine("Start");

            System.Console.WriteLine("Should we seed data? Y/n");
            ConsoleKeyInfo consoleKeyInfo = Console.ReadKey();
            if (consoleKeyInfo.KeyChar == 'Y')
            {
                SeedData.SeedDatabase();
            }

            System.Console.WriteLine("\n" + "Show all products Y/n" );
            consoleKeyInfo = Console.ReadKey();
            if (consoleKeyInfo.KeyChar == 'Y')
            {
                ShowAllData(db, 'X');
            }
            System.Console.WriteLine("\n" + "List all Facilities(F), Users(U), Activities(A)");
            consoleKeyInfo = Console.ReadKey();
            if (consoleKeyInfo.KeyChar == 'p' || consoleKeyInfo.KeyChar == 'l' || consoleKeyInfo.KeyChar == 'm')
            {
                ShowAllData(db, consoleKeyInfo.KeyChar);
            }
            Console.WriteLine("\n" + "Slut");


            

            
        }


        private static void ShowAllData(MyDbContext db, char c)
        { 
             switch (c)
            {
                case 'X':
                    ListAllFacilities(db);
                    ListAllUsers(db);
                    ListAllActivities(db);
                    break;

                case 'F':
                    ListAllFacilities(db);
                    break;

                case 'U':
                    ListAllUsers(db);
                    break;

                case 'A':
                    ListAllActivities(db);
                    break;
            }
        }
        private static void ListAllFacilities(MyDbContext db)
        {
            foreach (var pc in db.facilities.Include(p => p.Bookings).ToList())
            {
                Console.WriteLine(pc);
            }
        }

        private static void ListAllUsers(MyDbContext db)
        {
            foreach (var user in db.users)
            {
                Console.WriteLine(user.UserId);
            }
        }

        private static void ListAllActivities(MyDbContext db)
        {
            foreach (var pc in db.activities.Include(p => p.Bookings).ToList())
            {
                Console.WriteLine(pc);
            }
        }

    }
}

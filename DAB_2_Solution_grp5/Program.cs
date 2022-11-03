using System.Linq;
using System;
using Microsoft.EntityFrameworkCore;
using DAB_2_Solution_grp5.Data;
using DAB_2_Solution_grp5.Models;




namespace DAB_2_Solution_grp5
{
    public class Program
    {
        public static void Main(string[] args)
        {

            using (var db = new MyDbContext())
            {
                System.Console.WriteLine("Should we seed data? Y/n");
                ConsoleKeyInfo consoleKeyInfo = Console.ReadKey();
                if (consoleKeyInfo.KeyChar == 'Y')
                {
                    SeedData.SeedDatabase();
                }

                System.Console.WriteLine("Show all products Y/n");
                consoleKeyInfo = Console.ReadKey();
                if (consoleKeyInfo.KeyChar == 'Y')
                {
                    FacilityList(db);
                }

               /* System.Console.WriteLine("List all Pcs(p), Laptops(l), Printers(m)");
                consoleKeyInfo = Console.ReadKey();
                if (consoleKeyInfo.KeyChar == 'p' || consoleKeyInfo.KeyChar == 'l' || consoleKeyInfo.KeyChar == 'm')
                {
                    ShowAllProducts(db, consoleKeyInfo.KeyChar);
                } */

                System.Console.WriteLine("Quiting...");
            }
        }

       /* private static void ShowAllProducts(MyDbContext db, char c)
        {
            switch (c)
            {
                case 'a':
                    ListAllPcs(db);
                    ListAllLaptops(db);
                    ListAllPrinters(db);
                    break;

                case 'p':
                    ListAllPcs(db);
                    break;

                case 'l':
                    ListAllLaptops(db);
                    break;

                case 'm':
                    ListAllPrinters(db);
                    break;
            }
        } */


        
      
      /* static void FacilityList(MyDbContext db)
        {
            var facilityList = db.facilities.Include(x => x.FacilityId).ToList();

            foreach (var facilities in facilityList)
            {
                Console.WriteLine(facilities.Name);
            }
        } */

        private static void FacilityList(MyDbContext db)
        {
            foreach (var pc in db.facilities.Include(p => p.Bookings).ToList())
            {
                System.Console.WriteLine(pc);
            }
        }


    }
}

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

            SeedData.SeedDatabase();

            Console.WriteLine("Hej");

           


        }
      



    }
}

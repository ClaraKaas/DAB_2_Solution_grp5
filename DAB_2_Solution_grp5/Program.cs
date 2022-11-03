using System.Linq;
using System;
using Microsoft.EntityFrameworkCore;
using DAB_2_Solution_grp5.Data;




namespace DAB_2_Solution_grp5.Data
{
    class Program
    {
        static void Main(string[] args)
        {
            using var db = new MyDbContext();

            Console.WriteLine("Hello World!");
            var facility = db.Facility.
                OrderBy(b => b.FacilityId)
                .First();


           


        }
      



    }
}

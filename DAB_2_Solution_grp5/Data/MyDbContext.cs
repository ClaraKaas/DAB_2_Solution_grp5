using System;
using System.Collections.Generic;
using System.Linq;
using DAB_2_Solution_grp5.Models;
using System.Reflection.Emit;
using Microsoft.EntityFrameworkCore;


namespace DAB_2_Solution_grp5.Data
{
    public class MyDbContext : DbContext
    {
        //public MyDbContext(DbContextOptions<MyDbContext> options) : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("REPLACE_WITH_A_USEFULL_CONNECTION_STRING");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Author
            modelBuilder.Entity<Author>().HasKey(a => new { a.FirstName, a.LastName });

            // Book
            modelBuilder.Entity<Book>().HasKey(b => b.Isbn);
            modelBuilder.Entity<Book>() // One to many
                .HasMany<Review>(b => b.Reviews)
                .WithOne(r => r.Book)
                .HasForeignKey(r => r.BookIsbn);
            modelBuilder.Entity<Book>()
                .HasDiscriminator<string>("type")
                .HasValue<Book>("book")
                .HasValue<PriceOffer>("PriceOffer");


            // PriceOffer
            // Reivew

            // BookAuthors (many to many)
            modelBuilder.Entity<BookAuthors>()
                .HasOne(ba => ba.Book)
                .WithMany(b => b.BookAuthors)
                .HasForeignKey(ba => ba.BookIsbn);
            modelBuilder.Entity<BookAuthors>()
                .HasOne(ba => ba.Author)
                .WithMany(a => a.BookAuthors)
                .HasForeignKey(ba => new { ba.AuthorFirstName, ba.AuthorLastName });

        }

    }
}
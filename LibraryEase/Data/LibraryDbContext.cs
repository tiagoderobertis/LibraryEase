using LibraryEase.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LibraryEase.Data
{
    public class LibraryDbContext : DbContext
    {

        public DbSet<Book> Books { get; set; }
        public DbSet<Loan> Loans { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) => optionsBuilder.UseSqlite("Data source=LibEase.db");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Loan>() // the entity Loan
            .HasOne(l => l.Books) // Has only one Book
            .WithMany(b => b.Loans) // And one book has many loans
            .HasForeignKey(l => l.Books); // Loan has the foreign key of the book loaned.
        }



    }
}

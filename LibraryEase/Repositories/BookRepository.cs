using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using LibraryEase.Data;
using LibraryEase.Models;
using Microsoft.EntityFrameworkCore;

namespace LibraryEase.Repositories
{
    public class BookRepository<Book> : IBookRepository
    {

        private readonly LibraryDbContext context;
        public BookRepository(LibraryDbContext Context)
        {
            context = Context;
        }

        // Gets the availability of a given book.
        public int? GetBookAvailability(int bookId)
        {

            // Try to find the book in the database
            var exists = context.Books.FirstOrDefault(x => x.BookId == bookId);

            if (exists != null)
            {
                // If the book exists, return its availability
                return exists.Availability;
            }
            else
            {
                // If the book does not exist, return null
                return null;
            }

        }

        public List<int> GetBooksByAuthor(string authorName)
        {
            return SearchBooks(authorName, "Author");
        }

        public List<int> GetBooksByGenre(string genre)
        {
            return SearchBooks(genre, "Genre");
        }

        public List<int> GetBooksByTitle(string title)
        {


            return SearchBooks(title, "Title");
        }

        public List<int> GetBooksByYear(int year)
        {
            return SearchBooks(year.ToString(), "Year");
        }

        // This private method searches for books based on a search value and a specified property name.
        // It returns a list of book IDs that match the search criteria.
        private List<int> SearchBooks(string searchValue, string propertyName)
        {
            // Query the 'Books' DbSet from the context using LINQ to filter the books.
            return context.Books
                // Use the 'Where' method to filter books where the specified property contains the search value.
                .Where(x =>
                    // Get the property info of the specified property name from the book object.
                    x.GetType().GetProperty(propertyName)
                    // Get the value of the specified property for the current book object.
                    .GetValue(x)
                    // Convert the property value to a string and check if it contains the search value 
                    // (case-insensitive comparison).
                    .ToString().Contains(searchValue, StringComparison.OrdinalIgnoreCase)
                )
                // Select the 'BookId' property of the filtered books.
                .Select(x => x.BookId)
                // Convert the result to a list of integers, which are the IDs of the matching books.
                .ToList();
        }

    }
}

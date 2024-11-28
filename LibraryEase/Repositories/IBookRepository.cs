using LibraryEase.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryEase.Repositories
{
    public interface IBookRepository {
        List<int> GetBooksByTitle (string title);
        List<int> GetBooksByGenre(string genre);
        List<int> GetBooksByAuthor (string authorName);
        List<int> GetBooksByYear(int year);
        int? GetBookAvailability(int bookId);
    }
}

using LibraryEase.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryEase.Repositories
{
    interface ILoanRepository<T> where T : class
    {

        int activeLoansCount();
        List<string> activeLoansDetails();

        List<string> booksOnLoan();

    }
}

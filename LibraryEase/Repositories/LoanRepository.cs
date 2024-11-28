using LibraryEase.Data;
using LibraryEase.Models;
using Microsoft.Extensions.DependencyModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryEase.Repositories
{
    public class LoanRepository<T> : ILoanRepository<T> where T : class
    {

        public int activeLoansCount()
        {
            using var context = new LibraryDbContext(); // me aseguro de que el Dispose() sea automatico
            var loanRepo = new Repository<Loan>(context); // instancia de repositorio generico

            List<Loan> loans = loanRepo.GetAll(); // obtener todos los prestamos en una lista

            int activeLoansCount = 0;
            foreach (var activeLoan in loans) {
                if (activeLoan.IsReturned == false)
                {
                    activeLoansCount++;
                }
            }
            return activeLoansCount;
        }

        public List<string> activeLoansDetails()
        {
            using var context = new LibraryDbContext(); // me aseguro de que el Dispose() sea automatico
            var loanRepo = new Repository<Loan>(context); // instancia de repositorio generico

            List<Loan> loans = loanRepo.GetAll(); // obtener todos los prestamos en una lista

            var activeLoansDetailed = new List<string>();
            string loanDetails = string.Empty;
            foreach(var activeLoan in loans)
            {
                if (activeLoan.IsReturned == false)
                {
                    loanDetails += "Nombre del prestatario: " + activeLoan.Loaner.ToString() + "\nFecha de inicio del prestamo: " + activeLoan.StartLoan.ToString() + "\nFecha de finalizacion del prestamo: " + activeLoan.EndLoan.ToString() + "\nId de libro prestado: " + activeLoan.BookId.ToString() + "\n---";
                    activeLoansDetailed.Add(loanDetails);
                }
            }

            return activeLoansDetailed;
        }

        public List<string> booksOnLoan()
        {
            using var context = new LibraryDbContext();
            var loanRepo = new Repository<Loan>(context);

            List<Loan> loans = loanRepo.GetAll();

            var booksOnLoan = new List<string>();
            foreach (var loan in loans)
            {
                if (!loan.IsReturned)
                {
                    booksOnLoan.Add(loan.BookId.ToString());
                }
            }

            return booksOnLoan;
        }


    }
}

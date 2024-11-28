using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryEase.Models
{
    public class Loan
    {


        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int LoanId { get; set; }
        [Required]
        public string Loaner { get; set; } = string.Empty;
        [Required]
        public DateTime StartLoan { get; set; }
        [Required]
        public DateTime EndLoan { get; set; }
        [Required]
        public bool IsReturned { get; set; }        
        [Required]
        public int BookId { get; set; }
        public Book Books { get; set; } = new Book();

    }
}

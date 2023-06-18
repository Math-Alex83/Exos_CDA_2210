using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APIBanque.Models
{
    public class BankTransaction
    {
        [Key]
        [Column("transaction_id")]
        public int Id { get; set; }

        [Required]
        [Column("transaction_date")]
        public DateTime Date { get; set; }

        [Required]
        [Column("transaction_from")]
        [Range(10000000000,99999999999)]
        public long From { get; set; }

        [Required]
        [Column("transaction_to")]
        [Range(10000000000, 99999999999)]
        public long To { get; set; }

        [Required]
        [Column("transaction_amount")]
        [Range(1,99000, ErrorMessage = "Le montant n'est pas valide")]
        [Precision(7,2)]
        public decimal Amount { get; set; } 

    }
}
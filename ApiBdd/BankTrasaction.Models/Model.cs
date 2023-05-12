using MathNet.Numerics;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BankTrasaction.Models
{
    public class Model
    {
        [Key]
        [Column("Transaction Id")]
        public int Id { get; set; }

        [Required]
        [Column("Transaction Date")]
        public DateTime Date { get; set; }

        [Required]
        [Column("Transaction From")]
        public long From { get; set; }

        [Required]
        [Column("Transaction To")]
        public long To { get; set; }

        [Required]
        [Column("Transaction Amount")]
        public Precision Amount { get; set; }
    }
}
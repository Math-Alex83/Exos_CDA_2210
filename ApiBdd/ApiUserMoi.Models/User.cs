using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiUserMoi.Models
{
    [Table("Users")]
    public class User : Model
    {
        // respect de la convention pour rentre nullable, le "?" coller au Type.
        //[Column("user_name")]
        [Required]
        [MaxLength(16, ErrorMessage ="DTC")]
        [StringLength(16)]
        public string? UserName { get; set; }

        public string? PassWord { get; set; }


    }
}
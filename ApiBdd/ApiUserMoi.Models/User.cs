using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiUserMoi.Models
{
    [Table("Users")]
    public class User : Model
    {
        // respect de la convention pour rentre nullable, le "?" coller au Type.
        //[Column("user_name")]
        [Required(ErrorMessage = "Le nom de l'utilisateur est requis")]
        // [MaxLength(16, ErrorMessage ="DTC")]
        [StringLength(16, ErrorMessage = "")]
        [RegularExpression(@"^[a-zA-Z]+(?:\-[a-zA-Z]+)?$")]
        public string? UserName { get; set; }


        [Required(ErrorMessage ="Le mots de passe est dans.....")]
        public string? Password { get; set; }


    }
}
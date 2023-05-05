using System.ComponentModel.DataAnnotations;

namespace CerealsApiCours.Models
{
    public class Cereal
    {
        // Par convention une clé primaire est obligatoire et unique donc pas besoin de rajouter [Required] , [Key] pour spécifier que c'est une clé.

        [Key]
        public int CerealId { get; set; }

        // [Required] = Obligatoire
        [Required]
        public string Name { get; set; }


        [Required]
        public int Calories { get; set; }

    }
}

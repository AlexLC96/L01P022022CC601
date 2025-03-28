using System.ComponentModel.DataAnnotations;
namespace L01P022022CC601.Models
{
    public class alumnos
    {
        [Key]
        [Display(Name = "Id")]
        public int id { get; set; }

        [Required(ErrorMessage = "El código NO es opcional")]
        [Display(Name = "Código")]
        public string codigo { get; set; }

        [Required(ErrorMessage = "El nombre NO es opcional")]
        [Display(Name = "Nombre")]
        public string nombre { get; set; }

        [Required(ErrorMessage = "El apellido NO es opcional")]
        [Display(Name = "Apellidos")]
        public string apellidos { get; set; }

        [Required(ErrorMessage = "El DUI NO es opcional")]
        [Display(Name = "DUI")]
        public int dui { get; set; }

        [Required(ErrorMessage = "El estado NO es opcional")]
        [Display(Name = "Estado")]
        public int estado { get; set; } 
    }
}

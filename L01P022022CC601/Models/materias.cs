using System.ComponentModel.DataAnnotations;
namespace L01P022022CC601.Models
{
    public class materias
    {
        [Key]
        [Display(Name = "Id")]
        public int id { get; set; }

        [Required(ErrorMessage = "El nombre NO es opcional")]
        [Display(Name = "Nombre")]
        public string materia { get; set; }

        [Required(ErrorMessage = "Este campo NO es opcional")]
        [Display(Name = "Unidades valorativas")]
        public int unidades_valorativas { get; set; }

        [Required(ErrorMessage = "El estado NO es opcional")]
        [Display(Name = "Estado")]
        public string estado { get; set; }

    }
}

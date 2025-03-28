﻿using System.ComponentModel.DataAnnotations;
namespace L01P022022CC601.Models
{
    public class facultades
    {
        [Key]
        [Display(Name = "Id")]
        public int id { get; set; }

        [Required(ErrorMessage = "El nombre NO es opcional")]
        [Display(Name = "Nombre")]
        public string facultad { get; set; }
    }
}

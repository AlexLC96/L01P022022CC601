﻿using System.ComponentModel.DataAnnotations;
namespace L01P022022CC601.Models
{
    public class facultades
    {
        [Key]
        public int id { get; set; }
        public string facultad { get; set; }
    }
}

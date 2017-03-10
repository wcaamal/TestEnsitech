using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EnsitechTest.Models
{
    public class Origin
    {
        [Required]
        [StringLength(50, ErrorMessage = "El {0} debe ser menos de {2} caracteres")]
        [Display(Name = "Procedencia")]
        public string name { get; set; }
    }
}
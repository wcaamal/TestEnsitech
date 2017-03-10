using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EnsitechTest.Models
{
    public class ProductViewModel
    {
        [Required]
        [StringLength(100, ErrorMessage = "El {0} debe ser menos de {2} caracteres")]
        [Display(Name = "Producto")]
        public string name { get; set; }

        [Required]
        [Display(Name = "Precio")]
        public double price { get; set; }

        [Required]
        [Display(Name = "Procedencia")]
        public List<string> origins { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "El {0} debe ser menos de {2} caracteres")]
        [Display(Name = "Lugar de Procedencia")]
        public string origin { get; set; }
    }
}
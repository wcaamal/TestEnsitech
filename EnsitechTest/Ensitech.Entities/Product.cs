using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Ensitech.Entities
{
    public class Product
    {
        [Required]
        [StringLength(100, ErrorMessage = "El campo Producto debe ser menos de 100 caracteres")]
        [Display(Name = "Producto")]
        public string name { get; set; }

        [Required]
        [Range(0, double.MaxValue, ErrorMessage = "Ingrese un Precio valido")]
        [Display(Name = "Precio")]
        public double price { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "El campo Procesdencia debe ser menos de 50 caracteres")]
        [Display(Name = "Procedencia")]
        public string origin { get; set; }
    }
}

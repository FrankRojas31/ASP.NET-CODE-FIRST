﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace Sistemawebcf.Models
{
    public class Categoria
    {
        public int idcategoria { get; set; }

        [Display(Name="Nombre")]
        [Required(ErrorMessage ="Ingrese un nombre")]
        [StringLength(50, MinimumLength = 3,
            ErrorMessage ="El nombre no debe tener más de 50 caracteres, ni menos de 3")]
        public string nombre { get; set; }

        [StringLength(255, 
            ErrorMessage ="La descripción no puede tener más de 255 caracteres")]

        [Display(Name = "Descripción")]
        public string descripcion { get; set; }

        [Display(Name = "Estado")]
        public bool? estado { get; set; }

        public virtual ICollection<Producto> productos { get; set; }
    }
}

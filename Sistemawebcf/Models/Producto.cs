using System.ComponentModel.DataAnnotations;

namespace Sistemawebcf.Models
{
    public class Producto
    {
        public int idproducto { get; set; }

        [Required(ErrorMessage ="Seleccione una categoria")]
        public int idcategoria { get; set; }

        [Display(Name = "Codigo de Barras")]
        [StringLength(64,
            ErrorMessage = "El codigo debe ser menor a 64 caracteres")]
        public string codigo { get; set; }

        [Display(Name = "Nombre")]
        [Required(ErrorMessage = "Ingrese un nombre")]
        [StringLength(100, MinimumLength =3,
            ErrorMessage ="El nombre no puede tener mas de 100 caracteres, ni menos de 3")]
        public string nombre { get; set; }

        [Display(Name = "Precio de Venta")]
        [Required(ErrorMessage ="Ingrese el precio de venta")]
        public decimal precio_venta { get; set; }

        [Display(Name = "Stock")]
        [Required(ErrorMessage ="Ingresa un Stock")]
        public int stock { get; set; }


        [Display(Name = "Descripción")]
        [StringLength(255,
            ErrorMessage = "La descripción no puede tener más de 255 caracteres")]
        public string descripcion { get; set; }

        [Display(Name = "Estado")]
        public bool? estado { get; set; }

        [Display(Name ="Categoria")]
        public virtual Categoria categoria { get; set; }
    }
}

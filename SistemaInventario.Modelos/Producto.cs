using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaInventario.Modelos
{
    public class Producto
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "El numero de serie es requerido")]
        [MaxLength(60, ErrorMessage = "Número de serie debe tener un máximo de 60 caracteres")]

        public string NumeroSerie { get; set; }

        [Required(ErrorMessage = "La descripción es requerida")]
        [MaxLength(100, ErrorMessage = "La descripción debe tener un maximo de 100 caracteres")]
       
        public string Descripcion { get; set; }

        [Required(ErrorMessage = "El precio es requerido")]
        public double Precio { get; set; }

        [Required(ErrorMessage = "El costo es requerido")]
        public double Costo { get; set; }

        public string ImagenUrl { get; set; }

        [Required(ErrorMessage = "El estado es requerido")]
        public bool Estado { get; set; }

        // Seccion de FKs

        [Required(ErrorMessage = "La categoría es requerida")]
        public int CategoriaId { get; set; }

        [ForeignKey("CategoriaId")]
        public Categoria Categoria { get; set; }

        //

        [Required(ErrorMessage = "La categoría es requerida")]
        public int MarcaId { get; set; }

        [ForeignKey("MarcaId")]
        public Marca Marca { get; set; }

        // Seccion de recurcibidad 

        //? es para que se guarde como un null
        public int? PadreId { get; set; }

        public virtual Producto Padre { get; set; }

    }
}

 
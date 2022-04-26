using System.ComponentModel.DataAnnotations;

namespace Modelos
{
    public class Producto
    {
        [Required(ErrorMessage = "El Campo Codigo es Obligatorio")]
        public string Codigo { get; set; }
        [Required(ErrorMessage = "El Campo Descripcion es Obligatorio")]
        public string Descripcion { get; set; }
        public decimal Precio { get; set; }
        public int Existencia { get; set; }
        public byte[] Imagen { get; set; }
    }
}

using System.ComponentModel.DataAnnotations;

namespace PruebaTecnica02FJMAJueves22.Models
{
    public class Celulares
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public decimal Precio {  get; set; }
        public byte[]? Imagen {  get; set; }
        [Display(Name = "Marca")]
        public int MarcaId { get; set; }

        public virtual Marcas Marcas { get; set; } = null!;
    }
}

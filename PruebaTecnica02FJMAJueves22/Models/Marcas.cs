using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PruebaTecnica02FJMAJueves22.Models
{
    public class Marcas
    {
        public Marcas()
        {
            Celular = new HashSet<Celulares>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required(ErrorMessage ="El campo {0} es obligatorio")]
        [MinLength(5), MaxLength(30)]
        public string Nombre { get; set; }

        public virtual ICollection<Celulares> Celular { get; set; }
    }
}

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Gran_ve_culos.Models
{
    [Table("Marca")]
    public class Marca
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(30)]
        public string Nome { get; set; }
    }
}
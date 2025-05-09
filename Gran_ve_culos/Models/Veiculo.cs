using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Gran_ve_culos.Models
{
    [Table("Veiculo")]
    public class Veiculo
    {
        [Key]
        public int ModeloId { get; set; }
        [ForeignKey("ModeloId")]
        public Modelo Modelo { get; set; }

        [Required]
        public short AnoFabricacao { get; set; }

        [Required]
        public short AnoModelo { get; set; }

        [Required]
        public int CorId { get; set; }
        [ForeignKey("CorId")]
        public Cor Cor { get; set; }

        [Required]
        [Column(TypeName = "Numeric(10,2)")]
        public decimal MyProperty { get; set; }

        [StringLength(7)]
        public int Placa { get; set; }


    }
}
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VitalNutri.Models
{
    public class Alimento
    {
        [Key]
        public int AlimentoId { get; set; }
        [Required]
        public string Nome { get; set; }
        [Required]
        public int? Calorias { get; set; }
        [Required]
        public int? Carboidratos { get; set; }
        [Required]
        public int? Gorduras { get; set; }
        [Required]
        public int? Proteinas { get; set; }
        [ForeignKey("NutricionistaId")]
        public int NutricionistaId { get; set; }
        public virtual Nutricionista? Nutricionista { get; set; }
        public ICollection<RefeicaoAlimento>? RefeicoesAlimentos { get; set; }
    }
}

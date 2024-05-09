using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VitalNutri.Models
{
    public class Alimento
    {
        [Key]
        public int AlimentoId { get; set; }
        public string Nome { get; set; }
        public int? Calorias { get; set; }
        public int? Carboidratos { get; set; }
        public int? Gorduras { get; set; }
        public int? Proteinas { get; set; }
        public int NutricionistaId { get; set; }
        [ForeignKey("NutricionistaId")]
        public virtual Nutricionista Nutricionista { get; set; }
        public ICollection<RefeicaoAlimento> RefeicoesAlimentos { get; set; }
    }
}

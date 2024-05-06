using System.ComponentModel.DataAnnotations.Schema;

namespace VitalNutri.Models
{
    public class RefeicaoAlimento
    {
        public int RefeicaoId { get; set; }
        public int AlimentoId { get; set; }

        [ForeignKey("RefeicaoId")]
        public virtual Refeicao Refeicao { get; set; }

        [ForeignKey("AlimentoId")]
        public virtual Alimento Alimento { get; set; }
    }
}

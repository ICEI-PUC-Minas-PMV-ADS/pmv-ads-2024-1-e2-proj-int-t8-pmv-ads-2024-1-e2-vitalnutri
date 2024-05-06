using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace VitalNutri.Models
{
    public class RefeicaoHasAlimentos
    {
        public int RefeicaoId { get; set; }
        public int AlimentoId { get; set; }

        public virtual Refeicao Refeicao { get; set; }
        public virtual Alimento Alimento { get; set; }
    }
}

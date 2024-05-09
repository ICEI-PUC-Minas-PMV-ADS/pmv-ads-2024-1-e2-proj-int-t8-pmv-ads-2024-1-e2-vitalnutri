using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VitalNutri.Models
{
    public class Refeicao
    {
        public int RefeicaoId { get; set; }
        public int PlanoAlimentarId { get; set; }
        [ForeignKey("PlanoAlimentarId")]
        public PlanoAlimentar PlanoAlimentar { get; set; }
        public ICollection<RefeicaoAlimento> RefeicoesAlimentos { get; set; }
    }
}

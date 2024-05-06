using System.ComponentModel.DataAnnotations.Schema;

namespace VitalNutri.Models
{
    public class Treino
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public string Descricao { get; set; }

        public int PlanoDeTreinoId { get; set; }

        [ForeignKey("PlanoDeTreinoId")]
        public virtual PlanoDeTreino PlanoDeTreino { get; set; }
    }
}

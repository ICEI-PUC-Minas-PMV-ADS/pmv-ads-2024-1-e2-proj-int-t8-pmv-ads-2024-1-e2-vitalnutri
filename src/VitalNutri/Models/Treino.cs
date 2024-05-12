using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VitalNutri.Models
{
    public class Treino
    {
        // Propriedades
        public int TreinoId { get; set; }
        public int PlanoTreinoId { get; set; }
            
        [ForeignKey("PlanoTreinoId")]
        public virtual PlanoTreino PlanoTreino { get; set; }
        public ICollection<TreinoExercicio> TreinosExercicios { get; set; }
    }
}

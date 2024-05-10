using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VitalNutri.Models
{
    public class TreinoExercicio
    {
        // Propriedades
        public int TreinoId { get; set; }
        public int ExercicioId { get; set; }
        // Relacionamentos
        [ForeignKey("TreinoId")]
        public virtual Treino Treino { get; set; }
        [ForeignKey("ExercicioId")]
        public virtual Exercicio Exercicio { get; set; }
    }
}

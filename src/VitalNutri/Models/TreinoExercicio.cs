using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VitalNutri.Models
{
    public class TreinoExercicio
    {
        // Propriedades
        [ForeignKey("TreinoId")]
        public int TreinoId { get; set; }

        [ForeignKey("ExercicioId")]
        public int ExercicioId { get; set; }
        // Relacionamentos

        public virtual Treino Treino { get; set; }
        public virtual Exercicio Exercicio { get; set; }
    }
}

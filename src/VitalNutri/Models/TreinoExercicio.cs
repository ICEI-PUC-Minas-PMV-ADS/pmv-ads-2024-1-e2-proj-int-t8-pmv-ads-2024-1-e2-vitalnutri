namespace VitalNutri.Models
{
    public class TreinoExercicio
    {
        // Propriedades
        public int TreinoId { get; set; }
        public int ExercicioId { get; set; }

        // Relacionamentos
        public Treino Treino { get; set; }
        public Exercicio Exercicio { get; set; }
    }
}

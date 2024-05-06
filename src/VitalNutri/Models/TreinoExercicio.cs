namespace VitalNutri.Models
{
    public class TreinoExercicio
    {
        public int TreinoId { get; set; }
        public Treino Treino { get; set; }
        public int ExercicioId { get; set; }
        public Exercicio Exercicio { get; set; }

    }
}

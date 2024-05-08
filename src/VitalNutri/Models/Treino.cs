namespace VitalNutri.Models
{
    public class Treino
    {        // Propriedades
        public int Id { get; set; }
        public int TreinoId { get; set; }

        // Relacionamentos
        public PlanoTreino PlanoTreino { get; set; }
        public ICollection<TreinoExercicio> TreinosExercicios { get; set; }
    }
}

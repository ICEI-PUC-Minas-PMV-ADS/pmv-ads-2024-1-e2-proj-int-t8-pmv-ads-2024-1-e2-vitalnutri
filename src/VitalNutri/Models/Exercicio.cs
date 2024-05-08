namespace VitalNutri.Models
{
    public class Exercicio
    {
        // Propriedades
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public int? TreinadorPessoalId { get; set; }
        public byte[] Imagem { get; set; }

        // Relacionamentos
        public TreinadorPessoal TreinadorPessoal { get; set; }
        public ICollection<TreinoExercicio> TreinosExercicios { get; set; }
    }
}

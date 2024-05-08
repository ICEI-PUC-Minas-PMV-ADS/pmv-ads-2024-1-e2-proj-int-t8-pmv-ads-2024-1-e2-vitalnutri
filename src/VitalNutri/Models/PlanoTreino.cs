namespace VitalNutri.Models
{
    public class PlanoTreino
    {
        // Propriedades
        public int Id { get; set; }
        public int TreinadorPessoalId { get; set; }
        public string Descricao { get; set; }
        public string Nome { get; set; }
        public string Serie { get; set; }
        public string Exercicio { get; set; }
        public int Carga { get; set; }
        public int Repeticoes { get; set; }
        public int ClienteId { get; set; }

        // Relacionamentos
        public TreinadorPessoal TreinadorPessoal { get; set; }
        public Cliente Cliente { get; set; }
        public List<Treino> Treinos { get; set; }
    }
}

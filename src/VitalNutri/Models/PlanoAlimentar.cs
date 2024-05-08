namespace VitalNutri.Models
{
    public class PlanoAlimentar
    {
        // Propriedades
        public int Id { get; set; }
        public string Nome { get; set; }
        public int? NutricionistaId { get; set; }
        public TimeSpan? Horario { get; set; }
        public string Alimento { get; set; }
        public string Quantidade { get; set; }
        public int ClienteId { get; set; }

        // Relacionamentos
        public Nutricionista Nutricionista { get; set; }
        public Cliente Cliente { get; set; }
        public ICollection<Refeicao> Refeicoes { get; set; }
    }
}

namespace VitalNutri.Models
{
    public class Alimento
    {
        // Propriedades
        public int Id { get; set; }
        public string Nome { get; set; }
        public int? Calorias { get; set; }
        public int? Carboidratos { get; set; }
        public int? Gorduras { get; set; }
        public int? Proteinas { get; set; }
        public int NutricionistaId { get; set; }

        // Relacionamentos

        public Nutricionista Nutricionista { get; set; }
        public ICollection<RefeicaoAlimento> RefeicoesAlimentos { get; set; }
    }
}

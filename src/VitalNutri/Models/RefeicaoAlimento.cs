namespace VitalNutri.Models
{
    public class RefeicaoAlimento
    {
        // Propriedades
        public int RefeicaoId { get; set; }
        public int AlimentoId { get; set; }

        // Relacionamentos
        public Refeicao Refeicao { get; set; }
        public Alimento Alimento { get; set; }
    }
}

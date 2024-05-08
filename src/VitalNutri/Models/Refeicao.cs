namespace VitalNutri.Models
{
    public class Refeicao
    {
        // Propriedades
        public int Id { get; set; }
        public int PlanoAlimentarId { get; set; }

        // Relacionamentos

        public PlanoAlimentar PlanoAlimentar { get; set; }
        public ICollection<RefeicaoAlimento> RefeicoesAlimentos { get; set; }
    }
}

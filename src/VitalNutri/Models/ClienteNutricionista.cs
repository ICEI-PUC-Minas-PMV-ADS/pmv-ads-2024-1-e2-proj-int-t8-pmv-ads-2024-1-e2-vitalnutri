namespace VitalNutri.Models
{
    public class ClienteNutricionista
    {
        // Propriedades
        public int ClienteId { get; set; }
        public Cliente Cliente { get; set; }

        public int NutricionistaId { get; set; }
        public Nutricionista Nutricionista { get; set; }
    }
}

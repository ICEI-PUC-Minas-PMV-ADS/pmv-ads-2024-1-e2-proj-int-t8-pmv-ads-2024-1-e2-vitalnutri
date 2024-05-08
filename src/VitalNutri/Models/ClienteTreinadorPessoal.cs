namespace VitalNutri.Models
{
    public class ClienteTreinadorPessoal
    {
        public int ClienteId { get; set; }
        public Cliente Cliente { get; set; }

        public int TreinadorPessoalId { get; set; }
        public TreinadorPessoal TreinadorPessoal { get; set; }
    }
}

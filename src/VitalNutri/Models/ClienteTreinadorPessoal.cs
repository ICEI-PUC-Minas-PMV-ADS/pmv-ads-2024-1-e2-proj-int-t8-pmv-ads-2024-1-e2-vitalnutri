using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VitalNutri.Models
{
    public class ClienteTreinadorPessoal
    {
        public int ClienteId { get; set; }
        public int TreinadorPessoalId { get; set; }
        [ForeignKey("ClienteId")]
        public virtual Cliente Cliente { get; set; }
        [ForeignKey("TreinadorPessoalId")]
        public virtual TreinadorPessoal TreinadorPessoal { get; set; }
    }
}

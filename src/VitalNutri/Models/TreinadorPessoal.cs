using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VitalNutri.Models
{
    public class TreinadorPessoal
    {
        // Propriedades
        [Key]
        public int TreinadorPessoalId { get; set; }
        public string? NumeroRegistro { get; set; }
        public string? Especializacao { get; set; }
        public string Id { get; set; }
        [ForeignKey("Id")]
        public virtual Usuario Usuario { get; set; }
        public ICollection<PlanoTreino>? PlanosTreino { get; set; }
        public ICollection<ClienteTreinadorPessoal>? ClientesTreinadoresPessoais { get; set; }
    }
}

using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VitalNutri.Models
{
    public class Cliente
    {
        [Key]
        public int ClienteId { get; set; }
        public double? Peso { get; set; }
        public double? Altura { get; set; }
        public double? MetaPeso { get; set; }
        public string Id { get; set; }
        [ForeignKey("Id")]
        public virtual Usuario Usuario { get; set; }
        public ICollection<PlanoTreino>? PlanosTreino { get; set; }
        public ICollection<PlanoAlimentar>? PlanosAlimentares { get; set; }
        public ICollection<ClienteNutricionista>? ClientesNutricionistas { get; set; }
        public ICollection<ClienteTreinadorPessoal>? ClientesTreinadoresPessoais { get; set; }
    }
}

using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VitalNutri.Models
{
    public class Nutricionista
    {
        [Key]
        public int NutricionistaId { get; set; }
        public string? NumeroRegistro { get; set; }
        public string? Especializacao { get; set; }
        public string Id { get; set; }
        [ForeignKey("Id")]
        public virtual Usuario Usuario { get; set; }
        public ICollection<PlanoAlimentar>? PlanosAlimentares { get; set; }
        public ICollection<ClienteNutricionista>? ClientesNutricionistas { get; set; }
    }
}

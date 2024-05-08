using Microsoft.AspNetCore.Identity;

namespace VitalNutri.Models
{
    public class Nutricionista
    {
        // Propriedades
        public int Id { get; set; }
        public string NumeroRegistro { get; set; }
        public string Especializacao { get; set; }
        public int UsuarioId { get; set; }

        // Relacionamentos
        public Usuario Usuario { get; set; }
        public ICollection<PlanoAlimentar> PlanosAlimentares { get; set; }
        public ICollection<ClienteNutricionista> ClientesNutricionistas { get; set; }
    }
}

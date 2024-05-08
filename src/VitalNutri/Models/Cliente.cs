using Microsoft.AspNetCore.Identity;

namespace VitalNutri.Models
{
    public class Cliente
    {
        // Propriedades
        public int Id { get; set; }
        public double Peso { get; set; }
        public double Altura { get; set; }
        public double MetaPeso { get; set; }
        public int UsuarioId { get; set; }

        // Relacionamentos
        public Usuario Usuario { get; set; }
        public ICollection<PlanoTreino> PlanosTreino { get; set; }
        public ICollection<PlanoAlimentar> PlanosAlimentares { get; set; }
        public ICollection<ClienteNutricionista> ClientesNutricionistas { get; set; }
        public ICollection<ClienteTreinadorPessoal> ClientesTreinadoresPessoais { get; set; }
    }
}

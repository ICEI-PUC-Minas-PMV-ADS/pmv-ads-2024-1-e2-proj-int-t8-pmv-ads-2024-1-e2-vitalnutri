using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VitalNutri.Models
{
    public class Cliente
    {
        public int Id { get; set; }

        public int? UsuarioId { get; set; }

        [ForeignKey("UsuarioId")]
        public virtual Usuario Usuario { get; set; }

        public int? NutricionistaId { get; set; }

        [ForeignKey("NutricionistaId")]
        public virtual Nutricionista Nutricionista { get; set; }

        public int? TreinadorPessoalId { get; set; }

        [ForeignKey("TreinadorPessoalId")]
        public virtual TreinadorPessoal TreinadorPessoal { get; set; }

        public bool? PossuiAcompanhamentoNutricionista { get; set; }

        public bool? PossuiAcompanhamentoPersonal { get; set; }

        public bool? PossuiPlanoAlimentar { get; set; }

        public bool? PossuiPlanoTreino { get; set; }

        public double? Peso { get; set; }

        public double? Altura { get; set; }

        public double? MetaPeso { get; set; }
    }
}

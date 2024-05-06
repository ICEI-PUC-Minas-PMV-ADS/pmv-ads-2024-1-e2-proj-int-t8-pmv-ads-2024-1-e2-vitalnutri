using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VitalNutri.Models
{
    public class TreinadorPessoal
    {
        public int Id { get; set; }

        public int? UsuarioId { get; set; }

        [ForeignKey("UsuarioId")]
        public virtual Usuario Usuario { get; set; }

        public string NumeroRegistro { get; set; }

        public string Especializacao { get; set; }

        // Relacionamentos
        public virtual ICollection<PlanoDeTreino> PlanosDeTreino { get; set; }
    }
}

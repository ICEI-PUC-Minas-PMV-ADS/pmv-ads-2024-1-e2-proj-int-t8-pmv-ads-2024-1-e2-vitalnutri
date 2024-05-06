using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VitalNutri.Models
{
    public class PlanoDeTreino
    {
        public int Id { get; set; }

        public int? TreinadorPessoalId { get; set; }

        [ForeignKey("TreinadorPessoalId")]
        public virtual TreinadorPessoal TreinadorPessoal { get; set; }

        public string Descricao { get; set; }

        public string Nome { get; set; }

        public string Serie { get; set; }

        public string Exercicio { get; set; }

        public int? Carga { get; set; }

        public int? Repeticoes { get; set; }

        // Relacionamentos
        public virtual ICollection<Treino> Treinos { get; set; }
    }
}

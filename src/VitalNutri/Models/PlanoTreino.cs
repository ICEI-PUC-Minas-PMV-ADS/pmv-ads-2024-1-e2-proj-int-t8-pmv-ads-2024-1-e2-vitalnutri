using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VitalNutri.Models
{
    public class PlanoTreino
    {
        [Key]
        public int PlanoTreinoId { get; set; }
        public int TreinadorPessoalId { get; set; }
        public string Descricao { get; set; }
        public string Nome { get; set; }
        public string Serie { get; set; }
        public string Exercicio { get; set; }
        public int Carga { get; set; }
        public int Repeticoes { get; set; }
        public int ClienteId { get; set; }
        [ForeignKey("TreinadorPessoalId")]
        public virtual TreinadorPessoal TreinadorPessoal { get; set; }
        [ForeignKey("ClienteId")]
        public virtual Cliente Cliente { get; set; }
        public List<Treino> Treinos { get; set; }
    }
}

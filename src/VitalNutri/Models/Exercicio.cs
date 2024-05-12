using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VitalNutri.Models
{
    public class Exercicio
    {
        [Key]
        public int ExercicioId { get; set; }
        [Required]
        public string Nome { get; set; }
        [Required]
        public string? Descricao { get; set; }
        [ForeignKey("TreinadorPessoalId")]
        public int TreinadorPessoalId { get; set; }
        public byte[]? Imagem { get; set; }
        public virtual TreinadorPessoal? TreinadorPessoal { get; set; }
        public ICollection<TreinoExercicio>? TreinosExercicios { get; set; }
    }
}

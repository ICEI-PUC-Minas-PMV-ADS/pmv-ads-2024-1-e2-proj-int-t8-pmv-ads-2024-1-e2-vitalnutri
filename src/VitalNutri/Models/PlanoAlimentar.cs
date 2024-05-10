using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VitalNutri.Models
{
    public class PlanoAlimentar
    {
        [Key]
        public int PlanoAlimentarId { get; set; }
        public string Nome { get; set; }
        public int? NutricionistaId { get; set; }
        public TimeSpan? Horario { get; set; }
        public string Alimento { get; set; }
        public string Quantidade { get; set; }
        public int ClienteId { get; set; }
        [ForeignKey("NutricionistaId")]
        public virtual Nutricionista Nutricionista { get; set; }
        [ForeignKey("ClienteId")]
        public virtual Cliente Cliente { get; set; }
        public ICollection<Refeicao> Refeicoes { get; set; }
    }
}

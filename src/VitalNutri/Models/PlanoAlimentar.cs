using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VitalNutri.Models
{
    public class PlanoAlimentar
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public int? NutricionistaId { get; set; }

        [ForeignKey("NutricionistaId")]
        public virtual Nutricionista Nutricionista { get; set; }

        public TimeSpan? Horario { get; set; }

        public string Alimento { get; set; }

        public string Quantidade { get; set; }

        // Relacionamentos
        public virtual ICollection<Refeicao> Refeicoes { get; set; }
    }
}

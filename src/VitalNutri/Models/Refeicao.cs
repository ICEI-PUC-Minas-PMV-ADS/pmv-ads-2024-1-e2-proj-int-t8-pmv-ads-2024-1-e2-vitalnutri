using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VitalNutri.Models
{
    public class Refeicao
    {
        public int Id { get; set; }

        public int PlanoAlimentarId { get; set; }

        [ForeignKey("PlanoAlimentarId")]
        public virtual PlanoAlimentar PlanoAlimentar { get; set; }
    }
}

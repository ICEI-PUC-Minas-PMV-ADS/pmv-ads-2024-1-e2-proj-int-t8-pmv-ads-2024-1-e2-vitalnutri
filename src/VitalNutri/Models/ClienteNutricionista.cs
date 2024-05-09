using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VitalNutri.Models
{
    public class ClienteNutricionista
    {
        public int ClienteId { get; set; }
        [ForeignKey("ClienteId")]
        public virtual Cliente Cliente { get; set; }     
        public int NutricionistaId { get; set; }
        [ForeignKey("NutricionistaId")]
        public virtual Nutricionista Nutricionista { get; set; }
    }
}

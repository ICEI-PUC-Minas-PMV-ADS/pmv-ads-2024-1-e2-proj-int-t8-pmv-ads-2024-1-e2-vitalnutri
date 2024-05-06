using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace VitalNutri.Models
{
    public class ClienteHasPlanoAlimentar
    {
        public int ClienteId { get; set; }
        public int PlanoAlimentarId { get; set; }

        public virtual Cliente Cliente { get; set; }
        public virtual PlanoAlimentar PlanoAlimentar { get; set; }
    }
}

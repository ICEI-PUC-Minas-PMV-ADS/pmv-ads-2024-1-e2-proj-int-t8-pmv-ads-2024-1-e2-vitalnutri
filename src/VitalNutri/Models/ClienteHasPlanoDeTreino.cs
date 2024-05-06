using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace VitalNutri.Models
{
    public class ClienteHasPlanoDeTreino
    {
        public int ClienteId { get; set; }
        public int PlanoDeTreinoId { get; set; }

        public virtual Cliente Cliente { get; set; }
        public virtual PlanoDeTreino PlanoDeTreino { get; set; }
    }
}

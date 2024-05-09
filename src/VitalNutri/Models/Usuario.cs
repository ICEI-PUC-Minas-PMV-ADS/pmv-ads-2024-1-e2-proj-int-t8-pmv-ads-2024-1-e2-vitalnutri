using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.General;
using System.Runtime.Intrinsics.X86;

namespace VitalNutri.Models
{
    public class Usuario : IdentityUser
    {
        public string TipoUsuario { get; set; }

        // Relacionamentos
        public virtual ICollection<Cliente> Clientes { get; set; }
        public virtual ICollection<TreinadorPessoal> TreinadoresPessoais { get; set; }
        public virtual ICollection<Nutricionista> Nutricionistas { get; set; }
    }
}

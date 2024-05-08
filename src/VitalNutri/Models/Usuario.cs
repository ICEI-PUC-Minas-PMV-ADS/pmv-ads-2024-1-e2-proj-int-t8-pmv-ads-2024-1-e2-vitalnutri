using Microsoft.AspNetCore.Identity;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.General;
using System.Runtime.Intrinsics.X86;

namespace VitalNutri.Models
{
    public class Usuario: IdentityUser
    {
        public string TipoUsuario { get; set; }

        public ICollection<Cliente> Clientes { get; set; }
        public ICollection<TreinadorPessoal> TreinadoresPessoais { get; set; }
        public ICollection<Nutricionista> Nutricionistas { get; set; }
    }
}

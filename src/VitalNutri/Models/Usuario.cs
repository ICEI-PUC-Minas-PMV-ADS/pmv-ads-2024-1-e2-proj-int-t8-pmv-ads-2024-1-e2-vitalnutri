using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;


namespace VitalNutri.Models
{
    public class Usuario : IdentityUser
    {
        [Required(ErrorMessage = "O campo Tipo de Usuário é obrigatório.")]
        public string TipoUsuario { get; set; }

        // Relacionamentos
        public virtual ICollection<Cliente> Clientes { get; set; }
        public virtual ICollection<TreinadorPessoal> TreinadoresPessoais { get; set; }
        public virtual ICollection<Nutricionista> Nutricionistas { get; set; }
    }
}

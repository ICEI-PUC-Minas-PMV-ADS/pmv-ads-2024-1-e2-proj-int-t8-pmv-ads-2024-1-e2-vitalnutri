using Microsoft.AspNetCore.Identity;


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

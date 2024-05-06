using System.ComponentModel.DataAnnotations;

namespace VitalNutri.Models
{
    public class Usuario
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string NomeCompleto { get; set; }

        [Required]
        [StringLength(45)]
        public string NomeUsuario { get; set; }

        [Required]
        [StringLength(45)]
        public string Senha { get; set; }

        [Required]
        [StringLength(45)]
        public string Email { get; set; }

        [Required]
        [StringLength(45)]
        public string Permissoes { get; set; }

        [Required]
        [StringLength(45)]
        public string Ativo { get; set; }

        [StringLength(45)]
        public string Foto { get; set; }

        [StringLength(45)]
        public string Telefone { get; set; }

        [Required]
        public DateTime DataNascimento { get; set; }

        [Required]
        public DateTime DataCriacao { get; set; }

        [Required]
        public DateTime UltimoAcesso { get; set; }

        // Relacionamentos
        public virtual ICollection<Cliente> Clientes { get; set; }
        public virtual ICollection<TreinadorPessoal> TreinadoresPessoais { get; set; }
        public virtual ICollection<Nutricionista> Nutricionistas { get; set; }
    }
}

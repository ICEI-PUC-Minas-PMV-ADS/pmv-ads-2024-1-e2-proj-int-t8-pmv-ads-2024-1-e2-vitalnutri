using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using VitalNutri.Models;

namespace VitalNutri.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public virtual DbSet<Usuario> Usuarios { get; set; }
        public virtual DbSet<TreinadorPessoal> TreinadoresPessoais { get; set; }
        public virtual DbSet<PlanoDeTreino> PlanosDeTreino { get; set; }
        public virtual DbSet<Cliente> Clientes { get; set; }
        public virtual DbSet<Nutricionista> Nutricionistas { get; set; }
        public virtual DbSet<PlanoAlimentar> PlanosAlimentares { get; set; }
        public virtual DbSet<Treino> Treinos { get; set; }
        public virtual DbSet<Exercicio> Exercicios { get; set; }
        public virtual DbSet<Refeicao> Refeicoes { get; set; }
        public virtual DbSet<Alimento> Alimentos { get; set; }
        public virtual DbSet<RefeicaoHasAlimentos> RefeicoesHasAlimentos { get; set; }
        public virtual DbSet<ClienteHasPlanoAlimentar> ClientesHasPlanosAlimentares { get; set; }
        public virtual DbSet<ClienteHasPlanoDeTreino> ClientesHasPlanosDeTreino { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Usuario>()
                .HasMany(u => u.Clientes)
                .WithOne(c => c.Usuario)
                .HasForeignKey(c => c.UsuarioId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Usuario>()
                .HasMany(u => u.TreinadoresPessoais)
                .WithOne(tp => tp.Usuario)
                .HasForeignKey(tp => tp.UsuarioId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Usuario>()
                .HasMany(u => u.Nutricionistas)
                .WithOne(n => n.Usuario)
                .HasForeignKey(n => n.UsuarioId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<ClienteHasPlanoAlimentar>()
            .HasKey(cp => new { cp.ClienteId, cp.PlanoAlimentarId });

            modelBuilder.Entity<ClienteHasPlanoDeTreino>()
            .HasKey(cpt => new { cpt.ClienteId, cpt.PlanoDeTreinoId });

            modelBuilder.Entity<RefeicaoHasAlimentos>()
            .HasKey(rha => new { rha.RefeicaoId, rha.AlimentoId });
        }


    }
}

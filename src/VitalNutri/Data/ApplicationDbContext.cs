using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using VitalNutri.Models;

namespace VitalNutri.Data
{
    public class ApplicationDbContext : IdentityDbContext<IdentityUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        // DbSet para cada uma das entidades
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<TreinadorPessoal> TreinadoresPessoais { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Nutricionista> Nutricionistas { get; set; }
        public DbSet<PlanoTreino> PlanosTreino { get; set; }
        public DbSet<PlanoAlimentar> PlanosAlimentares { get; set; }
        public DbSet<Exercicio> Exercicios { get; set; }
        public DbSet<Refeicao> Refeicoes { get; set; }
        public DbSet<Alimento> Alimentos { get; set; }
        public DbSet<TreinoExercicio> TreinoExercicios { get; set; }
        public DbSet<RefeicaoAlimento> RefeicaoAlimentos { get; set; }
        public DbSet<ClienteNutricionista> ClientesNutricionistas { get; set; }
        public DbSet<ClienteTreinadorPessoal> ClientesTreinadoresPessoais { get; set; }
        // Método para configurar o modelo
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ClienteNutricionista>()
                .HasKey(cn => new { cn.ClienteId, cn.NutricionistaId });

            modelBuilder.Entity<ClienteTreinadorPessoal>()
                .HasKey(ct => new { ct.ClienteId, ct.TreinadorPessoalId });

            modelBuilder.Entity<RefeicaoAlimento>()
                .HasKey(ra => new { ra.RefeicaoId, ra.AlimentoId });

            modelBuilder.Entity<TreinoExercicio>()
                .HasKey(te => new { te.TreinoId, te.ExercicioId });

            modelBuilder.Entity<Cliente>()
                .HasMany(c => c.ClientesNutricionistas)
                .WithOne(cn => cn.Cliente)
                .HasForeignKey(cn => cn.ClienteId);

            modelBuilder.Entity<Nutricionista>()
                .HasMany(n => n.ClientesNutricionistas)
                .WithOne(cn => cn.Nutricionista)
                .HasForeignKey(cn => cn.NutricionistaId);

            modelBuilder.Entity<Cliente>()
                .HasMany(c => c.ClientesTreinadoresPessoais)
                .WithOne(ct => ct.Cliente)
                .HasForeignKey(ct => ct.ClienteId);

            modelBuilder.Entity<TreinadorPessoal>()
                .HasMany(tp => tp.ClientesTreinadoresPessoais)
                .WithOne(ct => ct.TreinadorPessoal)
                .HasForeignKey(ct => ct.TreinadorPessoalId);

            modelBuilder.Entity<PlanoAlimentar>()
                .HasOne(pa => pa.Nutricionista)
                .WithMany(n => n.PlanosAlimentares)
                .HasForeignKey(pa => pa.NutricionistaId);

            modelBuilder.Entity<PlanoAlimentar>()
                .HasOne(pa => pa.Cliente)
                .WithMany(c => c.PlanosAlimentares)
                .HasForeignKey(pa => pa.ClienteId);

            modelBuilder.Entity<PlanoTreino>()
                .HasOne(pt => pt.TreinadorPessoal)
                .WithMany(tp => tp.PlanosTreino)
                .HasForeignKey(pt => pt.TreinadorPessoalId);

            modelBuilder.Entity<PlanoTreino>()
                .HasOne(pt => pt.Cliente)
                .WithMany(c => c.PlanosTreino)
                .HasForeignKey(pt => pt.ClienteId);

            modelBuilder.Entity<Refeicao>()
                .HasOne(r => r.PlanoAlimentar)
                .WithMany(pa => pa.Refeicoes)
                .HasForeignKey(r => r.RefeicaoId);

            modelBuilder.Entity<RefeicaoAlimento>()
                .HasOne(ra => ra.Refeicao)
                .WithMany(r => r.RefeicoesAlimentos)
                .HasForeignKey(ra => ra.RefeicaoId);

            modelBuilder.Entity<RefeicaoAlimento>()
                .HasOne(ra => ra.Alimento)
                .WithMany(a => a.RefeicoesAlimentos)
                .HasForeignKey(ra => ra.AlimentoId);

            modelBuilder.Entity<Treino>()
                .HasOne(t => t.PlanoTreino)
                .WithMany(pt => pt.Treinos)
                .HasForeignKey(t => t.TreinoId);

            modelBuilder.Entity<TreinoExercicio>()
                .HasOne(te => te.Treino)
                .WithMany(t => t.TreinosExercicios)
                .HasForeignKey(te => te.TreinoId);

            modelBuilder.Entity<TreinoExercicio>()
                .HasOne(te => te.Exercicio)
                .WithMany(e => e.TreinosExercicios)
                .HasForeignKey(te => te.ExercicioId);

            // Configurações adicionais...

            base.OnModelCreating(modelBuilder);
        }
    }
}

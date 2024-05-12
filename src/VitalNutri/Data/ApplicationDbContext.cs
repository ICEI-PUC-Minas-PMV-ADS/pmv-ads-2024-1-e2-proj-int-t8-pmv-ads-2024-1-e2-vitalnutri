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
            //CLIENTE
            modelBuilder.Entity<Cliente>()
                .HasMany(c => c.ClientesNutricionistas)
                .WithOne(cn => cn.Cliente)
                .HasForeignKey(cn => cn.ClienteId);

            modelBuilder.Entity<Cliente>()
                .HasMany(c => c.ClientesTreinadoresPessoais)
                .WithOne(ct => ct.Cliente)
                .HasForeignKey(ct => ct.ClienteId);

            //NUTRICIONISTA
            modelBuilder.Entity<Nutricionista>() //1
                .HasMany(n => n.ClientesNutricionistas)
                .WithOne(cn => cn.Nutricionista)
                .HasForeignKey(cn => cn.NutricionistaId);

            modelBuilder.Entity<PlanoAlimentar>() //2
                .HasOne(pa => pa.Nutricionista)
                .WithMany(n => n.PlanosAlimentares)
                .HasForeignKey(pa => pa.NutricionistaId);

            modelBuilder.Entity<PlanoAlimentar>() //3
                .HasOne(pa => pa.Cliente)
                .WithMany(c => c.PlanosAlimentares)
                .HasForeignKey(pa => pa.ClienteId);

            modelBuilder.Entity<ClienteNutricionista>() //4
                .HasKey(cn => new { cn.ClienteId, cn.NutricionistaId });

            modelBuilder.Entity<RefeicaoAlimento>() //5
                .HasKey(ra => new { ra.RefeicaoId, ra.AlimentoId });

            modelBuilder.Entity<RefeicaoAlimento>() //6
                .HasOne(ra => ra.Refeicao)
                .WithMany(r => r.RefeicoesAlimentos)
                .HasForeignKey(ra => ra.RefeicaoId);

            modelBuilder.Entity<RefeicaoAlimento>() //7
                .HasOne(ra => ra.Alimento)
                .WithMany(a => a.RefeicoesAlimentos)
                .HasForeignKey(ra => ra.AlimentoId);

            modelBuilder.Entity<Refeicao>() //8
                .HasOne(r => r.PlanoAlimentar)
                .WithMany(pa => pa.Refeicoes)
                .HasForeignKey(r => r.RefeicaoId);


            //TREINADOR
            modelBuilder.Entity<TreinadorPessoal>() //1
                .HasMany(tp => tp.ClientesTreinadoresPessoais)
                .WithOne(ct => ct.TreinadorPessoal)
                .HasForeignKey(ct => ct.TreinadorPessoalId);

            modelBuilder.Entity<PlanoTreino>() //2
                .HasOne(pt => pt.TreinadorPessoal)
                .WithMany(tp => tp.PlanosTreino)
                .HasForeignKey(pt => pt.TreinadorPessoalId);

            modelBuilder.Entity<PlanoTreino>() //3
                .HasOne(pt => pt.Cliente)
                .WithMany(c => c.PlanosTreino)
                .HasForeignKey(pt => pt.ClienteId);

            modelBuilder.Entity<ClienteTreinadorPessoal>() //4
                .HasKey(ct => new { ct.ClienteId, ct.TreinadorPessoalId });

            modelBuilder.Entity<TreinoExercicio>() //5
                .HasKey(te => new { te.TreinoId, te.ExercicioId });

            modelBuilder.Entity<TreinoExercicio>() //7
                .HasOne(te => te.Treino)
                .WithMany(t => t.TreinosExercicios)
                .HasForeignKey(te => te.TreinoId)
                .OnDelete(DeleteBehavior.Restrict); 

            modelBuilder.Entity<TreinoExercicio>() //8
                .HasOne(te => te.Exercicio)
                .WithMany(e => e.TreinosExercicios)
                .HasForeignKey(te => te.ExercicioId);

            modelBuilder.Entity<Treino>() //6
                .HasOne(t => t.PlanoTreino)
                .WithMany(pt => pt.Treinos)
                .HasForeignKey(t => t.TreinoId);

            // Configurações adicionais...

            base.OnModelCreating(modelBuilder);
        }
    }
}

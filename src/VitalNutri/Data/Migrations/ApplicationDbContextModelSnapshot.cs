﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using VitalNutri.Data;

#nullable disable

namespace VitalNutri.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasMaxLength(13)
                        .HasColumnType("nvarchar(13)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasDiscriminator<string>("Discriminator").HasValue("IdentityUser");

                    b.UseTphMappingStrategy();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("VitalNutri.Models.Alimento", b =>
                {
                    b.Property<int>("AlimentoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AlimentoId"));

                    b.Property<int?>("Calorias")
                        .HasColumnType("int");

                    b.Property<int?>("Carboidratos")
                        .HasColumnType("int");

                    b.Property<int?>("Gorduras")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NutricionistaId")
                        .HasColumnType("int");

                    b.Property<int?>("Proteinas")
                        .HasColumnType("int");

                    b.HasKey("AlimentoId");

                    b.HasIndex("NutricionistaId");

                    b.ToTable("Alimentos");
                });

            modelBuilder.Entity("VitalNutri.Models.Cliente", b =>
                {
                    b.Property<int>("ClienteId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ClienteId"));

                    b.Property<double>("Altura")
                        .HasColumnType("float");

                    b.Property<string>("Id")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<double>("MetaPeso")
                        .HasColumnType("float");

                    b.Property<double>("Peso")
                        .HasColumnType("float");

                    b.HasKey("ClienteId");

                    b.HasIndex("Id");

                    b.ToTable("Clientes");
                });

            modelBuilder.Entity("VitalNutri.Models.ClienteNutricionista", b =>
                {
                    b.Property<int>("ClienteId")
                        .HasColumnType("int");

                    b.Property<int>("NutricionistaId")
                        .HasColumnType("int");

                    b.HasKey("ClienteId", "NutricionistaId");

                    b.HasIndex("NutricionistaId");

                    b.ToTable("ClientesNutricionistas");
                });

            modelBuilder.Entity("VitalNutri.Models.ClienteTreinadorPessoal", b =>
                {
                    b.Property<int>("ClienteId")
                        .HasColumnType("int");

                    b.Property<int>("TreinadorPessoalId")
                        .HasColumnType("int");

                    b.HasKey("ClienteId", "TreinadorPessoalId");

                    b.HasIndex("TreinadorPessoalId");

                    b.ToTable("ClientesTreinadoresPessoais");
                });

            modelBuilder.Entity("VitalNutri.Models.Exercicio", b =>
                {
                    b.Property<int>("ExercicioId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ExercicioId"));

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("Imagem")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("TreinadorPessoalId")
                        .HasColumnType("int");

                    b.HasKey("ExercicioId");

                    b.HasIndex("TreinadorPessoalId");

                    b.ToTable("Exercicios");
                });

            modelBuilder.Entity("VitalNutri.Models.Nutricionista", b =>
                {
                    b.Property<int>("NutricionistaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("NutricionistaId"));

                    b.Property<string>("Especializacao")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("NumeroRegistro")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("NutricionistaId");

                    b.HasIndex("Id");

                    b.ToTable("Nutricionistas");
                });

            modelBuilder.Entity("VitalNutri.Models.PlanoAlimentar", b =>
                {
                    b.Property<int>("PlanoAlimentarId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PlanoAlimentarId"));

                    b.Property<string>("Alimento")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ClienteId")
                        .HasColumnType("int");

                    b.Property<TimeSpan?>("Horario")
                        .HasColumnType("time");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("NutricionistaId")
                        .HasColumnType("int");

                    b.Property<string>("Quantidade")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PlanoAlimentarId");

                    b.HasIndex("ClienteId");

                    b.HasIndex("NutricionistaId");

                    b.ToTable("PlanosAlimentares");
                });

            modelBuilder.Entity("VitalNutri.Models.PlanoTreino", b =>
                {
                    b.Property<int>("PlanoTreinoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PlanoTreinoId"));

                    b.Property<int>("Carga")
                        .HasColumnType("int");

                    b.Property<int>("ClienteId")
                        .HasColumnType("int");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Exercicio")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Repeticoes")
                        .HasColumnType("int");

                    b.Property<string>("Serie")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TreinadorPessoalId")
                        .HasColumnType("int");

                    b.HasKey("PlanoTreinoId");

                    b.HasIndex("ClienteId");

                    b.HasIndex("TreinadorPessoalId");

                    b.ToTable("PlanosTreino");
                });

            modelBuilder.Entity("VitalNutri.Models.Refeicao", b =>
                {
                    b.Property<int>("RefeicaoId")
                        .HasColumnType("int");

                    b.Property<int>("PlanoAlimentarId")
                        .HasColumnType("int");

                    b.HasKey("RefeicaoId");

                    b.ToTable("Refeicoes");
                });

            modelBuilder.Entity("VitalNutri.Models.RefeicaoAlimento", b =>
                {
                    b.Property<int>("RefeicaoId")
                        .HasColumnType("int");

                    b.Property<int>("AlimentoId")
                        .HasColumnType("int");

                    b.HasKey("RefeicaoId", "AlimentoId");

                    b.HasIndex("AlimentoId");

                    b.ToTable("RefeicaoAlimentos");
                });

            modelBuilder.Entity("VitalNutri.Models.TreinadorPessoal", b =>
                {
                    b.Property<int>("TreinadorPessoalId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TreinadorPessoalId"));

                    b.Property<string>("Especializacao")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("NumeroRegistro")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TreinadorPessoalId");

                    b.HasIndex("Id");

                    b.ToTable("TreinadoresPessoais");
                });

            modelBuilder.Entity("VitalNutri.Models.Treino", b =>
                {
                    b.Property<int>("TreinoId")
                        .HasColumnType("int");

                    b.Property<int>("PlanoTreinoId")
                        .HasColumnType("int");

                    b.HasKey("TreinoId");

                    b.ToTable("Treino");
                });

            modelBuilder.Entity("VitalNutri.Models.TreinoExercicio", b =>
                {
                    b.Property<int>("TreinoId")
                        .HasColumnType("int");

                    b.Property<int>("ExercicioId")
                        .HasColumnType("int");

                    b.HasKey("TreinoId", "ExercicioId");

                    b.HasIndex("ExercicioId");

                    b.ToTable("TreinoExercicios");
                });

            modelBuilder.Entity("VitalNutri.Models.Usuario", b =>
                {
                    b.HasBaseType("Microsoft.AspNetCore.Identity.IdentityUser");

                    b.Property<string>("TipoUsuario")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasDiscriminator().HasValue("Usuario");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("VitalNutri.Models.Alimento", b =>
                {
                    b.HasOne("VitalNutri.Models.Nutricionista", "Nutricionista")
                        .WithMany()
                        .HasForeignKey("NutricionistaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Nutricionista");
                });

            modelBuilder.Entity("VitalNutri.Models.Cliente", b =>
                {
                    b.HasOne("VitalNutri.Models.Usuario", "Usuario")
                        .WithMany("Clientes")
                        .HasForeignKey("Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("VitalNutri.Models.ClienteNutricionista", b =>
                {
                    b.HasOne("VitalNutri.Models.Cliente", "Cliente")
                        .WithMany("ClientesNutricionistas")
                        .HasForeignKey("ClienteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("VitalNutri.Models.Nutricionista", "Nutricionista")
                        .WithMany("ClientesNutricionistas")
                        .HasForeignKey("NutricionistaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cliente");

                    b.Navigation("Nutricionista");
                });

            modelBuilder.Entity("VitalNutri.Models.ClienteTreinadorPessoal", b =>
                {
                    b.HasOne("VitalNutri.Models.Cliente", "Cliente")
                        .WithMany("ClientesTreinadoresPessoais")
                        .HasForeignKey("ClienteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("VitalNutri.Models.TreinadorPessoal", "TreinadorPessoal")
                        .WithMany("ClientesTreinadoresPessoais")
                        .HasForeignKey("TreinadorPessoalId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cliente");

                    b.Navigation("TreinadorPessoal");
                });

            modelBuilder.Entity("VitalNutri.Models.Exercicio", b =>
                {
                    b.HasOne("VitalNutri.Models.TreinadorPessoal", "TreinadorPessoal")
                        .WithMany()
                        .HasForeignKey("TreinadorPessoalId");

                    b.Navigation("TreinadorPessoal");
                });

            modelBuilder.Entity("VitalNutri.Models.Nutricionista", b =>
                {
                    b.HasOne("VitalNutri.Models.Usuario", "Usuario")
                        .WithMany("Nutricionistas")
                        .HasForeignKey("Id");

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("VitalNutri.Models.PlanoAlimentar", b =>
                {
                    b.HasOne("VitalNutri.Models.Cliente", "Cliente")
                        .WithMany("PlanosAlimentares")
                        .HasForeignKey("ClienteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("VitalNutri.Models.Nutricionista", "Nutricionista")
                        .WithMany("PlanosAlimentares")
                        .HasForeignKey("NutricionistaId");

                    b.Navigation("Cliente");

                    b.Navigation("Nutricionista");
                });

            modelBuilder.Entity("VitalNutri.Models.PlanoTreino", b =>
                {
                    b.HasOne("VitalNutri.Models.Cliente", "Cliente")
                        .WithMany("PlanosTreino")
                        .HasForeignKey("ClienteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("VitalNutri.Models.TreinadorPessoal", "TreinadorPessoal")
                        .WithMany("PlanosTreino")
                        .HasForeignKey("TreinadorPessoalId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cliente");

                    b.Navigation("TreinadorPessoal");
                });

            modelBuilder.Entity("VitalNutri.Models.Refeicao", b =>
                {
                    b.HasOne("VitalNutri.Models.PlanoAlimentar", "PlanoAlimentar")
                        .WithMany("Refeicoes")
                        .HasForeignKey("RefeicaoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("PlanoAlimentar");
                });

            modelBuilder.Entity("VitalNutri.Models.RefeicaoAlimento", b =>
                {
                    b.HasOne("VitalNutri.Models.Alimento", "Alimento")
                        .WithMany("RefeicoesAlimentos")
                        .HasForeignKey("AlimentoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("VitalNutri.Models.Refeicao", "Refeicao")
                        .WithMany("RefeicoesAlimentos")
                        .HasForeignKey("RefeicaoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Alimento");

                    b.Navigation("Refeicao");
                });

            modelBuilder.Entity("VitalNutri.Models.TreinadorPessoal", b =>
                {
                    b.HasOne("VitalNutri.Models.Usuario", "Usuario")
                        .WithMany("TreinadoresPessoais")
                        .HasForeignKey("Id");

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("VitalNutri.Models.Treino", b =>
                {
                    b.HasOne("VitalNutri.Models.PlanoTreino", "PlanoTreino")
                        .WithMany("Treinos")
                        .HasForeignKey("TreinoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("PlanoTreino");
                });

            modelBuilder.Entity("VitalNutri.Models.TreinoExercicio", b =>
                {
                    b.HasOne("VitalNutri.Models.Exercicio", "Exercicio")
                        .WithMany("TreinosExercicios")
                        .HasForeignKey("ExercicioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("VitalNutri.Models.Treino", "Treino")
                        .WithMany("TreinosExercicios")
                        .HasForeignKey("TreinoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Exercicio");

                    b.Navigation("Treino");
                });

            modelBuilder.Entity("VitalNutri.Models.Alimento", b =>
                {
                    b.Navigation("RefeicoesAlimentos");
                });

            modelBuilder.Entity("VitalNutri.Models.Cliente", b =>
                {
                    b.Navigation("ClientesNutricionistas");

                    b.Navigation("ClientesTreinadoresPessoais");

                    b.Navigation("PlanosAlimentares");

                    b.Navigation("PlanosTreino");
                });

            modelBuilder.Entity("VitalNutri.Models.Exercicio", b =>
                {
                    b.Navigation("TreinosExercicios");
                });

            modelBuilder.Entity("VitalNutri.Models.Nutricionista", b =>
                {
                    b.Navigation("ClientesNutricionistas");

                    b.Navigation("PlanosAlimentares");
                });

            modelBuilder.Entity("VitalNutri.Models.PlanoAlimentar", b =>
                {
                    b.Navigation("Refeicoes");
                });

            modelBuilder.Entity("VitalNutri.Models.PlanoTreino", b =>
                {
                    b.Navigation("Treinos");
                });

            modelBuilder.Entity("VitalNutri.Models.Refeicao", b =>
                {
                    b.Navigation("RefeicoesAlimentos");
                });

            modelBuilder.Entity("VitalNutri.Models.TreinadorPessoal", b =>
                {
                    b.Navigation("ClientesTreinadoresPessoais");

                    b.Navigation("PlanosTreino");
                });

            modelBuilder.Entity("VitalNutri.Models.Treino", b =>
                {
                    b.Navigation("TreinosExercicios");
                });

            modelBuilder.Entity("VitalNutri.Models.Usuario", b =>
                {
                    b.Navigation("Clientes");

                    b.Navigation("Nutricionistas");

                    b.Navigation("TreinadoresPessoais");
                });
#pragma warning restore 612, 618
        }
    }
}

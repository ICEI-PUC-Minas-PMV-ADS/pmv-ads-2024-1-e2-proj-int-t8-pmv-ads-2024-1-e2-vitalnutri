using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VitalNutri.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomeCompleto = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    NomeUsuario = table.Column<string>(type: "nvarchar(45)", maxLength: 45, nullable: false),
                    Senha = table.Column<string>(type: "nvarchar(45)", maxLength: 45, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(45)", maxLength: 45, nullable: false),
                    Permissoes = table.Column<string>(type: "nvarchar(45)", maxLength: 45, nullable: false),
                    Ativo = table.Column<string>(type: "nvarchar(45)", maxLength: 45, nullable: false),
                    Foto = table.Column<string>(type: "nvarchar(45)", maxLength: 45, nullable: false),
                    Telefone = table.Column<string>(type: "nvarchar(45)", maxLength: 45, nullable: false),
                    DataNascimento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DataCriacao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UltimoAcesso = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Nutricionistas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UsuarioId = table.Column<int>(type: "int", nullable: true),
                    NumeroRegistro = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Especializacao = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nutricionistas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Nutricionistas_Usuarios_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TreinadoresPessoais",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UsuarioId = table.Column<int>(type: "int", nullable: true),
                    NumeroRegistro = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Especializacao = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TreinadoresPessoais", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TreinadoresPessoais_Usuarios_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Alimentos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Calorias = table.Column<int>(type: "int", nullable: true),
                    Carboidratos = table.Column<int>(type: "int", nullable: true),
                    Gorduras = table.Column<int>(type: "int", nullable: true),
                    Proteinas = table.Column<int>(type: "int", nullable: true),
                    NutricionistaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Alimentos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Alimentos_Nutricionistas_NutricionistaId",
                        column: x => x.NutricionistaId,
                        principalTable: "Nutricionistas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PlanosAlimentares",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NutricionistaId = table.Column<int>(type: "int", nullable: true),
                    Horario = table.Column<TimeSpan>(type: "time", nullable: true),
                    Alimento = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Quantidade = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlanosAlimentares", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PlanosAlimentares_Nutricionistas_NutricionistaId",
                        column: x => x.NutricionistaId,
                        principalTable: "Nutricionistas",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UsuarioId = table.Column<int>(type: "int", nullable: true),
                    NutricionistaId = table.Column<int>(type: "int", nullable: true),
                    TreinadorPessoalId = table.Column<int>(type: "int", nullable: true),
                    PossuiAcompanhamentoNutricionista = table.Column<bool>(type: "bit", nullable: true),
                    PossuiAcompanhamentoPersonal = table.Column<bool>(type: "bit", nullable: true),
                    PossuiPlanoAlimentar = table.Column<bool>(type: "bit", nullable: true),
                    PossuiPlanoTreino = table.Column<bool>(type: "bit", nullable: true),
                    Peso = table.Column<double>(type: "float", nullable: true),
                    Altura = table.Column<double>(type: "float", nullable: true),
                    MetaPeso = table.Column<double>(type: "float", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Clientes_Nutricionistas_NutricionistaId",
                        column: x => x.NutricionistaId,
                        principalTable: "Nutricionistas",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Clientes_TreinadoresPessoais_TreinadorPessoalId",
                        column: x => x.TreinadorPessoalId,
                        principalTable: "TreinadoresPessoais",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Clientes_Usuarios_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Exercicios",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Descricao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TreinadorPessoalId = table.Column<int>(type: "int", nullable: true),
                    Imagem = table.Column<byte[]>(type: "varbinary(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Exercicios", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Exercicios_TreinadoresPessoais_TreinadorPessoalId",
                        column: x => x.TreinadorPessoalId,
                        principalTable: "TreinadoresPessoais",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "PlanosDeTreino",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TreinadorPessoalId = table.Column<int>(type: "int", nullable: true),
                    Descricao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Serie = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Exercicio = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Carga = table.Column<int>(type: "int", nullable: true),
                    Repeticoes = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlanosDeTreino", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PlanosDeTreino_TreinadoresPessoais_TreinadorPessoalId",
                        column: x => x.TreinadorPessoalId,
                        principalTable: "TreinadoresPessoais",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Refeicoes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PlanoAlimentarId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Refeicoes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Refeicoes_PlanosAlimentares_PlanoAlimentarId",
                        column: x => x.PlanoAlimentarId,
                        principalTable: "PlanosAlimentares",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ClientesHasPlanosAlimentares",
                columns: table => new
                {
                    ClienteId = table.Column<int>(type: "int", nullable: false),
                    PlanoAlimentarId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClientesHasPlanosAlimentares", x => new { x.ClienteId, x.PlanoAlimentarId });
                    table.ForeignKey(
                        name: "FK_ClientesHasPlanosAlimentares_Clientes_ClienteId",
                        column: x => x.ClienteId,
                        principalTable: "Clientes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ClientesHasPlanosAlimentares_PlanosAlimentares_PlanoAlimentarId",
                        column: x => x.PlanoAlimentarId,
                        principalTable: "PlanosAlimentares",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ClientesHasPlanosDeTreino",
                columns: table => new
                {
                    ClienteId = table.Column<int>(type: "int", nullable: false),
                    PlanoDeTreinoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClientesHasPlanosDeTreino", x => new { x.ClienteId, x.PlanoDeTreinoId });
                    table.ForeignKey(
                        name: "FK_ClientesHasPlanosDeTreino_Clientes_ClienteId",
                        column: x => x.ClienteId,
                        principalTable: "Clientes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ClientesHasPlanosDeTreino_PlanosDeTreino_PlanoDeTreinoId",
                        column: x => x.PlanoDeTreinoId,
                        principalTable: "PlanosDeTreino",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Treinos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Descricao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PlanoDeTreinoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Treinos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Treinos_PlanosDeTreino_PlanoDeTreinoId",
                        column: x => x.PlanoDeTreinoId,
                        principalTable: "PlanosDeTreino",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RefeicoesHasAlimentos",
                columns: table => new
                {
                    RefeicaoId = table.Column<int>(type: "int", nullable: false),
                    AlimentoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RefeicoesHasAlimentos", x => new { x.RefeicaoId, x.AlimentoId });
                    table.ForeignKey(
                        name: "FK_RefeicoesHasAlimentos_Alimentos_AlimentoId",
                        column: x => x.AlimentoId,
                        principalTable: "Alimentos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RefeicoesHasAlimentos_Refeicoes_RefeicaoId",
                        column: x => x.RefeicaoId,
                        principalTable: "Refeicoes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Alimentos_NutricionistaId",
                table: "Alimentos",
                column: "NutricionistaId");

            migrationBuilder.CreateIndex(
                name: "IX_Clientes_NutricionistaId",
                table: "Clientes",
                column: "NutricionistaId");

            migrationBuilder.CreateIndex(
                name: "IX_Clientes_TreinadorPessoalId",
                table: "Clientes",
                column: "TreinadorPessoalId");

            migrationBuilder.CreateIndex(
                name: "IX_Clientes_UsuarioId",
                table: "Clientes",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_ClientesHasPlanosAlimentares_PlanoAlimentarId",
                table: "ClientesHasPlanosAlimentares",
                column: "PlanoAlimentarId");

            migrationBuilder.CreateIndex(
                name: "IX_ClientesHasPlanosDeTreino_PlanoDeTreinoId",
                table: "ClientesHasPlanosDeTreino",
                column: "PlanoDeTreinoId");

            migrationBuilder.CreateIndex(
                name: "IX_Exercicios_TreinadorPessoalId",
                table: "Exercicios",
                column: "TreinadorPessoalId");

            migrationBuilder.CreateIndex(
                name: "IX_Nutricionistas_UsuarioId",
                table: "Nutricionistas",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_PlanosAlimentares_NutricionistaId",
                table: "PlanosAlimentares",
                column: "NutricionistaId");

            migrationBuilder.CreateIndex(
                name: "IX_PlanosDeTreino_TreinadorPessoalId",
                table: "PlanosDeTreino",
                column: "TreinadorPessoalId");

            migrationBuilder.CreateIndex(
                name: "IX_Refeicoes_PlanoAlimentarId",
                table: "Refeicoes",
                column: "PlanoAlimentarId");

            migrationBuilder.CreateIndex(
                name: "IX_RefeicoesHasAlimentos_AlimentoId",
                table: "RefeicoesHasAlimentos",
                column: "AlimentoId");

            migrationBuilder.CreateIndex(
                name: "IX_TreinadoresPessoais_UsuarioId",
                table: "TreinadoresPessoais",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Treinos_PlanoDeTreinoId",
                table: "Treinos",
                column: "PlanoDeTreinoId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ClientesHasPlanosAlimentares");

            migrationBuilder.DropTable(
                name: "ClientesHasPlanosDeTreino");

            migrationBuilder.DropTable(
                name: "Exercicios");

            migrationBuilder.DropTable(
                name: "RefeicoesHasAlimentos");

            migrationBuilder.DropTable(
                name: "Treinos");

            migrationBuilder.DropTable(
                name: "Clientes");

            migrationBuilder.DropTable(
                name: "Alimentos");

            migrationBuilder.DropTable(
                name: "Refeicoes");

            migrationBuilder.DropTable(
                name: "PlanosDeTreino");

            migrationBuilder.DropTable(
                name: "PlanosAlimentares");

            migrationBuilder.DropTable(
                name: "TreinadoresPessoais");

            migrationBuilder.DropTable(
                name: "Nutricionistas");

            migrationBuilder.DropTable(
                name: "Usuarios");
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VitalNutri.Data.Migrations
{
    /// <inheritdoc />
    public partial class Models : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "AspNetUsers",
                type: "nvarchar(13)",
                maxLength: 13,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "TipoUsuario",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    ClienteId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Peso = table.Column<double>(type: "float", nullable: false),
                    Altura = table.Column<double>(type: "float", nullable: false),
                    MetaPeso = table.Column<double>(type: "float", nullable: false),
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.ClienteId);
                    table.ForeignKey(
                        name: "FK_Clientes_AspNetUsers_Id",
                        column: x => x.Id,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Nutricionistas",
                columns: table => new
                {
                    NutricionistaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NumeroRegistro = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Especializacao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nutricionistas", x => x.NutricionistaId);
                    table.ForeignKey(
                        name: "FK_Nutricionistas_AspNetUsers_Id",
                        column: x => x.Id,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "TreinadoresPessoais",
                columns: table => new
                {
                    TreinadorPessoalId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NumeroRegistro = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Especializacao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TreinadoresPessoais", x => x.TreinadorPessoalId);
                    table.ForeignKey(
                        name: "FK_TreinadoresPessoais_AspNetUsers_Id",
                        column: x => x.Id,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Alimentos",
                columns: table => new
                {
                    AlimentoId = table.Column<int>(type: "int", nullable: false)
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
                    table.PrimaryKey("PK_Alimentos", x => x.AlimentoId);
                    table.ForeignKey(
                        name: "FK_Alimentos_Nutricionistas_NutricionistaId",
                        column: x => x.NutricionistaId,
                        principalTable: "Nutricionistas",
                        principalColumn: "NutricionistaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ClientesNutricionistas",
                columns: table => new
                {
                    ClienteId = table.Column<int>(type: "int", nullable: false),
                    NutricionistaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClientesNutricionistas", x => new { x.ClienteId, x.NutricionistaId });
                    table.ForeignKey(
                        name: "FK_ClientesNutricionistas_Clientes_ClienteId",
                        column: x => x.ClienteId,
                        principalTable: "Clientes",
                        principalColumn: "ClienteId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ClientesNutricionistas_Nutricionistas_NutricionistaId",
                        column: x => x.NutricionistaId,
                        principalTable: "Nutricionistas",
                        principalColumn: "NutricionistaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PlanosAlimentares",
                columns: table => new
                {
                    PlanoAlimentarId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NutricionistaId = table.Column<int>(type: "int", nullable: true),
                    Horario = table.Column<TimeSpan>(type: "time", nullable: true),
                    Alimento = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Quantidade = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ClienteId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlanosAlimentares", x => x.PlanoAlimentarId);
                    table.ForeignKey(
                        name: "FK_PlanosAlimentares_Clientes_ClienteId",
                        column: x => x.ClienteId,
                        principalTable: "Clientes",
                        principalColumn: "ClienteId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PlanosAlimentares_Nutricionistas_NutricionistaId",
                        column: x => x.NutricionistaId,
                        principalTable: "Nutricionistas",
                        principalColumn: "NutricionistaId");
                });

            migrationBuilder.CreateTable(
                name: "ClientesTreinadoresPessoais",
                columns: table => new
                {
                    ClienteId = table.Column<int>(type: "int", nullable: false),
                    TreinadorPessoalId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClientesTreinadoresPessoais", x => new { x.ClienteId, x.TreinadorPessoalId });
                    table.ForeignKey(
                        name: "FK_ClientesTreinadoresPessoais_Clientes_ClienteId",
                        column: x => x.ClienteId,
                        principalTable: "Clientes",
                        principalColumn: "ClienteId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ClientesTreinadoresPessoais_TreinadoresPessoais_TreinadorPessoalId",
                        column: x => x.TreinadorPessoalId,
                        principalTable: "TreinadoresPessoais",
                        principalColumn: "TreinadorPessoalId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Exercicios",
                columns: table => new
                {
                    ExercicioId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Descricao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TreinadorPessoalId = table.Column<int>(type: "int", nullable: true),
                    Imagem = table.Column<byte[]>(type: "varbinary(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Exercicios", x => x.ExercicioId);
                    table.ForeignKey(
                        name: "FK_Exercicios_TreinadoresPessoais_TreinadorPessoalId",
                        column: x => x.TreinadorPessoalId,
                        principalTable: "TreinadoresPessoais",
                        principalColumn: "TreinadorPessoalId");
                });

            migrationBuilder.CreateTable(
                name: "PlanosTreino",
                columns: table => new
                {
                    PlanoTreinoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TreinadorPessoalId = table.Column<int>(type: "int", nullable: false),
                    Descricao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Serie = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Exercicio = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Carga = table.Column<int>(type: "int", nullable: false),
                    Repeticoes = table.Column<int>(type: "int", nullable: false),
                    ClienteId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlanosTreino", x => x.PlanoTreinoId);
                    table.ForeignKey(
                        name: "FK_PlanosTreino_Clientes_ClienteId",
                        column: x => x.ClienteId,
                        principalTable: "Clientes",
                        principalColumn: "ClienteId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PlanosTreino_TreinadoresPessoais_TreinadorPessoalId",
                        column: x => x.TreinadorPessoalId,
                        principalTable: "TreinadoresPessoais",
                        principalColumn: "TreinadorPessoalId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Refeicoes",
                columns: table => new
                {
                    RefeicaoId = table.Column<int>(type: "int", nullable: false),
                    PlanoAlimentarId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Refeicoes", x => x.RefeicaoId);
                    table.ForeignKey(
                        name: "FK_Refeicoes_PlanosAlimentares_RefeicaoId",
                        column: x => x.RefeicaoId,
                        principalTable: "PlanosAlimentares",
                        principalColumn: "PlanoAlimentarId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Treino",
                columns: table => new
                {
                    TreinoId = table.Column<int>(type: "int", nullable: false),
                    PlanoTreinoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Treino", x => x.TreinoId);
                    table.ForeignKey(
                        name: "FK_Treino_PlanosTreino_TreinoId",
                        column: x => x.TreinoId,
                        principalTable: "PlanosTreino",
                        principalColumn: "PlanoTreinoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RefeicaoAlimentos",
                columns: table => new
                {
                    RefeicaoId = table.Column<int>(type: "int", nullable: false),
                    AlimentoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RefeicaoAlimentos", x => new { x.RefeicaoId, x.AlimentoId });
                    table.ForeignKey(
                        name: "FK_RefeicaoAlimentos_Alimentos_AlimentoId",
                        column: x => x.AlimentoId,
                        principalTable: "Alimentos",
                        principalColumn: "AlimentoId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RefeicaoAlimentos_Refeicoes_RefeicaoId",
                        column: x => x.RefeicaoId,
                        principalTable: "Refeicoes",
                        principalColumn: "RefeicaoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TreinoExercicios",
                columns: table => new
                {
                    TreinoId = table.Column<int>(type: "int", nullable: false),
                    ExercicioId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TreinoExercicios", x => new { x.TreinoId, x.ExercicioId });
                    table.ForeignKey(
                        name: "FK_TreinoExercicios_Exercicios_ExercicioId",
                        column: x => x.ExercicioId,
                        principalTable: "Exercicios",
                        principalColumn: "ExercicioId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TreinoExercicios_Treino_TreinoId",
                        column: x => x.TreinoId,
                        principalTable: "Treino",
                        principalColumn: "TreinoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Alimentos_NutricionistaId",
                table: "Alimentos",
                column: "NutricionistaId");

            migrationBuilder.CreateIndex(
                name: "IX_Clientes_Id",
                table: "Clientes",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_ClientesNutricionistas_NutricionistaId",
                table: "ClientesNutricionistas",
                column: "NutricionistaId");

            migrationBuilder.CreateIndex(
                name: "IX_ClientesTreinadoresPessoais_TreinadorPessoalId",
                table: "ClientesTreinadoresPessoais",
                column: "TreinadorPessoalId");

            migrationBuilder.CreateIndex(
                name: "IX_Exercicios_TreinadorPessoalId",
                table: "Exercicios",
                column: "TreinadorPessoalId");

            migrationBuilder.CreateIndex(
                name: "IX_Nutricionistas_Id",
                table: "Nutricionistas",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_PlanosAlimentares_ClienteId",
                table: "PlanosAlimentares",
                column: "ClienteId");

            migrationBuilder.CreateIndex(
                name: "IX_PlanosAlimentares_NutricionistaId",
                table: "PlanosAlimentares",
                column: "NutricionistaId");

            migrationBuilder.CreateIndex(
                name: "IX_PlanosTreino_ClienteId",
                table: "PlanosTreino",
                column: "ClienteId");

            migrationBuilder.CreateIndex(
                name: "IX_PlanosTreino_TreinadorPessoalId",
                table: "PlanosTreino",
                column: "TreinadorPessoalId");

            migrationBuilder.CreateIndex(
                name: "IX_RefeicaoAlimentos_AlimentoId",
                table: "RefeicaoAlimentos",
                column: "AlimentoId");

            migrationBuilder.CreateIndex(
                name: "IX_TreinadoresPessoais_Id",
                table: "TreinadoresPessoais",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_TreinoExercicios_ExercicioId",
                table: "TreinoExercicios",
                column: "ExercicioId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ClientesNutricionistas");

            migrationBuilder.DropTable(
                name: "ClientesTreinadoresPessoais");

            migrationBuilder.DropTable(
                name: "RefeicaoAlimentos");

            migrationBuilder.DropTable(
                name: "TreinoExercicios");

            migrationBuilder.DropTable(
                name: "Alimentos");

            migrationBuilder.DropTable(
                name: "Refeicoes");

            migrationBuilder.DropTable(
                name: "Exercicios");

            migrationBuilder.DropTable(
                name: "Treino");

            migrationBuilder.DropTable(
                name: "PlanosAlimentares");

            migrationBuilder.DropTable(
                name: "PlanosTreino");

            migrationBuilder.DropTable(
                name: "Nutricionistas");

            migrationBuilder.DropTable(
                name: "Clientes");

            migrationBuilder.DropTable(
                name: "TreinadoresPessoais");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "TipoUsuario",
                table: "AspNetUsers");
        }
    }
}

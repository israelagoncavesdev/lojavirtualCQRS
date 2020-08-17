using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MinhaLojaVirtual.Catalogo.Data.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categorias",
                columns: table => new
                {
                    id = table.Column<byte[]>(nullable: false),
                    nome = table.Column<string>(type: "varchar(250)", nullable: false),
                    codigo = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_categorias", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Produtos",
                columns: table => new
                {
                    id = table.Column<byte[]>(nullable: false),
                    categoria_id = table.Column<byte[]>(nullable: false),
                    nome = table.Column<string>(type: "varchar(250)", nullable: false),
                    descricao = table.Column<string>(type: "varchar(500)", nullable: false),
                    ativo = table.Column<bool>(nullable: false),
                    valor = table.Column<decimal>(nullable: false),
                    data_cadastro = table.Column<DateTime>(nullable: false),
                    imagem = table.Column<string>(type: "varchar(250)", nullable: false),
                    quantidade_estoque = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_produtos", x => x.id);
                    table.ForeignKey(
                        name: "fk_produtos_categorias_categoria_id",
                        column: x => x.categoria_id,
                        principalTable: "Categorias",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "dimensoes",
                columns: table => new
                {
                    ProdutoId = table.Column<byte[]>(nullable: false),
                    Altura = table.Column<int>(type: "int", nullable: false),
                    Largura = table.Column<int>(type: "int", nullable: false),
                    Profundidade = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dimensoes", x => x.ProdutoId);
                    table.ForeignKey(
                        name: "fk_produtos_dimensoes_dimensoes_temp_id",
                        column: x => x.ProdutoId,
                        principalTable: "Produtos",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "ix_produtos_categoria_id",
                table: "Produtos",
                column: "categoria_id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "dimensoes");

            migrationBuilder.DropTable(
                name: "Produtos");

            migrationBuilder.DropTable(
                name: "Categorias");
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CadastroProdutos.Migrations
{
    public partial class criandobancodedados : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Produtos",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nomeProduto = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    quantUnitaria = table.Column<int>(type: "int", nullable: false),
                    preco = table.Column<double>(type: "float", nullable: false),
                    peso = table.Column<double>(type: "float", nullable: false),
                    dataValidade = table.Column<DateTime>(type: "datetime2", nullable: false),
                    dataInclusao = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Produtos", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Produtos");
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BookStore.Migrations
{
    public partial class InitialCreation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AutoresBookStore",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nome = table.Column<string>(type: "TEXT", maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AutoresBookStore", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CategoriasBookStore",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nome = table.Column<string>(type: "TEXT", maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoriasBookStore", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LivrosBookStore",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nome = table.Column<string>(type: "TEXT", maxLength: 30, nullable: false),
                    ISBN = table.Column<string>(type: "TEXT", maxLength: 30, nullable: false),
                    DataLancamento = table.Column<DateTime>(type: "TEXT", nullable: false),
                    CategoriaId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LivrosBookStore", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LivrosBookStore_CategoriasBookStore_CategoriaId",
                        column: x => x.CategoriaId,
                        principalTable: "CategoriasBookStore",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AutorLivro",
                columns: table => new
                {
                    AutoresId = table.Column<int>(type: "INTEGER", nullable: false),
                    LivrosId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AutorLivro", x => new { x.AutoresId, x.LivrosId });
                    table.ForeignKey(
                        name: "FK_AutorLivro_AutoresBookStore_AutoresId",
                        column: x => x.AutoresId,
                        principalTable: "AutoresBookStore",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AutorLivro_LivrosBookStore_LivrosId",
                        column: x => x.LivrosId,
                        principalTable: "LivrosBookStore",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AutorLivro_LivrosId",
                table: "AutorLivro",
                column: "LivrosId");

            migrationBuilder.CreateIndex(
                name: "IX_LivrosBookStore_CategoriaId",
                table: "LivrosBookStore",
                column: "CategoriaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AutorLivro");

            migrationBuilder.DropTable(
                name: "AutoresBookStore");

            migrationBuilder.DropTable(
                name: "LivrosBookStore");

            migrationBuilder.DropTable(
                name: "CategoriasBookStore");
        }
    }
}

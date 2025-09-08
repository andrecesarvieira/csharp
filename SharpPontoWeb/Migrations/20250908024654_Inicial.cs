using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SharpPontoWeb.Migrations
{
    /// <inheritdoc />
    public partial class Inicial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Registros",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Data = table.Column<DateOnly>(type: "date", nullable: false),
                    Entrada = table.Column<TimeOnly>(type: "time(6)", nullable: false),
                    Almoco = table.Column<TimeOnly>(type: "time(6)", nullable: false),
                    Retorno = table.Column<TimeOnly>(type: "time(6)", nullable: false),
                    Saida = table.Column<TimeOnly>(type: "time(6)", nullable: false),
                    Manha = table.Column<TimeOnly>(type: "time(6)", nullable: false),
                    Tarde = table.Column<TimeOnly>(type: "time(6)", nullable: false),
                    TotalDia = table.Column<TimeOnly>(type: "time(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Registros", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Registros");
        }
    }
}

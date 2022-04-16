using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Vuelos.Infraestructure.EF.Migrations
{
    public partial class AgregarVuelos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Vuelo",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    nroItinerario = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    fechaInicio = table.Column<DateTime>(type: "DateTime", nullable: false),
                    fechaFinal = table.Column<DateTime>(type: "DateTime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vuelo", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "VueloProgramado",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    nroVuelo = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    lunes = table.Column<bool>(type: "bit", nullable: false),
                    martes = table.Column<bool>(type: "bit", nullable: false),
                    miercoles = table.Column<bool>(type: "bit", nullable: false),
                    jueves = table.Column<bool>(type: "bit", nullable: false),
                    viernes = table.Column<bool>(type: "bit", nullable: false),
                    sabado = table.Column<bool>(type: "bit", nullable: false),
                    domingo = table.Column<bool>(type: "bit", nullable: false),
                    horaSalida = table.Column<DateTime>(type: "DateTime", nullable: false),
                    horaLlegada = table.Column<DateTime>(type: "DateTime", nullable: false),
                    ciudadOrigen = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: true),
                    ciudadDestino = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: true),
                    precioVuelo = table.Column<decimal>(type: "decimal(10,2)", precision: 10, scale: 2, nullable: false),
                    cantidadMillas = table.Column<decimal>(type: "decimal(10,2)", precision: 10, scale: 2, nullable: false),
                    VueloId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VueloProgramado", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VueloProgramado_Vuelo_VueloId",
                        column: x => x.VueloId,
                        principalTable: "Vuelo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_VueloProgramado_VueloId",
                table: "VueloProgramado",
                column: "VueloId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "VueloProgramado");

            migrationBuilder.DropTable(
                name: "Vuelo");
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Vuelos.Infraestructure.EF.Migrations
{
    public partial class InitialStructure : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Aeronave",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    nroAeronave = table.Column<string>(type: "nvarchar(6)", maxLength: 6, nullable: true),
                    matricula = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    marca = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    modelo = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    capacidadAsientos = table.Column<int>(type: "int", nullable: false),
                    capacidadCombustible = table.Column<int>(type: "int", nullable: false),
                    esActivo = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Aeronave", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AsientosAeronave",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    nroAsiento = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: true),
                    fila = table.Column<int>(type: "int", nullable: false),
                    columna = table.Column<int>(type: "int", nullable: false),
                    estadoAsiento = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    AeronaveId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AsientosAeronave", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AsientosAeronave_Aeronave_AeronaveId",
                        column: x => x.AeronaveId,
                        principalTable: "Aeronave",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AsientosAeronave_AeronaveId",
                table: "AsientosAeronave",
                column: "AeronaveId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AsientosAeronave");

            migrationBuilder.DropTable(
                name: "Aeronave");
        }
    }
}

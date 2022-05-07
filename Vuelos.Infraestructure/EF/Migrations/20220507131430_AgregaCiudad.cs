using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Vuelos.Infraestructure.EF.Migrations
{
    public partial class AgregaCiudad : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Ciudad",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    codigoCiudad = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: true),
                    nombreCiudad = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    nombreAeropuerto = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    estadoAeropuerto = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ciudad", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Ciudad");
        }
    }
}

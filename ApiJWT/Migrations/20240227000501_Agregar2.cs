using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApiJWT.Migrations
{
    /// <inheritdoc />
    public partial class Agregar2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IdAlumno",
                table: "AlumnoMateria");

            migrationBuilder.DropColumn(
                name: "IdMateria",
                table: "AlumnoMateria");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "IdAlumno",
                table: "AlumnoMateria",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IdMateria",
                table: "AlumnoMateria",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}

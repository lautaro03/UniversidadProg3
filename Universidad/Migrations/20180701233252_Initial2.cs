using Microsoft.EntityFrameworkCore.Migrations;

namespace Universidad.Migrations
{
    public partial class Initial2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ProfesorID",
                table: "Profesores",
                newName: "ID");

            migrationBuilder.RenameColumn(
                name: "MateriaID",
                table: "Materias",
                newName: "ID");

            migrationBuilder.RenameColumn(
                name: "CatedraID",
                table: "Catedras",
                newName: "ID");

            migrationBuilder.RenameColumn(
                name: "CarreraID",
                table: "Carreras",
                newName: "ID");

            migrationBuilder.RenameColumn(
                name: "AlumnoID",
                table: "Alumnos",
                newName: "ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Profesores",
                newName: "ProfesorID");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Materias",
                newName: "MateriaID");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Catedras",
                newName: "CatedraID");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Carreras",
                newName: "CarreraID");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Alumnos",
                newName: "AlumnoID");
        }
    }
}

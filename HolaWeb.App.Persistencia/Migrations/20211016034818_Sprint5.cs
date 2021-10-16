using Microsoft.EntityFrameworkCore.Migrations;

namespace HolaWeb.App.Persistencia.Migrations
{
    public partial class Sprint5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Visitas_Mascotas_IdMascotaId",
                table: "Visitas");

            migrationBuilder.DropForeignKey(
                name: "FK_Visitas_Veterinarios_IdVeterinarioId",
                table: "Visitas");

            migrationBuilder.DropIndex(
                name: "IX_Visitas_IdMascotaId",
                table: "Visitas");

            migrationBuilder.DropIndex(
                name: "IX_Visitas_IdVeterinarioId",
                table: "Visitas");

            migrationBuilder.DropColumn(
                name: "IdMascotaId",
                table: "Visitas");

            migrationBuilder.DropColumn(
                name: "IdVeterinarioId",
                table: "Visitas");

            migrationBuilder.AddColumn<int>(
                name: "IdMascota",
                table: "Visitas",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IdVeterinario",
                table: "Visitas",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IdMascota",
                table: "Visitas");

            migrationBuilder.DropColumn(
                name: "IdVeterinario",
                table: "Visitas");

            migrationBuilder.AddColumn<int>(
                name: "IdMascotaId",
                table: "Visitas",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IdVeterinarioId",
                table: "Visitas",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Visitas_IdMascotaId",
                table: "Visitas",
                column: "IdMascotaId");

            migrationBuilder.CreateIndex(
                name: "IX_Visitas_IdVeterinarioId",
                table: "Visitas",
                column: "IdVeterinarioId");

            migrationBuilder.AddForeignKey(
                name: "FK_Visitas_Mascotas_IdMascotaId",
                table: "Visitas",
                column: "IdMascotaId",
                principalTable: "Mascotas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Visitas_Veterinarios_IdVeterinarioId",
                table: "Visitas",
                column: "IdVeterinarioId",
                principalTable: "Veterinarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}

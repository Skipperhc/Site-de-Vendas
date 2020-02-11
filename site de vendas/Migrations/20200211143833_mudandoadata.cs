using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace site_de_vendas.Migrations
{
    public partial class mudandoadata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "Data",
                table: "Eventos",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Data",
                table: "Eventos",
                type: "int",
                nullable: false,
                oldClrType: typeof(DateTime));
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebMVC6.Migrations
{
    public partial class testTurtleBro : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "ReportId",
                table: "Roles",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_Roles_ReportId",
                table: "Roles",
                column: "ReportId");

            migrationBuilder.AddForeignKey(
                name: "FK_Roles_Roles_ReportId",
                table: "Roles",
                column: "ReportId",
                principalTable: "Roles",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Roles_Roles_ReportId",
                table: "Roles");

            migrationBuilder.DropIndex(
                name: "IX_Roles_ReportId",
                table: "Roles");

            migrationBuilder.DropColumn(
                name: "ReportId",
                table: "Roles");
        }
    }
}

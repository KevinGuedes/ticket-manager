﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TicketManager.Infra.Migrations
{
    public partial class Seeds : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedAt", "Email", "Hash", "Name", "Role", "Salt" },
                values: new object[] { 1, new DateTime(2022, 5, 22, 11, 4, 55, 187, DateTimeKind.Local).AddTicks(7356), "johnl@email.com", "$2a$12$dNMivl8uiVUbJOanAbvggOThv0Psr6oaUEAf7dtgTYFB3x.PCfmr.", "John L.", 1, "1d8cf748c6156545d92237c8ef115f25" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedAt", "Email", "Hash", "Name", "Role", "Salt" },
                values: new object[] { 2, new DateTime(2022, 5, 22, 11, 4, 55, 187, DateTimeKind.Local).AddTicks(7365), "georgeh@email.com", "$2a$12$mc3HQ1zD.C8AAr/Lf2I29.XB.MJz6n5FLEXUOllaXPt0PdgveXU7C", "George H.", 0, "ccea7ca67997fc7437b1c19a482143a7" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Users");
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ASP.Net.Migrations
{
    /// <inheritdoc />
    public partial class BillCreationDate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Numbet",
                table: "Bills",
                newName: "Number");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Services",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreationDate",
                table: "Bills",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreationDate",
                table: "Bills");

            migrationBuilder.RenameColumn(
                name: "Number",
                table: "Bills",
                newName: "Numbet");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Services",
                type: "TEXT",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ASP.Net.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Services",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    ToPay = table.Column<double>(type: "REAL", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Services", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Bills",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    HotWaterAndHeatingId = table.Column<int>(type: "INTEGER", nullable: false),
                    ElectricityId = table.Column<int>(type: "INTEGER", nullable: false),
                    ColdWaterId = table.Column<int>(type: "INTEGER", nullable: false),
                    Numbet = table.Column<int>(type: "INTEGER", nullable: false),
                    Overpayment = table.Column<double>(type: "REAL", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bills", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Bills_Services_ColdWaterId",
                        column: x => x.ColdWaterId,
                        principalTable: "Services",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Bills_Services_ElectricityId",
                        column: x => x.ElectricityId,
                        principalTable: "Services",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Bills_Services_HotWaterAndHeatingId",
                        column: x => x.HotWaterAndHeatingId,
                        principalTable: "Services",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Bills_ColdWaterId",
                table: "Bills",
                column: "ColdWaterId");

            migrationBuilder.CreateIndex(
                name: "IX_Bills_ElectricityId",
                table: "Bills",
                column: "ElectricityId");

            migrationBuilder.CreateIndex(
                name: "IX_Bills_HotWaterAndHeatingId",
                table: "Bills",
                column: "HotWaterAndHeatingId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Bills");

            migrationBuilder.DropTable(
                name: "Services");
        }
    }
}

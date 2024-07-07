using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HastaneUygulamasi.Migrations
{
    /// <inheritdoc />
    public partial class CreateDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Katlars",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KatNumarası = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Katlars", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Odalars",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OdaNumarası = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Odalars", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Hastalar",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HastaAdi = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Tc = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: false),
                    DogumTarihi = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Katid = table.Column<int>(type: "int", nullable: false),
                    Odaid = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hastalar", x => x.id);
                    table.ForeignKey(
                        name: "FK_Hastalar_Katlars_Katid",
                        column: x => x.Katid,
                        principalTable: "Katlars",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Hastalar_Odalars_Odaid",
                        column: x => x.Odaid,
                        principalTable: "Odalars",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Hastalar_Katid",
                table: "Hastalar",
                column: "Katid");

            migrationBuilder.CreateIndex(
                name: "IX_Hastalar_Odaid",
                table: "Hastalar",
                column: "Odaid");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Hastalar");

            migrationBuilder.DropTable(
                name: "Katlars");

            migrationBuilder.DropTable(
                name: "Odalars");
        }
    }
}

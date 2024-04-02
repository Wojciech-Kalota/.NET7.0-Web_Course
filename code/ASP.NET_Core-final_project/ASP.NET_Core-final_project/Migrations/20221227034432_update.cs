using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ASPNET_Core_final_project.Migrations
{
    /// <inheritdoc />
    public partial class update : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Programmer_Languages",
                columns: table => new
                {
                    Id = table.Column<uint>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ProgrammerId = table.Column<uint>(type: "INTEGER", nullable: false),
                    LanguageId = table.Column<uint>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Programmer_Languages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Programmer_Languages_Languages_LanguageId",
                        column: x => x.LanguageId,
                        principalTable: "Languages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Programmer_Languages_Programmers_ProgrammerId",
                        column: x => x.ProgrammerId,
                        principalTable: "Programmers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Programmer_Languages_LanguageId",
                table: "Programmer_Languages",
                column: "LanguageId");

            migrationBuilder.CreateIndex(
                name: "IX_Programmer_Languages_ProgrammerId",
                table: "Programmer_Languages",
                column: "ProgrammerId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Programmer_Languages");
        }
    }
}

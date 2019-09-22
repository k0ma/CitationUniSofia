using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CitationUniSofia.Data.Migrations
{
    public partial class AreaScienceTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PublicationsFieldsSciences");

            migrationBuilder.CreateTable(
                name: "AreaScience",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    FieldScienceId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AreaScience", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AreaScience_FieldsSciences_FieldScienceId",
                        column: x => x.FieldScienceId,
                        principalTable: "FieldsSciences",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PublicationsAreasScience",
                columns: table => new
                {
                    PublicationId = table.Column<int>(nullable: false),
                    AreaScienceId = table.Column<int>(nullable: false),
                    Id = table.Column<int>(nullable: false),
                    Sequence = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PublicationsAreasScience", x => new { x.PublicationId, x.AreaScienceId });
                    table.ForeignKey(
                        name: "FK_PublicationsAreasScience_AreaScience_AreaScienceId",
                        column: x => x.AreaScienceId,
                        principalTable: "AreaScience",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PublicationsAreasScience_Publications_PublicationId",
                        column: x => x.PublicationId,
                        principalTable: "Publications",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AreaScience_FieldScienceId",
                table: "AreaScience",
                column: "FieldScienceId");

            migrationBuilder.CreateIndex(
                name: "IX_PublicationsAreasScience_AreaScienceId",
                table: "PublicationsAreasScience",
                column: "AreaScienceId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PublicationsAreasScience");

            migrationBuilder.DropTable(
                name: "AreaScience");

            migrationBuilder.CreateTable(
                name: "PublicationsFieldsSciences",
                columns: table => new
                {
                    PublicationId = table.Column<int>(nullable: false),
                    FieldScienceId = table.Column<int>(nullable: false),
                    Id = table.Column<int>(nullable: false),
                    Sequence = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PublicationsFieldsSciences", x => new { x.PublicationId, x.FieldScienceId });
                    table.ForeignKey(
                        name: "FK_PublicationsFieldsSciences_FieldsSciences_FieldScienceId",
                        column: x => x.FieldScienceId,
                        principalTable: "FieldsSciences",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PublicationsFieldsSciences_Publications_PublicationId",
                        column: x => x.PublicationId,
                        principalTable: "Publications",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PublicationsFieldsSciences_FieldScienceId",
                table: "PublicationsFieldsSciences",
                column: "FieldScienceId");
        }
    }
}

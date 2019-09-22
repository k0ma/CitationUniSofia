using Microsoft.EntityFrameworkCore.Migrations;

namespace CitationUniSofia.Data.Migrations
{
    public partial class AreaScienceTableSecond : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AreaScience_FieldsSciences_FieldScienceId",
                table: "AreaScience");

            migrationBuilder.DropForeignKey(
                name: "FK_PublicationsAreasScience_AreaScience_AreaScienceId",
                table: "PublicationsAreasScience");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AreaScience",
                table: "AreaScience");

            migrationBuilder.RenameTable(
                name: "AreaScience",
                newName: "AreasScience");

            migrationBuilder.RenameIndex(
                name: "IX_AreaScience_FieldScienceId",
                table: "AreasScience",
                newName: "IX_AreasScience_FieldScienceId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AreasScience",
                table: "AreasScience",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AreasScience_FieldsSciences_FieldScienceId",
                table: "AreasScience",
                column: "FieldScienceId",
                principalTable: "FieldsSciences",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PublicationsAreasScience_AreasScience_AreaScienceId",
                table: "PublicationsAreasScience",
                column: "AreaScienceId",
                principalTable: "AreasScience",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AreasScience_FieldsSciences_FieldScienceId",
                table: "AreasScience");

            migrationBuilder.DropForeignKey(
                name: "FK_PublicationsAreasScience_AreasScience_AreaScienceId",
                table: "PublicationsAreasScience");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AreasScience",
                table: "AreasScience");

            migrationBuilder.RenameTable(
                name: "AreasScience",
                newName: "AreaScience");

            migrationBuilder.RenameIndex(
                name: "IX_AreasScience_FieldScienceId",
                table: "AreaScience",
                newName: "IX_AreaScience_FieldScienceId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AreaScience",
                table: "AreaScience",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AreaScience_FieldsSciences_FieldScienceId",
                table: "AreaScience",
                column: "FieldScienceId",
                principalTable: "FieldsSciences",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PublicationsAreasScience_AreaScience_AreaScienceId",
                table: "PublicationsAreasScience",
                column: "AreaScienceId",
                principalTable: "AreaScience",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

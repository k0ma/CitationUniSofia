using Microsoft.EntityFrameworkCore.Migrations;

namespace CitationUniSofia.Data.Migrations
{
    public partial class Update_LinkingTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AreasScience_FieldsSciences_FieldScienceId",
                table: "AreasScience");

            migrationBuilder.DropForeignKey(
                name: "FK_Citations_Authors_AuthorId",
                table: "Citations");

            migrationBuilder.DropForeignKey(
                name: "FK_Citations_CitationTypes_CitationTypeId",
                table: "Citations");

            migrationBuilder.DropForeignKey(
                name: "FK_Citations_Institutions_InstitutionId",
                table: "Citations");

            migrationBuilder.DropForeignKey(
                name: "FK_Institutions_InstitutionsTypes_InstitutionTypeId",
                table: "Institutions");

            migrationBuilder.DropForeignKey(
                name: "FK_Publications_Authors_AuthorId",
                table: "Publications");

            migrationBuilder.DropForeignKey(
                name: "FK_Publications_Countries_CountryId",
                table: "Publications");

            migrationBuilder.DropForeignKey(
                name: "FK_Publications_Institutions_InstitutionId",
                table: "Publications");

            migrationBuilder.DropForeignKey(
                name: "FK_Publications_Languages_LanguageId",
                table: "Publications");

            migrationBuilder.DropForeignKey(
                name: "FK_Publications_PublicationTypes_PublicationTypeId",
                table: "Publications");

            migrationBuilder.AlterColumn<int>(
                name: "PublicationTypeId",
                table: "Publications",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "LanguageId",
                table: "Publications",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "InstitutionId",
                table: "Publications",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "CountryId",
                table: "Publications",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "AuthorId",
                table: "Publications",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "InstitutionTypeId",
                table: "Institutions",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "InstitutionId",
                table: "Citations",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "CitationTypeId",
                table: "Citations",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "AuthorId",
                table: "Citations",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "FieldScienceId",
                table: "AreasScience",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_AreasScience_FieldsSciences_FieldScienceId",
                table: "AreasScience",
                column: "FieldScienceId",
                principalTable: "FieldsSciences",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Citations_Authors_AuthorId",
                table: "Citations",
                column: "AuthorId",
                principalTable: "Authors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Citations_CitationTypes_CitationTypeId",
                table: "Citations",
                column: "CitationTypeId",
                principalTable: "CitationTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Citations_Institutions_InstitutionId",
                table: "Citations",
                column: "InstitutionId",
                principalTable: "Institutions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Institutions_InstitutionsTypes_InstitutionTypeId",
                table: "Institutions",
                column: "InstitutionTypeId",
                principalTable: "InstitutionsTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Publications_Authors_AuthorId",
                table: "Publications",
                column: "AuthorId",
                principalTable: "Authors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Publications_Countries_CountryId",
                table: "Publications",
                column: "CountryId",
                principalTable: "Countries",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Publications_Institutions_InstitutionId",
                table: "Publications",
                column: "InstitutionId",
                principalTable: "Institutions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Publications_Languages_LanguageId",
                table: "Publications",
                column: "LanguageId",
                principalTable: "Languages",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Publications_PublicationTypes_PublicationTypeId",
                table: "Publications",
                column: "PublicationTypeId",
                principalTable: "PublicationTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AreasScience_FieldsSciences_FieldScienceId",
                table: "AreasScience");

            migrationBuilder.DropForeignKey(
                name: "FK_Citations_Authors_AuthorId",
                table: "Citations");

            migrationBuilder.DropForeignKey(
                name: "FK_Citations_CitationTypes_CitationTypeId",
                table: "Citations");

            migrationBuilder.DropForeignKey(
                name: "FK_Citations_Institutions_InstitutionId",
                table: "Citations");

            migrationBuilder.DropForeignKey(
                name: "FK_Institutions_InstitutionsTypes_InstitutionTypeId",
                table: "Institutions");

            migrationBuilder.DropForeignKey(
                name: "FK_Publications_Authors_AuthorId",
                table: "Publications");

            migrationBuilder.DropForeignKey(
                name: "FK_Publications_Countries_CountryId",
                table: "Publications");

            migrationBuilder.DropForeignKey(
                name: "FK_Publications_Institutions_InstitutionId",
                table: "Publications");

            migrationBuilder.DropForeignKey(
                name: "FK_Publications_Languages_LanguageId",
                table: "Publications");

            migrationBuilder.DropForeignKey(
                name: "FK_Publications_PublicationTypes_PublicationTypeId",
                table: "Publications");

            migrationBuilder.AlterColumn<int>(
                name: "PublicationTypeId",
                table: "Publications",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "LanguageId",
                table: "Publications",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "InstitutionId",
                table: "Publications",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CountryId",
                table: "Publications",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "AuthorId",
                table: "Publications",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "InstitutionTypeId",
                table: "Institutions",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "InstitutionId",
                table: "Citations",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CitationTypeId",
                table: "Citations",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "AuthorId",
                table: "Citations",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "FieldScienceId",
                table: "AreasScience",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_AreasScience_FieldsSciences_FieldScienceId",
                table: "AreasScience",
                column: "FieldScienceId",
                principalTable: "FieldsSciences",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Citations_Authors_AuthorId",
                table: "Citations",
                column: "AuthorId",
                principalTable: "Authors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Citations_CitationTypes_CitationTypeId",
                table: "Citations",
                column: "CitationTypeId",
                principalTable: "CitationTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Citations_Institutions_InstitutionId",
                table: "Citations",
                column: "InstitutionId",
                principalTable: "Institutions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Institutions_InstitutionsTypes_InstitutionTypeId",
                table: "Institutions",
                column: "InstitutionTypeId",
                principalTable: "InstitutionsTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Publications_Authors_AuthorId",
                table: "Publications",
                column: "AuthorId",
                principalTable: "Authors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Publications_Countries_CountryId",
                table: "Publications",
                column: "CountryId",
                principalTable: "Countries",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Publications_Institutions_InstitutionId",
                table: "Publications",
                column: "InstitutionId",
                principalTable: "Institutions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Publications_Languages_LanguageId",
                table: "Publications",
                column: "LanguageId",
                principalTable: "Languages",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Publications_PublicationTypes_PublicationTypeId",
                table: "Publications",
                column: "PublicationTypeId",
                principalTable: "PublicationTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

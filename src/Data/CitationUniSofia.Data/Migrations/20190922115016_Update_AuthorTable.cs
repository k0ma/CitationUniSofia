using Microsoft.EntityFrameworkCore.Migrations;

namespace CitationUniSofia.Data.Migrations
{
    public partial class Update_AuthorTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AuthorInstitutionId",
                table: "Authors");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AuthorInstitutionId",
                table: "Authors",
                nullable: true);
        }
    }
}

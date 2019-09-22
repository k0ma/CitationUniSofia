using Microsoft.EntityFrameworkCore.Migrations;

namespace CitationUniSofia.Data.Migrations
{
    public partial class AddISBNFieldPublicationTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ISBN",
                table: "Publications",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ISBN",
                table: "Publications");
        }
    }
}

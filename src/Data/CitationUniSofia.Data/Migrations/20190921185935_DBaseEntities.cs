using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CitationUniSofia.Data.Migrations
{
    public partial class DBaseEntities : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Authors",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 200, nullable: false),
                    AuthorIdentifier = table.Column<string>(nullable: true),
                    AuthorIdentifier1 = table.Column<string>(nullable: true),
                    AuthorInstitutionId = table.Column<string>(nullable: true),
                    AlternativeName = table.Column<string>(nullable: true),
                    TransliterationName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Authors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CitationTypes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CitationTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Countries",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Countries", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FieldsSciences",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    FieldScienceIdentifier = table.Column<string>(nullable: true),
                    FieldScienceIdentifier1 = table.Column<string>(nullable: true),
                    Name = table.Column<string>(maxLength: 200, nullable: false),
                    Name1 = table.Column<string>(nullable: true),
                    EnglishName = table.Column<string>(nullable: true),
                    EnglishName1 = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FieldsSciences", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "InstitutionsTypes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InstitutionsTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Languages",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Languages", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Metadata",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Metadata", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PublicationTypes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PublicationTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Institutions",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Identifier = table.Column<string>(nullable: true),
                    Identifier1 = table.Column<string>(nullable: true),
                    Name = table.Column<string>(maxLength: 200, nullable: false),
                    Name1 = table.Column<string>(nullable: true),
                    AlternativeName = table.Column<string>(nullable: true),
                    AlternativeName1 = table.Column<string>(nullable: true),
                    TransliterationName = table.Column<string>(nullable: true),
                    TransliterationName1 = table.Column<string>(nullable: true),
                    WWW = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    TransliterationAddress = table.Column<string>(nullable: true),
                    InstitutionTypeId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Institutions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Institutions_InstitutionsTypes_InstitutionTypeId",
                        column: x => x.InstitutionTypeId,
                        principalTable: "InstitutionsTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Citations",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    sequence = table.Column<int>(nullable: false),
                    Name = table.Column<string>(maxLength: 200, nullable: false),
                    Name1 = table.Column<string>(nullable: true),
                    Year = table.Column<string>(nullable: true),
                    Detail = table.Column<string>(nullable: true),
                    Detail1 = table.Column<string>(nullable: true),
                    Pages = table.Column<string>(nullable: true),
                    CitationTypeId = table.Column<int>(nullable: false),
                    AuthorId = table.Column<int>(nullable: false),
                    InstitutionId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Citations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Citations_Authors_AuthorId",
                        column: x => x.AuthorId,
                        principalTable: "Authors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Citations_CitationTypes_CitationTypeId",
                        column: x => x.CitationTypeId,
                        principalTable: "CitationTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Citations_Institutions_InstitutionId",
                        column: x => x.InstitutionId,
                        principalTable: "Institutions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Publications",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ISSN = table.Column<string>(nullable: true),
                    Title = table.Column<string>(maxLength: 200, nullable: false),
                    Title1 = table.Column<string>(nullable: true),
                    IndexedResource = table.Column<string>(nullable: true),
                    IndexedResource1 = table.Column<string>(nullable: true),
                    AlternativeIndexedResource = table.Column<string>(nullable: true),
                    AlternativeIndexedResource1 = table.Column<string>(nullable: true),
                    Detail = table.Column<string>(nullable: true),
                    Summary = table.Column<string>(nullable: true),
                    PublicationTypeId = table.Column<int>(nullable: false),
                    LanguageId = table.Column<int>(nullable: false),
                    CountryId = table.Column<int>(nullable: false),
                    AuthorId = table.Column<int>(nullable: false),
                    InstitutionId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Publications", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Publications_Authors_AuthorId",
                        column: x => x.AuthorId,
                        principalTable: "Authors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Publications_Countries_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Countries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Publications_Institutions_InstitutionId",
                        column: x => x.InstitutionId,
                        principalTable: "Institutions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Publications_Languages_LanguageId",
                        column: x => x.LanguageId,
                        principalTable: "Languages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Publications_PublicationTypes_PublicationTypeId",
                        column: x => x.PublicationTypeId,
                        principalTable: "PublicationTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PublicationsCitations",
                columns: table => new
                {
                    PublicationId = table.Column<int>(nullable: false),
                    CitationId = table.Column<int>(nullable: false),
                    Id = table.Column<int>(nullable: false),
                    Sequence = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PublicationsCitations", x => new { x.PublicationId, x.CitationId });
                    table.UniqueConstraint("AK_PublicationsCitations_Id", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PublicationsCitations_Citations_CitationId",
                        column: x => x.CitationId,
                        principalTable: "Citations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PublicationsCitations_Publications_PublicationId",
                        column: x => x.PublicationId,
                        principalTable: "Publications",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

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

            migrationBuilder.CreateTable(
                name: "PublicationsMetadata",
                columns: table => new
                {
                    PublicationId = table.Column<int>(nullable: false),
                    MetadataId = table.Column<int>(nullable: false),
                    Id = table.Column<int>(nullable: false),
                    Sequence = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PublicationsMetadata", x => new { x.PublicationId, x.MetadataId });
                    table.ForeignKey(
                        name: "FK_PublicationsMetadata_Metadata_MetadataId",
                        column: x => x.MetadataId,
                        principalTable: "Metadata",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PublicationsMetadata_Publications_PublicationId",
                        column: x => x.PublicationId,
                        principalTable: "Publications",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Citations_AuthorId",
                table: "Citations",
                column: "AuthorId");

            migrationBuilder.CreateIndex(
                name: "IX_Citations_CitationTypeId",
                table: "Citations",
                column: "CitationTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Citations_InstitutionId",
                table: "Citations",
                column: "InstitutionId");

            migrationBuilder.CreateIndex(
                name: "IX_Institutions_InstitutionTypeId",
                table: "Institutions",
                column: "InstitutionTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Publications_AuthorId",
                table: "Publications",
                column: "AuthorId");

            migrationBuilder.CreateIndex(
                name: "IX_Publications_CountryId",
                table: "Publications",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_Publications_InstitutionId",
                table: "Publications",
                column: "InstitutionId");

            migrationBuilder.CreateIndex(
                name: "IX_Publications_LanguageId",
                table: "Publications",
                column: "LanguageId");

            migrationBuilder.CreateIndex(
                name: "IX_Publications_PublicationTypeId",
                table: "Publications",
                column: "PublicationTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_PublicationsCitations_CitationId",
                table: "PublicationsCitations",
                column: "CitationId");

            migrationBuilder.CreateIndex(
                name: "IX_PublicationsFieldsSciences_FieldScienceId",
                table: "PublicationsFieldsSciences",
                column: "FieldScienceId");

            migrationBuilder.CreateIndex(
                name: "IX_PublicationsMetadata_MetadataId",
                table: "PublicationsMetadata",
                column: "MetadataId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PublicationsCitations");

            migrationBuilder.DropTable(
                name: "PublicationsFieldsSciences");

            migrationBuilder.DropTable(
                name: "PublicationsMetadata");

            migrationBuilder.DropTable(
                name: "Citations");

            migrationBuilder.DropTable(
                name: "FieldsSciences");

            migrationBuilder.DropTable(
                name: "Metadata");

            migrationBuilder.DropTable(
                name: "Publications");

            migrationBuilder.DropTable(
                name: "CitationTypes");

            migrationBuilder.DropTable(
                name: "Authors");

            migrationBuilder.DropTable(
                name: "Countries");

            migrationBuilder.DropTable(
                name: "Institutions");

            migrationBuilder.DropTable(
                name: "Languages");

            migrationBuilder.DropTable(
                name: "PublicationTypes");

            migrationBuilder.DropTable(
                name: "InstitutionsTypes");
        }
    }
}

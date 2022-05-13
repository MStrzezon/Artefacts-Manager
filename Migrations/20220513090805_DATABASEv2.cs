using Microsoft.EntityFrameworkCore.Migrations;
using MySql.EntityFrameworkCore.Metadata;

namespace ArtefactsManager.Migrations
{
    public partial class DATABASEv2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CategoryCharacter");

            migrationBuilder.DropTable(
                name: "Caves");

            migrationBuilder.DropTable(
                name: "Dragons");

            migrationBuilder.DropTable(
                name: "Ents");

            migrationBuilder.DropTable(
                name: "Groves");

            migrationBuilder.DropTable(
                name: "Mages");

            migrationBuilder.DropTable(
                name: "Quarters");

            migrationBuilder.DropTable(
                name: "Species");

            migrationBuilder.DropTable(
                name: "Towers");

            migrationBuilder.DropTable(
                name: "Characters");

            migrationBuilder.CreateTable(
                name: "ArtefactsTypes",
                columns: table => new
                {
                    ArtefactTypeId = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    ArtefactName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArtefactsTypes", x => x.ArtefactTypeId);
                });

            migrationBuilder.CreateTable(
                name: "Attributes",
                columns: table => new
                {
                    AttributeId = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Attributes", x => x.AttributeId);
                });

            migrationBuilder.CreateTable(
                name: "Artefacts",
                columns: table => new
                {
                    ArtefactId = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    ArtefactTypeId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Artefacts", x => x.ArtefactId);
                    table.ForeignKey(
                        name: "FK_Artefacts_ArtefactsTypes_ArtefactTypeId",
                        column: x => x.ArtefactTypeId,
                        principalTable: "ArtefactsTypes",
                        principalColumn: "ArtefactTypeId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AttributesArtefactsTypes",
                columns: table => new
                {
                    ArtefactTypeId = table.Column<int>(nullable: false),
                    AttributeId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AttributesArtefactsTypes", x => new { x.AttributeId, x.ArtefactTypeId });
                    table.ForeignKey(
                        name: "FK_AttributesArtefactsTypes_ArtefactsTypes_ArtefactTypeId",
                        column: x => x.ArtefactTypeId,
                        principalTable: "ArtefactsTypes",
                        principalColumn: "ArtefactTypeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AttributesArtefactsTypes_Attributes_AttributeId",
                        column: x => x.AttributeId,
                        principalTable: "Attributes",
                        principalColumn: "AttributeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ArtefactsAttributes",
                columns: table => new
                {
                    ArtefactId = table.Column<int>(nullable: false),
                    AttributeId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArtefactsAttributes", x => new { x.ArtefactId, x.AttributeId });
                    table.ForeignKey(
                        name: "FK_ArtefactsAttributes_Artefacts_ArtefactId",
                        column: x => x.ArtefactId,
                        principalTable: "Artefacts",
                        principalColumn: "ArtefactId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ArtefactsAttributes_Attributes_AttributeId",
                        column: x => x.AttributeId,
                        principalTable: "Attributes",
                        principalColumn: "AttributeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CategoriesArtefacts",
                columns: table => new
                {
                    CategoryId = table.Column<int>(nullable: false),
                    ArtefactId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoriesArtefacts", x => new { x.CategoryId, x.ArtefactId });
                    table.ForeignKey(
                        name: "FK_CategoriesArtefacts_Artefacts_ArtefactId",
                        column: x => x.ArtefactId,
                        principalTable: "Artefacts",
                        principalColumn: "ArtefactId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CategoriesArtefacts_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Artefacts_ArtefactTypeId",
                table: "Artefacts",
                column: "ArtefactTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_ArtefactsAttributes_AttributeId",
                table: "ArtefactsAttributes",
                column: "AttributeId");

            migrationBuilder.CreateIndex(
                name: "IX_AttributesArtefactsTypes_ArtefactTypeId",
                table: "AttributesArtefactsTypes",
                column: "ArtefactTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_CategoriesArtefacts_ArtefactId",
                table: "CategoriesArtefacts",
                column: "ArtefactId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ArtefactsAttributes");

            migrationBuilder.DropTable(
                name: "AttributesArtefactsTypes");

            migrationBuilder.DropTable(
                name: "CategoriesArtefacts");

            migrationBuilder.DropTable(
                name: "Attributes");

            migrationBuilder.DropTable(
                name: "Artefacts");

            migrationBuilder.DropTable(
                name: "ArtefactsTypes");

            migrationBuilder.CreateTable(
                name: "Caves",
                columns: table => new
                {
                    CaveId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Area = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Caves", x => x.CaveId);
                });

            migrationBuilder.CreateTable(
                name: "Characters",
                columns: table => new
                {
                    CharacterId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Characters", x => x.CharacterId);
                });

            migrationBuilder.CreateTable(
                name: "Dragons",
                columns: table => new
                {
                    DragonId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "text", nullable: true),
                    SpeciesId = table.Column<int>(type: "int", nullable: false),
                    WingSpan = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dragons", x => x.DragonId);
                });

            migrationBuilder.CreateTable(
                name: "Ents",
                columns: table => new
                {
                    EntId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "text", nullable: true),
                    SpeciesId = table.Column<int>(type: "int", nullable: false),
                    numberOfRings = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ents", x => x.EntId);
                });

            migrationBuilder.CreateTable(
                name: "Groves",
                columns: table => new
                {
                    GroveId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Area = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Groves", x => x.GroveId);
                });

            migrationBuilder.CreateTable(
                name: "Mages",
                columns: table => new
                {
                    MageId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "text", nullable: true),
                    PowerLevel = table.Column<int>(type: "int", nullable: false),
                    QuarterId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mages", x => x.MageId);
                });

            migrationBuilder.CreateTable(
                name: "Quarters",
                columns: table => new
                {
                    QuarterId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    QuarterName = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Quarters", x => x.QuarterId);
                });

            migrationBuilder.CreateTable(
                name: "Species",
                columns: table => new
                {
                    SpeciesId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    SpeciesName = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Species", x => x.SpeciesId);
                });

            migrationBuilder.CreateTable(
                name: "Towers",
                columns: table => new
                {
                    TowerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Height = table.Column<int>(type: "int", nullable: false),
                    Material = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Towers", x => x.TowerId);
                });

            migrationBuilder.CreateTable(
                name: "CategoryCharacter",
                columns: table => new
                {
                    CharacterId = table.Column<int>(type: "int", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoryCharacter", x => new { x.CharacterId, x.CategoryId });
                    table.ForeignKey(
                        name: "FK_CategoryCharacter_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CategoryCharacter_Characters_CharacterId",
                        column: x => x.CharacterId,
                        principalTable: "Characters",
                        principalColumn: "CharacterId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CategoryCharacter_CategoryId",
                table: "CategoryCharacter",
                column: "CategoryId");
        }
    }
}

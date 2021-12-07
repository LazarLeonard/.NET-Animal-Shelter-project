using Microsoft.EntityFrameworkCore.Migrations;

namespace Heaven.Migrations
{
    public partial class M1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Caini",
                columns: table => new
                {
                    CainiId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nume_caine = table.Column<string>(nullable: true),
                    varsta = table.Column<int>(nullable: false),
                    culoare = table.Column<string>(nullable: true),
                    marime = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Caini", x => x.CainiId);
                });

            migrationBuilder.CreateTable(
                name: "Pisici",
                columns: table => new
                {
                    PisiciId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nume_pisica = table.Column<string>(nullable: true),
                    varsta = table.Column<int>(nullable: false),
                    culoare = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pisici", x => x.PisiciId);
                });

            migrationBuilder.CreateTable(
                name: "Utilizator",
                columns: table => new
                {
                    UtilizatorId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nume = table.Column<string>(nullable: true),
                    Prenume = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Utilizator", x => x.UtilizatorId);
                });

            migrationBuilder.CreateTable(
                name: "Contact",
                columns: table => new
                {
                    ContactId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nume = table.Column<string>(nullable: true),
                    Prenume = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    UtilizatorId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contact", x => x.ContactId);
                    table.ForeignKey(
                        name: "FK_Contact_Utilizator_UtilizatorId",
                        column: x => x.UtilizatorId,
                        principalTable: "Utilizator",
                        principalColumn: "UtilizatorId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Doneaza",
                columns: table => new
                {
                    DoneazaId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nr_card = table.Column<int>(nullable: false),
                    data = table.Column<int>(nullable: false),
                    CVC = table.Column<int>(nullable: false),
                    UtilizatorId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Doneaza", x => x.DoneazaId);
                    table.ForeignKey(
                        name: "FK_Doneaza_Utilizator_UtilizatorId",
                        column: x => x.UtilizatorId,
                        principalTable: "Utilizator",
                        principalColumn: "UtilizatorId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Adaposts",
                columns: table => new
                {
                    AdapostId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    denumire = table.Column<int>(nullable: false),
                    adresa = table.Column<int>(nullable: false),
                    oras = table.Column<int>(nullable: false),
                    ContactId = table.Column<int>(nullable: true),
                    DoneazaId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Adaposts", x => x.AdapostId);
                    table.ForeignKey(
                        name: "FK_Adaposts_Contact_ContactId",
                        column: x => x.ContactId,
                        principalTable: "Contact",
                        principalColumn: "ContactId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Adaposts_Doneaza_DoneazaId",
                        column: x => x.DoneazaId,
                        principalTable: "Doneaza",
                        principalColumn: "DoneazaId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Poze",
                columns: table => new
                {
                    PozeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    id_pisica = table.Column<int>(nullable: false),
                    id_caine = table.Column<int>(nullable: false),
                    AdapostId = table.Column<int>(nullable: true),
                    CainiId = table.Column<int>(nullable: true),
                    PisiciId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Poze", x => x.PozeId);
                    table.ForeignKey(
                        name: "FK_Poze_Adaposts_AdapostId",
                        column: x => x.AdapostId,
                        principalTable: "Adaposts",
                        principalColumn: "AdapostId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Poze_Caini_CainiId",
                        column: x => x.CainiId,
                        principalTable: "Caini",
                        principalColumn: "CainiId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Poze_Pisici_PisiciId",
                        column: x => x.PisiciId,
                        principalTable: "Pisici",
                        principalColumn: "PisiciId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Adaposts_ContactId",
                table: "Adaposts",
                column: "ContactId");

            migrationBuilder.CreateIndex(
                name: "IX_Adaposts_DoneazaId",
                table: "Adaposts",
                column: "DoneazaId");

            migrationBuilder.CreateIndex(
                name: "IX_Contact_UtilizatorId",
                table: "Contact",
                column: "UtilizatorId");

            migrationBuilder.CreateIndex(
                name: "IX_Doneaza_UtilizatorId",
                table: "Doneaza",
                column: "UtilizatorId");

            migrationBuilder.CreateIndex(
                name: "IX_Poze_AdapostId",
                table: "Poze",
                column: "AdapostId");

            migrationBuilder.CreateIndex(
                name: "IX_Poze_CainiId",
                table: "Poze",
                column: "CainiId");

            migrationBuilder.CreateIndex(
                name: "IX_Poze_PisiciId",
                table: "Poze",
                column: "PisiciId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Poze");

            migrationBuilder.DropTable(
                name: "Adaposts");

            migrationBuilder.DropTable(
                name: "Caini");

            migrationBuilder.DropTable(
                name: "Pisici");

            migrationBuilder.DropTable(
                name: "Contact");

            migrationBuilder.DropTable(
                name: "Doneaza");

            migrationBuilder.DropTable(
                name: "Utilizator");
        }
    }
}

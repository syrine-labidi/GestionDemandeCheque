using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GchequeWebApp.Migrations
{
    public partial class hello : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "demandes",
                columns: table => new
                {
                    ID_demande = table.Column<int>(type: "int", nullable: false),
                    email_banque = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    num_arrivee = table.Column<int>(type: "int", nullable: true),
                    dateOuverture = table.Column<DateTime>(type: "date", nullable: true),
                    datePriseEncharge = table.Column<DateTime>(type: "date", nullable: true),
                    dateCloture = table.Column<DateTime>(type: "date", nullable: true),
                    dateLivraison = table.Column<DateTime>(type: "date", nullable: true),
                    num_depart = table.Column<int>(type: "int", nullable: true),
                    statut = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_demandes", x => x.ID_demande);
                });

            migrationBuilder.CreateTable(
                name: "cheques",
                columns: table => new
                {
                    numCheque = table.Column<string>(type: "varchar(8)", unicode: false, maxLength: 8, nullable: false),
                    RIB = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    montantCheque = table.Column<double>(type: "float", nullable: true),
                    datePresentation = table.Column<DateTime>(type: "date", nullable: true),
                    nombreJours = table.Column<int>(type: "int", nullable: true),
                    montantTarifs = table.Column<double>(type: "float", nullable: true),
                    ID_demande = table.Column<int>(type: "int", nullable: true),
                    demandesID_demande = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cheques", x => x.numCheque);
                    table.ForeignKey(
                        name: "FK_cheques_demandes_demandesID_demande",
                        column: x => x.demandesID_demande,
                        principalTable: "demandes",
                        principalColumn: "ID_demande",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "images_cheques",
                columns: table => new
                {
                    ID_image = table.Column<int>(type: "int", nullable: false),
                    image_cheque = table.Column<byte[]>(type: "image", nullable: false),
                    ID_demande = table.Column<int>(type: "int", nullable: true),
                    demandesID_demande = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_images_cheques", x => x.ID_image);
                    table.ForeignKey(
                        name: "FK_images_cheques_demandes_demandesID_demande",
                        column: x => x.demandesID_demande,
                        principalTable: "demandes",
                        principalColumn: "ID_demande",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "institutions",
                columns: table => new
                {
                    ID_institution = table.Column<int>(type: "int", nullable: false),
                    libelle_institution = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    adresse_institution = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    email_contact = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    nom_contact = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    tel_contact = table.Column<int>(type: "int", nullable: true),
                    ID_demande = table.Column<int>(type: "int", nullable: true),
                    demandesID_demande = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_institutions", x => x.ID_institution);
                    table.ForeignKey(
                        name: "FK_institutions_demandes_demandesID_demande",
                        column: x => x.demandesID_demande,
                        principalTable: "demandes",
                        principalColumn: "ID_demande",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "personnels",
                columns: table => new
                {
                    ID_personnel = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    login = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    mot_de_passe = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    nom_personnel = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: false),
                    pernom_personnel = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    type_role = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    ID_demande = table.Column<int>(type: "int", nullable: true),
                    demandesID_demande = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_personnels", x => x.ID_personnel);
                    table.ForeignKey(
                        name: "FK_personnels_demandes_demandesID_demande",
                        column: x => x.demandesID_demande,
                        principalTable: "demandes",
                        principalColumn: "ID_demande",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "statut",
                columns: table => new
                {
                    ID_statut = table.Column<int>(type: "int", nullable: false),
                    type_statut = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    ID_demande = table.Column<int>(type: "int", nullable: true),
                    demandesID_demande = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_statut", x => x.ID_statut);
                    table.ForeignKey(
                        name: "FK_statut_demandes_demandesID_demande",
                        column: x => x.demandesID_demande,
                        principalTable: "demandes",
                        principalColumn: "ID_demande",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tarifs",
                columns: table => new
                {
                    ID_tarifs = table.Column<int>(type: "int", nullable: false),
                    libelle_tarifs = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    periode_tarifs = table.Column<int>(type: "int", nullable: true),
                    tarifs = table.Column<double>(type: "float", nullable: true),
                    ID_demande = table.Column<int>(type: "int", nullable: true),
                    demandesID_demande = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tarifs", x => x.ID_tarifs);
                    table.ForeignKey(
                        name: "FK_tarifs_demandes_demandesID_demande",
                        column: x => x.demandesID_demande,
                        principalTable: "demandes",
                        principalColumn: "ID_demande",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "roles",
                columns: table => new
                {
                    ID_role = table.Column<int>(type: "int", nullable: false),
                    type_roles = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    ID_personnel = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    personnelsID_personnel = table.Column<string>(type: "varchar(10)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_roles", x => x.ID_role);
                    table.ForeignKey(
                        name: "FK_roles_personnels_personnelsID_personnel",
                        column: x => x.personnelsID_personnel,
                        principalTable: "personnels",
                        principalColumn: "ID_personnel");
                });

            migrationBuilder.CreateIndex(
                name: "IX_cheques_demandesID_demande",
                table: "cheques",
                column: "demandesID_demande");

            migrationBuilder.CreateIndex(
                name: "IX_images_cheques_demandesID_demande",
                table: "images_cheques",
                column: "demandesID_demande");

            migrationBuilder.CreateIndex(
                name: "IX_institutions_demandesID_demande",
                table: "institutions",
                column: "demandesID_demande");

            migrationBuilder.CreateIndex(
                name: "IX_personnels_demandesID_demande",
                table: "personnels",
                column: "demandesID_demande");

            migrationBuilder.CreateIndex(
                name: "IX_roles_personnelsID_personnel",
                table: "roles",
                column: "personnelsID_personnel");

            migrationBuilder.CreateIndex(
                name: "IX_statut_demandesID_demande",
                table: "statut",
                column: "demandesID_demande");

            migrationBuilder.CreateIndex(
                name: "IX_tarifs_demandesID_demande",
                table: "tarifs",
                column: "demandesID_demande");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "cheques");

            migrationBuilder.DropTable(
                name: "images_cheques");

            migrationBuilder.DropTable(
                name: "institutions");

            migrationBuilder.DropTable(
                name: "roles");

            migrationBuilder.DropTable(
                name: "statut");

            migrationBuilder.DropTable(
                name: "tarifs");

            migrationBuilder.DropTable(
                name: "personnels");

            migrationBuilder.DropTable(
                name: "demandes");
        }
    }
}

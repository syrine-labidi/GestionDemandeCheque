// <auto-generated />
using System;
using GchequeWebApp.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace GchequeWebApp.Migrations
{
    [DbContext(typeof(DbChequeContext))]
    [Migration("20220405120959_addIdentityV2")]
    partial class addIdentityV2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("GchequeWebApp.Models.cheques", b =>
                {
                    b.Property<string>("numCheque")
                        .HasMaxLength(8)
                        .IsUnicode(false)
                        .HasColumnType("varchar(8)");

                    b.Property<int?>("ID_demande")
                        .HasColumnType("int");

                    b.Property<string>("RIB")
                        .IsRequired()
                        .HasMaxLength(20)
                        .IsUnicode(false)
                        .HasColumnType("varchar(20)");

                    b.Property<DateTime?>("datePresentation")
                        .HasColumnType("date");

                    b.Property<int>("demandesID_demande")
                        .HasColumnType("int");

                    b.Property<double?>("montantCheque")
                        .HasColumnType("float");

                    b.Property<double?>("montantTarifs")
                        .HasColumnType("float");

                    b.Property<int?>("nombreJours")
                        .HasColumnType("int");

                    b.HasKey("numCheque");

                    b.HasIndex("demandesID_demande");

                    b.ToTable("cheques");
                });

            modelBuilder.Entity("GchequeWebApp.Models.demandes", b =>
                {
                    b.Property<int>("ID_demande")
                        .HasColumnType("int");

                    b.Property<DateTime?>("dateCloture")
                        .HasColumnType("date");

                    b.Property<DateTime?>("dateLivraison")
                        .HasColumnType("date");

                    b.Property<DateTime?>("dateOuverture")
                        .HasColumnType("date");

                    b.Property<DateTime?>("datePriseEncharge")
                        .HasColumnType("date");

                    b.Property<string>("email_banque")
                        .IsRequired()
                        .HasMaxLength(20)
                        .IsUnicode(false)
                        .HasColumnType("varchar(20)");

                    b.Property<int?>("num_arrivee")
                        .HasColumnType("int");

                    b.Property<int?>("num_depart")
                        .HasColumnType("int");

                    b.Property<string>("statut")
                        .IsRequired()
                        .HasMaxLength(20)
                        .IsUnicode(false)
                        .HasColumnType("varchar(20)");

                    b.HasKey("ID_demande");

                    b.ToTable("demandes");
                });

            modelBuilder.Entity("GchequeWebApp.Models.images_cheques", b =>
                {
                    b.Property<int>("ID_image")
                        .HasColumnType("int");

                    b.Property<int?>("ID_demande")
                        .HasColumnType("int");

                    b.Property<int>("demandesID_demande")
                        .HasColumnType("int");

                    b.Property<byte[]>("image_cheque")
                        .IsRequired()
                        .HasColumnType("image");

                    b.HasKey("ID_image");

                    b.HasIndex("demandesID_demande");

                    b.ToTable("images_cheques");
                });

            modelBuilder.Entity("GchequeWebApp.Models.institutions", b =>
                {
                    b.Property<int>("ID_institution")
                        .HasColumnType("int");

                    b.Property<int?>("ID_demande")
                        .HasColumnType("int");

                    b.Property<string>("adresse_institution")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<int>("demandesID_demande")
                        .HasColumnType("int");

                    b.Property<string>("email_contact")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("libelle_institution")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("nom_contact")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<int?>("tel_contact")
                        .HasColumnType("int");

                    b.HasKey("ID_institution");

                    b.HasIndex("demandesID_demande");

                    b.ToTable("institutions");
                });

            modelBuilder.Entity("GchequeWebApp.Models.personnels", b =>
                {
                    b.Property<string>("ID_personnel")
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("varchar(10)");

                    b.Property<int?>("ID_demande")
                        .HasColumnType("int");

                    b.Property<int>("demandesID_demande")
                        .HasColumnType("int");

                    b.Property<string>("login")
                        .IsRequired()
                        .HasMaxLength(20)
                        .IsUnicode(false)
                        .HasColumnType("varchar(20)");

                    b.Property<string>("mot_de_passe")
                        .IsRequired()
                        .HasMaxLength(20)
                        .IsUnicode(false)
                        .HasColumnType("varchar(20)");

                    b.Property<string>("nom_personnel")
                        .IsRequired()
                        .HasMaxLength(30)
                        .IsUnicode(false)
                        .HasColumnType("varchar(30)");

                    b.Property<string>("pernom_personnel")
                        .IsRequired()
                        .HasMaxLength(20)
                        .IsUnicode(false)
                        .HasColumnType("varchar(20)");

                    b.Property<string>("type_role")
                        .IsRequired()
                        .HasMaxLength(20)
                        .IsUnicode(false)
                        .HasColumnType("varchar(20)");

                    b.HasKey("ID_personnel");

                    b.HasIndex("demandesID_demande");

                    b.ToTable("personnels");
                });

            modelBuilder.Entity("GchequeWebApp.Models.roles", b =>
                {
                    b.Property<int>("ID_role")
                        .HasColumnType("int");

                    b.Property<string>("name_roles")
                        .IsRequired()
                        .HasMaxLength(20)
                        .IsUnicode(false)
                        .HasColumnType("varchar(20)");

                    b.Property<string>("personnelsID_personnel")
                        .HasColumnType("varchar(10)");

                    b.HasKey("ID_role");

                    b.HasIndex("personnelsID_personnel");

                    b.ToTable("roles");
                });

            modelBuilder.Entity("GchequeWebApp.Models.statut", b =>
                {
                    b.Property<int>("ID_statut")
                        .HasColumnType("int");

                    b.Property<int?>("ID_demande")
                        .HasColumnType("int");

                    b.Property<int>("demandesID_demande")
                        .HasColumnType("int");

                    b.Property<string>("type_statut")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.HasKey("ID_statut");

                    b.HasIndex("demandesID_demande");

                    b.ToTable("statut");
                });

            modelBuilder.Entity("GchequeWebApp.Models.tarifs", b =>
                {
                    b.Property<int>("ID_tarifs")
                        .HasColumnType("int");

                    b.Property<int?>("ID_demande")
                        .HasColumnType("int");

                    b.Property<int>("demandesID_demande")
                        .HasColumnType("int");

                    b.Property<string>("libelle_tarifs")
                        .IsRequired()
                        .HasMaxLength(20)
                        .IsUnicode(false)
                        .HasColumnType("varchar(20)");

                    b.Property<int?>("periode_tarifs")
                        .HasColumnType("int");

                    b.Property<double?>("tarifs1")
                        .HasColumnType("float")
                        .HasColumnName("tarifs");

                    b.HasKey("ID_tarifs");

                    b.HasIndex("demandesID_demande");

                    b.ToTable("tarifs");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("GchequeWebApp.Models.cheques", b =>
                {
                    b.HasOne("GchequeWebApp.Models.demandes", "demandes")
                        .WithMany("cheques")
                        .HasForeignKey("demandesID_demande")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("demandes");
                });

            modelBuilder.Entity("GchequeWebApp.Models.images_cheques", b =>
                {
                    b.HasOne("GchequeWebApp.Models.demandes", "demandes")
                        .WithMany("images_cheques")
                        .HasForeignKey("demandesID_demande")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("demandes");
                });

            modelBuilder.Entity("GchequeWebApp.Models.institutions", b =>
                {
                    b.HasOne("GchequeWebApp.Models.demandes", "demandes")
                        .WithMany("institutions")
                        .HasForeignKey("demandesID_demande")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("demandes");
                });

            modelBuilder.Entity("GchequeWebApp.Models.personnels", b =>
                {
                    b.HasOne("GchequeWebApp.Models.demandes", "demandes")
                        .WithMany("personnels")
                        .HasForeignKey("demandesID_demande")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("demandes");
                });

            modelBuilder.Entity("GchequeWebApp.Models.roles", b =>
                {
                    b.HasOne("GchequeWebApp.Models.personnels", "personnels")
                        .WithMany("roles")
                        .HasForeignKey("personnelsID_personnel");

                    b.Navigation("personnels");
                });

            modelBuilder.Entity("GchequeWebApp.Models.statut", b =>
                {
                    b.HasOne("GchequeWebApp.Models.demandes", "demandes")
                        .WithMany("statut1")
                        .HasForeignKey("demandesID_demande")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("demandes");
                });

            modelBuilder.Entity("GchequeWebApp.Models.tarifs", b =>
                {
                    b.HasOne("GchequeWebApp.Models.demandes", "demandes")
                        .WithMany("tarifs")
                        .HasForeignKey("demandesID_demande")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("demandes");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("GchequeWebApp.Models.demandes", b =>
                {
                    b.Navigation("cheques");

                    b.Navigation("images_cheques");

                    b.Navigation("institutions");

                    b.Navigation("personnels");

                    b.Navigation("statut1");

                    b.Navigation("tarifs");
                });

            modelBuilder.Entity("GchequeWebApp.Models.personnels", b =>
                {
                    b.Navigation("roles");
                });
#pragma warning restore 612, 618
        }
    }
}

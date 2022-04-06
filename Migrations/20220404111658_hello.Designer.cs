﻿// <auto-generated />
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
    [Migration("20220404111658_hello")]
    partial class hello
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

                    b.Property<string>("ID_personnel")
                        .IsRequired()
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("varchar(10)");

                    b.Property<string>("personnelsID_personnel")
                        .HasColumnType("varchar(10)");

                    b.Property<string>("type_roles")
                        .IsRequired()
                        .HasMaxLength(20)
                        .IsUnicode(false)
                        .HasColumnType("varchar(20)");

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
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.ComponentModel.DataAnnotations.Schema;

using System.Linq;

namespace GchequeWebApp.Models
{
    public partial class DbChequeContext : IdentityDbContext
    {
        public DbChequeContext()
           
        {
        }
        public DbChequeContext(DbContextOptions<DbChequeContext> options):base(options)

        {
        }

        public virtual DbSet<cheques> cheques { get; set; }
        public virtual DbSet<demandes> demandes { get; set; }
        public virtual DbSet<images_cheques> images_cheques { get; set; }
        public virtual DbSet<institutions> institutions { get; set; }
        public virtual DbSet<personnels> personnels { get; set; }
        public virtual DbSet<roles> roles { get; set; }
        public virtual DbSet<statut> statut { get; set; }
        public virtual DbSet<tarifs> tarifs { get; set; }

   
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<cheques>()
                .Property(e => e.numCheque)
                .IsUnicode(false);

            modelBuilder.Entity<cheques>()
                .Property(e => e.RIB)
                .IsUnicode(false);

            modelBuilder.Entity<demandes>()
                .Property(e => e.email_banque)
                .IsUnicode(false);

            modelBuilder.Entity<demandes>()
                .Property(e => e.statut)
                .IsUnicode(false);

            modelBuilder.Entity<institutions>()
                .Property(e => e.libelle_institution)
                .IsUnicode(false);

            modelBuilder.Entity<institutions>()
                .Property(e => e.adresse_institution)
                .IsUnicode(false);

            modelBuilder.Entity<institutions>()
                .Property(e => e.email_contact)
                .IsUnicode(false);

            modelBuilder.Entity<institutions>()
                .Property(e => e.nom_contact)
                .IsUnicode(false);

            modelBuilder.Entity<personnels>()
                .Property(e => e.ID_personnel)
                .IsUnicode(false);

            modelBuilder.Entity<personnels>()
                .Property(e => e.login)
                .IsUnicode(false);

            modelBuilder.Entity<personnels>()
                .Property(e => e.mot_de_passe)
                .IsUnicode(false);

            modelBuilder.Entity<personnels>()
                .Property(e => e.nom_personnel)
                .IsUnicode(false);

            modelBuilder.Entity<personnels>()
                .Property(e => e.pernom_personnel)
                .IsUnicode(false);

            modelBuilder.Entity<personnels>()
                .Property(e => e.type_role)
                .IsUnicode(false);

            modelBuilder.Entity<roles>()
                .Property(e => e.name_roles)
                .IsUnicode(false);

 

            modelBuilder.Entity<statut>()
                .Property(e => e.type_statut)
                .IsUnicode(false);

            modelBuilder.Entity<tarifs>()
                .Property(e => e.libelle_tarifs)
                .IsUnicode(false);
        }
    }
}

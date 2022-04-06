namespace GchequeWebApp.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
 

    public partial class demandes
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public demandes()
        {
            cheques = new HashSet<cheques>();
            images_cheques = new HashSet<images_cheques>();
            institutions = new HashSet<institutions>();
            personnels = new HashSet<personnels>();
            statut1 = new HashSet<statut>();
            tarifs = new HashSet<tarifs>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID_demande { get; set; }

        [StringLength(20)]
        public string email_banque { get; set; }

        public int? num_arrivee { get; set; }

        [Column(TypeName = "date")]
        public DateTime? dateOuverture { get; set; }

        [Column(TypeName = "date")]
        public DateTime? datePriseEncharge { get; set; }

        [Column(TypeName = "date")]
        public DateTime? dateCloture { get; set; }

        [Column(TypeName = "date")]
        public DateTime? dateLivraison { get; set; }

        public int? num_depart { get; set; }

        [StringLength(20)]
        public string statut { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<cheques> cheques { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<images_cheques> images_cheques { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<institutions> institutions { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<personnels> personnels { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<statut> statut1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tarifs> tarifs { get; set; }
    }
}

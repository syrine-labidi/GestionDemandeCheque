namespace GchequeWebApp.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
   

    public partial class institutions
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID_institution { get; set; }

        [StringLength(50)]
        public string libelle_institution { get; set; }

        [StringLength(50)]
        public string adresse_institution { get; set; }

        [StringLength(50)]
        public string email_contact { get; set; }

        [StringLength(50)]
        public string nom_contact { get; set; }

        public int? tel_contact { get; set; }

        public int? ID_demande { get; set; }

        public virtual demandes demandes { get; set; }
    }
}

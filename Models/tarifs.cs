namespace GchequeWebApp.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
   

    public partial class tarifs
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID_tarifs { get; set; }

        [StringLength(20)]
        public string libelle_tarifs { get; set; }

        public int? periode_tarifs { get; set; }

        [Column("tarifs")]
        public double? tarifs1 { get; set; }

        public int? ID_demande { get; set; }

        public virtual demandes demandes { get; set; }
    }
}

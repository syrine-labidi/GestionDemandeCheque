namespace GchequeWebApp.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
   

    public partial class cheques
    {
        [Key]
        [StringLength(8)]
        public string numCheque { get; set; }

        [StringLength(20)]
        public string RIB { get; set; }

        public double? montantCheque { get; set; }

        [Column(TypeName = "date")]
        public DateTime? datePresentation { get; set; }

        public int? nombreJours { get; set; }

        public double? montantTarifs { get; set; }

        public int? ID_demande { get; set; }

        public virtual demandes demandes { get; set; }
    }
}

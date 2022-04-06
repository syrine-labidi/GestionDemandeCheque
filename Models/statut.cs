namespace GchequeWebApp.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
   

    [Table("statut")]
    public partial class statut
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID_statut { get; set; }

        [StringLength(50)]
        public string type_statut { get; set; }

        public int? ID_demande { get; set; }

        public virtual demandes demandes { get; set; }
    }
}

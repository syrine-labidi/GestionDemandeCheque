namespace GchequeWebApp.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
   

    public partial class images_cheques
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID_image { get; set; }

        [Column(TypeName = "image")]
        public byte[] image_cheque { get; set; }

        public int? ID_demande { get; set; }

        public virtual demandes demandes { get; set; }
    }
}

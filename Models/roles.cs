namespace GchequeWebApp.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
   

    public partial class roles
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID_role { get; set; }

        [StringLength(20)]
        public string name_roles { get; set; }



        public virtual personnels personnels { get; set; }
    }
}

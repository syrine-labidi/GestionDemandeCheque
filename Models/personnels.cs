namespace GchequeWebApp.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
   

    public partial class personnels
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public personnels()
        {
            roles = new HashSet<roles>();
        }

        [Key]
        [StringLength(10)]
        public string ID_personnel { get; set; }

        [StringLength(20)]
        public string login { get; set; }

        [StringLength(20)]
        public string mot_de_passe { get; set; }

        [StringLength(30)]
        public string nom_personnel { get; set; }

        [StringLength(20)]
        public string pernom_personnel { get; set; }

        [StringLength(20)]
        public string type_role { get; set; }

        public int? ID_demande { get; set; }

        public virtual demandes demandes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<roles> roles { get; set; }
    }
}

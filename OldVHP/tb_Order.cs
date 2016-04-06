namespace OldVHP
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tb_Order
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tb_Order()
        {
            tb_Plan = new HashSet<tb_Plan>();
        }

        [Key]
        public int OrderID { get; set; }

        public DateTime OrderDate { get; set; }

        [Required]
        [StringLength(50)]
        public string Customer { get; set; }

        [StringLength(30)]
        public string PO { get; set; }

        [Required]
        [StringLength(50)]
        public string ProductName { get; set; }

        [StringLength(50)]
        public string PMIWorkNumber { get; set; }

        [Required]
        [StringLength(30)]
        public string ProductType { get; set; }

        [StringLength(15)]
        public string Purity { get; set; }

        [StringLength(15)]
        public string Method { get; set; }

        [StringLength(15)]
        public string Shape { get; set; }

        public double? Number { get; set; }

        [StringLength(10)]
        public string Unit { get; set; }

        [StringLength(50)]
        public string Dimension { get; set; }

        public DateTime? SendDateNeed { get; set; }

        [StringLength(50)]
        public string Receiver { get; set; }

        public bool? IsFinished { get; set; }

        public DateTime? SendDateFact { get; set; }

        [StringLength(250)]
        public string OrderMemo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_Plan> tb_Plan { get; set; }
    }
}

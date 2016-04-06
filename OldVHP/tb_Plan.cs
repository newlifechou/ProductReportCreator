namespace OldVHP
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tb_Plan
    {
        public int OrderID { get; set; }

        [Key]
        public int PlanID { get; set; }

        public DateTime VHPTimePlan { get; set; }

        public double? MoldMD { get; set; }

        public double? PressThick { get; set; }

        public int? PressNum { get; set; }

        [StringLength(50)]
        public string DeviceType { get; set; }

        [StringLength(300)]
        public string PowderRequire { get; set; }

        [StringLength(300)]
        public string FillRequire { get; set; }

        [StringLength(300)]
        public string MachineRequire { get; set; }

        [StringLength(10)]
        public string HighestPressure { get; set; }

        [StringLength(10)]
        public string HighestTemp { get; set; }

        [StringLength(300)]
        public string PlanMemo { get; set; }

        public bool? IsOkToSend { get; set; }

        public double? DensityCal { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public double? WeightS { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public double? WeightAll { get; set; }

        [StringLength(50)]
        public string PersonInCharge { get; set; }

        public virtual tb_Order tb_Order { get; set; }
    }
}

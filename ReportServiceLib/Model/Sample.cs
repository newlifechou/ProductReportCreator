using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace ReportServiceLib.Model
{
    public class Sample
    {

        public Guid Id { get; set; }
        [Required]
        public string Material { get; set; }
        [Required]
        public string Lot { get; set; }

        public string Customer { get; set; }
        public string PO { get; set; }
        public string Weight1 { get; set; }
        public string Weight2 { get; set; }
        public string Weight3 { get; set; }
        public string Weight4{ get; set; }
        public string ForTarget { get; set; }

        public DateTime CreateDate { get; set; }
        public string Remark { get; set; }
        public DateTime OrderDate { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace ReportServiceLib.Model
{
    public class Target
    {
        
        public Guid Id { get; set;}
        [Required]
        public string Material { get; set; }
        [Required]
        public string Lot { get; set; }
        public string MaterialAbbr { get; set; }

        public string Size { get; set; }
        public string Customer { get; set; }
        public string PO { get; set; }
        public string Density { get; set; }
        public string Weight { get; set; }
        public string Resistance { get; set; }
        public string XRFComposition { get; set; }
        public string Remark { get; set; }
        public string Dimension { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime OrderDate { get; set; }

    }
}
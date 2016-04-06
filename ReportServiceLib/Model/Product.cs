using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace ReportServiceLib.Model
{
    public class Product
    {
        public Guid Id { get; set;}
        public string Material { get; set; }
        public string Lot { get; set; }
        public string Size { get; set; }
        public string Customer { get; set; }
        public string PO { get; set; }
        public string Density { get; set; }
        public string Weight { get; set; }
        public string Resistance { get; set; }
        public string Composition { get; set; }


        public bool IsSend { get; set; }
        public DateTime SendDate { get; set; }
    }
}
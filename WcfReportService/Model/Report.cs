using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WcfReportService.Model
{
    [DataContract(Namespace ="Http://www.newlifechou.com")]
    public class ProductReport
    {
        [DataMember]
        public Guid Id { get; set;}
        [DataMember]
        public string Material { get; set; }
        [DataMember]
        public string Lot { get; set; }
        [DataMember]
        public string Size { get; set; }
        [DataMember]
        public string Customer { get; set; }
        [DataMember]
        public string PO { get; set; }
        [DataMember]
        public string Density { get; set; }
        [DataMember]
        public string Weight { get; set; }
        [DataMember]
        public string Resistance { get; set; }
        [DataMember]
        public string Composition { get; set; }
    }
}
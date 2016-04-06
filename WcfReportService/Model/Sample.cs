using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WcfReportService.Model
{
    [DataContract(Namespace ="http://www.newlifechou.com")]
    public class Sample
    {
        [DataMember]
        public Guid Id { get; set; }
        [DataMember]
        public string Composition { get; set; }
        [DataMember]
        public string Customer { get; set; }
        [DataMember]
        public string Lot { get; set; }
        [DataMember]
        public string PO { get; set; }
        [DataMember]
        public string Weight1 { get; set; }
        [DataMember]
        public string Weight2 { get; set; }
        [DataMember]
        public string Weight3 { get; set; }
        [DataMember]
        public string Weight4{ get; set; }

        [DataMember]
        public bool IsSend { get; set; }
        [DataMember]
        public DateTime SendDate { get; set; }

    }
}
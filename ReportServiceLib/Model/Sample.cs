using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace ReportServiceLib.Model
{
    public class Sample
    {

        public Guid Id { get; set; }
        public string Composition { get; set; }
        public string Customer { get; set; }
        public string Lot { get; set; }
        public string PO { get; set; }
        public string Weight1 { get; set; }
        public string Weight2 { get; set; }
        public string Weight3 { get; set; }
        public string Weight4{ get; set; }

        public bool IsSend { get; set; }
        public DateTime SendDate { get; set; }

    }
}
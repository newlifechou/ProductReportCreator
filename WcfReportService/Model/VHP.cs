using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

/*
    Developer:xs.zhou@outlook.com
    CreateTime:2016/4/6 14:52:44
*/
namespace WcfReportService.Model
{
    [DataContract(Namespace ="http://www.newlifechou.com")]
    public class VHP
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public DateTime VHPDate { get; set; }
        [DataMember]
        public string VHPDevice { get; set; }
        [DataMember]
        public string Customer { get; set; }
        [DataMember]
        public string PO { get; set; }
        [DataMember]
        public string ProductName { get; set; }
        [DataMember]
        public string PMIWorkingNumber { get; set; }
        [DataMember]
        public string Dimension { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
    Developer:xs.zhou@outlook.com
    CreateTime:2016/4/6 14:52:44
*/
namespace ReportServiceLib.Model
{
    public class VHP
    {
        public int PlanId { get; set; }
        public DateTime VHPDate { get; set; }
        public string VHPDevice { get; set; }
        public string Customer { get; set; }
        public string PO { get; set; }
        public string ProductName { get; set; }
        public string PMIWorkingNumber { get; set; }
        public string Dimension { get; set; }
    }
}

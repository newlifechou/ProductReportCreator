using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfReportCreator.ServiceReferenceTargetReport;

/*
    Developer:xs.zhou@outlook.com
    CreateTime:2016/4/20 14:58:13
*/
namespace WpfReportCreator.Service
{
    public class ReportTemplate
    {
        public int Id { get; set; }
        public string ReportTempateName { get; set; }
        //委托类型的Creator
        public Action<string,Target> ReportCreator { get; set; }
    }
}

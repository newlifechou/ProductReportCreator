using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
    Developer:xs.zhou@outlook.com
    CreateTime:2016/4/20 15:08:11
*/
namespace WpfReportCreator.Service
{
    public static class ReportTemplateFactory
    {
        public static List<ReportTemplate> GetReportTemlates()
        {
            List<ReportTemplate> templates = new List<ReportTemplate>();
            templates.Add(new ReportTemplate()
            {
                Id = 0,
                ReportTempateName = "ProductReport 产品报告第一版",
                ReportCreator = ActualReportCreator.CreateProductReport
            });
            templates.Add(new ReportTemplate()
            {
                Id = 1,
                ReportTempateName = "COAReport COA报告普通版",
                ReportCreator = ActualReportCreator.CreateCOAReport
            });
            templates.Add(new ReportTemplate()
            {
                Id = 2,
                ReportTempateName = "COAReport COA报告BridgeLine专用版",
                ReportCreator = ActualReportCreator.CreateCOAReport
            });
            return templates;
        }
    }
}

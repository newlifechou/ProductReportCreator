using Novacode;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfReportCreator.ServiceReferenceTargetReport;

/*
    Developer:xs.zhou@outlook.com
    CreateTime:2016/4/20 15:09:53
*/
namespace WpfReportCreator.Service
{
    public static class ActualReportCreator
    {
        public static void CreateProductReport(string fileName, Target target)
        {
            string sourceFile = @"Report\ProductTemplate.docx";
            CopyTemplate(sourceFile, fileName);
            using (DocX document=DocX.Load(fileName))
            {
                document.ReplaceText("[Material]", target.Material??"");
                document.ReplaceText("[Customer]", target.Customer ?? "");
                document.ReplaceText("[PO]", target.PO ?? "");
                document.ReplaceText("[CreateDate]", target.CreateDate.ToShortDateString());

                document.ReplaceText("[Lot]", target.Lot ?? "");
                document.ReplaceText("[Weight]", target.Weight ?? "");
                document.ReplaceText("[Density]", target.Density ?? "");
                document.ReplaceText("[Resistance]", target.Resistance ?? "");
                document.ReplaceText("[Remark]", target.Remark ?? "");

                if (!string.IsNullOrEmpty(target.Dimension))
                {

                }




                document.Save();
            }



        }
        public static void CreateCOAReport(string fileName, Target target)
        {

        }
        public static void CreateCOABridgeLineReport(string fileName, Target target)
        {

        }

        private static void CopyTemplate(string sourceFile,string targetFile)
        {
            if (File.Exists(targetFile))
            {
                File.Delete(targetFile);
            }
            File.Copy(sourceFile, targetFile);
        }
    }
}

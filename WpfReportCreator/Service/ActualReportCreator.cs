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
            using (DocX document = DocX.Load(fileName))
            {
                document.ReplaceText("[Material]", target.Material ?? "");
                document.ReplaceText("[Customer]", target.Customer ?? "");
                document.ReplaceText("[PO]", target.PO ?? "");
                document.ReplaceText("[CreateDate]", target.CreateDate.ToShortDateString());

                document.ReplaceText("[Lot]", target.Lot ?? "");
                document.ReplaceText("[Weight]", target.Weight ?? "");
                document.ReplaceText("[Density]", target.Density ?? "");
                document.ReplaceText("[Resistance]", target.Resistance ?? "");
                document.ReplaceText("[Remark]", target.Remark ?? "");

                //填充尺寸表格
                if (!string.IsNullOrEmpty(target.Dimension))
                {
                    string[] items = target.Dimension.Split(';');
                    document.ReplaceText("[D1]", items[0]);
                    document.ReplaceText("[D2]", items[1]);
                    document.ReplaceText("[H1]", items[2]);
                    document.ReplaceText("[H2]", items[3]);
                    document.ReplaceText("[H3]", items[4]);
                    document.ReplaceText("[H4]", items[5]);
                }
                else
                {
                    document.ReplaceText("[D1]", "");
                    document.ReplaceText("[D2]", "");
                    document.ReplaceText("[H1]", "");
                    document.ReplaceText("[H2]", "");
                    document.ReplaceText("[H3]", "");
                    document.ReplaceText("[H4]", "");
                }

                //填充XRF表格
                if (document.Tables!=null&&document.Tables.Count>0)
                {
                    Table mainTable = document.Tables[0];
                    Paragraph p = mainTable.Rows[9].Cells[0].Paragraphs[0];
                    string[] lines=target.XRFComposition.Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);

                    int rowCount = lines.Count();
                    int columnCount = lines[0].Split(',').Count();
                    //判断行数，如果小于2，则说明没有成分数据，而是测不出说明文本
                    if (rowCount<2)
                    {
                        document.ReplaceText("[XRFRemark]", target.XRFComposition);
                        return;
                    }
                    document.ReplaceText("[XRFRemark]", "以上成分存在测试偏差，仅供参考");


                    Table xrfTable = document.AddTable(rowCount, columnCount);
                    xrfTable.Design = TableDesign.TableGrid;
                    xrfTable.Alignment = Alignment.center;
                    xrfTable.AutoFit = AutoFit.Contents;


                    for (int i = 0; i < lines.Count(); i++)
                    {
                        string[] items = lines[i].Split(',');
                        for (int j = 0; j < items.Count(); j++)
                        {
                            xrfTable.Rows[i].Cells[j].Paragraphs[0].Append(items[j]);
                        }
                    }
                    p.InsertTableAfterSelf(xrfTable);

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

        private static void CopyTemplate(string sourceFile, string targetFile)
        {
            if (File.Exists(targetFile))
            {
                File.Delete(targetFile);
            }
            File.Copy(sourceFile, targetFile);
        }
    }
}

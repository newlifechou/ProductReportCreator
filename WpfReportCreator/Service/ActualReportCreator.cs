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
        /// <summary>
        /// 产品报告
        /// </summary>
        /// <param name="fileName"></param>
        /// <param name="target"></param>
        public static void CreateProductReport(string fileName, Target target)
        {
            string sourceFile = @"Report\ProductTemplate.docx";
            CopyTemplate(sourceFile, fileName);
            #region 生成部分
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
                document.ReplaceText("[Size]", target.Size ?? "");
                document.ReplaceText("[Dimension]", target.Dimension ?? "");


                //填充XRF表格
                if (document.Tables[0] != null)
                {
                    Table mainTable = document.Tables[0];
                    Paragraph p = mainTable.Rows[9].Cells[0].Paragraphs[0];
                    InsertXrfTable(document, p, target.XRFComposition, "无测试结果");
                }



                document.Save();
            }

            #endregion

        }


        /// <summary>
        /// COA报告
        /// </summary>
        /// <param name="fileName"></param>
        /// <param name="target"></param>
        public static void CreateCOAReport(string fileName, Target target)
        {
            string sourceFile = @"Report\COATemplate.docx";
            CopyTemplate(sourceFile, fileName);

            #region 生成部分
            using (DocX document = DocX.Load(fileName))
            {
                document.ReplaceText("[Customer]", target.Customer ?? "");
                string lotNumber = (target.MaterialAbbr ?? "") + "-" + (target.Lot ?? "");
                document.ReplaceText("[Lot]", lotNumber);
                document.ReplaceText("[PO]", target.PO ?? "");
                document.ReplaceText("[COADate]", DateTime.Now.ToString("MM/dd/yyyy"));
                document.ReplaceText("[Material]", target.Material ?? "");
                document.ReplaceText("[Size]", target.Size ?? "");
                document.ReplaceText("[Weight]", target.Weight ?? "");
                document.ReplaceText("[Density]", target.Density ?? "");
                document.ReplaceText("[Resistance]", target.Resistance ?? "");
                document.ReplaceText("[Dimension]", target.Dimension ?? "");
                document.ReplaceText("[OrderDate]", target.OrderDate.ToString("MM/dd/yyyy"));
                document.ReplaceText("[CreateDate]", target.CreateDate.ToString("MM/dd/yyyy"));

                //填充XRF表格
                if (document.Tables[1] != null)
                {
                    Table mainTable = document.Tables[1];
                    Paragraph p = mainTable.Rows[5].Cells[0].Paragraphs[0];
                    InsertXrfTable(document, p, target.XRFComposition, "No Composition Test Results");


                    //填充标称的成分
                    if (!string.IsNullOrEmpty(target.Material))
                    {
                        Paragraph elementNames = mainTable.Rows[4].Cells[0].Paragraphs[0];
                        foreach (var name in GetCompositionNames(target.Material))
                        {
                            elementNames.Append(name + "\r\n").FontSize(11).Font(new System.Drawing.FontFamily("Calibri"));
                        }

                        Paragraph elementValues = mainTable.Rows[4].Cells[1].Paragraphs[0];
                        Paragraph units = mainTable.Rows[4].Cells[2].Paragraphs[0];
                        foreach (var at in GetCompositionValues(target.Material))
                        {
                            elementValues.Append(at + "\r\n").FontSize(11).Font(new System.Drawing.FontFamily("Calibri"));
                            units.Append("Atm%" + "\r\n").FontSize(11).Font(new System.Drawing.FontFamily("Calibri"));
                        }

                    }
                }

                document.Save();
            }
            #endregion
        }


        /// <summary>
        /// COA韩国
        /// </summary>
        /// <param name="fileName"></param>
        /// <param name="target"></param>
        public static void CreateCOABridgeLineReport(string fileName, Target target)
        {
            string sourceFile = @"Report\COATempalteBridgeLine.docx";
            CopyTemplate(sourceFile, fileName);
            #region 生成部分
            using (DocX document = DocX.Load(fileName))
            {
                document.ReplaceText("[Customer]", target.Customer ?? "");
                string lotNumber = (target.MaterialAbbr ?? "") + "-" + (target.Lot ?? "");
                document.ReplaceText("[Lot]", lotNumber);
                document.ReplaceText("[PO]", target.PO ?? "");
                document.ReplaceText("[COADate]", DateTime.Now.ToString("MM/dd/yyyy"));

                document.ReplaceText("[Material]", target.Material ?? "");
                document.ReplaceText("[Size]", target.Size ?? "");
                document.ReplaceText("[Weight]", target.Weight ?? "");
                document.ReplaceText("[Density]", target.Density ?? "");
                document.ReplaceText("[Resistance]", target.Resistance ?? "");
                document.ReplaceText("[Dimension]", target.Dimension ?? "");
                document.ReplaceText("[OrderDate]", target.OrderDate.ToString("MM/dd/yyyy"));
                document.ReplaceText("[CreateDate]", target.CreateDate.ToString("MM/dd/yyyy"));

                //填充XRF表格
                //填充XRF表格
                if (document.Tables[1] != null)
                {
                    Table mainTable = document.Tables[1];
                    Paragraph p = mainTable.Rows[6].Cells[0].Paragraphs[0];
                    InsertXrfTable(document, p, target.XRFComposition, "No Composition Test Results");


                    //填充标称的成分
                    if (!string.IsNullOrEmpty(target.Material))
                    {
                        Paragraph elementNames = mainTable.Rows[4].Cells[0].Paragraphs[0];
                        foreach (var name in GetCompositionNames(target.Material))
                        {
                            elementNames.Append(name + "\r\n").FontSize(11).Font(new System.Drawing.FontFamily("Calibri"));
                        }

                        Paragraph elementValues = mainTable.Rows[4].Cells[1].Paragraphs[0];
                        Paragraph units = mainTable.Rows[4].Cells[2].Paragraphs[0];
                        foreach (var at in GetCompositionValues(target.Material))
                        {
                            elementValues.Append(at + "\r\n").FontSize(11).Font(new System.Drawing.FontFamily("Calibri"));
                            units.Append("Atm%" + "\r\n").FontSize(11).Font(new System.Drawing.FontFamily("Calibri"));
                        }

                    }


                }

                document.Save();
            }
            #endregion

        }

        /// <summary>
        /// 绑定报告
        /// </summary>
        /// <param name="fileName"></param>
        /// <param name="target"></param>
        public static void CreateOpticraftReport(string fileName, Target target)
        {
            string sourceFile = @"Report\GeAsSeElastomer440Blank.docx";
            CopyTemplate(sourceFile, fileName);
            #region 生成部分
            using (DocX document = DocX.Load(fileName))
            {
                string lotNumber = (target.MaterialAbbr ?? "") + "-" + (target.Lot ?? "");
                document.ReplaceText("[Lot]", lotNumber);
                document.ReplaceText("[PO]", target.PO ?? "");
                document.ReplaceText("[CurrentDate]", DateTime.Now.ToString("MM/dd/yyyy"));
                document.ReplaceText("[CurrentLot]", DateTime.Now.ToString("yyMMdd"));
                document.ReplaceText("[Size]", target.Size ?? "");
                document.ReplaceText("[MaterialAbbr]", target.MaterialAbbr ?? "");
                document.Save();
            }
            #endregion
        }
        /// <summary>
        /// 抛光报告
        /// </summary>
        /// <param name="fileName"></param>
        /// <param name="target"></param>
        public static void CreatePolishReport(string fileName, Target target)
        {
            string sourceFile = @"Report\OpticraftGrindingSeAsGe.docx";
            CopyTemplate(sourceFile, fileName);
            #region 生成部分
            using (DocX document = DocX.Load(fileName))
            {
                string lotNumber = (target.MaterialAbbr ?? "") + "-" + (target.Lot ?? "");
                document.ReplaceText("[Lot]", lotNumber);
                document.ReplaceText("[PO]", target.PO ?? "");
                document.ReplaceText("[CurrentDate]", DateTime.Now.ToString("MM/dd/yyyy"));
                document.ReplaceText("[CurrentLot]", DateTime.Now.ToString("yyMMdd"));
                document.ReplaceText("[Size]", target.Size ?? "");
                document.ReplaceText("[Dimension]", target.Dimension ?? "");
                document.Save();
            }
            #endregion
        }

        private static void CopyTemplate(string sourceFile, string targetFile)
        {
            if (File.Exists(targetFile))
            {
                File.Delete(targetFile);
            }
            File.Copy(sourceFile, targetFile);
        }

        private static void InsertXrfTable(DocX document, Paragraph p, string xrfComposition, string noCompositionMessage)
        {
            if (!string.IsNullOrEmpty(xrfComposition))
            {
                string[] lines = xrfComposition.Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);
                int rowCount = lines.Count();
                int columnCount = lines[0].Split(',').Count();

                if (rowCount < 2)
                {
                    p.InsertText(xrfComposition);
                }
                else
                {
                    Table xrfTable = document.AddTable(rowCount, columnCount);
                    xrfTable.Design = TableDesign.TableGrid;
                    xrfTable.Alignment = Alignment.center;
                    xrfTable.AutoFit = AutoFit.Contents;

                    for (int i = 0; i < lines.Count(); i++)
                    {
                        string[] items = lines[i].Split(',');
                        for (int j = 0; j < items.Count(); j++)
                        {
                            Cell cell = xrfTable.Rows[i].Cells[j];
                            cell.Width = 80;
                            cell.Paragraphs[0].Append(items[j]).FontSize(11).Font(new System.Drawing.FontFamily("Calibri"));
                        }
                    }
                    p.InsertTableAfterSelf(xrfTable);
                }

            }
            else
            {
                p.InsertText(noCompositionMessage);
            }
        }

        private static string[] GetMatchesString(string material, string pattern)
        {
            var matches = System.Text.RegularExpressions.Regex.Matches(material, pattern);
            string[] compositionNames = new string[matches.Count];
            for (int i = 0; i < matches.Count; i++)
            {
                compositionNames[i] = matches[i].Value;
            }
            return compositionNames;
        }

        private static string[] GetCompositionValues(string material)
        {
            return GetMatchesString(material, @"[\d\.]+");
        }

        private static string[] GetCompositionNames(string material)
        {
            return GetMatchesString(material, @"[A-Za-z]+");
        }
    }
}

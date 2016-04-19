using DocumentFormat.OpenXml.Wordprocessing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
    Developer:xs.zhou@outlook.com
    CreateTime:2016/4/19 11:26:59
*/
namespace WpfReportCreator.ReportTemplate
{
    public static class  GenerateTable
    {
        /// <summary>
        /// 利用XRF字符串来创建表格
        /// </summary>
        /// <param name="xrfComposition"></param>
        /// <returns></returns>
        public static Table CreateXRFTable(string xrfComposition)
        {
            string[] lines = xrfComposition.Split(new char[] { '\r', '\n' });
            Table table1 = new Table();

            foreach (var line in lines)
            {
                TableRow row = new TableRow();
                foreach (var item in line.Split(new char[] { ',' }))
                {
                    TableCell cell = new TableCell(new Paragraph(new Run(new Text(item))));
                    row.AppendChild(cell);
                }
                table1.AppendChild(row);
            }
            return table1;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfReportCreator.ServiceReferenceTargetReport;

/*
    Developer:xs.zhou@outlook.com
    CreateTime:2016/4/14 16:00:39
*/
namespace WpfReportCreator.Service
{
    public static class Common
    {
        public static string GetProductLotNumber(DateTime vhpDate, string vhpDevice)
        {
            string part1 = vhpDate.ToString("yyMMdd");
            string part2 = "Unknown";
            switch (vhpDevice)
            {
                case "A":
                    part2 = "M";
                    break;
                case "B":
                    part2 = "N";
                    break;
                case "C":
                    part2 = "O";
                    break;
                default:
                    part2 = "Unknown";
                    break;
            }
            return $"{part1}-{part2}-1";
        }

        /// <summary>
        /// 扩展方法
        /// </summary>
        /// <param name="target"></param>
        /// <returns></returns>
        public static Target DeepCopy(this Target t)
        {
            Target tmp = new Target();
            if (t != null)
            {
                tmp.Id = t.Id;
                tmp.Lot = t.Lot;
                tmp.Material = t.Material;
                tmp.Size = t.Size;
                tmp.Customer = t.Customer;
                tmp.PO = t.PO;
                tmp.Density = t.Density;
                tmp.Resistance = t.Resistance;
                tmp.XRFComposition = t.XRFComposition;
                tmp.Remark = t.Remark;
                tmp.CreateDate = t.CreateDate;
            }
            return tmp;
        }
    }
}
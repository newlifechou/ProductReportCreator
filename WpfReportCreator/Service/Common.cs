using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
    Developer:xs.zhou@outlook.com
    CreateTime:2016/4/14 16:00:39
*/
namespace WpfReportCreator.Service
{
    public static class Common
    {
        public static string GetProductLotNumber(DateTime vhpDate,string vhpDevice)
        {
            string part1 = vhpDate.ToString("yyMMdd");
            string part2="Unknown";
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
    }
}

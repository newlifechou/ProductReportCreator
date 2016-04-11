using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

/*
    Developer:xs.zhou@outlook.com
    CreateTime:2016/4/8 17:41:09
*/
namespace WpfReportCreator.Service
{
    public enum LogState
    {
        Pass,
        NotPass
    }
    /// <summary>
    /// 简易的登录资格验证类
    /// </summary>
    public static  class Access
    {
        public static LogState AccessState { get; set; }

        static Access()
        {
            AccessState = LogState.NotPass;
        }

        public static  bool Login(string pwd)
        {
            if (pwd=="newlifechou")
            {
                AccessState = LogState.Pass;
                return true;
            }
            return false;
        }

        public static void LogOut()
        {
            AccessState = LogState.NotPass;
        }




    }
}

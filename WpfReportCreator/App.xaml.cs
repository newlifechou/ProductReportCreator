using Microsoft.Practices.ServiceLocation;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace WpfReportCreator
{
    /// <summary>
    /// App.xaml 的交互逻辑
    /// </summary>
    public partial class App : Application
    {
        public static WindowManager MainWindowService
        {
            get
            {
                return ServiceLocator.Current.GetInstance<WindowManager>();
            }
        }
    }
}

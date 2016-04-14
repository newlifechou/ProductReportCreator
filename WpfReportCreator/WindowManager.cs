using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using WpfReportCreator.View;
using WpfReportCreator.ViewModel;

/*
    Developer:xs.zhou@outlook.com
    CreateTime:2016/4/14 9:17:32
*/
namespace WpfReportCreator
{
    public class WindowManager
    {

        public void ShowUCTargetView()
        {
            MainView main =App.Current.MainWindow as MainView;
            UCTargetView childView = new UCTargetView();
            UCTargetViewModel childViewModel = new UCTargetViewModel();
            childView.DataContext = childViewModel;
            main.mainContent.Content = childView;
        }

        public void ShowUCSampleView()
        {

        }

    }
}

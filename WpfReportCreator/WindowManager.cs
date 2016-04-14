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
        private MainView main;
        private UCTargetView targetView;
        private UCSampleView sampleView;



        public WindowManager()
        {
            //只实例化一次
            main = App.Current.MainWindow as MainView;
            targetView = new UCTargetView();
            sampleView = new UCSampleView();
        }

        #region 项目窗体区域
        public void ShowUCTargetView()
        {
            main.mainContent.Content = targetView;
        }

        public void ShowUCSampleView()
        {
            main.mainContent.Content = sampleView;
        }
        #endregion



        #region MessageBox区域
        public bool ShowMessageBoxOKCancel(string message, string title)
        {
            return MessageBox.Show(message, title) == MessageBoxResult.OK;
        }
        #endregion


    }
}

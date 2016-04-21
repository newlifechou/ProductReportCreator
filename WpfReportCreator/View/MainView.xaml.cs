using Microsoft.Practices.ServiceLocation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WpfReportCreator.ViewModel;

namespace WpfReportCreator.View
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainView : Window
    {
        public MainView()
        {
            InitializeComponent();
            App.MainWindowService.ShowUCTargetView();
        }

        #region 内容控件
        private LogInView logInView;
        #endregion
        private bool CheckAuth()
        {
            return Service.Access.AccessState == Service.LogState.Pass;
        }

        private void LogIn_Click(object sender, RoutedEventArgs e)
        {
            if (CheckAuth())
            {
                MessageBox.Show("You have Logged in!");
                return;
            }
            logInView = new LogInView();
            logInView.ShowDialog();
        }

        /// <summary>
        /// let WindowManager use it
        /// </summary>
        public void SetMainContent(UserControl uc)
        {
            if (uc!=null)
            {
                this.mainContent.Content = uc;
            }
        }

    }
}

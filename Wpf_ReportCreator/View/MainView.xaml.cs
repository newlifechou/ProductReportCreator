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
            ucTargetView = new UCTargetView();
            ucSampleView = new UCSampleView();


            mainContent.Content = ucTargetView;
        }
        #region 内容控件
        private UCTargetView ucTargetView;
        private UCSampleView ucSampleView;
        #endregion


        private void btnProductView_Click(object sender, RoutedEventArgs e)
        {
            mainContent.Content = ucTargetView;
        }

        private void btnSampleView_Click(object sender, RoutedEventArgs e)
        {
            mainContent.Content = ucSampleView;
        }
    }
}

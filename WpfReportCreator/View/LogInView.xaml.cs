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
using System.Windows.Shapes;

namespace WpfReportCreator.View
{
    /// <summary>
    /// LogIn.xaml 的交互逻辑
    /// </summary>
    public partial class LogInView : Window
    {
        public LogInView()
        {
            InitializeComponent();
        }

        private void LogIn_Click(object sender, RoutedEventArgs e)
        {
            if (!Service.Access.Login(txtPassCode.Text.Trim()))
            {
                MessageBox.Show("Wrong PassCode");
                return;
            }
            this.Close();
        }
    }
}

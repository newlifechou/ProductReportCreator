using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using WpfReportCreator.ServiceReferenceTargetReport;
using WpfReportCreator.View;
using WpfReportCreator.ViewModel;
using System.Windows.Forms;
using WpfReportCreator.Service;
using WpfReportCreator.ServiceReferenceSampleReport;
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
        private UCTargetEditView targetEditView;

        private UCTargetEditViewModel targetEditViewModel;

        private ReportView reportView;
        private ReportViewModel reportViewModel;

        private UCSampleEditView sampleEditView;
        private UCSampleEditViewModel sampleEditViewModel;


        public WindowManager()
        {
            //只实例化一次
            main = App.Current.MainWindow as MainView;
            targetView = new UCTargetView();
            sampleView = new UCSampleView();
            targetEditView = new UCTargetEditView();

            targetEditViewModel = new UCTargetEditViewModel();
            reportView = new ReportView();
            reportViewModel = new ReportViewModel();

            sampleEditView = new UCSampleEditView();
            sampleEditViewModel = new UCSampleEditViewModel();
        }

        #region 项目窗体区域
        public void ShowUCTargetView()
        {
            main.SetMainContent(targetView);
        }

        public void ShowUCSampleView()
        {
            main.SetMainContent(sampleView);
        }

        public void ShowTargetEdit(Target target, NewOrUpdate flag)
        {
            //这里target不能够直接引用，不然编辑窗口就会和主窗口的当前选择项就会是同一个数据项了
            //需要深拷贝才行
            Target tmpTarget = target.DeepCopy();
            targetEditViewModel.CurrentTarget = tmpTarget;
            targetEditViewModel.EditFlag = flag;

            targetEditView.DataContext = targetEditViewModel;
            main.SetMainContent(targetEditView);
        }
        /// <summary>
        /// 用于下级视图返回
        /// </summary>
        public void ReturnToTargetEdit()
        {
            main.SetMainContent(targetEditView);
        }


        /// <summary>
        /// 显示VHP计划选择视图
        /// </summary>
        public void ShowVHPSelect(string msg)
        {
            UCVHPSelectView viewVHPSelect = new UCVHPSelectView();
            UCVHPSelectViewModel vm = new UCVHPSelectViewModel();
            vm.Msg = msg;
            viewVHPSelect.DataContext = vm;
            main.SetMainContent(viewVHPSelect);
        }

        /// <summary>
        ///显示报告视图 
        /// </summary>
        public void ShowReport(Target target)
        {
            reportViewModel.CurrentTarget = target;
            reportView.DataContext = reportViewModel;
            main.SetMainContent(reportView);
        }


        public void ShowSampleEdit(Sample sample, NewOrUpdate flag)
        {
            Sample tmpSample = sample.DeepCopy();
            sampleEditViewModel.CurrentSample = tmpSample;
            sampleEditViewModel.Flag = flag;
            sampleEditView.DataContext = sampleEditViewModel;
            main.SetMainContent(sampleEditView);

        }

        public void ReturnToSampleEdit()
        {
            main.SetMainContent(sampleEditView);
        }

        #endregion



        #region MessageBox区域
        /// <summary>
        /// 警告信息显示对话框
        /// </summary>
        /// <param name="message"></param>
        /// <param name="title"></param>
        /// <returns></returns>
        public bool ShowWarningWithOKCancel(string message, string title)
        {
            return System.Windows.MessageBox.Show(message, title, MessageBoxButton.OKCancel, MessageBoxImage.Warning)
                == MessageBoxResult.OK;
        }

        public void ShowOKInfo(string message, string title)
        {
            System.Windows.MessageBox.Show(message, title, MessageBoxButton.OK, System.Windows.MessageBoxImage.Information);
        }
        /// <summary>
        /// 文件夹选择对话框
        /// </summary>
        /// <returns></returns>
        public string ShowFolderSelectDialog()
        {
            FolderBrowserDialog folderSelect = new FolderBrowserDialog();
            folderSelect.Description = "Please select the target folder";
            folderSelect.ShowNewFolderButton = true;
            folderSelect.RootFolder = Environment.SpecialFolder.Desktop;
            if (folderSelect.ShowDialog() == DialogResult.OK)
            {
                return folderSelect.SelectedPath;
            }
            return Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
        }
        #endregion


    }
}

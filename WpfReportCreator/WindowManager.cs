using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using WpfReportCreator.ServiceReferenceTargetReport;
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
        private UCTargetEditView targetEditView;

        private UCTargetEditViewModel targetEditViewModel;

        public WindowManager()
        {
            //只实例化一次
            main = App.Current.MainWindow as MainView;
            targetView = new UCTargetView();
            sampleView = new UCSampleView();
            targetEditView = new UCTargetEditView();

            targetEditViewModel = new UCTargetEditViewModel();
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

        public void ShowTargetEdit(Target target, NewOrUpdate flag)
        {
            targetEditViewModel.CurrentTarget = target;
            targetEditViewModel.EditFlag = flag;

            targetEditView.DataContext = targetEditViewModel;
            main.mainContent.Content = targetEditView;
        }
        /// <summary>
        /// 用于下级视图返回
        /// </summary>
        public void ReturnToTargetEdit()
        {
            main.mainContent.Content = targetEditView;
        }


        public void ShowVHPSelect()
        {
            UCVHPSelectView view = new UCVHPSelectView();
            main.mainContent.Content = view;
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

using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfReportCreator.ReportTemplate;
using WpfReportCreator.ServiceReferenceTargetReport;

/*
    Developer:xs.zhou@outlook.com
    CreateTime:2016/4/18 12:44:55
*/
namespace WpfReportCreator.ViewModel
{
    public class ReportViewModel:ViewModelBase
    {
        public ReportViewModel()
        {
            savePath = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
            ProductReportCommand = new RelayCommand(ActionProductReport);
            CoaReportCommand = new RelayCommand(ActionCoaReport);
            BrowseSavePathCommand = new RelayCommand(BrowseSavePathExecute);
        }

        private void BrowseSavePathExecute()
        {
            SavePath=App.MainWindowService.ShowFolderSelectDialog();
        }

        private void ActionCoaReport()
        {
            throw new NotImplementedException();
        }

        private void ActionProductReport()
        {
            if (CurrentTarget!=null)
            {
                string fileName = $"Lot#{CurrentTarget.Lot}-{CurrentTarget.Material}-{CurrentTarget.Customer}.docx".Replace('%',' ');
                
                string filePath = System.IO.Path.Combine(SavePath,fileName );

                ProductReportTemplate template = new ProductReportTemplate();
                template.CurrentTarget = CurrentTarget;
                template.CreatePackage(filePath);
                App.MainWindowService.ShowOKInfo($"Report is Created at {SavePath} ", "OK");
            }
        }

        private Target currentTarget;
        public Target CurrentTarget
        {
            get { return currentTarget; }
            set
            {
                if (currentTarget == value)
                    return;
                currentTarget = value;
                RaisePropertyChanged(() => CurrentTarget);
            }
        }

        private ObservableCollection<string> productReportTemplates;
        public ObservableCollection<string> ProductReportTemplates
        {
            get { return productReportTemplates; }
            set
            {
                if (productReportTemplates == value)
                    return;
                productReportTemplates = value;
                RaisePropertyChanged(() => ProductReportTemplates);
            }
        }

        private ObservableCollection<string> coaReportTemplates;
        public ObservableCollection<string> CoaReportTemplates
        {
            get { return coaReportTemplates; }
            set
            {
                if (coaReportTemplates == value)
                    return;
                coaReportTemplates = value;
                RaisePropertyChanged(() => CoaReportTemplates);
            }
        }
        //文件存储路径
        private string savePath;
        public string SavePath
        {
            get { return savePath; }
            set
            {
                if (savePath == value)
                    return;
                savePath = value;
                RaisePropertyChanged(() => SavePath);
            }
        }


        public RelayCommand ProductReportCommand { get; set; }
        public RelayCommand CoaReportCommand { get; set; }
        public RelayCommand BrowseSavePathCommand { get; set; }
    }
}

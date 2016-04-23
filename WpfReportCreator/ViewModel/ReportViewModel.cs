using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfReportCreator.Service;
using WpfReportCreator.ServiceReferenceTargetReport;

/*
    Developer:xs.zhou@outlook.com
    CreateTime:2016/4/18 12:44:55
*/
namespace WpfReportCreator.ViewModel
{
    public class ReportViewModel : ViewModelBase
    {
        public ReportViewModel()
        {
            savePath = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
            ReportTemplates = new ObservableCollection<ReportTemplate>(ReportTemplateFactory.GetReportTemlates());
            ReportCommand = new RelayCommand<ReportTemplate>(ActionReport);
            BrowseSavePathCommand = new RelayCommand(BrowseSavePathExecute);



        }
        //    

        //    string filePath =
        private void ActionReport(ReportTemplate obj)
        {

            obj.ReportCreator(FilePath(obj.Id),CurrentTarget);

            App.MainWindowService.ShowOKInfo($"Report is Created at {SavePath} ", obj.ReportTempateName);
        }
        private string FilePath(int id)
        {
            string filePath = string.Empty;
            switch (id)
            {
                case 0:
                    string fileStr1 = $"Lot#{CurrentTarget.Lot}-{CurrentTarget.Material}-{CurrentTarget.Customer}.docx".Replace('%', ' ');
                    filePath = GetFilePath(fileStr1);
                    break;
                case 1:
                    string fileStr2 = $"COA-Lot#{CurrentTarget.Lot}-{CurrentTarget.Material}.docx";
                    filePath = GetFilePath(fileStr2);
                    break;
                case 2:
                    string fileStr3 = $"COABridgeLine-Lot#{CurrentTarget.Lot}-{CurrentTarget.Material}.docx";
                    filePath = GetFilePath(fileStr3);
                    break;
                case 3:
                    string fileStr4 = "绑定加工订单" + DateTime.Now.ToString("yyyyMMddHHmmss") + ".docx";
                    filePath = GetFilePath(fileStr4);
                    break;
                case 4:
                    string fileStr5 = "440抛光加工订单" + DateTime.Now.ToString("yyyyMMddHHmmss") + ".docx";
                    filePath = GetFilePath(fileStr5);
                    break;
                default:
                    throw new Exception("File Name Not Right");
            }
            return filePath;
        }
        private string GetFilePath(string fileName)
        {
            return System.IO.Path.Combine(SavePath, fileName);
        }

        private void BrowseSavePathExecute()
        {
            SavePath = App.MainWindowService.ShowFolderSelectDialog();
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

        private ObservableCollection<ReportTemplate> reportTemplates;
        public ObservableCollection<ReportTemplate> ReportTemplates
        {
            get { return reportTemplates; }
            set
            {
                if (reportTemplates == value)
                    return;
                reportTemplates = value;
                RaisePropertyChanged(() => ReportTemplates);
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


        public RelayCommand<ReportTemplate> ReportCommand { get; set; }
        public RelayCommand BrowseSavePathCommand { get; set; }
    }
}

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

        private void ActionReport(ReportTemplate obj)
        {
            obj.ReportCreator();
            App.MainWindowService.ShowOKInfo($"Report is Created at {SavePath} ", obj.ReportTempateName);
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

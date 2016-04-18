using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            ProductReportCommand = new RelayCommand(ActionProductReport);
            CoaReportCommand = new RelayCommand(ActionCoaReport);
        }

        private void ActionCoaReport()
        {
            throw new NotImplementedException();
        }

        private void ActionProductReport()
        {
            throw new NotImplementedException();
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

        public RelayCommand ProductReportCommand { get; set; }
        public RelayCommand CoaReportCommand { get; set; }


    }
}

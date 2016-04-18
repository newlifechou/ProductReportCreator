using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
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


    }
}

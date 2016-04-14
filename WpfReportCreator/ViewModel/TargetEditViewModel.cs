using System;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;
using WpfReportCreator.ServiceReferenceTargetReport;
using Microsoft.Practices.ServiceLocation;

namespace WpfReportCreator.ViewModel
{
    /// <summary>
    /// This class contains properties that a View can data bind to.
    /// <para>
    /// See http://www.galasoft.ch/mvvm
    /// </para>
    /// </summary>
    public class TargetEditViewModel : ViewModelBase
    {
        /// <summary>
        /// Initializes a new instance of the TargetEditViewModel class.
        /// </summary>
        public TargetEditViewModel()
        {
            SelectVHPCommand = new RelayCommand(SelectVHPAction);
        }

        private void SelectVHPAction()
        {
            ServiceLocator.Current.GetInstance<WindowManager>().ShowVHPSelect();
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
        //标志是新建还是更新
        public NewOrUpdate EditFlag { get; set; }


        public RelayCommand SelectVHPCommand { get; set; }

    }
}
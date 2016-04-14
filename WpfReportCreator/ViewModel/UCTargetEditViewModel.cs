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
    public class UCTargetEditViewModel : ViewModelBase
    {
        /// <summary>
        /// Initializes a new instance of the TargetEditViewModel class.
        /// </summary>
        public UCTargetEditViewModel()
        {
            SelectVHPCommand = new RelayCommand(SelectVHPAction);
            GiveUpCommand = new RelayCommand(GiveUpAction);
        }

        private void GiveUpAction()
        {
            App.MainWindowService.ShowUCTargetView();
        }

        private void SelectVHPAction()
        {
            App.MainWindowService.ShowVHPSelect();
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
        public RelayCommand GiveUpCommand { get; set; }
    }
}
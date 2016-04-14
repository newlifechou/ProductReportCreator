using System;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;
using WpfReportCreator.ServiceReferenceTargetReport;
using Microsoft.Practices.ServiceLocation;
using GalaSoft.MvvmLight.Messaging;
using WpfReportCreator.ServiceReferenceVHP;

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
            SaveCommand = new RelayCommand(SaveAction);


            Messenger.Default.Register<NotificationMessage<VHP>>(this, "VHPSelect", msg =>
            {
                var gg = msg.Content;
                Target tmp = new Target()
                {
                    Id=CurrentTarget.Id,
                    CreateDate = DateTime.Now,
                    Customer = gg.Customer,
                    PO = gg.PO,
                    Material = gg.ProductName,
                    Size = gg.Dimension,
                    Lot = gg.VHPDate.ToString("yyMMdd")
                };
                CurrentTarget = tmp;

                RaisePropertyChanged(() => CurrentTarget);
            });
        }

        private void SaveAction()
        {
            if (CurrentTarget!=null)
            {
                TargetReportServiceClient client = new TargetReportServiceClient();
                if (client.AddTarget(CurrentTarget))
                {
                    App.MainWindowService.ShowUCTargetView();
                }
                else
                {
                    App.MainWindowService.ShowMessageBoxOKCancel("Error", "Error");
                }

            }
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
        public RelayCommand SaveCommand { get; set; }
    }
}
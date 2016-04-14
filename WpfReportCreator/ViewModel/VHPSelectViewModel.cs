using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;
using System.Collections.ObjectModel;
using WpfReportCreator.ServiceReferenceVHP;
using System;
using GalaSoft.MvvmLight.Messaging;

namespace WpfReportCreator.ViewModel
{
    /// <summary>
    /// This class contains properties that a View can data bind to.
    /// <para>
    /// See http://www.galasoft.ch/mvvm
    /// </para>
    /// </summary>
    public class VHPSelectViewModel : ViewModelBase
    {
        /// <summary>
        /// Initializes a new instance of the VHPSelectViewModel class.
        /// </summary>
        public VHPSelectViewModel()
        {
            VHPServiceClient client = new VHPServiceClient();
            VHPs = new ObservableCollection<VHP>(client.GetVHPs(0,20));
            if (VHPs.Count>0)
            {
                CurrentVHP = VHPs[0];
            }

            SelectCommand = new RelayCommand(SelectAction);
            GiveUpCommand = new RelayCommand(GiveUpAction);

        }

        private void GiveUpAction()
        {
            App.MainWindowService.ReturnToTargetEdit();
        }

        private void SelectAction()
        {
            Messenger.Default.Send<NotificationMessage<VHP>>(new NotificationMessage<VHP>(CurrentVHP,""), "VHPSelect");
            App.MainWindowService.ReturnToTargetEdit();
        }

        private VHP currentVHP;
        public VHP CurrentVHP
        {
            get { return currentVHP; }
            set
            {
                if (currentVHP == value)
                    return;
                currentVHP = value;
                RaisePropertyChanged(() => CurrentVHP);
            }
        }


        private ObservableCollection<VHP> vhps;
        public ObservableCollection<VHP> VHPs
        {
            get { return vhps; }
            set
            {
                if (vhps == value)
                    return;
                vhps = value;
                RaisePropertyChanged(() => VHPs);
            }
        }
        public RelayCommand SelectCommand { get; set; }
        public RelayCommand GiveUpCommand { get; set; }

    }
}
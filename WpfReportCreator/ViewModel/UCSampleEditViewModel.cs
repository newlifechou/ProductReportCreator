using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;
using GalaSoft.MvvmLight.Messaging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfReportCreator.Service;
using WpfReportCreator.ServiceReferenceSampleReport;
using WpfReportCreator.ServiceReferenceVHP;

namespace WpfReportCreator.ViewModel
{
    public class UCSampleEditViewModel : ViewModelBase
    {
        public UCSampleEditViewModel()
        {
            SaveCommand = new RelayCommand(SaveExecute);
            GiveUpCommand = new RelayCommand(GiveUpExecute);
            SelectVHPCommand = new RelayCommand(VHPSelectExecute);
            Messenger.Default.Register<NotificationMessage<VHP>>(this, "SampleSelect", msg =>
            {
                var gg = msg.Content;
                Sample tmp = new Sample()
                {
                    Id = CurrentSample.Id,
                    CreateDate = DateTime.Now,
                    Customer = gg.Customer,
                    PO = gg.PO,
                    Material = gg.ProductName,
                    Lot = Common.GetProductLotNumber(gg.VHPDate, gg.VHPDevice),
                    OrderDate=gg.OrderDate                 
                };
                CurrentSample = tmp;
                RaisePropertyChanged(() => CurrentSample);
            });
        }

        private void VHPSelectExecute()
        {
            App.MainWindowService.ShowVHPSelect("SampleSelect");
        }

        private void GiveUpExecute()
        {
            App.MainWindowService.ShowUCSampleView();
        }

        private void SaveExecute()
        {
            if (CurrentSample != null)
            {
                SampleReportServiceClient client = new SampleReportServiceClient();

                bool saveResult = false;
                if (Flag == NewOrUpdate.New)
                {
                    saveResult = client.AddSample(CurrentSample);
                }
                else
                {
                    saveResult = client.UpdateSample(CurrentSample);
                }

                if (saveResult)
                {
                    App.MainWindowService.ShowUCSampleView();
                    Messenger.Default.Send<NotificationMessage>(null, "RefreshSampleView");
                }
                else
                {
                    App.MainWindowService.ShowWarningWithOKCancel("Error", "Error");
                }

            }
        }

        private Sample currentSample;
        public Sample CurrentSample
        {
            get { return currentSample; }
            set
            {
                if (value == currentSample)
                {
                    return;
                }
                currentSample = value;
                RaisePropertyChanged(nameof(currentSample));
            }
        }
        public NewOrUpdate Flag { get; set; }

        public RelayCommand SaveCommand { get; private set; }
        public RelayCommand GiveUpCommand { get; private set; }
        public RelayCommand SelectVHPCommand { get; private set; }
    }
}

using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfReportCreator.ServiceReferenceSampleReport;

namespace WpfReportCreator.ViewModel
{
    public class UCSampleEditViewModel : ViewModelBase
    {
        public UCSampleEditViewModel()
        {
            SaveCommand = new RelayCommand(SaveExecute);
            GiveUpCommand = new RelayCommand(GiveUpExecute);
        }

        private void GiveUpExecute()
        {
            throw new NotImplementedException();
        }

        private void SaveExecute()
        {
            throw new NotImplementedException();
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

        public RelayCommand SaveCommand { get; private set; }
        public RelayCommand GiveUpCommand { get; private set; }
    }
}

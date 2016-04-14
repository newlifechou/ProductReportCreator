using GalaSoft.MvvmLight;
using System.Collections.ObjectModel;
using WpfReportCreator.ServiceReferenceVHP;

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

    }
}
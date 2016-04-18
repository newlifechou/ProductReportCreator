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

        public string Msg { get; set; }
        /// <summary>
        /// Initializes a new instance of the VHPSelectViewModel class.
        /// </summary>
        public VHPSelectViewModel()
        {
            PageSize = 30;
            RecordCount = GetRecordCount();
            PageIndex = 1;

            SetPageByRecord();

            SelectCommand = new RelayCommand(SelectAction);
            GiveUpCommand = new RelayCommand(GiveUpAction);
            PageCommand = new RelayCommand(() =>
              {
                  SetPageByRecord();
              });
        }
        private int GetRecordCount()
        {
            VHPServiceClient client = new VHPServiceClient();
            int count= client.GetVHPCount();
            client.Close();
            return count;
        }
        private void SetPageByRecord()
        {
            VHPServiceClient client = new VHPServiceClient();
            VHPs = new ObservableCollection<VHP>(client.GetVHPs((PageIndex-1)*PageSize, PageSize));
            if (VHPs.Count > 0)
            {
                CurrentVHP = VHPs[0];
            }
            client.Close();
        }

        private void GiveUpAction()
        {
            App.MainWindowService.ReturnToTargetEdit();
        }

        private void SelectAction()
        {
            Messenger.Default.Send<NotificationMessage<VHP>>(new NotificationMessage<VHP>(CurrentVHP,""), Msg);
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
        public RelayCommand PageCommand { get; set; }
        #region 分页区域
        private int pageIndex;
        public int PageIndex
        {
            get { return pageIndex; }
            set
            {
                if (pageIndex == value)
                    return;
                pageIndex = value;
                RaisePropertyChanged(() => PageIndex);
            }
        }
        private int recordCount;
        public int RecordCount
        {
            get { return recordCount; }
            set
            {
                if (recordCount == value)
                    return;
                recordCount = value;
                RaisePropertyChanged(() => RecordCount);
            }
        }
        private int pageSize;
        public int PageSize
        {
            get { return pageSize; }
            set
            {
                if (pageSize == value)
                    return;
                pageSize = value;
                RaisePropertyChanged(() => PageSize);
            }
        }
        private int pageCount;
        public int PageCount
        {
            get { return pageCount; }
            set
            {
                if (pageCount == value)
                    return;
                pageCount = value;
                RaisePropertyChanged(() => PageCount);
            }
        }

        #endregion



    }
}
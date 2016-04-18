using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfReportCreator.ServiceReferenceSampleReport;

/*
    Developer:xs.zhou@outlook.com
    CreateTime:2016/4/11 9:24:46
*/
namespace WpfReportCreator.ViewModel
{
    public class UCSampleViewModel : ViewModelBase
    {

        public UCSampleViewModel()
        {
            InitalProperties();
            InitialCommands();
        }

        #region 初始化区域
        private void InitalProperties()
        {
            SearchLot = string.Empty;
            SearchCustomer = string.Empty;
            SetPageWhenCondtionChange();
        }

        private void SetPageWhenCondtionChange()
        {
            PageIndex = 1;
            PageSize = 10;
            RecordCount = GetTargetsCountByCondition(SearchLot, SearchCustomer);
            PageAction();
        }

        private void PageAction()
        {
            GetPageByCondition(SearchLot, SearchCustomer, (PageIndex - 1) * PageSize, PageSize);
        }

        private int GetTargetsCountByCondition(string searchLot, string searchCustomer)
        {
            ServiceReferenceSampleReport.SampleReportServiceClient client = new SampleReportServiceClient();
            int result = client.GetSampleCount(SearchLot, searchCustomer);
            client.Close();
            return result;
        }

        private void GetPageByCondition(string lot, string customer, int skip, int take)
        {
            ServiceReferenceSampleReport.SampleReportServiceClient client = new SampleReportServiceClient();
            Samples = new ObservableCollection<Sample>(client.GetSamplesByCondition(lot, customer, skip, take));
            client.Close();
        }

        private void InitialCommands()
        {
            AddCommand = new RelayCommand(ExecuteAdd, CanAdd);
            EditCommand = new RelayCommand<Sample>(ExecuteEdit, CanEdit);
            DeleteCommand = new RelayCommand<Sample>(ExecuteDelete, CanDelete);
            SearchCommand = new RelayCommand(ExecuteSearch, CanSearch);
            PageCommand = new RelayCommand(ExecutePage);
        }

        private void ExecutePage()
        {
            SetPageWhenCondtionChange();
        }

        private void ExecuteSearch()
        {
            SetPageWhenCondtionChange();
        }

        private bool CanSearch()
        {
            return !string.IsNullOrEmpty(SearchCustomer) && !string.IsNullOrEmpty(SearchLot);
        }

        private void ExecuteDelete(Sample obj)
        {
            throw new NotImplementedException();
        }

        private bool CanDelete(Sample arg)
        {
            return true;
        }

        private void ExecuteEdit(Sample obj)
        {
            throw new NotImplementedException();
        }

        private bool CanEdit(Sample arg)
        {
            return true;
        }

        private void ExecuteAdd()
        {
            Sample sample = new Sample()
            {
                Id = Guid.NewGuid(),
                Material = "Some Composition"
            };
            App.MainWindowService.ShowSampleEdit(sample, NewOrUpdate.New);
        }

        private bool CanAdd()
        {
            return true;
        }
        #endregion

        #region 属性区域
        private string searchLot;
        public string SearchLot
        {
            get { return searchLot; }
            set
            {
                if (searchLot == value)
                    return;
                searchLot = value;
                RaisePropertyChanged(() => SearchLot);
            }
        }
        private string searchCustomer;
        public string SearchCustomer
        {
            get { return searchCustomer; }
            set
            {
                if (searchCustomer == value)
                    return;
                searchCustomer = value;
                RaisePropertyChanged(() => SearchCustomer);
            }
        }
        private ObservableCollection<Sample> samples;
        public ObservableCollection<Sample> Samples
        {
            get { return samples; }
            set
            {
                if (samples == value)
                    return;
                samples = value;
                RaisePropertyChanged(() => Samples);
            }
        }

        #endregion

        #region 命令区域
        public RelayCommand AddCommand { get; private set; }
        public RelayCommand<Sample> EditCommand { get; private set; }
        public RelayCommand<Sample> DeleteCommand { get; private set; }
        public RelayCommand SearchCommand { get; private set; }
        public RelayCommand GetAllCommand { get; private set; }

        #endregion
        #region 分页属性和命令
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
        public RelayCommand PageCommand { get; private set; }
        #endregion #region 分页
    }
}

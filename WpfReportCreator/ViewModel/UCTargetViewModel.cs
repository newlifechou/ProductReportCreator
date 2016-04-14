using System;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;
using System.Collections.ObjectModel;
using WpfReportCreator.ServiceReferenceTargetReport;
using System.Linq;
using Microsoft.Practices.ServiceLocation;

namespace WpfReportCreator.ViewModel
{
    /// <summary>
    /// This class contains properties that a View can data bind to.
    /// <para>
    /// See http://www.galasoft.ch/mvvm
    /// </para>
    /// </summary>
    public class UCTargetViewModel : ViewModelBase
    {
        /// <summary>
        /// Initializes a new instance of the UCTargetViewModel class.
        /// </summary>
        public UCTargetViewModel()
        {
            InitialProperties();
            IntialCommands();
        }
        #region 初始化区域

        private void InitialProperties()
        {
            SearchCustomer = string.Empty;
            SearchLot = string.Empty;
            SetPageWhenCondtionChange();
        }

        private void SetPageWhenCondtionChange()
        {
            PageIndex = 1;
            PageSize = 10;
            RecordCount = GetTargetsCountByCondition(SearchLot, SearchCustomer);
            PageAction();
        }

        private void IntialCommands()
        {
            AddCommand = new RelayCommand(ActionAdd, CanAdd);
            SearchCommand = new RelayCommand(ActionSearch, CanSearch);
            GetAllCommand = new RelayCommand(ActionGetAll);
            EditCommand = new RelayCommand(ActionEdit, CanEdit);
            DeleteCommand = new RelayCommand(ActionDelete, CanDelete);

            PageCommand = new RelayCommand(PageAction);
        }



        private void PageAction()
        {
            GetTargetsByCondition(SearchLot, SearchCustomer, (PageIndex - 1) * PageSize, PageSize);
        }

        private bool CanDelete()
        {
            return CheckAuth();
        }

        private void ActionDelete()
        {
            throw new NotImplementedException();
        }

        private bool CanEdit()
        {
            return CheckAuth();
        }

        private void ActionEdit()
        {
            throw new NotImplementedException();
        }

        private void ActionGetAll()
        {
            SearchCustomer = string.Empty;
            SearchLot = string.Empty;
            SetPageWhenCondtionChange();
        }

        private bool CanSearch()
        {
            return !(string.IsNullOrEmpty(SearchLot) && string.IsNullOrEmpty(SearchCustomer));
        }

        private void ActionSearch()
        {
            SetPageWhenCondtionChange();
        }

        #endregion

        private void GetAllTargets(int skip, int take)
        {
            TargetReportServiceClient client = new TargetReportServiceClient();
            Targets = new ObservableCollection<Target>(client.GetTargets(skip, take));
            client.Close();
        }
        private int GetTargetsCountByCondition(string lot, string customer)
        {
            TargetReportServiceClient client = new TargetReportServiceClient();
            return client.GetTargetCount(lot, customer);
        }
        private void GetTargetsByCondition(string lot, string customer, int skip, int take)
        {
            TargetReportServiceClient client = new TargetReportServiceClient();
            Targets = new ObservableCollection<Target>(client.GetTargetsByCondition(lot, customer, skip, take));
            client.Close();
        }

        private bool CanAdd()
        {
            //return CheckAuth();
            return true;
        }

        private void ActionAdd()
        {
            Target empty = new Target()
            {
                Id = Guid.NewGuid()
            };
          App.MainWindowService.ShowTargetEdit(empty,NewOrUpdate.New);
        }

        private bool CheckAuth()
        {
            return Service.Access.AccessState == Service.LogState.Pass;
        }


        #region 命令区域
        public RelayCommand AddCommand { get; private set; }
        public RelayCommand EditCommand { get; private set; }
        public RelayCommand DeleteCommand { get; private set; }
        public RelayCommand DetailsCommand { get; private set; }
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
        #endregion



        #region 属性区域

        private ObservableCollection<Target> targets;
        public ObservableCollection<Target> Targets
        {
            get { return targets; }
            set
            {
                if (targets == value)
                    return;
                targets = value;
                RaisePropertyChanged(() => Targets);
            }
        }

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

        #endregion

    }
}
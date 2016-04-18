using System;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;
using System.Collections.ObjectModel;
using WpfReportCreator.ServiceReferenceTargetReport;
using System.Linq;
using Microsoft.Practices.ServiceLocation;
using GalaSoft.MvvmLight.Messaging;
using WpfReportCreator.Service;

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

            Messenger.Default.Register<NotificationMessage>(this, "RefreshTargetView", msg =>
            {
                SetPageWhenCondtionChange();
            });
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
            EditCommand = new RelayCommand<Target>(ActionEdit, CanEdit);
            DeleteCommand = new RelayCommand<Target>(ActionDelete, CanDelete);
            ReportCommand = new RelayCommand<Target>(ActionReport);

            PageCommand = new RelayCommand(PageAction);
        }

        private void ActionReport(Target obj)
        {
            Target t = obj.DeepCopy();
            App.MainWindowService.ShowReport(t);
        }

        private void PageAction()
        {
            GetTargetsByCondition(SearchLot, SearchCustomer, (PageIndex - 1) * PageSize, PageSize);
        }

        private bool CanDelete(Target t)
        {
            //return CheckAuth();
            return true;
        }

        private void ActionDelete(Target t)
        {
            if (App.MainWindowService.ShowWarningWithOKCancel("Are you sure to delete this?", "warning"))
            {
                TargetReportServiceClient client = new TargetReportServiceClient();
                client.DeleteTarget(t);
                client.Close();
                Messenger.Default.Send<NotificationMessage>(null, "RefreshTargetView");
            }
        }

        private bool CanEdit(Target t)
        {
            //return CheckAuth();
            return true;
        }

        private void ActionEdit(Target t)
        {
            //这里考虑深拷贝一下，改在WindowManager中实现
            App.MainWindowService.ShowTargetEdit(t, NewOrUpdate.Update);
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
                Id = Guid.NewGuid(),
                Lot = "160418-M-1",
                Material = "Some Composition"
            };
            App.MainWindowService.ShowTargetEdit(empty, NewOrUpdate.New);
        }

        private bool CheckAuth()
        {
            return Service.Access.AccessState == Service.LogState.Pass;
        }


        #region 命令区域
        public RelayCommand AddCommand { get; private set; }
        public RelayCommand<Target> EditCommand { get; private set; }
        public RelayCommand<Target> DeleteCommand { get; private set; }
        public RelayCommand<Target> ReportCommand { get; private set; }
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
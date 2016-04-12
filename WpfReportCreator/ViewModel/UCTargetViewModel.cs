using System;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;
using System.Collections.ObjectModel;
using WpfReportCreator.ServiceReferenceTargetReport;
using System.Linq;

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
            SearchLot = "";
            SearchCustomer = "";
            GetAllTargets(0, 20);
        }

        private void IntialCommands()
        {
            AddCommand = new RelayCommand(ActionAdd, CanAdd);
            SearchCommand = new RelayCommand(ActionSearch, CanSearch);
            GetAllCommand = new RelayCommand(ActionGetAll);
            EditCommand = new RelayCommand(ActionEdit, CanEdit);
            DeleteCommand = new RelayCommand(ActionDelete, CanDelete);
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
            GetAllTargets(0, 20);
        }

        private bool CanSearch()
        {
            return !(string.IsNullOrEmpty(SearchLot) && string.IsNullOrEmpty(SearchCustomer));
        }

        private void ActionSearch()
        {
            GetTargetsByCondition(SearchLot, SearchCustomer, 0, 20);
        }

        #endregion

        private void GetAllTargets(int skip, int take)
        {
            TargetReportServiceClient client = new TargetReportServiceClient();
            Targets = new ObservableCollection<Target>(client.GetTargets(skip, take));
            client.Close();
        }
        private void GetTargetsByCondition(string lot, string customer, int skip, int take)
        {
            TargetReportServiceClient client = new TargetReportServiceClient();
            Targets = new ObservableCollection<Target>(client.GetTargetsByCondition(lot, customer, skip, take));
            client.Close();
        }

        private bool CanAdd()
        {
            return CheckAuth();
        }

        private bool CheckAuth()
        {
            return Service.Access.AccessState == Service.LogState.Pass;
        }

        private void ActionAdd()
        {
            throw new NotImplementedException();
        }




        #region 命令区域
        public RelayCommand AddCommand { get; private set; }
        public RelayCommand EditCommand { get; private set; }
        public RelayCommand DeleteCommand { get; private set; }
        public RelayCommand DetailsCommand { get; private set; }
        public RelayCommand SearchCommand { get; private set; }
        public RelayCommand GetAllCommand { get; private set; }
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
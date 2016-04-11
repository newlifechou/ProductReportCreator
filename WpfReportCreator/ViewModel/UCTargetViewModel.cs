using System;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;

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
            AddCommand = new RelayCommand(ActionAdd, CanAdd);
        }

        private bool CanAdd()
        {
            return Service.Access.AccessState==Service.LogState.Pass;
        }

        private void ActionAdd()
        {
            throw new NotImplementedException();
        }

        public RelayCommand AddCommand { get; set; }


    }
}
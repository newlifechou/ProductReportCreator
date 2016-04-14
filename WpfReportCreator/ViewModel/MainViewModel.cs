using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;
using Microsoft.Practices.ServiceLocation;

namespace WpfReportCreator.ViewModel
{
    /// <summary>
    /// This class contains properties that the main View can data bind to.
    /// <para>
    /// Use the <strong>mvvminpc</strong> snippet to add bindable properties to this ViewModel.
    /// </para>
    /// <para>
    /// You can also use Blend to data bind with the tool's support.
    /// </para>
    /// <para>
    /// See http://www.galasoft.ch/mvvm
    /// </para>
    /// </summary>
    public class MainViewModel : ViewModelBase
    {
        public MainViewModel()
        {
            InitialCommands();
        }

        private void InitialCommands()
        {
            OpenUCTargetCommand = new RelayCommand(() =>
            {
                WindowManagerService.ShowUCTargetView();
            });
            OpenUCSampleCommand = new RelayCommand(() =>
            {
                WindowManagerService.ShowUCSampleView();
            });
        }

        #region √¸¡Ó«¯”Ú
        public RelayCommand OpenUCTargetCommand { get; set; }
        public RelayCommand OpenUCSampleCommand { get; set; }
        #endregion

        public WindowManager WindowManagerService
        {
            get
            {
                return ServiceLocator.Current.GetInstance<WindowManager>();
            }
        }
    }
}
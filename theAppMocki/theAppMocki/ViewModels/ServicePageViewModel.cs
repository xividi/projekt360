using Prism.Commands;
using Prism.Navigation;
using System;
using System.Windows.Input;
using Xamarin.Forms;
using Prism.Mvvm;
using Prism.Navigation.Xaml;
using Xamarin.Essentials;
using System.Threading.Tasks;
using System.IO;

namespace theAppMocki.ViewModels
{
    public class ServicePageViewModel : BindableBase
    {
        public string _title;

        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        private DelegateCommand _navigateCommand;
        private readonly INavigationService _navigationService;

        public ServicePageViewModel(INavigationService navigationService)
        {
            Title = "Service Page";
            _navigationService = navigationService;
        }

        private DelegateCommand menuButton;
        public ICommand MenuButton => menuButton ?? (menuButton = new DelegateCommand(PerformMenuButton));

        private void PerformMenuButton()
        {

        }

        private DelegateCommand openCamera;
        public ICommand OpenCamera => openCamera ?? (openCamera = new DelegateCommand(PerformOpenCamera));

        private void PerformOpenCamera()
        {
        }
    }
}



using Prism.Commands;
using Prism.Navigation;
using System;
using System.Windows.Input;
using Xamarin.Forms;
using Prism.Mvvm;

namespace theAppMocki.ViewModels
{
    public class MainPageViewModel : BindableBase
    {
        public string _title;

        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        private DelegateCommand _navigateCommand;
        private readonly INavigationService _navigationService;

        public MainPageViewModel (INavigationService navigationService)
        {
            Title = "Main Page";
            _navigationService = navigationService;
        }

        private DelegateCommand remoteAccessBar;
        private DelegateCommand photoService;
        public ICommand RemoteAccessBar => remoteAccessBar ?? (remoteAccessBar = new DelegateCommand(PerformRemoteAccessBar));
        public ICommand PhotoService => photoService ?? (photoService = new DelegateCommand(PerformPhotoService));

        private async void PerformRemoteAccessBar()
        {
            await _navigationService.NavigateAsync("LoginPage");

        }

        private async void PerformPhotoService()
        {
            await _navigationService.NavigateAsync("ServicePage");
        }

        private DelegateCommand navigationSettings;
        public ICommand NavigationSettings => navigationSettings ?? ( navigationSettings = new DelegateCommand(PerformNavigationSettings));

        private async void PerformNavigationSettings()
        {
            await _navigationService.NavigateAsync("SettingsPage");
        }
    }
}



using Prism.Commands;
using Prism.Navigation;
using System;
using System.Windows.Input;
using Xamarin.Forms;
using Prism.Mvvm;

namespace theAppMocki.ViewModels
{
    public class SettingsPageViewModel : BindableBase
    {
        public string _title;

        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        private DelegateCommand _navigateCommand;
        private readonly INavigationService _navigationService;

        public SettingsPageViewModel(INavigationService navigationService)
        {
            Title = "Main Page";
            _navigationService = navigationService;
        }

        private DelegateCommand remoteAccessBar;
        private DelegateCommand photoService;
        public ICommand PhotoService => photoService ?? (photoService = new DelegateCommand(PerformPhotoService));


        private async void PerformPhotoService()
        {
            await _navigationService.NavigateAsync("ServicePage");
        }

        private DelegateCommand welcomePage;
        public ICommand WelcomePage => welcomePage ?? (welcomePage = new DelegateCommand(PerformWelcomePage));

        private async void PerformWelcomePage()
        {
            await _navigationService.NavigateAsync("WelcomePage");
        }

        private DelegateCommand loginPage;
        public ICommand LoginPage => loginPage ?? (loginPage = new DelegateCommand(PerformLoginPage));

        private async void PerformLoginPage()
        {
            await _navigationService.NavigateAsync("LoginPage");
        }

        private DelegateCommand mainPage;
        public ICommand MainPage => mainPage ?? (mainPage = new DelegateCommand(PerformMainPage));

        private async void PerformMainPage()
        {
            await _navigationService.NavigateAsync("MainPage");

        }

        private DelegateCommand servicePage;
        public ICommand ServicePage => servicePage ?? (servicePage = new DelegateCommand(PerformServicePage));

        private async void PerformServicePage()
        {
            await _navigationService.NavigateAsync("ServicePage");

        }
    }
}

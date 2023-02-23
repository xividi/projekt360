using System;
using Prism.Mvvm;
using Prism.Navigation;
using Prism.Commands;
using Xamarin.Forms;

namespace theAppMocki.ViewModels
{
    public class WelcomePageViewModel :BindableBase
    {
        public string _title;

        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        private DelegateCommand _navigateCommand;
        private readonly INavigationService _navigationService;

        public DelegateCommand NavigateCommand => _navigateCommand ?? (_navigateCommand = new DelegateCommand(ExecuteNavigateCommand));

        public WelcomePageViewModel(INavigationService navigationService)
        {
            Title = "Welcome Page";
            _navigationService = navigationService;
        }

        async void ExecuteNavigateCommand()
        {
            await _navigationService.NavigateAsync("LoginPage");
        }
    }
}


using System;
using Prism.Mvvm;
using Prism.Commands;
using Prism.Navigation;
using Xamarin.Forms;

namespace theAppMocki.ViewModels
{
    public class LoginPageViewModel : BindableBase
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

        public LoginPageViewModel(INavigationService navigationService)
        {
            Title = "Login Page";
            _navigationService = navigationService;
        }

        async void ExecuteNavigateCommand()
        {
            await _navigationService.NavigateAsync("MainPage");
        }
    }
}



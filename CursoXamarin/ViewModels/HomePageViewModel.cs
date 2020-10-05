using Prism.Commands;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CursoXamarin.ViewModels
{
    public class HomePageViewModel
    {
        protected readonly INavigationService _navigationService;

        public HomePageViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
        }

        private DelegateCommand _myCommand;

        public DelegateCommand MyCommand => _myCommand ?? (_myCommand = new DelegateCommand(async () => await MyCommandAsync()));

        private Task MyCommandAsync()
        {
            return _navigationService.NavigateAsync("EntryPage");
        }
    }
}

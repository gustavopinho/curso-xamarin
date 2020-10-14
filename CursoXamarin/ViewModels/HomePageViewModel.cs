using Prism.Commands;
using Prism.Navigation;
using Prism.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CursoXamarin.ViewModels
{
    public class HomePageViewModel: ViewModelBase
    {
        public HomePageViewModel(IPageDialogService pageDialogService, INavigationService navigationService) : base(pageDialogService, navigationService)
        {
            base.PageTitle = "Titulo do App";
        }
    }
}

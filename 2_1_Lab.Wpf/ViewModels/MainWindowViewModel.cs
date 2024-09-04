using _2_1_Lab.Wpf.Core;
using _2_1_Lab.Wpf.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_1_Lab.Wpf.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {

        private INavigationService _navigationService;

        public INavigationService NavigationService
        {
            get { return _navigationService; }
            set { _navigationService = value; OnPropertyChanged(); }
        }

        public MainWindowViewModel(INavigationService navigationService)
        {
            NavigationService = navigationService;
            
        }
    }
}

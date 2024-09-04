using _2_1_Lab.Wpf.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_1_Lab.Wpf.Services
{
    public interface INavigationService
    {
        ViewModelBase CurrentViewModel { get; }
        void NavigateTo<ViewModelType>() where ViewModelType: ViewModelBase;

    }

    public class NavigationService : ObservableObject ,INavigationService
    {
        private readonly Func<Type, ViewModelBase> viewModelFactory;
        public NavigationService(Func<Type, ViewModelBase> viewModelFactory)
        {
            this.viewModelFactory = viewModelFactory;
        }

        private ViewModelBase _currentViewModel;
        public ViewModelBase CurrentViewModel
        {
            get => _currentViewModel;
            set
            {
                _currentViewModel = value;
                OnPropertyChanged();
            }
        }

        public void NavigateTo<ViewModelType>() where ViewModelType : ViewModelBase
        {
            CurrentViewModel = viewModelFactory.Invoke(typeof(ViewModelType));
        }
    }
}

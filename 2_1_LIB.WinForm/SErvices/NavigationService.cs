using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using static _2_1_LIB.WinForm.SErvices.NavigationService;

namespace _2_1_LIB.WinForm.SErvices
{
    public interface INavigationService
    {
        UserControl CurrentView { get; }

        event NavigatedHandler? Navigated;
        void NavigateTo<ViewType>() where ViewType : UserControl;
    }
    public class NavigationService : INavigationService
    {
        public NavigationService(Func<Type, UserControl> viewFactory)
        {
            _viewFactory = viewFactory;
        }
        private readonly Func<Type, UserControl> _viewFactory;

        public UserControl CurrentView { get; set; }

        public delegate void NavigatedHandler(object sender, EventArgs e);
        public event NavigatedHandler? Navigated;

        public void NavigateTo<ViewType>() where ViewType : UserControl
        {
            CurrentView = _viewFactory.Invoke(typeof(ViewType));
            Navigated?.Invoke(this, new EventArgs());
        }
    }
}

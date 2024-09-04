using _2_1_Lab.Application;
using _2_1_Lab.Domain.IRepositories;
using _2_1_Lab.Domain.IStores;
using _2_1_Lab.Infrastracture;
using _2_1_Lab.Wpf.Core;
using _2_1_Lab.Wpf.Services;
using _2_1_Lab.Wpf.ViewModels;
using _2_1_Lab.Wpf.Views;
using Microsoft.Extensions.DependencyInjection;
using System.Configuration;
using System.Data;
using System.Windows;

namespace _2_1_Lab.Wpf
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : System.Windows.Application
    {
        private readonly IServiceCollection _serviceCollection;
        private readonly IServiceProvider _serviceProvider;
        public App()
        {
            _serviceCollection = new ServiceCollection();
            _serviceCollection.AddSingleton<MainWindow>(provider => new MainWindow
            {
                DataContext = provider.GetRequiredService<MainWindowViewModel>()
            });
            _serviceCollection.AddSingleton<MainWindowViewModel>();

            _serviceCollection.AddSingleton<StudentTableViewModel>();
            _serviceCollection.AddSingleton<StudentGraphicsViewModel>();

            _serviceCollection.AddSingleton<Func<Type, ViewModelBase>>(p => 
            (ViewModelType) => (ViewModelBase)p.GetRequiredService(ViewModelType));

            _serviceCollection.AddSingleton<INavigationService, NavigationService>();
            _serviceCollection.AddSingleton<IStudentStore, StudentStore>();

            _serviceCollection.AddSingleton<IStudentRepository, StudentRepository>();

            _serviceProvider = _serviceCollection.BuildServiceProvider();
        }

        protected override void OnStartup(StartupEventArgs e)
        {
            var StartUpWindow = _serviceProvider.GetRequiredService<MainWindow>();
            _serviceProvider.GetRequiredService<INavigationService>().NavigateTo<StudentTableViewModel>();
            StartUpWindow.Show();
            base.OnStartup(e);
        }
    }

}

using _2_1_Lab.Application;
using _2_1_Lab.Domain.IRepositories;
using _2_1_Lab.Domain.IStores;
using _2_1_Lab.Infrastracture;
using _2_1_LIB.WinForm.Controls;
using _2_1_LIB.WinForm.SErvices;
using Microsoft.Extensions.DependencyInjection;

namespace _2_1_LIB.WinForm
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var serviceProvider = new ServiceCollection()
                .AddSingleton<IStudentRepository, StudentRepository>()
                .AddSingleton<IStudentStore, StudentStore>()
                .AddSingleton<StudentListForm>()
                .AddSingleton<StudentTableView>()
                .AddSingleton<Func<Type, UserControl>>(p => type => (UserControl)p.GetRequiredService(type))
                .AddSingleton<INavigationService, NavigationService>()
                .BuildServiceProvider();
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(serviceProvider.GetRequiredService<StudentListForm>());


        }
    }
}
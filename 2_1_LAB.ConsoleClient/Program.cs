using _2_1_Lab.Application;
using _2_1_Lab.Domain;
using _2_1_Lab.Domain.IRepositories;
using _2_1_Lab.Domain.IStores;
using _2_1_Lab.Infrastracture;
using Microsoft.Extensions.DependencyInjection;
using System.Runtime.InteropServices;

namespace _2_1_LAB.ConsoleClient
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var _serviceProvider = new ServiceCollection()
            .AddSingleton<IStudentStore, StudentStore>()
            .AddSingleton<IStudentRepository, StudentRepository>()
            .AddSingleton<StudentConsoleHandler>()
            .BuildServiceProvider();

            var StudentConsoleHandler = _serviceProvider.GetRequiredService<StudentConsoleHandler>();

            Console.WriteLine("1. Добавить студента. \n2. Удалить студента. \n3. Обновить студента. \n4. Отобразить список. \n5. Выйти.");
            var Exit = false;
            
            while(!Exit)
            {
                Console.WriteLine("Введите номер операции.");
                var command = Console.ReadLine();
                switch (command)
                {
                    case "1":
                        StudentConsoleHandler.AddStudent();
                        break;
                    case "2":
                        StudentConsoleHandler.RemoveStudent();
                        break;

                    case "3":
                        StudentConsoleHandler.UpdateStudent();
                        break;

                    case "4":
                        StudentConsoleHandler.OutputAllStudentsToConsole();
                        break;
                    case "5":
                        Exit = true;
                        break;
                }
            }

        }


    }
}

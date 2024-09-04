using _2_1_Lab.Domain;
using _2_1_Lab.Domain.IStores;
using _2_1_Lab.Wpf.Core;
using _2_1_Lab.Wpf.Services;
using LiveCharts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_1_Lab.Wpf.ViewModels
{
    public class StudentGraphicsViewModel : ViewModelBase
    {
        private INavigationService _navigationService;

        public INavigationService NavigationService
        {
            get { return _navigationService; }
            set { _navigationService = value; OnPropertyChanged(); }
        }
        private IStudentStore _studentStore;

        public IStudentStore StudentStore
        {
            get { return _studentStore; }
            set { _studentStore = value; OnPropertyChanged(); }
        }

        private ChartValues<int> _specialitesValues;

        public ChartValues<int> SpecialitesValues
        {
            get { return _specialitesValues; }
            set { _specialitesValues = value; OnPropertyChanged(); }
        }

        private List<string> _spicialitiesTitles;

        public List<string> SpicialitiesTitles
        {
            get { return _spicialitiesTitles; }
            set { _spicialitiesTitles = value; OnPropertyChanged(); }
        }

        public RelayCommand GoToStudentTableCommand { get; set; }
        public RelayCommand UpdateGraphicsCommand { get; set; }
        public StudentGraphicsViewModel(INavigationService navigationService, IStudentStore studentStore)
        {
            NavigationService = navigationService;
            StudentStore = studentStore;
            CountSpecialitiesData();
            InitializeCommands();
        }
        private void InitializeCommands()
        {
            UpdateGraphicsCommand = new RelayCommand(o => CountSpecialitiesData(), o => true);
            GoToStudentTableCommand = new RelayCommand(o => NavigationService.NavigateTo<StudentTableViewModel>(), o => true);
        }
        private void CountSpecialitiesData()
        {
            SpecialitesValues = new ChartValues<int>();
            SpicialitiesTitles = new List<string>();

            var specialtyCounts = StudentStore.GetAllStudents()
                .GroupBy(s => s.Speciality)
                .Select(g => new
                {
                    Title = g.Key,
                    Count = g.Count()
                }).ToList(); 

            foreach(var specialty in specialtyCounts)
            {
                SpicialitiesTitles.Add(specialty.Title);
                SpecialitesValues.Add(specialty.Count);
            }
        }
    }
}

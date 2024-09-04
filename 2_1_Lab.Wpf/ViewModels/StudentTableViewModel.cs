using _2_1_Lab.Application;
using _2_1_Lab.Domain;
using _2_1_Lab.Domain.IStores;
using _2_1_Lab.Wpf.Core;
using _2_1_Lab.Wpf.Records;
using _2_1_Lab.Wpf.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Annotations;

namespace _2_1_Lab.Wpf.ViewModels
{
    public class StudentTableViewModel : ViewModelBase
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

        private ObservableCollection<Student> _studentToView;
        public ObservableCollection<Student> StudentsToView
        {
            get { return _studentToView; }
            set { _studentToView = value; OnPropertyChanged(); }
        }

        private Student _selectedStudent;

        public Student SelectedStudent
        {
            get { return _selectedStudent; }
            set { _selectedStudent = value; OnPropertyChanged(); }
        }

        private StudentCridentials _studentCridentials = new StudentCridentials();

        public StudentCridentials StudentCridentials
        {
            get { return _studentCridentials; }
            set { _studentCridentials = value; OnPropertyChanged(); }
        }

        public RelayCommand AddStudent { get; set; }
        public RelayCommand RemoveStudent { get; set; }
        public RelayCommand UpdateStudent { get; set; }
        public RelayCommand UpdateStudentsTable { get; set; }
        public RelayCommand GoToStudentGraphics { get; set; }
        public StudentTableViewModel(INavigationService navigationService, IStudentStore studentStore)
        {
            NavigationService = navigationService;
            StudentStore = studentStore;

            StudentsToView = new ObservableCollection<Student>(StudentStore.GetAllStudents());
            InitializeCommands();
        }

        private void InitializeCommands()
        {
            AddStudent = new RelayCommand(o => AddStudentFunc(), o => StudentCridentials.Valid());
            RemoveStudent = new RelayCommand(o => RemoveStudentFunc(SelectedStudent), o => SelectedStudent != null);
            UpdateStudent = new RelayCommand(
                o => UpdateStudentFunc(SelectedStudent, new Student(StudentCridentials.Name, StudentCridentials.Speciality, StudentCridentials.Group)), 
                o => StudentCridentials.Valid() && SelectedStudent != null);

            GoToStudentGraphics = new RelayCommand(o => NavigationService.NavigateTo<StudentGraphicsViewModel>(), o=> true);
            
        }

        private void ClearCredentials()
        {
            StudentCridentials = new StudentCridentials();
        }

        private void AddStudentFunc()
        {
            StudentStore.AddStudent(new Student(StudentCridentials.Name, StudentCridentials.Speciality, StudentCridentials.Group));
            UpdateStudentsTableFunc();
            ClearCredentials();
        }
        private void RemoveStudentFunc(Student student)
        {
            StudentStore.RemoveStudent(student);
            UpdateStudentsTableFunc();
            ClearCredentials();
        }
        private void UpdateStudentFunc(Student studentToUpdate, Student student)
        {
            StudentStore.UpdateStudent(studentToUpdate, student);
            UpdateStudentsTableFunc();
            ClearCredentials();
        }
        private void UpdateStudentsTableFunc()
        {
            StudentsToView = new ObservableCollection<Student>(StudentStore.GetAllStudents());
        }
    }
}

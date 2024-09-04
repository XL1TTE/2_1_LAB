using _2_1_Lab.Domain;
using _2_1_Lab.Domain.IRepositories;
using _2_1_Lab.Domain.IStores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_1_Lab.Application
{
    public class StudentStore : IStudentStore

    {
        public StudentStore(IStudentRepository studentRepository)
        {
            this.studentRepository = studentRepository;
        }
        public IStudentRepository studentRepository { get; set; }

        public void AddStudent(Student student)
        {
            studentRepository.AddStudent(student);
        }

        public void UpdateStudent(Student studentToUpdate, Student student)
        {
            studentRepository.UpdateStudent(studentToUpdate, student);
        }

        public List<Student> GetAllStudents()
        {
            return studentRepository.GetAllStudents();
        }

        public void RemoveStudent(Student student)
        {
            studentRepository.RemoveStudent(student);
        }
    }
}

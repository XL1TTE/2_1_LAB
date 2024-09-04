using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_1_Lab.Domain.IRepositories
{
    public interface IStudentRepository
    {
        List<Student> GetAllStudents();

        void AddStudent(Student student);
        void UpdateStudent(Student studentToUpdate, Student Student);
        void RemoveStudent(Student student);
    }
}

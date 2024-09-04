using _2_1_Lab.Domain.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_1_Lab.Domain.IStores
{
    public interface IStudentStore
    {
        IStudentRepository studentRepository { set;  }

        void AddStudent(Student student);
        void RemoveStudent(Student student);
        void UpdateStudent(Student studentToUpdate, Student student);
        List<Student> GetAllStudents();


    }
}

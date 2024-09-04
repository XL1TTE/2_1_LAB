using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_1_Lab.Wpf.Records
{
    public class StudentCridentials
    {
        public string Name { get; set; } = "";
        public string Speciality { get; set; } = "";
        public string Group { get; set; } = "";

        public bool Valid()
        {
            return (Name != "" && Speciality != "" && Group != "");
        }
    }
}

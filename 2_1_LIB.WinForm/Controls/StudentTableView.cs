using _2_1_Lab.Application;
using _2_1_Lab.Domain.IStores;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2_1_LIB.WinForm.Controls
{
    public partial class StudentTableView : UserControl
    {
        private readonly IStudentStore _studentStore;
        public StudentTableView(IStudentStore studentStore)
        {
            _studentStore = studentStore;
            InitializeComponent();
            LoadStudentData();
        }

        private void LoadStudentData()
        {
            StudentTable.DataSource = _studentStore.GetAllStudents();
            StudentTable.Columns[0].HeaderText = "Имя";
            StudentTable.Columns[1].HeaderText = "Группа";
            StudentTable.Columns[2].HeaderText = "Специальность";
        }
    }
}

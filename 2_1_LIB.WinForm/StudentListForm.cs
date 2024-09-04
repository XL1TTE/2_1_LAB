using _2_1_Lab.Domain.IStores;
using _2_1_LIB.WinForm.Controls;
using _2_1_LIB.WinForm.SErvices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2_1_LIB.WinForm
{
    public partial class StudentListForm : Form
    {
        private readonly INavigationService _navigationService;
        public StudentListForm(INavigationService navigationService)
        {
            _navigationService = navigationService;

            InitializeComponent();

            _navigationService.Navigated += UpdateView;

            _navigationService.NavigateTo<StudentTableView>();
        }
        
        private void UpdateView(object sender, EventArgs e)
        {
            panel1.Controls.Clear();

            var view = _navigationService.CurrentView;

            panel1.Controls.Add(view);
            view.Dock = DockStyle.Fill;

        }

    }


}

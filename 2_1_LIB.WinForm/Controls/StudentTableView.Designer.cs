namespace _2_1_LIB.WinForm.Controls
{
    partial class StudentTableView
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            panel3 = new Panel();
            panel2 = new Panel();
            StudentSpeciality = new Label();
            StudentGroup = new Label();
            StudentName = new Label();
            StudentNameBox = new TextBox();
            StudentGroupBox = new TextBox();
            StudentSpecialityBox = new TextBox();
            DeleteStudentButton = new Button();
            AddStudentButton = new Button();
            panel4 = new Panel();
            StudentTable = new DataGridView();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)StudentTable).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.AutoSize = true;
            panel1.Controls.Add(panel3);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(814, 455);
            panel1.TabIndex = 2;
            // 
            // panel3
            // 
            panel3.AutoSize = true;
            panel3.Controls.Add(panel2);
            panel3.Controls.Add(panel4);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(814, 455);
            panel3.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(StudentSpeciality);
            panel2.Controls.Add(StudentGroup);
            panel2.Controls.Add(StudentName);
            panel2.Controls.Add(StudentNameBox);
            panel2.Controls.Add(StudentGroupBox);
            panel2.Controls.Add(StudentSpecialityBox);
            panel2.Controls.Add(DeleteStudentButton);
            panel2.Controls.Add(AddStudentButton);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(606, 0);
            panel2.MaximumSize = new Size(208, 0);
            panel2.MinimumSize = new Size(208, 320);
            panel2.Name = "panel2";
            panel2.Size = new Size(208, 455);
            panel2.TabIndex = 2;
            // 
            // StudentSpeciality
            // 
            StudentSpeciality.AutoSize = true;
            StudentSpeciality.Location = new Point(11, 173);
            StudentSpeciality.Name = "StudentSpeciality";
            StudentSpeciality.Size = new Size(182, 20);
            StudentSpeciality.TabIndex = 23;
            StudentSpeciality.Text = "Специализация студента";
            // 
            // StudentGroup
            // 
            StudentGroup.AutoSize = true;
            StudentGroup.Location = new Point(11, 120);
            StudentGroup.Name = "StudentGroup";
            StudentGroup.Size = new Size(121, 20);
            StudentGroup.TabIndex = 22;
            StudentGroup.Text = "Группа студента";
            // 
            // StudentName
            // 
            StudentName.AutoSize = true;
            StudentName.Location = new Point(11, 62);
            StudentName.Name = "StudentName";
            StudentName.Size = new Size(102, 20);
            StudentName.TabIndex = 21;
            StudentName.Text = "Имя студента";
            // 
            // StudentNameBox
            // 
            StudentNameBox.Location = new Point(11, 143);
            StudentNameBox.Name = "StudentNameBox";
            StudentNameBox.Size = new Size(188, 27);
            StudentNameBox.TabIndex = 20;
            // 
            // StudentGroupBox
            // 
            StudentGroupBox.Location = new Point(11, 85);
            StudentGroupBox.Name = "StudentGroupBox";
            StudentGroupBox.Size = new Size(188, 27);
            StudentGroupBox.TabIndex = 19;
            // 
            // StudentSpecialityBox
            // 
            StudentSpecialityBox.Location = new Point(11, 196);
            StudentSpecialityBox.Name = "StudentSpecialityBox";
            StudentSpecialityBox.Size = new Size(188, 27);
            StudentSpecialityBox.TabIndex = 18;
            // 
            // DeleteStudentButton
            // 
            DeleteStudentButton.Location = new Point(11, 268);
            DeleteStudentButton.Name = "DeleteStudentButton";
            DeleteStudentButton.Size = new Size(94, 29);
            DeleteStudentButton.TabIndex = 17;
            DeleteStudentButton.Text = "Удалить";
            DeleteStudentButton.UseVisualStyleBackColor = true;
            // 
            // AddStudentButton
            // 
            AddStudentButton.Location = new Point(111, 268);
            AddStudentButton.Name = "AddStudentButton";
            AddStudentButton.Size = new Size(94, 29);
            AddStudentButton.TabIndex = 16;
            AddStudentButton.Text = "Добавить";
            AddStudentButton.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel4.AutoSize = true;
            panel4.Controls.Add(StudentTable);
            panel4.Location = new Point(3, 3);
            panel4.Name = "panel4";
            panel4.Size = new Size(597, 449);
            panel4.TabIndex = 0;
            // 
            // StudentTable
            // 
            StudentTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            StudentTable.BackgroundColor = SystemColors.ControlLightLight;
            StudentTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            StudentTable.Dock = DockStyle.Fill;
            StudentTable.GridColor = SystemColors.ActiveCaptionText;
            StudentTable.Location = new Point(0, 0);
            StudentTable.Name = "StudentTable";
            StudentTable.ReadOnly = true;
            StudentTable.RowHeadersWidth = 51;
            StudentTable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            StudentTable.Size = new Size(597, 449);
            StudentTable.TabIndex = 6;
            // 
            // StudentTableView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Name = "StudentTableView";
            Size = new Size(814, 455);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)StudentTable).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel1;
        private Panel panel3;
        private Panel panel4;
        private Panel panel2;
        private Label StudentSpeciality;
        private Label StudentGroup;
        private Label StudentName;
        private TextBox StudentNameBox;
        private TextBox StudentGroupBox;
        private TextBox StudentSpecialityBox;
        private Button DeleteStudentButton;
        private Button AddStudentButton;
        private DataGridView StudentTable;
    }
}

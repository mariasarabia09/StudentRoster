using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Roster
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            studentGrid.DataSource = Program.ReadStudentsFromFile();
        }

        private void addStudentButton_Click(object sender, EventArgs e)
        {
            panelMain.Visible = false;
            panelAddStudent.Visible = true;
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            var student = new Student()
            {
                FirstName = tbFirstName.Text,
                LastName = tbLastName.Text,
                DOB = tbDob.Text,
                Major = tbMajor.Text,
                StudentId = tbStudentId.Text
            };
            
            Program.WriteStudentToFile(student);

            studentGrid.DataSource = Program.ReadStudentsFromFile();

            panelAddStudent.Visible = false;
            panelMain.Visible = true;
        }
    }
}

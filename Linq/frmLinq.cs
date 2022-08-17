using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Linq
{
    public partial class frmLinq : Form
    {
        public frmLinq()
        {
            InitializeComponent();
        }

        List<ClsStudent> tabStudents = new List<ClsStudent>();

        private void frmLinq_Load(object sender, EventArgs e)
        {
            tabStudents.Add(new ClsStudent("Alex", "Fashion", 5));
            tabStudents.Add(new ClsStudent("Maria", "Computer", 80));
            tabStudents.Add(new ClsStudent("Abraham", "Fashion", 95));
            tabStudents.Add(new ClsStudent("Julia", "Accounting", 60));
            tabStudents.Add(new ClsStudent("Juan", "Computer", 78));
            tabStudents.Add(new ClsStudent("Nani", "Fashion", 12));

            // Fill the combo box with the school programs
            var allPrograms = (from element in tabStudents select element.Program).Distinct();

            comboBoxSelectProgram.DisplayMember = "Program";
            comboBoxSelectProgram.DataSource = allPrograms.ToList();

            var Students = from element in tabStudents select element;

            dataGridViewResult.DataSource = Students.ToList();


        }

        private void comboBoxSelectProgram_SelectedIndexChanged(object sender, EventArgs e)
        {
            var findStudents = from element 
                               in tabStudents 
                               where element.Program == comboBoxSelectProgram.SelectedItem.ToString() 
                               select element;

            dataGridViewResult.DataSource = findStudents.ToList();
        }
    }
}

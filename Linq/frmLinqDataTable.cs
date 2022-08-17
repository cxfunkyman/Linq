using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using OleDbToSQLiteInterceptor;

namespace Linq
{
    public partial class frmLinqDataTable : Form
    {
        public frmLinqDataTable()
        {
            InitializeComponent();
        }
        // we use dataset to store many datatables in one single collection
        DataSet mySet = new DataSet();

        private void frmLinqDataTable_Load(object sender, EventArgs e)
        {
            OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Seky-Vanier\source\repos\Linq\Linq\bin\Debug\Data\School.mdb");
            conn.Open();

            OleDbCommand cmd = new OleDbCommand("SELECT * FROM Courses", conn);
            OleDbDataAdapter adpCourses = new OleDbDataAdapter(cmd);
            adpCourses.Fill(mySet, "Courses");

            OleDbCommand cmd2 = new OleDbCommand("SELECT * FROM Students", conn);
            OleDbDataAdapter adpStudents = new OleDbDataAdapter(cmd2);
            adpStudents.Fill(mySet, "Students");

          // dataGridViewResultCourse.DataSource = mySet.Tables["Courses"];
            dataGridViewResultCourse.DataSource = mySet.Tables["Students"];

            //fill the comboBox (linQ)

            var CoursesTR = from DataRow cr in mySet.Tables["Courses"].Rows
                            select new { Titles = cr.Field<string>("Title"), refC = cr.Field<Int32>("RefCourse") };

            comboBoxSelectCourse.DisplayMember = "Titles";
            comboBoxSelectCourse.ValueMember = "refC";
            comboBoxSelectCourse.DataSource = CoursesTR.ToList();
        }

        private void dataGridViewResultCourse_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBoxSelectCourse_SelectedIndexChanged(object sender, EventArgs e)
        {
            int refC = Convert.ToInt32(comboBoxSelectCourse.SelectedValue.ToString());

            var student = from DataRow st in mySet.Tables["Students"].Rows
                          where st.Field<Int32>("RefCourse") == refC
                          select st;
            
            if(student != null)
            dataGridViewResultCourse.DataSource = student.CopyToDataTable();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;

namespace CourseWork
{
    public partial class Form2 : Form
    {
        public Form1 MainForm { get; set; }
        public Form2()
        {
            InitializeComponent();
            BindGrid("No");
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            MainForm.OpenAddForm = false;
            this.Close();
        }
             
        public void BindGrid(string typeOfSort)
        {
            Student obj = new Student();
            List<Student> listStudents = obj.List();
            if (typeOfSort == "Name")
            {
                List<Student> ls = BubbleSortThroughName(listStudents);
            }
            if (typeOfSort == "Date")
            {
                List<Student> ls = BubbleSortThroughDate(listStudents);
            }
            DataTable dt = Utility.ConvertToDataTable(listStudents);
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string myValue = dataGridView1[0,e.RowIndex].Value.ToString();
            Student obj = new Student();
            List<Student> listStudents = obj.List();
            int id = int.Parse(myValue);
            Student s = listStudents.Where(x => x.Id == id).FirstOrDefault();
            MainForm.FillTextField(s);
            MainForm.OpenAddForm = false;
            this.Close();
            
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            MainForm.OpenAddForm = false;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
        public List<Student> BubbleSortThroughName(List<Student> ls)
        {
            int l = ls.Count;
            Student temp;
            for (int i = 0; i < l; i++)
            {
                for (int j = 0; j < l-1; j++)
                {
                    if (ls[j].Name.CompareTo(ls[j+1].Name) > 0 )
                    {
                        temp = ls[j];
                        ls[j] = ls[j+1];
                        ls[j + 1] = temp;

                    }
                }
            }
            return ls;
        }
        public List<Student> BubbleSortThroughDate(List<Student> ls)
        {
            int l = ls.Count;
            Student temp;
            for (int i = 0; i < l; i++)
            {
                for (int j = 0; j < l - 1; j++)
                {
                    if (ls[j].RegistrationDate.CompareTo(ls[j + 1].RegistrationDate) > 0)
                    {
                        temp = ls[j];
                        ls[j] = ls[j + 1];
                        ls[j + 1] = temp;

                    }
                }
            }
            return ls;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonBySortFirstName_Click(object sender, EventArgs e)
        {
            BindGrid("Name");
        }

        private void buttonBySortDate_Click(object sender, EventArgs e)
        {
            BindGrid("Date");
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            BindGrid("No");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

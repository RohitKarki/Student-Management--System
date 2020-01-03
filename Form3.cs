using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Forms;

namespace CourseWork
{
    public partial class Form3 : Form
    {
        public Form1 MainForm { get; set; }
        public Form3()
        {
            InitializeComponent();
            BindGrid();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
        public void BindGrid()
        {
            Student obj = new Student();
            List<Student> listStudents = obj.List();
            BindChart(listStudents);
            WeeklyInformation(listStudents);
        }
        public void BindChart(List<Student> lst)
        {
            if (lst != null)
            {

                var result = lst
                    .GroupBy(l => l.Faculty)
                    .Select(c1 => new
                    {
                        Faculty = c1.First().Faculty,
                        Count = c1.Count().ToString()
                    }).ToList();
                DataTable dt = Utility.ConvertToDataTable(result);
                chart1.DataSource = dt;
                chart1.Name = "Faculty";
                chart1.Series["Series1"].XValueMember = "Faculty";
                chart1.Series["Series1"].YValueMembers = "Count";
                this.chart1.Titles.Remove(this.chart1.Titles.FirstOrDefault());
                this.chart1.Titles.Add("Enrollment Chart");
                chart1.Series["Series1"].IsValueShownAsLabel = true;

            }
        }
        public void WeeklyInformation(List<Student> lst)
        {
            if (lst != null)
            {
                var result = lst
                    .GroupBy(d => new { V = CultureInfo.CurrentCulture.Calendar.GetWeekOfYear(d.RegistrationDate, CalendarWeekRule.FirstDay, DayOfWeek.Sunday), d.Faculty })
                    .Select(c1 => new
                    {
                        Faculty = c1.First().Faculty,
                        Total_Student = c1.Count().ToString(),
                        Week = "Week" + c1.Key.V.ToString(),

                    }).ToList();

                    DataTable dt = Utility.ConvertToDataTable(result);
                    dataGridViewWeeklyReport.DataSource = dt;
                
            }
        }
        private void buttonExit_Click(object sender, EventArgs e)
        {
            MainForm.OpenViewGraph = false;
            this.Close();
        }

        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {
            MainForm.OpenViewGraph = false;
        }

        private void dataGridViewWeeklyReport_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

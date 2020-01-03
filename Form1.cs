using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace CourseWork
{

    public partial class Form1 : Form
    {
        public bool OpenAddForm { get; set; }
        public bool OpenViewGraph { get; set; }
        public Form1()
        {
            this.OpenAddForm = false;
            this.OpenViewGraph = false;
            InitializeComponent();

        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ActionViewGraph();
        }
        public void ActionViewGraph()
        {
            if (!OpenViewGraph)
            {
                Form3 frm = new Form3() { MainForm = this };
                frm.Show(this);
                OpenViewGraph = true;
            }
            
        }
        private void label2_Click(object sender, EventArgs e)
        {
           
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonVDetail_Click(object sender, EventArgs e)
        {
            ActionViewDetailButton();
        }

        public void ActionViewDetailButton()
        {
            if (!OpenAddForm)
            {
                Form2 frm = new Form2() { MainForm = this };
                frm.Show(this);
                OpenAddForm = true;
            }
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            Student obj = new Student();
            try
            {
                if (Validation())
                {
                    string firstName = txtFirstName.Text;
                    string lastName = txtLastName.Text;
                    obj.Name = firstName + " " + lastName;
                    obj.Address = txtAddress.Text;
                    obj.Email = txtEmail.Text;
                    obj.DOB = dtpDOB.Value;
                    obj.Contact = txtContact.Text;
                    obj.Gender = cbGender.SelectedItem.ToString();
                    obj.Faculty = cbFaculty.SelectedItem.ToString();
                    obj.RegistrationDate = dtpRegisterationDate.Value;
                    obj.Add(obj);
                    MessageBox.Show("Registration Sucessfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Clear();
                }


                //else if (string.IsNullOrEmpty(cbGender.Text) || cbGender.Text != "Male" || cbGender.Text != "Female" || cbGender.Text != "Others")
                //{
                //    MessageBox.Show("Select from gender option. !!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //}

             
            }
            catch (Exception)
            {
               MessageBox.Show("Something is missing !!!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }
        public bool Validation()
        {
            bool validate = true;
            if (string.IsNullOrEmpty(txtFirstName.Text))
            {
                ErrorMessage("first name");
                validate = false;
            }
            else if (string.IsNullOrEmpty(txtLastName.Text))
            {
                ErrorMessage("last name");
                validate = false;
            }
            else if (string.IsNullOrEmpty(txtAddress.Text))
            {
                ErrorMessage("address");
                validate = false;
            }
            else if (string.IsNullOrEmpty(txtContact.Text))
            {
                ErrorMessage("contact");
                validate = false;
            }
            else if (string.IsNullOrEmpty(txtEmail.Text))
            {
                ErrorMessage("email");
                validate = false;
            }
            else if (string.IsNullOrEmpty(cbGender.Text))
            {
                ErrorMessage("gender");
                validate = false;
            }
            else if (string.IsNullOrEmpty(cbFaculty.Text))
            {
                ErrorMessage("faculty");
                validate = false;
            }
            else if (IsValidEmail(txtEmail.Text) == false)
            {
                MessageBox.Show("Email is not validate.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                validate = false;
            }
            //else if (IsPhoneNumber(txtContact.Text) == false)
           // {
            //    MessageBox.Show("Contact is not validate.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    validate = false;
            //}
            return validate;
        } 
        private void ErrorMessage(string e)
        {
            string v = "You missed to fill the " + e + ".";
            MessageBox.Show(v, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        private void Clear()
        {
            txtId.Text = "";
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtAddress.Text = "";
            txtEmail.Text = "";
            dtpDOB.Value = DateTime.Today;
            txtContact.Text = "";
            cbGender.SelectedItem = null;
            cbFaculty.SelectedItem = null;
        }

        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {
        }
        public bool IsValidEmail(string source)
        {
            return new EmailAddressAttribute().IsValid(source);
        }
        public static bool IsPhoneNumber(string number)
        {
            return Regex.Match(number, @"^(\+[0-9]{9})$").Success;
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you Sure? You want to delete thsi information.", "Warning for Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                Student obj = new Student();
                int id = int.Parse(txtId.Text);
                obj.Delete(id);
                Clear();
                MessageBox.Show("Delete Successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            Clear();
            ButtonStatus(false, true);
            ActionViewDetailButton();
        }
        public void FillTextField(Student std)
        {
            txtId.Text = std.Id.ToString();
            txtFirstName.Text = std.Name.Split(' ')[0];
            txtLastName.Text = std.Name.Split(' ')[1];
            txtAddress.Text = std.Address;
            txtEmail.Text = std.Email;
            dtpDOB.Value = std.DOB;
            txtContact.Text = std.Contact;
            cbGender.SelectedItem = std.Gender;
            cbFaculty.SelectedItem = std.Faculty;

            ButtonStatus(true, false);
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Clear();
            ButtonStatus(false,true);
            
        }
        public void ButtonStatus(bool con1, bool con2)
        {
            buttonDelete.Visible = con1;
            buttonUpdate.Visible = con1;
            buttonCancel.Visible = con1;
            buttonVDetail.Visible = con2;
            buttonSubmit.Visible = con2;
            buttonVGraph.Visible = con2;
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you Sure? You want to Update this information.", "Warning for Update", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if(result == DialogResult.Yes)
            {
                Student obj = new Student();
                obj.Id = int.Parse(txtId.Text);
                string firstName = txtFirstName.Text;
                string lastName = txtLastName.Text;
                obj.Name = firstName + " " + lastName;
                obj.Address = txtAddress.Text;
                obj.Email = txtEmail.Text;
                obj.DOB = dtpDOB.Value;
                obj.Contact = txtContact.Text;
                obj.Gender = cbGender.SelectedItem.ToString();
                obj.Faculty = cbFaculty.SelectedItem.ToString();
                obj.Edit(obj);
                Clear();
                MessageBox.Show("Update Successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
            Clear();
            ButtonStatus(false, true);
            ActionViewDetailButton();


        }

        private void cbGender_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbGender_DropDownClosed(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}

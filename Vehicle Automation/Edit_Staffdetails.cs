using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Vehicle_Automation
{
    public partial class Edit_Staffdetails : Form
    {
        private static Edit_Staffdetails _instance7;
        public Edit_Staffdetails()
        {
            InitializeComponent();
            Fillcombobox();
        }
        void Fillcombobox()
        {
            string constring = "datasource=localhost;port=3306;username=root;password=Ammoos123";
            string Query = "Select * from vehicle_automation.staff_details";
            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlCommand cmdDatabase = new MySqlCommand(Query, conDataBase);
            MySqlDataReader myReader;
            try
            {
                conDataBase.Open();
                myReader = cmdDatabase.ExecuteReader();
                while (myReader.Read())
                {
                    string code = myReader.GetString("Code_Given");
                    comboBox1.Items.Add(code);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public Edit_Staffdetails instance7
        {
            get
            {
                if (Edit_Staffdetails._instance7 == null)
                {
                    Edit_Staffdetails._instance7 = new Edit_Staffdetails();
                }
                Edit_Staffdetails._instance7.Activate();
                return Edit_Staffdetails._instance7;
            }
        }

        private void Edit_Staffdetails_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Edit_Staffdetails_FormClosed(object sender, FormClosedEventArgs e)
        {
            Edit_Staffdetails._instance7 = null;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string constring = "datasource=localhost;port=3306;username=root;password=Ammoos123";
            string Query = "Select * from vehicle_automation.staff_details where code_given='" + comboBox1.SelectedItem + "';";
            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlCommand cmdDatabase = new MySqlCommand(Query, conDataBase);
            MySqlDataReader myReader;
            try
            {
                conDataBase.Open();
                myReader = cmdDatabase.ExecuteReader();
                while (myReader.Read())
                {
                    string sname = myReader.GetString("name");
                    string sadd = myReader.GetString("Address");
                    string scontct = myReader.GetInt32("contact_details").ToString();
                    string sdept = myReader.GetString("department");
                    string semp_date = myReader.GetString("emp_date");
                    textBox1.Text = sname;
                    richTextBox1.Text = sadd;
                    textBox2.Text = scontct;
                    comboBox2.Text = sdept;
                    dateTimePicker1.Text = semp_date;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string constring = "datasource=localhost;port=3306;username=root;password=Ammoos123";
            string Query = " update vehicle_automation.staff_details set name='" + this.textBox1.Text + "',code_given='" + this.comboBox1.SelectedItem + "',Address='" + this.richTextBox1.Text + "',contact_details='" + this.textBox2.Text + "',department='" + this.comboBox2.SelectedItem + "',emp_date='" + dateTimePicker1.Text + "' where code_given='" + this.comboBox1.SelectedItem + "';";
            MySqlConnection conDatabase = new MySqlConnection(constring);
            MySqlCommand cmdDatabase = new MySqlCommand(Query, conDatabase);
            //cmdDatabase.Parameters.AddWithValue("@code", this.comboBox1.SelectedItem);
            //cmdDatabase.Parameters.AddWithValue("@name", textBox1.Text);
            //cmdDatabase.Parameters.AddWithValue("@address", richTextBox1.Text);
            //cmdDatabase.Parameters.AddWithValue("@contact", textBox2.Text);
            //cmdDatabase.Parameters.AddWithValue("@dept", this.comboBox2.SelectedItem);
            //cmdDatabase.Parameters.AddWithValue("@empdata", dateTimePicker1.Text);

            try
            {
                conDatabase.Open();
                int affectedRows = cmdDatabase.ExecuteNonQuery();
                if (affectedRows > 0)
                {
                    MessageBox.Show("Staff Details updated Successfully");
                }
                else
                {
                    MessageBox.Show("Updation Failed");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }        
        }
    }
}

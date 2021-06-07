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
    public partial class Edit_VehicleDetails : Form
    {
        private static Edit_VehicleDetails _instance3;
        public Edit_VehicleDetails()
        {
            InitializeComponent();
            Fillcombo();
        }
        void Fillcombo()
        {
            string constring = "datasource=localhost;port=3306;username=root;password=Ammoos123";
            string Query = "Select * from vehicle_automation.vehicle_details";
            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlCommand cmdDatabase = new MySqlCommand(Query, conDataBase);
            MySqlDataReader myReader;
            try
            {
                conDataBase.Open();
                myReader = cmdDatabase.ExecuteReader();
                while (myReader.Read())
                {
                    string RegNo = myReader.GetString("Vehicle_RegNo");
                    comboBox1.Items.Add(RegNo);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public Edit_VehicleDetails instance3
        {
            get
            {
                if (Edit_VehicleDetails._instance3 == null)
                {
                    Edit_VehicleDetails._instance3 = new Edit_VehicleDetails();
                }
                Edit_VehicleDetails._instance3.Activate();
                return Edit_VehicleDetails._instance3;
            }
        }

        private void Edit_VehicleDetails_FormClosed(object sender, FormClosedEventArgs e)
        {
            Edit_VehicleDetails._instance3 = null;
        }

        private void Edit_VehicleDetails_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string constring = "datasource=localhost;port=3306;username=root;password=Ammoos123";
            string Query = " update vehicle_automation.vehicle_details set Vehicle_Regno= '" + this.comboBox1.SelectedItem + "',Manufacturer='" + this.textBox1.Text + "',Address='" + this.richTextBox1.Text + "',Contact_details='" + this.textBox4.Text + "',Representative_Name='" + this.textBox5.Text + "'where Vehicle_Regno= '" + this.comboBox1.SelectedItem + "' ;";
            MySqlConnection conDatabase = new MySqlConnection(constring);
            MySqlCommand cmdDatabase = new MySqlCommand(Query, conDatabase);
            try
            {
                conDatabase.Open();
                int affectedRows = cmdDatabase.ExecuteNonQuery();
                if (affectedRows > 0)
                {
                    MessageBox.Show("Vehicle Details Updation Successfull");
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string constring = "datasource=localhost;port=3306;username=root;password=Ammoos123";
            string Query = "Select * from vehicle_automation.vehicle_details where vehicle_Regno='" + comboBox1.SelectedItem + "';";
            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlCommand cmdDatabase = new MySqlCommand(Query, conDataBase);
            MySqlDataReader myReader;
            try
            {
                conDataBase.Open();
                myReader = cmdDatabase.ExecuteReader();
                while (myReader.Read())
                {
                    string mname = myReader.GetString("manufacturer");
                    string madd = myReader.GetString("Address");
                    string mcontct = myReader.GetInt32("contact_details").ToString();
                    string mrepname = myReader.GetString("representative_name");
                    
                    textBox1.Text = mname;
                    richTextBox1.Text = madd;
                    textBox4.Text = mcontct;
                    textBox5.Text = mrepname;
                    

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

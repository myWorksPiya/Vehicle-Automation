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
    public partial class AddVehicle : Form
    {
        private static AddVehicle _instance2;
        public AddVehicle()
        {
            InitializeComponent();
        }
        public AddVehicle instance2
        {
            get
            {
                if (AddVehicle._instance2 == null)
                {
                    AddVehicle._instance2 = new AddVehicle();
                }
                AddVehicle._instance2.Activate();
                return AddVehicle._instance2;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void AddVehicle_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddVehicle_FormClosed(object sender, FormClosedEventArgs e)
        {
            AddVehicle._instance2 = null;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string constring = "datasource=localhost;port=3306;username=root;password=Ammoos123";
            string Query = " insert into vehicle_automation.vehicle_details(Vehicle_Regno,Manufacturer,Address,Contact_details,Representative_Name) values('" + this.textBox2.Text + "', '" + this.textBox1.Text + "','" + this.rtb3.Text + "','" + this.textBox4.Text + "','" + this.textBox5.Text + "');";
            MySqlConnection conDatabase = new MySqlConnection(constring);
            MySqlCommand cmdDatabase = new MySqlCommand(Query, conDatabase);
            try
            {
                conDatabase.Open();
                int affectedRows = cmdDatabase.ExecuteNonQuery();
                if (affectedRows > 0)
                {
                    MessageBox.Show("Vehicle Details Insertion Successfull");
                }
                else
                {
                    MessageBox.Show("Insertion Failed. Check the values inserted");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }   
        }
    }
}

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
    public partial class Maintenance_Log : Form
    {
        private static Maintenance_Log _instance1;
        public Maintenance_Log()
        {
            InitializeComponent();
            Fillmechname();
            Fillregno();
        }
        string vehicle_tuned;
        string oil_changed, gearboxoil, airfilter;
        void Fillmechname()
        {
            string constring = "datasource=localhost;port=3306;username=root;password=Ammoos123";
            string Query = "Select * from vehicle_automation.staff_details where department='mechanic section'";
            MySqlConnection coDataBase = new MySqlConnection(constring);
            MySqlCommand cmDatabase = new MySqlCommand(Query, coDataBase);
            MySqlDataReader myReader;
            try
            {
                coDataBase.Open();
                myReader = cmDatabase.ExecuteReader();
                while (myReader.Read())
                {
                    string mechname = myReader.GetString("Name");
                    comboBox2.Items.Add(mechname);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        void Fillregno()
        {
            string constring = "datasource=localhost;port=3306;username=root;password=Ammoos123";
            string Query = "Select * from vehicle_automation.vehicle_details ";
            MySqlConnection coDataBase = new MySqlConnection(constring);
            MySqlCommand cmDatabase = new MySqlCommand(Query, coDataBase);
            MySqlDataReader myReader;
            try
            {
                coDataBase.Open();
                myReader = cmDatabase.ExecuteReader();
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

        public Maintenance_Log instance1
        {
            get
            {
                if(Maintenance_Log._instance1 == null)
                {
                    Maintenance_Log._instance1 = new Maintenance_Log();
                }
                Maintenance_Log._instance1.Activate();
                return Maintenance_Log._instance1;
            }
        }

        private void Maintenance_Log_FormClosed(object sender, FormClosedEventArgs e)
        {
            Maintenance_Log._instance1 = null;
        }

        private void lbl13_Click(object sender, EventArgs e)
        {

        }

        private void Maintenance_Log_Load(object sender, EventArgs e)
        {

        }

        private void lbl14_Click(object sender, EventArgs e)
        {

        }

        private void lbl17_Click(object sender, EventArgs e)
        {

        }

        private void lbl18_Click(object sender, EventArgs e)
        {

        }

        private void lbl44_Click(object sender, EventArgs e)
        {

        }

        private void lbl19_Click(object sender, EventArgs e)
        {

        }

        private void lbl20_Click(object sender, EventArgs e)
        {

        }

        private void lbl21_Click(object sender, EventArgs e)
        {

        }

        private void lbl15_Click(object sender, EventArgs e)
        {

        }

        private void lbl22_Click(object sender, EventArgs e)
        {

        }

        private void lbl23_Click(object sender, EventArgs e)
        {

        }

        private void lbl25_Click(object sender, EventArgs e)
        {

        }

        private void lbl26_Click(object sender, EventArgs e)
        {

        }

        private void lbl24_Click(object sender, EventArgs e)
        {

        }

        private void Savebtn_Click(object sender, EventArgs e)
        {
            string constring = "datasource=localhost;port=3306;username=root;password=Ammoos123";
            string Query = " insert into vehicle_automation.maintenance_log(VehRegno,Maintenance_Date,Odometer_Reading,Mechanic,Job_Number,Vehicle_Tuned,Oil_Changed,Type_of_oil,GearBoxoil_changed,GearBoxoil_Type,Tyres_Changed,Airfilter_Changed,Seats_Changed,Issues_Details,Solutions) values('" + this.comboBox1.SelectedItem + "', '" + this.dtpicker2.Text + "','" + this.textBox1.Text + "','" + this.comboBox2.SelectedItem + "','" + this.textBox2.Text + "','" + vehicle_tuned + "','" + oil_changed + "','" + this.comboBox3.SelectedItem + "','" + gearboxoil + "','" + this.comboBox4.SelectedItem + "','" + this.comboBox5.SelectedItem + "','" + airfilter + "','" + this.comboBox6.SelectedItem + "','" + this.rtb1.Text + "','" + this.rtb2.Text + "');";
            MySqlConnection conDatabase = new MySqlConnection(constring);
            MySqlCommand cmdDatabase = new MySqlCommand(Query, conDatabase);

            try
            {
                conDatabase.Open();
                int affectedRows = cmdDatabase.ExecuteNonQuery();
                if (affectedRows > 0)
                {
                    MessageBox.Show("Maintenance log is added");
                }
                else
                {
                    MessageBox.Show("Insertion Failed.Check the values inserted");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            airfilter = "Yes";
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            airfilter = "No";
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            vehicle_tuned = "Yes";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            vehicle_tuned = "No";
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            oil_changed = "Yes";
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            oil_changed = "No";
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            gearboxoil = "Yes";
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            gearboxoil = "No";
        }
    }
}

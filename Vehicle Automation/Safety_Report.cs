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
    public partial class Safety_Report : Form
    {
        private static Safety_Report _instance;
        public Safety_Report()
        {
            InitializeComponent();
            Fillopname();
            Fillcombo();
            Fillinspname();
        }
        string oil_leaking;
        void Fillopname()
        {
            string constring = "datasource=localhost;port=3306;username=root;password=Ammoos123";
            string Query = "Select * from vehicle_automation.staff_details where department='Operator Section'";
            MySqlConnection coDataBase = new MySqlConnection(constring);
            MySqlCommand cmDatabase = new MySqlCommand(Query, coDataBase);
            MySqlDataReader myReader;
            try
            {
                coDataBase.Open();
                myReader = cmDatabase.ExecuteReader();
                while (myReader.Read())
                {
                    string opname = myReader.GetString("Name");
                    cmb8.Items.Add(opname);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

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
                    cmb7.Items.Add(RegNo);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        void Fillinspname()
        {
            string constring = "datasource=localhost;port=3306;username=root;password=Ammoos123";
            string Query = "Select * from vehicle_automation.staff_details where department='inspection'";
            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlCommand cmdDatabase = new MySqlCommand(Query, conDataBase);
            MySqlDataReader myReader;
            try
            {
                conDataBase.Open();
                myReader = cmdDatabase.ExecuteReader();
                while (myReader.Read())
                {
                    string ipname = myReader.GetString("Name");
                    cmb16.Items.Add(ipname);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        
        public Safety_Report instance
        {
            get
            {
                if (Safety_Report._instance == null)
                {
                    Safety_Report._instance = new Safety_Report();
                }
                Safety_Report._instance.Activate();
                return Safety_Report._instance;
            }
        }

        private void Safety_Report_FormClosed(object sender, FormClosedEventArgs e)
        {
            Safety_Report._instance = null;
        }

        private void Savebtn_Click(object sender, EventArgs e)
        {
            string constring = "datasource=localhost;port=3306;username=root;password=Ammoos123";
            string Query = " insert into vehicle_automation.safetyinspection_report(VehRegno,Inspection_Date,Operator,Odometer_Reading,Windshield_Condition,Wiperblades_condition,Tyres_Condition,Doors_Condition,Breaking_Efficiency,Oil_leaking, Parts_condition,Details_of_repairs, vehicle_Condition,  Inspector,Code) values('" + this.cmb7.SelectedItem + "','" + dateTimePicker1.Text + "','" + cmb8.SelectedItem + "','" + textBox1.Text + "','" + this.cmb9.SelectedItem + "','" + this.cmb10.SelectedItem + "','" + this.cmb11.SelectedItem + "','" + this.cmb12.SelectedItem + "','" + this.cmb13.SelectedItem + "','" + oil_leaking + "','" + this.cmb14.SelectedItem + "','" + this.richTextBox1.Text + "','" + this.cmb15.SelectedItem + "','" + this.cmb16.SelectedItem + "','" + textBox2.Text + "');";
             MySqlConnection conDatabase = new MySqlConnection(constring);
            MySqlCommand cmdDatabase = new MySqlCommand(Query, conDatabase);

            try
            {
                conDatabase.Open();
                int affectedRows = cmdDatabase.ExecuteNonQuery();
                if (affectedRows > 0)
                {
                    MessageBox.Show("Safety_Report is added");
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
            oil_leaking = "Yes";
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            oil_leaking = "No";
        }
        
    }
}

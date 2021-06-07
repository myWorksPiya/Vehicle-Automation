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
    public partial class DeleteVehicle : Form
    {
        private static DeleteVehicle _instance5;
        public DeleteVehicle()
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
                    cmb7.Items.Add(RegNo);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public DeleteVehicle instance5
        {
            get
            {
                if (DeleteVehicle._instance5 == null)
                {
                    DeleteVehicle._instance5 = new DeleteVehicle();
                }
                DeleteVehicle._instance5.Activate();
                return DeleteVehicle._instance5;
            }
        }

        private void DeleteVehicle_FormClosed(object sender, FormClosedEventArgs e)
        {
            DeleteVehicle._instance5 = null;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string constring = "datasource=localhost;port=3306;username=root;password=Ammoos123";
            string Query = " delete from vehicle_automation.vehicle_details where vehicle_Regno = @Regno;";
            MySqlConnection conDatabase = new MySqlConnection(constring);
            MySqlCommand cmdDatabase = new MySqlCommand(Query, conDatabase);
            cmdDatabase.Parameters.AddWithValue("@Regno", this.cmb7.SelectedItem);
            //MySqlDataReader myReader;
            try
            {
                conDatabase.Open();
                int affectedRows = cmdDatabase.ExecuteNonQuery();
                if (affectedRows > 0)
                {
                    MessageBox.Show("Deletion Successfull");
                }
                else
                {
                    MessageBox.Show("Deletion Failed. Check the values inserted");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }       
        }

    }
}

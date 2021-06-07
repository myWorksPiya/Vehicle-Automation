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
    public partial class Delete_Staff : Form
    {
        private static Delete_Staff _instance6;
        public Delete_Staff()
        {
            InitializeComponent();
            Fillcombo();
        }
        void Fillcombo()
        {
            string constring = "datasource=localhost;port=3306;username=root;password=Ammoos123";
            string Query = "Select * from vehicle_automation.staff_details";
            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlCommand cmdDatabase = new MySqlCommand(Query, conDataBase);
            MySqlDataReader myReader;
            try
            {
                conDataBase.Open();
                myReader= cmdDatabase.ExecuteReader();
                while(myReader.Read())
                {
                    
                    string sectioncode = myReader.GetString("Code_Given");
                    comboBox1.Items.Add(sectioncode);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public Delete_Staff instance6
        {
            get
            {
                if (Delete_Staff._instance6 == null)
                {
                    Delete_Staff._instance6 = new Delete_Staff();
                }
                Delete_Staff._instance6.Activate();
                return Delete_Staff._instance6;
            }
        }

        private void Delete_Staff_FormClosed(object sender, FormClosedEventArgs e)
        {
            Delete_Staff._instance6 = null;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string constring = "datasource=localhost;port=3306;username=root;password=Ammoos123";
            string Query = " delete from vehicle_automation.staff_details where code_given = @givencode and department = @dept;";
            MySqlConnection conDatabase = new MySqlConnection(constring);
            MySqlCommand cmdDatabase = new MySqlCommand(Query, conDatabase);
            cmdDatabase.Parameters.AddWithValue("@givencode", this.comboBox1.SelectedItem);
            cmdDatabase.Parameters.AddWithValue("@dept", this.cmb7.SelectedItem);
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


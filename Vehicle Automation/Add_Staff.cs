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

    public partial class Add_Staff : Form
    {
        private static Add_Staff _instance4;
        public Add_Staff()
        {
            InitializeComponent();
        }
        public Add_Staff Instance4
        {
            get
            {
                if (Add_Staff._instance4 == null)
                {
                    Add_Staff._instance4 = new Add_Staff();
                }
                Add_Staff._instance4.Activate();
                return Add_Staff._instance4;
            }
        }

        private void Add_Staff_FormClosed(object sender, FormClosedEventArgs e)
        {
            Add_Staff._instance4 = null;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string constring = "datasource=localhost;port=3306;username=root;password=Ammoos123";
            string Query = " insert into vehicle_automation.staff_details(name,code_given,Address,contact_details,department,emp_date) values(@name, @code,@address,@contact,@dept,@empdata);";
            MySqlConnection conDatabase = new MySqlConnection(constring);
            MySqlCommand cmdDatabase = new MySqlCommand(Query, conDatabase);
            cmdDatabase.Parameters.AddWithValue("@name", textBox2.Text);
            cmdDatabase.Parameters.AddWithValue("@code", textBox1.Text);
            cmdDatabase.Parameters.AddWithValue("@address", richTextBox1.Text);
            cmdDatabase.Parameters.AddWithValue("@contact", textBox3.Text);
            cmdDatabase.Parameters.AddWithValue("@dept", this.comboBox1.SelectedItem);
            cmdDatabase.Parameters.AddWithValue("@empdata", dateTimePicker1.Text);

            try
            {
                conDatabase.Open();
                int affectedRows = cmdDatabase.ExecuteNonQuery();
                if (affectedRows > 0)
                {
                    MessageBox.Show("Staff details added Successfully");
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

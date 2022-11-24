using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AFC
{
    public partial class MainFrame : Form
    {
        public MainFrame()
        {
          
              InitializeComponent();
            
        }

        private void ViewProcessDataButton_Click(object sender, EventArgs e)
        {
            ViewProcces add = new ViewProcces();
            add.Text = dataTextBox1.Text.ToString();
            add.Show();
            
        }

        private void backMainFramepictureBox1_Click(object sender, EventArgs e)
        {
            StartPage add = new StartPage();
            add.Show();
            this.Hide();

        }



        private string searchOnPage()
        {
            string nameOnPage = "AK-47 |,AWP |,MP9 |,MAC-10 |,Desert Eagle |,M4A4 |,M4A1-S |,Glock-18 |,USP-S |,Negev |,P2000 |,Five-Seven |,P250 |,Dual Berettas |,Tec-9 |,CZ75-Auto |,PP-Bizon |,MP7 |,FAMAS |,P90 |,Sawed-Off |,R8 Revolver |,M249 |, Galil AR |,XM1014 |,MAG-7 |,G3SG1 |,AUG |,SG 553 |,SCAR 20 |,SSG 08 |";
            string temp = "(";
            string[] names = nameOnPage.Split(',');
            int start = 0;
            int finish = 0;
            string buff = null;
            int count = names.Length;
            if (dataTextBox1.Text == "")
            {
                return null;
            }
            for (int i = 0; i < count; i++)
            {
                start = dataTextBox1.Text.IndexOf(names[i]);
                if (start != 0 && start != -1)
                {
                    string r = dataTextBox1.Text.Substring(start);
                    buff = dataTextBox1.Text.Substring(start, r.IndexOf(temp)-1);
                    break;
                }
            }



            return buff;
        }

       
       private void dataTextBox1_TextChanged(object sender, EventArgs e)
        {
            string a = searchOnPage();
            if(a==null)
            {
                return;
            }
                DataBase db = new DataBase();
            db.openConnection();
            string collection="", quality="";
            string quary1 = "SELECT collection FROM afc WHERE name = '"+a+"'";
            string quary2 = "SELECT quality FROM afc WHERE name = '" + a + "'";
            MySqlCommand command = new MySqlCommand(quary1,db.getConnection());
            MySqlDataReader reader = command.ExecuteReader();
            
            while (reader.Read())
            {
                collection=reader[0].ToString();

            }
            reader.Close(); 
            MySqlCommand command2 = new MySqlCommand(quary2, db.getConnection());
            MySqlDataReader reader2 = command2.ExecuteReader();
            while (reader2.Read())
            {
               quality = reader2[0].ToString();

            }
            reader2.Close();
            switch (quality)
            {
                case "Convert":
                    break;

                case "Classified":
                    string quary3 = "SELECT name FROM afc WHERE collection = '" + collection + "' AND quality = 'Convert'";
                    MySqlCommand command3 = new MySqlCommand(quary3, db.getConnection());
                    MySqlDataReader reader3 = command3.ExecuteReader();
                    while (reader3.Read())
                    {
                        DatacomboBox1.Items.Add(reader3[0].ToString());
                    }
                    reader3.Close();
                    break;

                case "Restricted":
                    string quary4 = "SELECT name FROM afc WHERE collection = '" + collection + "' AND quality = 'Classified'";
                    MySqlCommand command4 = new MySqlCommand(quary4, db.getConnection());
                    MySqlDataReader reader4 = command4.ExecuteReader();
                    while (reader4.Read())
                    {
                        DatacomboBox1.Items.Add(reader4[0].ToString());
                    }
                    reader4.Close();
                    break;

                case "Mil-Spec":
                    string quary5 = "SELECT name FROM afc WHERE collection = '" + collection + "' AND quality = 'Restricted'";
                    MySqlCommand command5 = new MySqlCommand(quary5, db.getConnection());
                    MySqlDataReader reader5 = command5.ExecuteReader();
                   
                    while (reader5.Read())
                    {
                        DatacomboBox1.Items.Add(reader5[0].ToString());
                    }
                
                    reader5.Close();
                    break;

                case "Industrial Grade":
                    string quary6 = "SELECT name FROM afc WHERE collection = '" + collection + "' AND quality = 'Mil-Spec'";
                    MySqlCommand command6 = new MySqlCommand(quary6, db.getConnection());
                    MySqlDataReader reader6 = command6.ExecuteReader();
                    while (reader6.Read())
                    {
                        DatacomboBox1.Items.Add(reader6[0].ToString());
                    }
                    reader6.Close();
                    break;

                case "Consumer Grade":
                    string quary7 = "SELECT name FROM afc WHERE collection = '" + collection + "' AND quality = 'Industrial Grade'";
                    MySqlCommand command7 = new MySqlCommand(quary7, db.getConnection());
                    MySqlDataReader reader7 = command7.ExecuteReader();
                    while (reader7.Read())
                    {
                        DatacomboBox1.Items.Add(reader7[0].ToString());
                    }
                    reader7.Close();
                    break;

                 default:
                 break;
            }
            db.closeConnection();
            
        }

        private void doCalculationButton_Click(object sender, EventArgs e)
        {

        }

        private void DatacomboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            doCalculationButton.Enabled = true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            dataTextBox1.Text = "0";
        }
    }
}

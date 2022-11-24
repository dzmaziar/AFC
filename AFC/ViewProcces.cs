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
    public partial class ViewProcces : Form
    {
        public ViewProcces()
        {
            InitializeComponent();
        }
        private string searchOnPage()
        {
          //  MainFrame Main = new MainFrame();
            string nameOnPage = "AK-47 |,AWP |,MP9 |,MAC-10 |,Desert Eagle |,M4A4 |,M4A1-S |,Glock-18 |,USP-S |,Negev |,P2000 |,Five-Seven |,P250 |,Dual Berettas |,Tec-9 |,CZ75-Auto |,PP-Bizon |,MP7 |,FAMAS |,P90 |,Sawed-Off |,R8 Revolver |,M249 |, Galil AR |,XM1014 |,MAG-7 |,G3SG1 |,AUG |,SG 553 |,SCAR 20 |,SSG 08 |";
            string temp = "(";
            string[] names = nameOnPage.Split(',');
            int start = 0;
            int finish = 0;
            string buff = null;
            int count = names.Length;

          string name = Text.ToString();

            if ( name== "" && name == "0")
            {
                return null;
            }
            for (int i = 0; i < count; i++)
            {
                start = name.IndexOf(names[i]);
                if (start != 0 && start != -1)
                {
                    string r = name.Substring(start);
                    buff = name.Substring(start, r.IndexOf(temp) - 1);
                    break;
                }
            }



            return buff;
        }

        private void ViewProccessPanel1_Paint(object sender, PaintEventArgs e)
        {
          
            string buff = null;
            buff = searchOnPage();
            if (buff == null) {
                return;
            }
            string floatBuff = null;
            floatBuff = Text.ToString();
            List<double> floatList = new List<double>();
            floatList=(FloatHighLighter.HighLightFloats(floatBuff));
        
            List<string> data = new List<string>();
           foreach (double d in floatList)
            {
                // Apply formatting to the string if necessary
                data.Add(d.ToString());
            }
           for(int i=0;i<data.Count;i++)
            {
                // Apply formatting to the string if necessary
                dataGridView1.Rows.Add(buff,data[i]);
            }
          
            

        }

      
    }
}

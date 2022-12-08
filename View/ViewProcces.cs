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
using AFC.Presenter;
using AFClibrary;

namespace AFC
{
    public partial class ViewProcces : Form
    {
        public ViewProcces()
        {
            InitializeComponent();
        }
        
        private void ViewProccessPanel1_Paint(object sender, PaintEventArgs e)
        {
            ViewProccesPresenter.ViewProcces(Text,dataGridView1);
        }
    }
}

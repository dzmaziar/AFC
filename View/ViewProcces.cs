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
using Presenter;
using Presenter.View;

namespace AFC
{
    public partial class ViewProcces : Form, IViewDataProccess
    {
        ViewProcessedDataPresenter _presenter;
        public ViewProcces()
        {
            InitializeComponent();
            _presenter = new ViewProcessedDataPresenter(this);
        }

        public void SetData(string buff,List<string> arr)
        {
            for (int i = 0; i < arr.Count; i++)
            {

                dataGridView1.Rows.Add(buff, arr[i]);
            }
        }

        private void ViewProccessPanel1_Paint(object sender, PaintEventArgs e)
        {
            _presenter.ViewProcessedData(Text);
        }
    }
}

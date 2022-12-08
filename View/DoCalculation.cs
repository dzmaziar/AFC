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

namespace AFC
{
    public partial class DoCalculation : Form
    {
        public DoCalculation(string answer)
        {
            InitializeComponent();
            Text = answer;
        }

        private void DoCalculation_Load(object sender, EventArgs e)
        {
           DoCalculationPresenter.DoCalculation(Text,combinationDataGridView);
        }

       
    }
}

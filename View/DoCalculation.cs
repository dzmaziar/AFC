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
    public partial class DoCalculation : Form, IDoCalculationView
    {
       private DoCalculationPresenter _presenter;
        public DoCalculation(string answer)
        {
            InitializeComponent();
            Text = answer;
            _presenter = new DoCalculationPresenter(this);

        }
        public void SetListOnGried(List<string> list)
        {
            for (int i = 0; i < 10; i++)
            {
                combinationDataGridView.Rows.Add(list[i]);
            }
        }
        private void DoCalculation_Load(object sender, EventArgs e)
        {
           _presenter.DoCalculation(Text);
        }

       
    }
}

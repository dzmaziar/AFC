using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Presenterr;
using Presenterr.View;

namespace AFC
{
    public partial class DoCalculationFrame : Form, IDoCalculationView
    {
       private DoCalculationPresenter _presenter;
        public DoCalculationFrame()
        {
            InitializeComponent();
            _presenter = new DoCalculationPresenter(this);
        }
        public DoCalculationFrame(string answer)
        {
            InitializeComponent();
            Text = answer;
            _presenter = new DoCalculationPresenter(this);
            _presenter.GetCalculateResult(Text);

        }
        public void SetListOnGried(List<string> list)
        {
            for (int i = 0; i < 10; i++)
            {
              combinationDataGridView.Rows.Add(list[i]);
            }
        }
        //private void DoCalculation_Load(object sender, EventArgs e)
        //{
        // _presenter.DoCalculation(Text);
        //}

       
    }
}

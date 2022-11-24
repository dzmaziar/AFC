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
    public partial class DoCalculation : Form
    {
        public DoCalculation(string answer)
        {
            InitializeComponent();
            Text = answer;
        }

        private void DoCalculation_Load(object sender, EventArgs e)
        {
            string answer = Text.ToString();
            string[] answerArray = null;
               answerArray = answer.Split('\n');
            List<string> data = new List<string>();
            foreach(string line in answerArray)
            {
                data.Add(line.ToString());
            }
            for (int i = 0; i < 10; i++)
            {
                // Apply formatting to the string if necessary
                combinationDataGridView.Rows.Add(data[i]);
            }
        }

        
    }
}

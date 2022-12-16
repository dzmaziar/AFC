using Presenterr;
using Presenterr.View;
namespace AFC
{
    public partial class MainFrame : Form, IMainFrameView
    {
       private MainFramePresenter _presenter;
        public MainFrame()
        {
            InitializeComponent();
            _presenter = new MainFramePresenter(this);
        }
        private void ViewProcessDataButton_Click(object sender, EventArgs e)
        {
            ViewProcces add = new ViewProcces();
            add.Text = dataTextBox1.Text;
            add.Show();

        }
        private void backMainFramepictureBox1_Click(object sender, EventArgs e)
        {
            StartPage add = new StartPage();
            add.Show();
            this.Hide();
        }
        private void dataTextBox1_TextChanged(object sender, EventArgs e)
        {
            _presenter.SelectGun(dataTextBox1.Text);
        }
        private void doCalculationButton_Click(object sender, EventArgs e)
        {

            var text = _presenter.Counting();
            if(text == null || text == "0")
            {
                return;
            }
            DoCalculationFrame doCalculation = new DoCalculationFrame(text);
            doCalculation.Show();
        }
        private void DatacomboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (floatTextBox.Text != "")
            {
                doCalculationButton.Enabled = true;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            dataTextBox1.Text = "0";
            DatacomboBox1.Items.Clear();
            DatacomboBox1.Text = "";
            doCalculationButton.Enabled = false;
            floatTextBox.Clear();
        }

        public void SetComboBox(string[] list)
        {
            DatacomboBox1.Items.AddRange(list);
        }

        public string GetSelectedItem()
        {
            return DatacomboBox1.SelectedItem.ToString();
        }

        public void ViewMessageBox(string message)
        {
            MessageBox.Show(message);
        }

        public string GetFloatText()
        {
           return floatTextBox.Text;
        }

        public string GetdataText()
        {
            return dataTextBox1.Text;
        }
    }
}

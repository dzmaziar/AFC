namespace AFC
{
    partial class MainFrame
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainFrame));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.doCalculationButton = new System.Windows.Forms.Button();
            this.backMainFramepictureBox1 = new System.Windows.Forms.PictureBox();
            this.DatacomboBox1 = new System.Windows.Forms.ComboBox();
            this.getRecommenationButton = new System.Windows.Forms.Button();
            this.ViewProcessDataButton = new System.Windows.Forms.Button();
            this.dataTextBox1 = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.backMainFramepictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RosyBrown;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.doCalculationButton);
            this.panel1.Controls.Add(this.backMainFramepictureBox1);
            this.panel1.Controls.Add(this.DatacomboBox1);
            this.panel1.Controls.Add(this.getRecommenationButton);
            this.panel1.Controls.Add(this.ViewProcessDataButton);
            this.panel1.Controls.Add(this.dataTextBox1);
            this.panel1.Location = new System.Drawing.Point(-1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1293, 797);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(205, 61);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(45, 39);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // doCalculationButton
            // 
            this.doCalculationButton.BackColor = System.Drawing.Color.Transparent;
            this.doCalculationButton.Enabled = false;
            this.doCalculationButton.Location = new System.Drawing.Point(534, 196);
            this.doCalculationButton.Name = "doCalculationButton";
            this.doCalculationButton.Size = new System.Drawing.Size(196, 55);
            this.doCalculationButton.TabIndex = 5;
            this.doCalculationButton.Text = "Do Calculation";
            this.doCalculationButton.UseVisualStyleBackColor = false;
            this.doCalculationButton.Click += new System.EventHandler(this.doCalculationButton_Click);
            // 
            // backMainFramepictureBox1
            // 
            this.backMainFramepictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("backMainFramepictureBox1.Image")));
            this.backMainFramepictureBox1.Location = new System.Drawing.Point(30, 538);
            this.backMainFramepictureBox1.Name = "backMainFramepictureBox1";
            this.backMainFramepictureBox1.Size = new System.Drawing.Size(125, 62);
            this.backMainFramepictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.backMainFramepictureBox1.TabIndex = 4;
            this.backMainFramepictureBox1.TabStop = false;
            this.backMainFramepictureBox1.Click += new System.EventHandler(this.backMainFramepictureBox1_Click);
            // 
            // DatacomboBox1
            // 
            this.DatacomboBox1.BackColor = System.Drawing.Color.Silver;
            this.DatacomboBox1.FormattingEnabled = true;
            this.DatacomboBox1.Location = new System.Drawing.Point(265, 132);
            this.DatacomboBox1.Name = "DatacomboBox1";
            this.DatacomboBox1.Size = new System.Drawing.Size(770, 28);
            this.DatacomboBox1.TabIndex = 3;
            this.DatacomboBox1.SelectionChangeCommitted += new System.EventHandler(this.DatacomboBox1_SelectionChangeCommitted);
            // 
            // getRecommenationButton
            // 
            this.getRecommenationButton.Location = new System.Drawing.Point(915, 538);
            this.getRecommenationButton.Name = "getRecommenationButton";
            this.getRecommenationButton.Size = new System.Drawing.Size(206, 48);
            this.getRecommenationButton.TabIndex = 2;
            this.getRecommenationButton.Text = "Get Recommendation";
            this.getRecommenationButton.UseVisualStyleBackColor = true;
            // 
            // ViewProcessDataButton
            // 
            this.ViewProcessDataButton.BackColor = System.Drawing.Color.Transparent;
            this.ViewProcessDataButton.Location = new System.Drawing.Point(915, 444);
            this.ViewProcessDataButton.Name = "ViewProcessDataButton";
            this.ViewProcessDataButton.Size = new System.Drawing.Size(206, 48);
            this.ViewProcessDataButton.TabIndex = 1;
            this.ViewProcessDataButton.Text = "View Procces";
            this.ViewProcessDataButton.UseVisualStyleBackColor = false;
            this.ViewProcessDataButton.Click += new System.EventHandler(this.ViewProcessDataButton_Click);
            // 
            // dataTextBox1
            // 
            this.dataTextBox1.BackColor = System.Drawing.Color.Silver;
            this.dataTextBox1.Location = new System.Drawing.Point(265, 53);
            this.dataTextBox1.Multiline = true;
            this.dataTextBox1.Name = "dataTextBox1";
            this.dataTextBox1.Size = new System.Drawing.Size(770, 47);
            this.dataTextBox1.TabIndex = 0;
            this.dataTextBox1.Text = "0";
            this.dataTextBox1.TextChanged += new System.EventHandler(this.dataTextBox1_TextChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // MainFrame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1192, 651);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "MainFrame";
            this.Text = "MainFrame";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.backMainFramepictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Button getRecommenationButton;
        private Button ViewProcessDataButton;
        private ContextMenuStrip contextMenuStrip1;
        private ComboBox DatacomboBox1;
        private PictureBox backMainFramepictureBox1;
        private Button doCalculationButton;
        private PictureBox pictureBox1;
        public TextBox dataTextBox1;
    }
}
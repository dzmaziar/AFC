namespace AFC
{
    partial class StartPage
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
            this.backGround = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.button2 = new System.Windows.Forms.Button();
            this.buttonDataBase = new System.Windows.Forms.Button();
            this.buttonCalculator = new System.Windows.Forms.Button();
            this.buttonMainFrame = new System.Windows.Forms.Button();
            this.backGround.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // backGround
            // 
            this.backGround.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.backGround.BackColor = System.Drawing.Color.RosyBrown;
            this.backGround.Controls.Add(this.tableLayoutPanel1);
            this.backGround.Location = new System.Drawing.Point(-3, -1);
            this.backGround.Name = "backGround";
            this.backGround.Size = new System.Drawing.Size(979, 712);
            this.backGround.TabIndex = 0;
            this.backGround.Paint += new System.Windows.Forms.PaintEventHandler(this.backGround_Paint);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.button2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonDataBase, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonCalculator, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonMainFrame, 2, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(211, 211);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(542, 208);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(138, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(129, 202);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // buttonDataBase
            // 
            this.buttonDataBase.Location = new System.Drawing.Point(3, 3);
            this.buttonDataBase.Name = "buttonDataBase";
            this.buttonDataBase.Size = new System.Drawing.Size(129, 202);
            this.buttonDataBase.TabIndex = 0;
            this.buttonDataBase.Text = "View All Items";
            this.buttonDataBase.UseVisualStyleBackColor = true;
            this.buttonDataBase.Click += new System.EventHandler(this.buttonDataBase_Click);
            // 
            // buttonCalculator
            // 
            this.buttonCalculator.Location = new System.Drawing.Point(408, 3);
            this.buttonCalculator.Name = "buttonCalculator";
            this.buttonCalculator.Size = new System.Drawing.Size(131, 202);
            this.buttonCalculator.TabIndex = 3;
            this.buttonCalculator.Text = "Calculator";
            this.buttonCalculator.UseVisualStyleBackColor = true;
            this.buttonCalculator.Click += new System.EventHandler(this.buttonCalculator_Click);
            // 
            // buttonMainFrame
            // 
            this.buttonMainFrame.Location = new System.Drawing.Point(273, 3);
            this.buttonMainFrame.Name = "buttonMainFrame";
            this.buttonMainFrame.Size = new System.Drawing.Size(129, 202);
            this.buttonMainFrame.TabIndex = 2;
            this.buttonMainFrame.Text = "MainFrame";
            this.buttonMainFrame.UseVisualStyleBackColor = true;
            this.buttonMainFrame.Click += new System.EventHandler(this.buttonMainFrame_Click);
            // 
            // StartPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(973, 709);
            this.Controls.Add(this.backGround);
            this.Name = "StartPage";
            this.Text = "StartPage";
            this.backGround.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }


        #endregion

        private Panel backGround;
        private TableLayoutPanel tableLayoutPanel1;
        private Button button2;
        private Button buttonDataBase;
        private Button buttonCalculator;
        private Button buttonMainFrame;
    }
}
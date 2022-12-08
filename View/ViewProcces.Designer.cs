namespace AFC
{
    partial class ViewProcces
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
            this.ViewProccessPanel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Float = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ViewProccessPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // ViewProccessPanel1
            // 
            this.ViewProccessPanel1.BackColor = System.Drawing.Color.RosyBrown;
            this.ViewProccessPanel1.Controls.Add(this.dataGridView1);
            this.ViewProccessPanel1.Location = new System.Drawing.Point(-2, -3);
            this.ViewProccessPanel1.Name = "ViewProccessPanel1";
            this.ViewProccessPanel1.Size = new System.Drawing.Size(1230, 736);
            this.ViewProccessPanel1.TabIndex = 0;
            this.ViewProccessPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.ViewProccessPanel1_Paint);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Name,
            this.Float});
            this.dataGridView1.Location = new System.Drawing.Point(236, 68);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(303, 536);
            this.dataGridView1.TabIndex = 0;       // 
            // Name
            // 
            this.Name.HeaderText = "Name";
            this.Name.MinimumWidth = 6;
            this.Name.Name = "Name";
            this.Name.Width = 125;
            // 
            // Float
            // 
            this.Float.HeaderText = "Float";
            this.Float.MinimumWidth = 6;
            this.Float.Name = "Float";
            this.Float.Width = 125;
            // 
            // ViewProcces
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 725);
            this.Controls.Add(this.ViewProccessPanel1);
            this.Text = "ViewProcces";
            this.ViewProccessPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel ViewProccessPanel1;
        internal DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Name;
        private DataGridViewTextBoxColumn Float;
    }
}
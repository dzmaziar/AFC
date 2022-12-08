namespace AFC
{
    partial class ViewDataBase
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewDataBase));
            this.panel1 = new System.Windows.Forms.Panel();
            this.annotationTextBox = new System.Windows.Forms.TextBox();
            this.searchInDBTextBox = new System.Windows.Forms.TextBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.collection = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quality = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.minimum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maximum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.seed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBackDataBase = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBackDataBase)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.RosyBrown;
            this.panel1.Controls.Add(this.annotationTextBox);
            this.panel1.Controls.Add(this.searchInDBTextBox);
            this.panel1.Controls.Add(this.dataGridView);
            this.panel1.Controls.Add(this.pictureBackDataBase);
            this.panel1.Location = new System.Drawing.Point(-3, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(954, 768);
            this.panel1.TabIndex = 0;
            // 
            // annotationTextBox
            // 
            this.annotationTextBox.BackColor = System.Drawing.Color.RosyBrown;
            this.annotationTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.annotationTextBox.Location = new System.Drawing.Point(205, 15);
            this.annotationTextBox.Name = "annotationTextBox";
            this.annotationTextBox.ReadOnly = true;
            this.annotationTextBox.Size = new System.Drawing.Size(125, 20);
            this.annotationTextBox.TabIndex = 3;
            this.annotationTextBox.Text = "Search by Name:";
            // 
            // searchInDBTextBox
            // 
            this.searchInDBTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.searchInDBTextBox.BackColor = System.Drawing.SystemColors.MenuBar;
            this.searchInDBTextBox.Location = new System.Drawing.Point(205, 48);
            this.searchInDBTextBox.Name = "searchInDBTextBox";
            this.searchInDBTextBox.Size = new System.Drawing.Size(556, 27);
            this.searchInDBTextBox.TabIndex = 2;
            this.searchInDBTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.searchInDBTextBox.TextChanged += new System.EventHandler(this.searchInDBTextBox_TextChanged);
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name,
            this.collection,
            this.quality,
            this.minimum,
            this.maximum,
            this.seed});
            this.dataGridView.Location = new System.Drawing.Point(80, 117);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 29;
            this.dataGridView.Size = new System.Drawing.Size(799, 651);
            this.dataGridView.TabIndex = 1;
            // 
            // name
            // 
            this.name.HeaderText = "name";
            this.name.MinimumWidth = 6;
            this.name.Name = "name";
            this.name.Width = 125;
            // 
            // collection
            // 
            this.collection.HeaderText = "collection";
            this.collection.MinimumWidth = 6;
            this.collection.Name = "collection";
            this.collection.Width = 125;
            // 
            // quality
            // 
            this.quality.HeaderText = "quality";
            this.quality.MinimumWidth = 6;
            this.quality.Name = "quality";
            this.quality.Width = 125;
            // 
            // minimum
            // 
            this.minimum.HeaderText = "minimum";
            this.minimum.MinimumWidth = 6;
            this.minimum.Name = "minimum";
            this.minimum.Width = 125;
            // 
            // maximum
            // 
            this.maximum.HeaderText = "maximum";
            this.maximum.MinimumWidth = 6;
            this.maximum.Name = "maximum";
            this.maximum.Width = 125;
            // 
            // seed
            // 
            this.seed.HeaderText = "seed";
            this.seed.MinimumWidth = 6;
            this.seed.Name = "seed";
            this.seed.Width = 125;
            // 
            // pictureBackDataBase
            // 
            this.pictureBackDataBase.BackColor = System.Drawing.Color.RosyBrown;
            this.pictureBackDataBase.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBackDataBase.Image = ((System.Drawing.Image)(resources.GetObject("pictureBackDataBase.Image")));
            this.pictureBackDataBase.Location = new System.Drawing.Point(3, 13);
            this.pictureBackDataBase.Name = "pictureBackDataBase";
            this.pictureBackDataBase.Size = new System.Drawing.Size(125, 62);
            this.pictureBackDataBase.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBackDataBase.TabIndex = 0;
            this.pictureBackDataBase.TabStop = false;
            this.pictureBackDataBase.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // ViewDataBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 764);
            this.Controls.Add(this.panel1);
            this.Name = "ViewDataBase";
            this.Text = "ViewDataBase";
            this.Load += new System.EventHandler(this.ViewDataBase_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBackDataBase)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBackDataBase;
        private DataGridView dataGridView;
        private DataGridViewTextBoxColumn name;
        private DataGridViewTextBoxColumn collection;
        private DataGridViewTextBoxColumn quality;
        private DataGridViewTextBoxColumn minimum;
        private DataGridViewTextBoxColumn maximum;
        private DataGridViewTextBoxColumn seed;
        private TextBox searchInDBTextBox;
        private TextBox annotationTextBox;
    }
}
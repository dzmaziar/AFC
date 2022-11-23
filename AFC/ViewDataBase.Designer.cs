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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pictureBackDataBase = new System.Windows.Forms.PictureBox();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.collection = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quality = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.minimum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maximum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.seed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBackDataBase)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.RosyBrown;
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.pictureBackDataBase);
            this.panel1.Location = new System.Drawing.Point(-3, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(954, 768);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.name,
            this.collection,
            this.quality,
            this.minimum,
            this.maximum,
            this.seed});
            this.dataGridView1.Location = new System.Drawing.Point(15, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(925, 661);
            this.dataGridView1.TabIndex = 1;
            // 
            // pictureBackDataBase
            // 
            this.pictureBackDataBase.BackColor = System.Drawing.Color.RosyBrown;
            this.pictureBackDataBase.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBackDataBase.Image = ((System.Drawing.Image)(resources.GetObject("pictureBackDataBase.Image")));
            this.pictureBackDataBase.Location = new System.Drawing.Point(15, 691);
            this.pictureBackDataBase.Name = "pictureBackDataBase";
            this.pictureBackDataBase.Size = new System.Drawing.Size(125, 62);
            this.pictureBackDataBase.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBackDataBase.TabIndex = 0;
            this.pictureBackDataBase.TabStop = false;
            this.pictureBackDataBase.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.Width = 125;
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
            // ViewDataBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 764);
            this.Controls.Add(this.panel1);
            this.Name = "ViewDataBase";
            this.Text = "ViewDataBase";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBackDataBase)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBackDataBase;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn name;
        private DataGridViewTextBoxColumn collection;
        private DataGridViewTextBoxColumn quality;
        private DataGridViewTextBoxColumn minimum;
        private DataGridViewTextBoxColumn maximum;
        private DataGridViewTextBoxColumn seed;
    }
}
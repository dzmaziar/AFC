namespace AFC
{
    partial class DoCalculationFrame
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
            this.combinationDataGridView = new System.Windows.Forms.DataGridView();
            this.Combination = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.combinationDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // combinationDataGridView
            // 
            this.combinationDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.combinationDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Combination});
            this.combinationDataGridView.Location = new System.Drawing.Point(234, 91);
            this.combinationDataGridView.Name = "combinationDataGridView";
            this.combinationDataGridView.RowHeadersWidth = 51;
            this.combinationDataGridView.RowTemplate.Height = 29;
            this.combinationDataGridView.Size = new System.Drawing.Size(407, 591);
            this.combinationDataGridView.TabIndex = 0;
            // Combination
            // 
            this.Combination.HeaderText = "Combination";
            this.Combination.MinimumWidth = 6;
            this.Combination.Name = "Combination";
            this.Combination.Width = 125;
            // 
            // DoCalculation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(1113, 763);
            this.Controls.Add(this.combinationDataGridView);
            this.MaximizeBox = false;
            this.Name = "DoCalculation";
            this.Text = "DoCalculation";
            //this.Load += new System.EventHandler(this.DoCalculation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.combinationDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public DataGridView combinationDataGridView;
        private DataGridViewTextBoxColumn Combination;
    }
}
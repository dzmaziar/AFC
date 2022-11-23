namespace AFC
{
    partial class AddToDB
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.seedField = new System.Windows.Forms.TextBox();
            this.maxField = new System.Windows.Forms.TextBox();
            this.minField = new System.Windows.Forms.TextBox();
            this.qualityField = new System.Windows.Forms.TextBox();
            this.collectionField = new System.Windows.Forms.TextBox();
            this.nameField = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.RosyBrown;
            this.panel1.Controls.Add(this.buttonAdd);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.seedField);
            this.panel1.Controls.Add(this.maxField);
            this.panel1.Controls.Add(this.minField);
            this.panel1.Controls.Add(this.qualityField);
            this.panel1.Controls.Add(this.collectionField);
            this.panel1.Controls.Add(this.nameField);
            this.panel1.Location = new System.Drawing.Point(-1, -4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(971, 794);
            this.panel1.TabIndex = 0;
           
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(373, 504);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(198, 29);
            this.buttonAdd.TabIndex = 12;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click_1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(143, 435);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "редкий сид";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(150, 381);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "максимум";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(150, 332);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "минимум";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(150, 285);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Редкость";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(150, 240);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Коллекция";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(150, 198);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Название";
            // 
            // seedField
            // 
            this.seedField.Location = new System.Drawing.Point(233, 432);
            this.seedField.Name = "seedField";
            this.seedField.Size = new System.Drawing.Size(482, 27);
            this.seedField.TabIndex = 5;
            // 
            // maxField
            // 
            this.maxField.Location = new System.Drawing.Point(233, 381);
            this.maxField.Name = "maxField";
            this.maxField.Size = new System.Drawing.Size(482, 27);
            this.maxField.TabIndex = 4;
            // 
            // minField
            // 
            this.minField.Location = new System.Drawing.Point(233, 332);
            this.minField.Name = "minField";
            this.minField.Size = new System.Drawing.Size(482, 27);
            this.minField.TabIndex = 3;
            // 
            // qualityField
            // 
            this.qualityField.Location = new System.Drawing.Point(233, 285);
            this.qualityField.Name = "qualityField";
            this.qualityField.Size = new System.Drawing.Size(482, 27);
            this.qualityField.TabIndex = 2;
            // 
            // collectionField
            // 
            this.collectionField.Location = new System.Drawing.Point(233, 237);
            this.collectionField.Name = "collectionField";
            this.collectionField.Size = new System.Drawing.Size(482, 27);
            this.collectionField.TabIndex = 1;
            // 
            // nameField
            // 
            this.nameField.Location = new System.Drawing.Point(233, 195);
            this.nameField.Name = "nameField";
            this.nameField.Size = new System.Drawing.Size(482, 27);
            this.nameField.TabIndex = 0;
            // 
            // AddToDB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 786);
            this.Controls.Add(this.panel1);
            this.Name = "AddToDB";
            this.Text = "AddToDB";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private TextBox seedField;
        private TextBox maxField;
        private TextBox minField;
        private TextBox qualityField;
        private TextBox collectionField;
        private TextBox nameField;
        private Button buttonAdd;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}
namespace WinFormsApp1
{
    partial class ViewInventory
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
            dataGridView1 = new DataGridView();
            pictureBox1 = new PictureBox();
            nameText = new Label();
            descriptionText = new Label();
            totalText = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 47;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(161, 426);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(419, 38);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(150, 150);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // nameText
            // 
            nameText.AutoSize = true;
            nameText.Location = new Point(468, 206);
            nameText.Name = "nameText";
            nameText.Size = new Size(45, 19);
            nameText.TabIndex = 2;
            nameText.Text = "label1";
            // 
            // descriptionText
            // 
            descriptionText.AutoSize = true;
            descriptionText.Location = new Point(468, 262);
            descriptionText.Name = "descriptionText";
            descriptionText.Size = new Size(45, 19);
            descriptionText.TabIndex = 3;
            descriptionText.Text = "label2";
            descriptionText.TextAlign = ContentAlignment.TopCenter;
            // 
            // totalText
            // 
            totalText.AutoSize = true;
            totalText.Location = new Point(468, 225);
            totalText.Name = "totalText";
            totalText.Size = new Size(45, 19);
            totalText.TabIndex = 4;
            totalText.Text = "label2";
            // 
            // ViewInventory
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(totalText);
            Controls.Add(descriptionText);
            Controls.Add(nameText);
            Controls.Add(pictureBox1);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ViewInventory";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "M-One Inventory | View Inventory";
            Load += ViewInventory_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private PictureBox pictureBox1;
        private Label nameText;
        private Label descriptionText;
        private Label totalText;
    }
}
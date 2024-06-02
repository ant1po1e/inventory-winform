namespace WinFormsApp1
{
    partial class Inventory
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
            button1 = new Button();
            nameBox = new TextBox();
            descriptionBox = new TextBox();
            totalBox = new NumericUpDown();
            button2 = new Button();
            pictureBox1 = new PictureBox();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            idBox = new TextBox();
            searchBox = new TextBox();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)totalBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(39, 77);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 47;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(723, 193);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // button1
            // 
            button1.Location = new Point(400, 427);
            button1.Name = "button1";
            button1.Size = new Size(86, 26);
            button1.TabIndex = 1;
            button1.Text = "Insert";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // nameBox
            // 
            nameBox.Location = new Point(39, 288);
            nameBox.Name = "nameBox";
            nameBox.Size = new Size(149, 26);
            nameBox.TabIndex = 2;
            // 
            // descriptionBox
            // 
            descriptionBox.Location = new Point(194, 288);
            descriptionBox.Multiline = true;
            descriptionBox.Name = "descriptionBox";
            descriptionBox.Size = new Size(200, 165);
            descriptionBox.TabIndex = 3;
            // 
            // totalBox
            // 
            totalBox.Location = new Point(400, 289);
            totalBox.Name = "totalBox";
            totalBox.Size = new Size(164, 26);
            totalBox.TabIndex = 5;
            // 
            // button2
            // 
            button2.Location = new Point(570, 289);
            button2.Name = "button2";
            button2.Size = new Size(66, 26);
            button2.TabIndex = 6;
            button2.Text = "Upload";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.Location = new Point(2, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(118, 118);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // button3
            // 
            button3.Location = new Point(492, 427);
            button3.Name = "button3";
            button3.Size = new Size(86, 26);
            button3.TabIndex = 8;
            button3.Text = "Update";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(584, 427);
            button4.Name = "button4";
            button4.Size = new Size(86, 26);
            button4.TabIndex = 9;
            button4.Text = "Delete";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(676, 427);
            button5.Name = "button5";
            button5.Size = new Size(86, 26);
            button5.TabIndex = 10;
            button5.Text = "Clear";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // idBox
            // 
            idBox.Location = new Point(39, 320);
            idBox.Name = "idBox";
            idBox.ReadOnly = true;
            idBox.Size = new Size(39, 26);
            idBox.TabIndex = 11;
            // 
            // searchBox
            // 
            searchBox.Location = new Point(642, 45);
            searchBox.Name = "searchBox";
            searchBox.Size = new Size(115, 26);
            searchBox.TabIndex = 12;
            searchBox.TextChanged += textBox1_TextChanged;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(642, 289);
            panel1.Name = "panel1";
            panel1.Size = new Size(122, 122);
            panel1.TabIndex = 13;
            // 
            // Inventory
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 471);
            Controls.Add(searchBox);
            Controls.Add(idBox);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(totalBox);
            Controls.Add(descriptionBox);
            Controls.Add(nameBox);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Inventory";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "M-One Inventory | Edit Inventory";
            Load += Inventory_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)totalBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button button1;
        private TextBox nameBox;
        private TextBox descriptionBox;
        private NumericUpDown totalBox;
        private Button button2;
        private PictureBox pictureBox1;
        private Button button3;
        private Button button4;
        private Button button5;
        private TextBox idBox;
        private TextBox searchBox;
        private Panel panel1;
    }
}
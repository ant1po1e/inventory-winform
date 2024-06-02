namespace WinFormsApp1
{
    partial class Dashboard
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
            components = new System.ComponentModel.Container();
            usernameLabel = new Label();
            goToInventory = new Button();
            button1 = new Button();
            panel1 = new Panel();
            dateNowText = new Label();
            timeNowText = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            button2 = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.Font = new Font("Segoe UI", 11.7818184F, FontStyle.Regular, GraphicsUnit.Point, 0);
            usernameLabel.ForeColor = Color.Black;
            usernameLabel.Location = new Point(87, 12);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new Size(59, 25);
            usernameLabel.TabIndex = 0;
            usernameLabel.Text = "label1";
            // 
            // goToInventory
            // 
            goToInventory.BackColor = Color.White;
            goToInventory.Location = new Point(104, 156);
            goToInventory.Name = "goToInventory";
            goToInventory.Size = new Size(207, 177);
            goToInventory.TabIndex = 1;
            goToInventory.Text = "Edit Inventory";
            goToInventory.UseVisualStyleBackColor = false;
            goToInventory.Click += goToInventory_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.LightGray;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(12, 12);
            button1.Name = "button1";
            button1.Size = new Size(69, 28);
            button1.TabIndex = 2;
            button1.Text = "Logout";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(dateNowText);
            panel1.Controls.Add(timeNowText);
            panel1.Controls.Add(usernameLabel);
            panel1.Controls.Add(button1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 91);
            panel1.TabIndex = 3;
            // 
            // dateNowText
            // 
            dateNowText.Font = new Font("Segoe UI", 11.7818184F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateNowText.ForeColor = Color.Black;
            dateNowText.Location = new Point(490, 48);
            dateNowText.Name = "dateNowText";
            dateNowText.Size = new Size(287, 25);
            dateNowText.TabIndex = 4;
            dateNowText.Text = "label1";
            dateNowText.TextAlign = ContentAlignment.MiddleRight;
            // 
            // timeNowText
            // 
            timeNowText.Font = new Font("Segoe UI", 11.7818184F, FontStyle.Regular, GraphicsUnit.Point, 0);
            timeNowText.ForeColor = Color.Black;
            timeNowText.Location = new Point(605, 12);
            timeNowText.Name = "timeNowText";
            timeNowText.Size = new Size(172, 25);
            timeNowText.TabIndex = 3;
            timeNowText.Text = "label1";
            timeNowText.TextAlign = ContentAlignment.MiddleRight;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Tick += timer1_Tick;
            // 
            // button2
            // 
            button2.BackColor = Color.White;
            button2.Location = new Point(477, 156);
            button2.Name = "button2";
            button2.Size = new Size(207, 177);
            button2.TabIndex = 4;
            button2.Text = "View Inventory";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(panel1);
            Controls.Add(goToInventory);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Dashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dashboard";
            Load += Dashboard_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label usernameLabel;
        private Button goToInventory;
        private Button button1;
        private Panel panel1;
        private Label timeNowText;
        private System.Windows.Forms.Timer timer1;
        private Label dateNowText;
        private Button button2;
    }
}
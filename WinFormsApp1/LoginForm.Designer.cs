namespace WinFormsApp1
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            usernameBox = new TextBox();
            Username = new Label();
            label2 = new Label();
            checkBox1 = new CheckBox();
            label3 = new Label();
            passwordBox = new TextBox();
            label1 = new Label();
            label5 = new Label();
            label4 = new Label();
            customButton1 = new Controls.CustomButton();
            SuspendLayout();
            // 
            // usernameBox
            // 
            usernameBox.BackColor = Color.LightGray;
            usernameBox.BorderStyle = BorderStyle.FixedSingle;
            usernameBox.Font = new Font("Nirmala UI", 11.7818184F, FontStyle.Regular, GraphicsUnit.Point, 0);
            usernameBox.ForeColor = Color.DimGray;
            usernameBox.Location = new Point(47, 223);
            usernameBox.Name = "usernameBox";
            usernameBox.PlaceholderText = "Username";
            usernameBox.Size = new Size(199, 31);
            usernameBox.TabIndex = 1;
            // 
            // Username
            // 
            Username.AutoSize = true;
            Username.Font = new Font("Nirmala UI", 9.818182F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Username.ForeColor = Color.DarkGray;
            Username.Location = new Point(47, 200);
            Username.Name = "Username";
            Username.Size = new Size(86, 20);
            Username.TabIndex = 1;
            Username.Text = "USERNAME";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Nirmala UI", 9.818182F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.DarkGray;
            label2.Location = new Point(47, 257);
            label2.Name = "label2";
            label2.Size = new Size(87, 20);
            label2.TabIndex = 2;
            label2.Text = "PASSWORD";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Nirmala UI", 7.85454559F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkBox1.Location = new Point(138, 317);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(108, 19);
            checkBox1.TabIndex = 3;
            checkBox1.Text = "Show Password";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Cursor = Cursors.Hand;
            label3.Font = new Font("Nirmala UI", 7.85454559F, FontStyle.Bold);
            label3.ForeColor = Color.DodgerBlue;
            label3.Location = new Point(185, 406);
            label3.Name = "label3";
            label3.Size = new Size(54, 15);
            label3.TabIndex = 14;
            label3.Text = "Register";
            label3.Click += label3_Click;
            // 
            // passwordBox
            // 
            passwordBox.BackColor = Color.LightGray;
            passwordBox.BorderStyle = BorderStyle.FixedSingle;
            passwordBox.Font = new Font("Nirmala UI", 11.7818184F, FontStyle.Regular, GraphicsUnit.Point, 0);
            passwordBox.ForeColor = Color.DimGray;
            passwordBox.Location = new Point(47, 280);
            passwordBox.Name = "passwordBox";
            passwordBox.PasswordChar = '*';
            passwordBox.PlaceholderText = "password";
            passwordBox.Size = new Size(199, 31);
            passwordBox.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Nirmala UI", 7.85454559F, FontStyle.Bold);
            label1.ForeColor = Color.DarkGray;
            label1.Location = new Point(49, 406);
            label1.Name = "label1";
            label1.Size = new Size(133, 15);
            label1.TabIndex = 15;
            label1.Text = "Dont have an account?";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Nirmala UI", 24.2181816F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(87, 107);
            label5.Name = "label5";
            label5.Size = new Size(120, 50);
            label5.TabIndex = 17;
            label5.Text = "Login";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Nirmala UI", 9.818182F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.DarkGray;
            label4.Location = new Point(84, 157);
            label4.Name = "label4";
            label4.Size = new Size(127, 20);
            label4.TabIndex = 16;
            label4.Text = "Login to Continue";
            // 
            // customButton1
            // 
            customButton1.BackColor = Color.Black;
            customButton1.BackgroundColor = Color.Black;
            customButton1.BorderColor = Color.Transparent;
            customButton1.BorderRadius = 15;
            customButton1.BorderSize = 0;
            customButton1.FlatAppearance.BorderSize = 0;
            customButton1.FlatStyle = FlatStyle.Flat;
            customButton1.Font = new Font("Nirmala UI", 9.818182F, FontStyle.Bold, GraphicsUnit.Point, 0);
            customButton1.ForeColor = Color.White;
            customButton1.Location = new Point(39, 342);
            customButton1.Name = "customButton1";
            customButton1.Size = new Size(207, 40);
            customButton1.TabIndex = 18;
            customButton1.Text = "Login";
            customButton1.TextColor = Color.White;
            customButton1.UseVisualStyleBackColor = false;
            customButton1.Click += customButton1_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(292, 474);
            Controls.Add(customButton1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(label3);
            Controls.Add(checkBox1);
            Controls.Add(label2);
            Controls.Add(Username);
            Controls.Add(usernameBox);
            Controls.Add(passwordBox);
            Font = new Font("Nirmala UI", 9.818182F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.Black;
            FormBorderStyle = FormBorderStyle.None;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "M-One Inventory | Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox usernameBox;
        private Label Username;
        private Label label2;
        private CheckBox checkBox1;
        private Label label3;
        private TextBox passwordBox;
        private Label label1;
        private Label label5;
        private Label label4;
        private Controls.CustomButton customButton1;
    }
}

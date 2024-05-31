namespace WinFormsApp1
{
    partial class RegisterForm
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
            label5 = new Label();
            label1 = new Label();
            label3 = new Label();
            checkBox1 = new CheckBox();
            button1 = new Button();
            label2 = new Label();
            Username = new Label();
            usernameBox = new TextBox();
            passwordBox = new TextBox();
            label6 = new Label();
            emailBox = new TextBox();
            label4 = new Label();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Nirmala UI", 24.2181816F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(66, 49);
            label5.Name = "label5";
            label5.Size = new Size(164, 50);
            label5.TabIndex = 27;
            label5.Text = "Register";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Nirmala UI", 7.85454559F, FontStyle.Bold);
            label1.ForeColor = Color.DarkGray;
            label1.Location = new Point(53, 406);
            label1.Name = "label1";
            label1.Size = new Size(147, 15);
            label1.TabIndex = 25;
            label1.Text = "Already have an account?";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Cursor = Cursors.Hand;
            label3.Font = new Font("Nirmala UI", 7.85454559F, FontStyle.Bold);
            label3.ForeColor = Color.DodgerBlue;
            label3.Location = new Point(203, 406);
            label3.Name = "label3";
            label3.Size = new Size(37, 15);
            label3.TabIndex = 24;
            label3.Text = "Login";
            label3.Click += label3_Click_1;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Nirmala UI", 7.85454559F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkBox1.Location = new Point(138, 317);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(108, 19);
            checkBox1.TabIndex = 4;
            checkBox1.Text = "Show Password";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged_1;
            // 
            // button1
            // 
            button1.BackColor = Color.Black;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Nirmala UI", 9.818182F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(47, 342);
            button1.Name = "button1";
            button1.Size = new Size(199, 39);
            button1.TabIndex = 5;
            button1.Text = "Register";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Nirmala UI", 9.818182F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.DarkGray;
            label2.Location = new Point(47, 257);
            label2.Name = "label2";
            label2.Size = new Size(87, 20);
            label2.TabIndex = 21;
            label2.Text = "PASSWORD";
            // 
            // Username
            // 
            Username.AutoSize = true;
            Username.Font = new Font("Nirmala UI", 9.818182F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Username.ForeColor = Color.DarkGray;
            Username.Location = new Point(47, 143);
            Username.Name = "Username";
            Username.Size = new Size(86, 20);
            Username.TabIndex = 20;
            Username.Text = "USERNAME";
            // 
            // usernameBox
            // 
            usernameBox.BackColor = Color.LightGray;
            usernameBox.BorderStyle = BorderStyle.FixedSingle;
            usernameBox.Font = new Font("Nirmala UI", 11.7818184F, FontStyle.Regular, GraphicsUnit.Point, 0);
            usernameBox.ForeColor = Color.DimGray;
            usernameBox.Location = new Point(47, 166);
            usernameBox.Name = "usernameBox";
            usernameBox.PlaceholderText = "Username";
            usernameBox.Size = new Size(199, 31);
            usernameBox.TabIndex = 1;
            usernameBox.TextChanged += usernameBox_TextChanged;
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
            passwordBox.TabIndex = 3;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Nirmala UI", 9.818182F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.DarkGray;
            label6.Location = new Point(47, 200);
            label6.Name = "label6";
            label6.Size = new Size(51, 20);
            label6.TabIndex = 29;
            label6.Text = "EMAIL";
            // 
            // emailBox
            // 
            emailBox.BackColor = Color.LightGray;
            emailBox.BorderStyle = BorderStyle.FixedSingle;
            emailBox.Font = new Font("Nirmala UI", 11.7818184F, FontStyle.Regular, GraphicsUnit.Point, 0);
            emailBox.ForeColor = Color.DimGray;
            emailBox.Location = new Point(47, 223);
            emailBox.Name = "emailBox";
            emailBox.PlaceholderText = "email@gmail.com";
            emailBox.Size = new Size(199, 31);
            emailBox.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Nirmala UI", 9.818182F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.DarkGray;
            label4.Location = new Point(82, 99);
            label4.Name = "label4";
            label4.Size = new Size(130, 20);
            label4.TabIndex = 30;
            label4.Text = "Create an Account";
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(292, 474);
            Controls.Add(label4);
            Controls.Add(label6);
            Controls.Add(emailBox);
            Controls.Add(label5);
            Controls.Add(label1);
            Controls.Add(label3);
            Controls.Add(checkBox1);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(Username);
            Controls.Add(usernameBox);
            Controls.Add(passwordBox);
            Font = new Font("Nirmala UI", 9.818182F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "RegisterForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RegisterForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label5;
        private Label label1;
        private Label label3;
        private CheckBox checkBox1;
        private Button button1;
        private Label label2;
        private Label Username;
        private TextBox usernameBox;
        private TextBox passwordBox;
        private Label label6;
        private TextBox emailBox;
        private Label label4;
    }
}
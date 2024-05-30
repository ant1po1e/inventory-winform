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
            button1 = new Button();
            checkBox1 = new CheckBox();
            label3 = new Label();
            passwordBox = new TextBox();
            label1 = new Label();
            label4 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // usernameBox
            // 
            usernameBox.BackColor = Color.LightGray;
            usernameBox.BorderStyle = BorderStyle.None;
            usernameBox.Font = new Font("Nirmala UI", 11.7818184F, FontStyle.Regular, GraphicsUnit.Point, 0);
            usernameBox.ForeColor = Color.DimGray;
            usernameBox.Location = new Point(47, 230);
            usernameBox.Name = "usernameBox";
            usernameBox.PlaceholderText = "Username";
            usernameBox.Size = new Size(199, 24);
            usernameBox.TabIndex = 1;
            // 
            // Username
            // 
            Username.AutoSize = true;
            Username.Font = new Font("Nirmala UI", 9.818182F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Username.ForeColor = Color.DarkGray;
            Username.Location = new Point(47, 207);
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
            label2.Location = new Point(47, 264);
            label2.Name = "label2";
            label2.Size = new Size(87, 20);
            label2.TabIndex = 2;
            label2.Text = "PASSWORD";
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
            button1.TabIndex = 4;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
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
            passwordBox.BorderStyle = BorderStyle.None;
            passwordBox.Font = new Font("Nirmala UI", 11.7818184F, FontStyle.Regular, GraphicsUnit.Point, 0);
            passwordBox.ForeColor = Color.DimGray;
            passwordBox.Location = new Point(47, 287);
            passwordBox.Name = "passwordBox";
            passwordBox.PasswordChar = '*';
            passwordBox.PlaceholderText = "password";
            passwordBox.Size = new Size(199, 24);
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
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Nirmala UI", 9.818182F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.DarkGray;
            label4.Location = new Point(81, 161);
            label4.Name = "label4";
            label4.Size = new Size(128, 20);
            label4.TabIndex = 16;
            label4.Text = "Login To Continue";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Nirmala UI", 24.2181816F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(87, 111);
            label5.Name = "label5";
            label5.Size = new Size(120, 50);
            label5.TabIndex = 17;
            label5.Text = "Login";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(292, 474);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(label3);
            Controls.Add(checkBox1);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(Username);
            Controls.Add(usernameBox);
            Controls.Add(passwordBox);
            Font = new Font("Nirmala UI", 9.818182F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.Black;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += LoginForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox usernameBox;
        private Label Username;
        private Label label2;
        private Button button1;
        private CheckBox checkBox1;
        private Label label3;
        private TextBox passwordBox;
        private Label label1;
        private Label label4;
        private Label label5;
    }
}

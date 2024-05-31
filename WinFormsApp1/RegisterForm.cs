using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class RegisterForm : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-44VPTOK;Initial Catalog=""Final Project"";Integrated Security=True;TrustServerCertificate=True");
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (IsValidEmail(emailBox.Text) && IsValid())
            {
                if (conn.State != ConnectionState.Open)
                {
                    try
                    {
                        conn.Open();
                        using (SqlCommand getUser = new SqlCommand("SELECT * FROM users WHERE username = @username", conn))
                        {
                            getUser.Parameters.AddWithValue("@username", usernameBox.Text.Trim());

                            SqlDataAdapter sda = new SqlDataAdapter(getUser);
                            DataTable dt = new DataTable();

                            sda.Fill(dt);

                            if (dt.Rows.Count >= 1)
                            {
                                MessageBox.Show("Username already exist.", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                using (SqlCommand insertUser = new SqlCommand("INSERT INTO users (username, email, password) VALUES (@username, @email, @password)", conn))
                                {
                                    insertUser.Parameters.AddWithValue("@username", usernameBox.Text);
                                    insertUser.Parameters.AddWithValue("@email", emailBox.Text);
                                    insertUser.Parameters.AddWithValue("@password", passwordBox.Text);

                                    insertUser.ExecuteNonQuery();

                                    MessageBox.Show("User registered successfully.", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    LoginForm login = new LoginForm();
                                    login.Show();
                                    this.Hide();
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        conn.Close();
                    }
                }
            }
        }

        private bool IsValidEmail(string email)
        {
            try
            {
                MailAddress ma = new MailAddress(email);

                return true;
            }
            catch
            {
                MessageBox.Show("Please input valid email addres.", "Warning Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                passwordBox.PasswordChar = '\0';
            }
            else
            {
                passwordBox.PasswordChar = '*';
            }
        }

        private bool IsValid()
        {
            if (usernameBox.Text == "" || emailBox.Text == "" || passwordBox.Text == "")
            {
                MessageBox.Show("Please input the empty fields.", "Warning Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            RegisterForm register = new RegisterForm();
            register.Show();
            this.Hide();
        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                passwordBox.PasswordChar = '\0';
            }
            else
            {
                passwordBox.PasswordChar = '*';
            }
        }

        private void label3_Click_1(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            login.Show();
            this.Hide();
        }

        private void usernameBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

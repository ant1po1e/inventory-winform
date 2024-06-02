using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Dashboard : Form
    {
        private string loggedUsername;


        public Dashboard(string username)
        {
            InitializeComponent();
            usernameLabel.Text = username;
            loggedUsername = username;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            login.Show();
            this.Hide();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            timer1.Start();
            timeNowText.Text = DateTime.Now.ToLongTimeString();
            dateNowText.Text = DateTime.Now.ToLongDateString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timeNowText.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }

        private void goToInventory_Click(object sender, EventArgs e)
        {
            Inventory inventory = new Inventory(loggedUsername);
            inventory.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ViewInventory viewInventory = new ViewInventory();
            viewInventory.Show();
            this.Hide();
        }
    }
}

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
    }
}

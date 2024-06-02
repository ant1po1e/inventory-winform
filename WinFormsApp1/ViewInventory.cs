using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class ViewInventory : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-44VPTOK;Initial Catalog=""Final Project"";Integrated Security=True;TrustServerCertificate=True");
        string query = "SELECT name AS Name, description AS Description, image AS Image, total AS Total FROM inventory";

        private string loggedUsername;

        public ViewInventory()
        {
            InitializeComponent();
        }

        private void ViewInventory_Load(object sender, EventArgs e)
        {
            LoadDataGrid();
        }

        private void LoadDataGrid()
        {
            if (conn.State != ConnectionState.Open)
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query, conn);

                    SqlDataReader sdr = cmd.ExecuteReader();
                    DataTable dt = new DataTable();

                    dt.Load(sdr);
                    dataGridView1.DataSource = dt;

                    dataGridView1.Columns["Description"].Visible = false;
                    dataGridView1.Columns["Image"].Visible = false;
                    dataGridView1.Columns["Total"].Visible = false;
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                nameText.Text = row.Cells["Name"].Value.ToString();
                descriptionText.Text = row.Cells["Description"].Value.ToString();
                totalText.Text = row.Cells["Total"].Value.ToString();

                byte[] imageData = (byte[])row.Cells["Image"].Value;

                using (MemoryStream ms = new MemoryStream(imageData))
                {
                    pictureBox1.Image = Image.FromStream(ms);
                }
            }
        }
    }
}

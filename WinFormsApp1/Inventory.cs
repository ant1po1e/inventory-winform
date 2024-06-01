using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Inventory : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-44VPTOK;Initial Catalog=""Final Project"";Integrated Security=True;TrustServerCertificate=True");
        string query = "SELECT id as '#', name AS Name, description AS Description, image AS Image, total AS Total FROM inventory";

        private string loggedUsername;
        private int key;

        public Inventory(string loggedUsername)
        {
            InitializeComponent();
            this.loggedUsername = loggedUsername;
        }

        private void Inventory_Load(object sender, EventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
            InsertData();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var msg = MessageBox.Show("Are you sure?", "Question Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (msg == DialogResult.No)
            {
                MessageBox.Show("Operation canceled.", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                UpdateData();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var msg = MessageBox.Show("Are you sure?", "Question Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (msg == DialogResult.No)
            {
                MessageBox.Show("Operation canceled.", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                DeleteData();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private bool IsValid()
        {
            if (nameBox.Text == "" || descriptionBox.Text == "" || pictureBox1 == null || totalBox.Text == "")
            {
                MessageBox.Show("Please fill the empty fields.", "Warning Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            return true;
        }

        private void ClearFields()
        {
            nameBox.Text = "";
            descriptionBox.Text = "";
            pictureBox1.Image = null;
            totalBox.Value = 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (var ofd = new OpenFileDialog())
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    pictureBox1.Image = Image.FromFile(ofd.FileName);
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                nameBox.Text = row.Cells["Name"].Value.ToString();
                descriptionBox.Text = row.Cells["Description"].Value.ToString();

                byte[] imageData = (byte[])row.Cells["Image"].Value;

                using (MemoryStream ms = new MemoryStream(imageData))
                {
                    pictureBox1.Image = Image.FromStream(ms);
                }

                totalBox.Value = Convert.ToInt32(row.Cells["Total"].Value);
            }

            if (nameBox.Text == "")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                idBox.Text = key.ToString();
            }
        }

        private void InsertData()
        {
            Image img = pictureBox1.Image;
            byte[] arr;
            ImageConverter converter = new ImageConverter();
            arr = (byte[])converter.ConvertTo(img, typeof(byte[]));


            if (IsValid())
            {
                try
                {
                    conn.Open();

                    SqlCommand cmd = new SqlCommand("INSERT INTO inventory (name, description, image, total) VALUES (@name, @desc, @img, @total)", conn);
                    cmd.Parameters.AddWithValue("@name", nameBox.Text);
                    cmd.Parameters.AddWithValue("@desc", descriptionBox.Text);
                    cmd.Parameters.AddWithValue("@img", arr);
                    cmd.Parameters.AddWithValue("@total", totalBox.Text);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data successfully added.", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    conn.Close();
                    LoadDataGrid();
                    ClearFields();
                }
            }
        }

        private void UpdateData()
        {
            Image img = pictureBox1.Image;
            byte[] arr;
            ImageConverter converter = new ImageConverter();
            arr = (byte[])converter.ConvertTo(img, typeof(byte[]));

            if (IsValid())
            {
                try
                {
                    conn.Open();

                    SqlCommand cmd = new SqlCommand("UPDATE inventory SET name = @name, description = @desc, image = @img, total = @total WHERE id = @ID", conn);
                    cmd.Parameters.AddWithValue("@name", nameBox.Text);
                    cmd.Parameters.AddWithValue("@desc", descriptionBox.Text);
                    cmd.Parameters.AddWithValue("@img", arr);
                    cmd.Parameters.AddWithValue("@total", totalBox.Text);
                    cmd.Parameters.AddWithValue("@ID", key);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data successfully updated.", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    conn.Close();
                    LoadDataGrid();
                    ClearFields();
                }
            }
        }

        private void DeleteData()
        {
            if (IsValid())
            {
                try
                {
                    conn.Open();

                    SqlCommand cmd = new SqlCommand("DELETE FROM inventory WHERE id = @ID", conn);
                    cmd.Parameters.AddWithValue("@ID", key);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data successfully deleted.", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    conn.Close();
                    LoadDataGrid();
                    ClearFields();
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                conn.Open();

                string searchQuery = query + " WHERE name LIKE @searchText OR description LIKE @searchText OR total LIKE @searchText";
                SqlCommand cmd = new SqlCommand(searchQuery, conn);
                cmd.Parameters.AddWithValue("@searchText", '%' + searchBox.Text + '%');

                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();

                sda.Fill(dt);
                dataGridView1.DataSource = dt;
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

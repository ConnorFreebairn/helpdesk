using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace Help_Desk
{
    public partial class usermanagment : Form
    {
        public usermanagment()
        {
            InitializeComponent();
        }

        private DataTable dtUsers;

        private void Usermanagment_Load(object sender, EventArgs e)
        {
            this.usersTableAdapter.Fill(this.authenticationDataSet1.Users);
            listBox1.DataSource = GetData();
            listBox1.DisplayMember = "username";
        }

        private DataTable GetData()
        {
            dtUsers = new DataTable();
            SqlConnection conn = new SqlConnection(@"Data Source=CONNOR-PC\SQLEXPRESS;Initial Catalog=Authentication;Integrated Security=True;Pooling=False");
            {   // Playing with stored SQL procedures here, never used them before. :D
                using (SqlCommand cmd = new SqlCommand("usp_GetAllUsers", conn))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    dtUsers.Load(reader);
                }
            }

            return dtUsers;

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=CONNOR-PC\SQLEXPRESS;Initial Catalog=Authentication;Integrated Security=True;Pooling=False");
            using (SqlCommand command = connection.CreateCommand())
            {
                command.CommandText = "INSERT INTO Users (username,password) VALUES (@username, @password)";

                command.Parameters.AddWithValue("@username", textBox_username.Text.ToString());
                command.Parameters.AddWithValue("@password", textBox_password.Text.ToString());

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();

                listBox1.DataSource = GetData();
                listBox1.Refresh();
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=CONNOR-PC\SQLEXPRESS;Initial Catalog=Authentication;Integrated Security=True;Pooling=False");
            using (SqlCommand command = connection.CreateCommand())
            {
                DataRow selectedRow = ((DataRowView)listBox1.SelectedItem).Row;
                string selectedValue = selectedRow[1].ToString();

                command.CommandText = "DELETE FROM Users WHERE username = '" + selectedValue.ToString() + "'";

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();

                listBox1.DataSource = GetData();
                listBox1.Refresh();
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            listBox1.DataSource = GetData();
            listBox1.Refresh();
        }

        private void FillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.usersTableAdapter.FillBy(this.authenticationDataSet1.Users);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void Button4_Click(object sender, EventArgs e)
        {
            dashboard objdashboard = new dashboard();
            this.Close();
            objdashboard.Show();
        }
    }
}

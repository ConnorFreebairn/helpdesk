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

namespace Help_Desk
{
    public partial class ticketdetails : Form
    {
        public ticketdetails()
        {
            InitializeComponent();
        }

        private void Ticketdetails_Load(object sender, EventArgs e)
        {
            textBox1.Text = Properties.Settings.Default.ticketid;
            textBox2.Text = Properties.Settings.Default.affecteduser;
            richTextBox1.Text = Properties.Settings.Default.message;
            comboBox1.Text = Properties.Settings.Default.status;


            SqlConnection conn = new SqlConnection(@"Data Source=CONNOR-PC\SQLEXPRESS;Initial Catalog=Authentication;Integrated Security=True;Pooling=False");
            {
                conn.Open();
                using (SqlCommand cmd =
                    new SqlCommand("SELECT comments FROM tickets WHERE ticketid = '" + Properties.Settings.Default.ticketid.ToString() + "'", conn))
                {
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            richTextBox2.Text = reader["comments"].ToString();
                        }
                    }

                    reader.Close();
                }
            }
            Properties.Settings.Default.ticketid = "";
            Properties.Settings.Default.affecteduser = "";
            Properties.Settings.Default.status = "";
            Properties.Settings.Default.message = "";
            Properties.Settings.Default.Save();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            dashboard objdashboard = new dashboard();
            this.Close();
            objdashboard.Show();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=CONNOR-PC\SQLEXPRESS;Initial Catalog=Authentication;Integrated Security=True;Pooling=False");

            {
                conn.Open();
                using (SqlCommand cmd =
                    new SqlCommand("UPDATE tickets SET status=@status, comments=@comments" +
                    " WHERE ticketid=@ticketid", conn))
                {
                    cmd.Parameters.AddWithValue("@ticketid", textBox1.Text);
                    cmd.Parameters.AddWithValue("@status", comboBox1.Text);
                    cmd.Parameters.AddWithValue("@comments", richTextBox2.Text);
                    cmd.ExecuteNonQuery();

                    //rows number of record got updated
                }
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=CONNOR-PC\SQLEXPRESS;Initial Catalog=Authentication;Integrated Security=True;Pooling=False");

            {
                conn.Open();
                using (SqlCommand cmd =
                    new SqlCommand("UPDATE tickets SET status=@status, comments=@comments" +
                    " WHERE ticketid=@ticketid", conn))
                {
                    cmd.Parameters.AddWithValue("@ticketid", textBox1.Text);
                    cmd.Parameters.AddWithValue("@status", comboBox1.Text);
                    cmd.Parameters.AddWithValue("@comments", richTextBox2.Text);
                    cmd.ExecuteNonQuery();

                    //rows number of record got updated
                }
            }
            dashboard objdashboard = new dashboard();
            this.Close();
            objdashboard.Show();
        }
    }
}

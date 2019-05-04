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

namespace User_Ticket_Submission
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=CONNOR-PC\SQLEXPRESS;Initial Catalog=Authentication;Integrated Security=True;Pooling=False");
            using (SqlCommand command = connection.CreateCommand())
            {
                command.CommandText = "INSERT INTO tickets (affecteduser,message,status) VALUES (@affecteduser, @message, @status)";

                command.Parameters.AddWithValue("@affecteduser", textBox1.Text.ToString());
                command.Parameters.AddWithValue("@message", richTextBox1.Text.ToString());
                command.Parameters.AddWithValue("@status", "open");

                MessageBox.Show("Your ticket has been created.");

                richTextBox1.Text = "";
                textBox1.Text = "";

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
        }
    }
}

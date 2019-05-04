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
    public partial class authentication : Form
    {
        public authentication()
        {
            InitializeComponent();
        }

        private void Login_button_Click(object sender, EventArgs e)
        {
            SqlConnection sqlcon = new SqlConnection(@"Data Source=CONNOR-PC\SQLEXPRESS;Initial Catalog=Authentication;Integrated Security=True;Pooling=False");
            string query = "Select * from Users Where username = '" + username_textBox.Text.Trim() + "' and password = '" + password_textBox.Text.Trim() + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, sqlcon);
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);
            if (dtbl.Rows.Count == 1)
            {
                dashboard objdashboard = new dashboard();
                this.Hide();
                objdashboard.Show();
            }
            else
            {
                MessageBox.Show("Please check your username and password.");
            }
        }

        private void Exit_button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

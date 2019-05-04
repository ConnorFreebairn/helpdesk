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
    public partial class dashboard : Form
    {
        public dashboard()
        {
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'authenticationDataSet.tickets' table. You can move, or remove it, as needed.
            this.ticketsTableAdapter.Fill(this.authenticationDataSet.tickets);
            try
            {
                this.ticketsTableAdapter.all_tickets_open(this.authenticationDataSet.tickets);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void All_tickets_openToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.ticketsTableAdapter.all_tickets_open(this.authenticationDataSet.tickets);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void All_tickets_closedToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.ticketsTableAdapter.all_tickets_closed(this.authenticationDataSet.tickets);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                this.ticketsTableAdapter.all_tickets_open(this.authenticationDataSet.tickets);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            try
            {
                this.ticketsTableAdapter.all_tickets_closed(this.authenticationDataSet.tickets);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void OpenSelectedTicketToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                Properties.Settings.Default.ticketid = row.Cells[0].Value.ToString();
                Properties.Settings.Default.affecteduser = row.Cells[1].Value.ToString();
                Properties.Settings.Default.message = row.Cells[2].Value.ToString();
                Properties.Settings.Default.status = row.Cells[3].Value.ToString();
                Properties.Settings.Default.Save();
                
            }
            ticketdetails td = new ticketdetails(); //this is the change, code for redirect  
            this.Close();
            td.ShowDialog();
        }

        private void UserManagmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            usermanagment td = new usermanagment(); //this is the change, code for redirect  
            this.Close();
            td.ShowDialog();
        }
    }
}

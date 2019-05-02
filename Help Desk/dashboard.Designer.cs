namespace Help_Desk
{
    partial class dashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.userManagmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openSelectedTicketToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.all_tickets_openToolStrip = new System.Windows.Forms.ToolStrip();
            this.all_tickets_openToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.all_tickets_closedToolStrip = new System.Windows.Forms.ToolStrip();
            this.all_tickets_closedToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.ticketsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.authenticationDataSet = new Help_Desk.AuthenticationDataSet();
            this.ticketsTableAdapter = new Help_Desk.AuthenticationDataSetTableAdapters.ticketsTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.ticketidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.affecteduserDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.messageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.all_tickets_openToolStrip.SuspendLayout();
            this.all_tickets_closedToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ticketsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.authenticationDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userManagmentToolStripMenuItem,
            this.openSelectedTicketToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1135, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // userManagmentToolStripMenuItem
            // 
            this.userManagmentToolStripMenuItem.Name = "userManagmentToolStripMenuItem";
            this.userManagmentToolStripMenuItem.Size = new System.Drawing.Size(110, 20);
            this.userManagmentToolStripMenuItem.Text = "User managment";
            // 
            // openSelectedTicketToolStripMenuItem
            // 
            this.openSelectedTicketToolStripMenuItem.Name = "openSelectedTicketToolStripMenuItem";
            this.openSelectedTicketToolStripMenuItem.Size = new System.Drawing.Size(126, 20);
            this.openSelectedTicketToolStripMenuItem.Text = "Open selected ticket";
            this.openSelectedTicketToolStripMenuItem.Click += new System.EventHandler(this.OpenSelectedTicketToolStripMenuItem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ticketidDataGridViewTextBoxColumn,
            this.affecteduserDataGridViewTextBoxColumn,
            this.messageDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.ticketsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(180, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(943, 551);
            this.dataGridView1.TabIndex = 5;
            // 
            // all_tickets_openToolStrip
            // 
            this.all_tickets_openToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.all_tickets_openToolStripButton});
            this.all_tickets_openToolStrip.Location = new System.Drawing.Point(0, 24);
            this.all_tickets_openToolStrip.Name = "all_tickets_openToolStrip";
            this.all_tickets_openToolStrip.Size = new System.Drawing.Size(1152, 25);
            this.all_tickets_openToolStrip.TabIndex = 6;
            this.all_tickets_openToolStrip.Text = "all_tickets_openToolStrip";
            this.all_tickets_openToolStrip.Visible = false;
            // 
            // all_tickets_openToolStripButton
            // 
            this.all_tickets_openToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.all_tickets_openToolStripButton.Name = "all_tickets_openToolStripButton";
            this.all_tickets_openToolStripButton.Size = new System.Drawing.Size(94, 22);
            this.all_tickets_openToolStripButton.Text = "all_tickets_open";
            this.all_tickets_openToolStripButton.Click += new System.EventHandler(this.All_tickets_openToolStripButton_Click);
            // 
            // all_tickets_closedToolStrip
            // 
            this.all_tickets_closedToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.all_tickets_closedToolStripButton});
            this.all_tickets_closedToolStrip.Location = new System.Drawing.Point(0, 24);
            this.all_tickets_closedToolStrip.Name = "all_tickets_closedToolStrip";
            this.all_tickets_closedToolStrip.Size = new System.Drawing.Size(1152, 25);
            this.all_tickets_closedToolStrip.TabIndex = 7;
            this.all_tickets_closedToolStrip.Text = "all_tickets_closedToolStrip";
            this.all_tickets_closedToolStrip.Visible = false;
            // 
            // all_tickets_closedToolStripButton
            // 
            this.all_tickets_closedToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.all_tickets_closedToolStripButton.Name = "all_tickets_closedToolStripButton";
            this.all_tickets_closedToolStripButton.Size = new System.Drawing.Size(101, 22);
            this.all_tickets_closedToolStripButton.Text = "all_tickets_closed";
            this.all_tickets_closedToolStripButton.Click += new System.EventHandler(this.All_tickets_closedToolStripButton_Click);
            // 
            // ticketsBindingSource
            // 
            this.ticketsBindingSource.DataMember = "tickets";
            this.ticketsBindingSource.DataSource = this.authenticationDataSet;
            // 
            // authenticationDataSet
            // 
            this.authenticationDataSet.DataSetName = "AuthenticationDataSet";
            this.authenticationDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ticketsTableAdapter
            // 
            this.ticketsTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 27);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(162, 44);
            this.button1.TabIndex = 8;
            this.button1.Text = "All open tickets";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 77);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(162, 44);
            this.button2.TabIndex = 9;
            this.button2.Text = "All closed tickets";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // ticketidDataGridViewTextBoxColumn
            // 
            this.ticketidDataGridViewTextBoxColumn.DataPropertyName = "ticketid";
            this.ticketidDataGridViewTextBoxColumn.HeaderText = "ticketid";
            this.ticketidDataGridViewTextBoxColumn.Name = "ticketidDataGridViewTextBoxColumn";
            this.ticketidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // affecteduserDataGridViewTextBoxColumn
            // 
            this.affecteduserDataGridViewTextBoxColumn.DataPropertyName = "affecteduser";
            this.affecteduserDataGridViewTextBoxColumn.HeaderText = "affecteduser";
            this.affecteduserDataGridViewTextBoxColumn.Name = "affecteduserDataGridViewTextBoxColumn";
            this.affecteduserDataGridViewTextBoxColumn.Width = 150;
            // 
            // messageDataGridViewTextBoxColumn
            // 
            this.messageDataGridViewTextBoxColumn.DataPropertyName = "message";
            this.messageDataGridViewTextBoxColumn.HeaderText = "message";
            this.messageDataGridViewTextBoxColumn.Name = "messageDataGridViewTextBoxColumn";
            this.messageDataGridViewTextBoxColumn.Width = 550;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "status";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            // 
            // dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1135, 590);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.all_tickets_closedToolStrip);
            this.Controls.Add(this.all_tickets_openToolStrip);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "dashboard";
            this.Text = "dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.all_tickets_openToolStrip.ResumeLayout(false);
            this.all_tickets_openToolStrip.PerformLayout();
            this.all_tickets_closedToolStrip.ResumeLayout(false);
            this.all_tickets_closedToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ticketsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.authenticationDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem userManagmentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openSelectedTicketToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private AuthenticationDataSet authenticationDataSet;
        private System.Windows.Forms.BindingSource ticketsBindingSource;
        private AuthenticationDataSetTableAdapters.ticketsTableAdapter ticketsTableAdapter;
        private System.Windows.Forms.ToolStrip all_tickets_openToolStrip;
        private System.Windows.Forms.ToolStripButton all_tickets_openToolStripButton;
        private System.Windows.Forms.ToolStrip all_tickets_closedToolStrip;
        private System.Windows.Forms.ToolStripButton all_tickets_closedToolStripButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ticketidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn affecteduserDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn messageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
    }
}
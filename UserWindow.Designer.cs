namespace Test
{
    partial class UserWindow
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
            this.tabControlUser = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.textUserFilterGuestTeam = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textUserFilterHomeTeam = new System.Windows.Forms.TextBox();
            this.buttonUserGetMatchFilter = new System.Windows.Forms.Button();
            this.dataGridViewUpcomming = new System.Windows.Forms.DataGridView();
            this.buttonUpcomming = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.numericBuyTicketNumber = new System.Windows.Forms.NumericUpDown();
            this.numericBuyMatchId = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonBuyTicket = new System.Windows.Forms.Button();
            this.buttonGetAvailableTickets = new System.Windows.Forms.Button();
            this.dataGridBuyAvailableTickets = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.buttonUserGetMyTickets = new System.Windows.Forms.Button();
            this.dataGridViewUserMyTickets = new System.Windows.Forms.DataGridView();
            this.labelUserId = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.contextMenuStripBuyTickets = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.buyTicketToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuMyTickets = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.removeTicketToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControlUser.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUpcomming)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericBuyTicketNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericBuyMatchId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridBuyAvailableTickets)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUserMyTickets)).BeginInit();
            this.contextMenuStripBuyTickets.SuspendLayout();
            this.contextMenuMyTickets.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlUser
            // 
            this.tabControlUser.Controls.Add(this.tabPage1);
            this.tabControlUser.Controls.Add(this.tabPage2);
            this.tabControlUser.Controls.Add(this.tabPage3);
            this.tabControlUser.Location = new System.Drawing.Point(12, 51);
            this.tabControlUser.Name = "tabControlUser";
            this.tabControlUser.SelectedIndex = 0;
            this.tabControlUser.Size = new System.Drawing.Size(870, 387);
            this.tabControlUser.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.textUserFilterGuestTeam);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.textUserFilterHomeTeam);
            this.tabPage1.Controls.Add(this.buttonUserGetMatchFilter);
            this.tabPage1.Controls.Add(this.dataGridViewUpcomming);
            this.tabPage1.Controls.Add(this.buttonUpcomming);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(862, 361);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Upcomming matches";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // textUserFilterGuestTeam
            // 
            this.textUserFilterGuestTeam.Location = new System.Drawing.Point(549, 36);
            this.textUserFilterGuestTeam.Name = "textUserFilterGuestTeam";
            this.textUserFilterGuestTeam.Size = new System.Drawing.Size(112, 20);
            this.textUserFilterGuestTeam.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(571, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Guest team";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(428, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Home team";
            // 
            // textUserFilterHomeTeam
            // 
            this.textUserFilterHomeTeam.Location = new System.Drawing.Point(406, 36);
            this.textUserFilterHomeTeam.Name = "textUserFilterHomeTeam";
            this.textUserFilterHomeTeam.Size = new System.Drawing.Size(112, 20);
            this.textUserFilterHomeTeam.TabIndex = 3;
            // 
            // buttonUserGetMatchFilter
            // 
            this.buttonUserGetMatchFilter.Location = new System.Drawing.Point(278, 17);
            this.buttonUserGetMatchFilter.Name = "buttonUserGetMatchFilter";
            this.buttonUserGetMatchFilter.Size = new System.Drawing.Size(105, 39);
            this.buttonUserGetMatchFilter.TabIndex = 2;
            this.buttonUserGetMatchFilter.Text = "Get match";
            this.buttonUserGetMatchFilter.UseVisualStyleBackColor = true;
            this.buttonUserGetMatchFilter.Click += new System.EventHandler(this.buttonUserGetMatchFilter_Click);
            // 
            // dataGridViewUpcomming
            // 
            this.dataGridViewUpcomming.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUpcomming.Location = new System.Drawing.Point(20, 84);
            this.dataGridViewUpcomming.Name = "dataGridViewUpcomming";
            this.dataGridViewUpcomming.Size = new System.Drawing.Size(724, 258);
            this.dataGridViewUpcomming.TabIndex = 1;
            // 
            // buttonUpcomming
            // 
            this.buttonUpcomming.Location = new System.Drawing.Point(20, 17);
            this.buttonUpcomming.Name = "buttonUpcomming";
            this.buttonUpcomming.Size = new System.Drawing.Size(107, 39);
            this.buttonUpcomming.TabIndex = 0;
            this.buttonUpcomming.Text = "Get all matches";
            this.buttonUpcomming.UseVisualStyleBackColor = true;
            this.buttonUpcomming.Click += new System.EventHandler(this.buttonUpcomming_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.numericBuyTicketNumber);
            this.tabPage2.Controls.Add(this.numericBuyMatchId);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.buttonBuyTicket);
            this.tabPage2.Controls.Add(this.buttonGetAvailableTickets);
            this.tabPage2.Controls.Add(this.dataGridBuyAvailableTickets);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(862, 361);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Buy tickets";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // numericBuyTicketNumber
            // 
            this.numericBuyTicketNumber.Location = new System.Drawing.Point(582, 41);
            this.numericBuyTicketNumber.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericBuyTicketNumber.Name = "numericBuyTicketNumber";
            this.numericBuyTicketNumber.Size = new System.Drawing.Size(91, 20);
            this.numericBuyTicketNumber.TabIndex = 11;
            this.numericBuyTicketNumber.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericBuyMatchId
            // 
            this.numericBuyMatchId.Location = new System.Drawing.Point(434, 41);
            this.numericBuyMatchId.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericBuyMatchId.Name = "numericBuyMatchId";
            this.numericBuyMatchId.Size = new System.Drawing.Size(91, 20);
            this.numericBuyMatchId.TabIndex = 10;
            this.numericBuyMatchId.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(579, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Ticket number";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(431, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Match number";
            // 
            // buttonBuyTicket
            // 
            this.buttonBuyTicket.Location = new System.Drawing.Point(275, 23);
            this.buttonBuyTicket.Name = "buttonBuyTicket";
            this.buttonBuyTicket.Size = new System.Drawing.Size(123, 39);
            this.buttonBuyTicket.TabIndex = 4;
            this.buttonBuyTicket.Text = "Buy ticket";
            this.buttonBuyTicket.UseVisualStyleBackColor = true;
            this.buttonBuyTicket.Click += new System.EventHandler(this.buttonBuyTicket_Click);
            // 
            // buttonGetAvailableTickets
            // 
            this.buttonGetAvailableTickets.Location = new System.Drawing.Point(17, 23);
            this.buttonGetAvailableTickets.Name = "buttonGetAvailableTickets";
            this.buttonGetAvailableTickets.Size = new System.Drawing.Size(123, 39);
            this.buttonGetAvailableTickets.TabIndex = 3;
            this.buttonGetAvailableTickets.Text = "Get available tickets";
            this.buttonGetAvailableTickets.UseVisualStyleBackColor = true;
            this.buttonGetAvailableTickets.Click += new System.EventHandler(this.buttonGetAvailableTickets_Click);
            // 
            // dataGridBuyAvailableTickets
            // 
            this.dataGridBuyAvailableTickets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridBuyAvailableTickets.ContextMenuStrip = this.contextMenuStripBuyTickets;
            this.dataGridBuyAvailableTickets.Location = new System.Drawing.Point(17, 88);
            this.dataGridBuyAvailableTickets.Name = "dataGridBuyAvailableTickets";
            this.dataGridBuyAvailableTickets.Size = new System.Drawing.Size(662, 258);
            this.dataGridBuyAvailableTickets.TabIndex = 2;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.buttonUserGetMyTickets);
            this.tabPage3.Controls.Add(this.dataGridViewUserMyTickets);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(862, 361);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "My tickets";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // buttonUserGetMyTickets
            // 
            this.buttonUserGetMyTickets.Location = new System.Drawing.Point(28, 22);
            this.buttonUserGetMyTickets.Name = "buttonUserGetMyTickets";
            this.buttonUserGetMyTickets.Size = new System.Drawing.Size(123, 39);
            this.buttonUserGetMyTickets.TabIndex = 5;
            this.buttonUserGetMyTickets.Text = "Show my tickets";
            this.buttonUserGetMyTickets.UseVisualStyleBackColor = true;
            this.buttonUserGetMyTickets.Click += new System.EventHandler(this.buttonUserGetMyTickets_Click);
            // 
            // dataGridViewUserMyTickets
            // 
            this.dataGridViewUserMyTickets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUserMyTickets.Location = new System.Drawing.Point(28, 87);
            this.dataGridViewUserMyTickets.Name = "dataGridViewUserMyTickets";
            this.dataGridViewUserMyTickets.Size = new System.Drawing.Size(662, 258);
            this.dataGridViewUserMyTickets.TabIndex = 4;
            // 
            // labelUserId
            // 
            this.labelUserId.AutoSize = true;
            this.labelUserId.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelUserId.Location = new System.Drawing.Point(461, 9);
            this.labelUserId.Name = "labelUserId";
            this.labelUserId.Size = new System.Drawing.Size(0, 25);
            this.labelUserId.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(289, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Your user id is";
            // 
            // contextMenuStripBuyTickets
            // 
            this.contextMenuStripBuyTickets.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buyTicketToolStripMenuItem});
            this.contextMenuStripBuyTickets.Name = "contextMenuStripBuyTickets";
            this.contextMenuStripBuyTickets.Size = new System.Drawing.Size(127, 26);
            // 
            // buyTicketToolStripMenuItem
            // 
            this.buyTicketToolStripMenuItem.Name = "buyTicketToolStripMenuItem";
            this.buyTicketToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.buyTicketToolStripMenuItem.Text = "Buy ticket";
            // 
            // contextMenuMyTickets
            // 
            this.contextMenuMyTickets.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.removeTicketToolStripMenuItem});
            this.contextMenuMyTickets.Name = "contextMenuMyTickets";
            this.contextMenuMyTickets.Size = new System.Drawing.Size(150, 26);
            // 
            // removeTicketToolStripMenuItem
            // 
            this.removeTicketToolStripMenuItem.Name = "removeTicketToolStripMenuItem";
            this.removeTicketToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.removeTicketToolStripMenuItem.Text = "Remove ticket";
            // 
            // UserWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 494);
            this.Controls.Add(this.labelUserId);
            this.Controls.Add(this.tabControlUser);
            this.Controls.Add(this.label1);
            this.Name = "UserWindow";
            this.Text = "UserWindow";
            this.tabControlUser.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUpcomming)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericBuyTicketNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericBuyMatchId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridBuyAvailableTickets)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUserMyTickets)).EndInit();
            this.contextMenuStripBuyTickets.ResumeLayout(false);
            this.contextMenuMyTickets.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlUser;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dataGridViewUpcomming;
        private System.Windows.Forms.Button buttonUpcomming;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label labelUserId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textUserFilterHomeTeam;
        private System.Windows.Forms.Button buttonUserGetMatchFilter;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox textUserFilterGuestTeam;
        private System.Windows.Forms.Button buttonGetAvailableTickets;
        private System.Windows.Forms.DataGridView dataGridBuyAvailableTickets;
        private System.Windows.Forms.NumericUpDown numericBuyTicketNumber;
        private System.Windows.Forms.NumericUpDown numericBuyMatchId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonBuyTicket;
        private System.Windows.Forms.Button buttonUserGetMyTickets;
        private System.Windows.Forms.DataGridView dataGridViewUserMyTickets;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripBuyTickets;
        private System.Windows.Forms.ToolStripMenuItem buyTicketToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuMyTickets;
        private System.Windows.Forms.ToolStripMenuItem removeTicketToolStripMenuItem;
    }
}
namespace Test.Models
{
    partial class AdminWindow
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.checkBoxFutreMatches = new System.Windows.Forms.CheckBox();
            this.buttonGetMatches = new System.Windows.Forms.Button();
            this.dataGridViewMatch = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.numericTickersMatchId = new System.Windows.Forms.NumericUpDown();
            this.dataGridViewTickets = new System.Windows.Forms.DataGridView();
            this.buttonTicketsCreate = new System.Windows.Forms.Button();
            this.numericTicketsMatchNumberOfTickets = new System.Windows.Forms.NumericUpDown();
            this.buttonTicketsGetMatchInfo = new System.Windows.Forms.Button();
            this.label = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dateTimeCreateMatchTime = new System.Windows.Forms.DateTimePicker();
            this.buttonCreateMatchBack = new System.Windows.Forms.Button();
            this.buttonCreateMatchCreate = new System.Windows.Forms.Button();
            this.dateTimeCreateMatch = new System.Windows.Forms.DateTimePicker();
            this.textCreateMatchTypeOfEvent = new System.Windows.Forms.TextBox();
            this.textCreateMatchGuestTeam = new System.Windows.Forms.TextBox();
            this.textCreateMatchHomeTeam = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.numericUpdateMatchId = new System.Windows.Forms.NumericUpDown();
            this.textUpdateTypeOfEvent = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.dateUpdateTime = new System.Windows.Forms.DateTimePicker();
            this.dateUpdateDate = new System.Windows.Forms.DateTimePicker();
            this.textUpdateGuestTeam = new System.Windows.Forms.TextBox();
            this.textUpdateHomeTeam = new System.Windows.Forms.TextBox();
            this.buttonUpdateUpdate = new System.Windows.Forms.Button();
            this.buttonUpdateGetMatchInfo = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tabUsers = new System.Windows.Forms.TabPage();
            this.dataGridViewUsers = new System.Windows.Forms.DataGridView();
            this.buttonUsersGetUsers = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatch)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericTickersMatchId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTickets)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericTicketsMatchNumberOfTickets)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpdateMatchId)).BeginInit();
            this.tabUsers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabUsers);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1052, 426);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.checkBoxFutreMatches);
            this.tabPage1.Controls.Add(this.buttonGetMatches);
            this.tabPage1.Controls.Add(this.dataGridViewMatch);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1044, 400);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Matches";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // checkBoxFutreMatches
            // 
            this.checkBoxFutreMatches.AutoSize = true;
            this.checkBoxFutreMatches.Location = new System.Drawing.Point(273, 41);
            this.checkBoxFutreMatches.Name = "checkBoxFutreMatches";
            this.checkBoxFutreMatches.Size = new System.Drawing.Size(118, 17);
            this.checkBoxFutreMatches.TabIndex = 2;
            this.checkBoxFutreMatches.Text = "only future matches";
            this.checkBoxFutreMatches.UseVisualStyleBackColor = true;
            // 
            // buttonGetMatches
            // 
            this.buttonGetMatches.Location = new System.Drawing.Point(166, 37);
            this.buttonGetMatches.Name = "buttonGetMatches";
            this.buttonGetMatches.Size = new System.Drawing.Size(75, 23);
            this.buttonGetMatches.TabIndex = 1;
            this.buttonGetMatches.Text = "Get matches";
            this.buttonGetMatches.UseVisualStyleBackColor = true;
            this.buttonGetMatches.Click += new System.EventHandler(this.buttonGetMatches_Click);
            // 
            // dataGridViewMatch
            // 
            this.dataGridViewMatch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMatch.Location = new System.Drawing.Point(44, 89);
            this.dataGridViewMatch.Name = "dataGridViewMatch";
            this.dataGridViewMatch.Size = new System.Drawing.Size(687, 234);
            this.dataGridViewMatch.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.numericTickersMatchId);
            this.tabPage2.Controls.Add(this.dataGridViewTickets);
            this.tabPage2.Controls.Add(this.buttonTicketsCreate);
            this.tabPage2.Controls.Add(this.numericTicketsMatchNumberOfTickets);
            this.tabPage2.Controls.Add(this.buttonTicketsGetMatchInfo);
            this.tabPage2.Controls.Add(this.label);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1044, 400);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Tickets";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // numericTickersMatchId
            // 
            this.numericTickersMatchId.Location = new System.Drawing.Point(56, 62);
            this.numericTickersMatchId.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.numericTickersMatchId.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericTickersMatchId.Name = "numericTickersMatchId";
            this.numericTickersMatchId.Size = new System.Drawing.Size(100, 20);
            this.numericTickersMatchId.TabIndex = 14;
            this.numericTickersMatchId.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // dataGridViewTickets
            // 
            this.dataGridViewTickets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTickets.Location = new System.Drawing.Point(56, 132);
            this.dataGridViewTickets.Name = "dataGridViewTickets";
            this.dataGridViewTickets.Size = new System.Drawing.Size(840, 234);
            this.dataGridViewTickets.TabIndex = 13;
            // 
            // buttonTicketsCreate
            // 
            this.buttonTicketsCreate.Location = new System.Drawing.Point(622, 36);
            this.buttonTicketsCreate.Name = "buttonTicketsCreate";
            this.buttonTicketsCreate.Size = new System.Drawing.Size(142, 46);
            this.buttonTicketsCreate.TabIndex = 12;
            this.buttonTicketsCreate.Text = "Create tickets for match";
            this.buttonTicketsCreate.UseVisualStyleBackColor = true;
            this.buttonTicketsCreate.Click += new System.EventHandler(this.buttonTicketsCreate_Click);
            // 
            // numericTicketsMatchNumberOfTickets
            // 
            this.numericTicketsMatchNumberOfTickets.Location = new System.Drawing.Point(796, 62);
            this.numericTicketsMatchNumberOfTickets.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.numericTicketsMatchNumberOfTickets.Name = "numericTicketsMatchNumberOfTickets";
            this.numericTicketsMatchNumberOfTickets.Size = new System.Drawing.Size(100, 20);
            this.numericTicketsMatchNumberOfTickets.TabIndex = 11;
            // 
            // buttonTicketsGetMatchInfo
            // 
            this.buttonTicketsGetMatchInfo.Location = new System.Drawing.Point(177, 36);
            this.buttonTicketsGetMatchInfo.Name = "buttonTicketsGetMatchInfo";
            this.buttonTicketsGetMatchInfo.Size = new System.Drawing.Size(142, 46);
            this.buttonTicketsGetMatchInfo.TabIndex = 7;
            this.buttonTicketsGetMatchInfo.Text = "Show tickets for match";
            this.buttonTicketsGetMatchInfo.UseVisualStyleBackColor = true;
            this.buttonTicketsGetMatchInfo.Click += new System.EventHandler(this.buttonTicketsGetMatchInfo_Click);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(793, 36);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(90, 13);
            this.label.TabIndex = 6;
            this.label.Text = "Number of tickets";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(53, 36);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Match number";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dateTimeCreateMatchTime);
            this.tabPage3.Controls.Add(this.buttonCreateMatchBack);
            this.tabPage3.Controls.Add(this.buttonCreateMatchCreate);
            this.tabPage3.Controls.Add(this.dateTimeCreateMatch);
            this.tabPage3.Controls.Add(this.textCreateMatchTypeOfEvent);
            this.tabPage3.Controls.Add(this.textCreateMatchGuestTeam);
            this.tabPage3.Controls.Add(this.textCreateMatchHomeTeam);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Controls.Add(this.label2);
            this.tabPage3.Controls.Add(this.label1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1044, 400);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Plan a match";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dateTimeCreateMatchTime
            // 
            this.dateTimeCreateMatchTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimeCreateMatchTime.Location = new System.Drawing.Point(163, 195);
            this.dateTimeCreateMatchTime.Name = "dateTimeCreateMatchTime";
            this.dateTimeCreateMatchTime.Size = new System.Drawing.Size(99, 20);
            this.dateTimeCreateMatchTime.TabIndex = 11;
            this.dateTimeCreateMatchTime.Value = new System.DateTime(2025, 1, 30, 0, 0, 0, 0);
            // 
            // buttonCreateMatchBack
            // 
            this.buttonCreateMatchBack.Location = new System.Drawing.Point(163, 333);
            this.buttonCreateMatchBack.Name = "buttonCreateMatchBack";
            this.buttonCreateMatchBack.Size = new System.Drawing.Size(75, 23);
            this.buttonCreateMatchBack.TabIndex = 10;
            this.buttonCreateMatchBack.Text = "Back";
            this.buttonCreateMatchBack.UseVisualStyleBackColor = true;
            // 
            // buttonCreateMatchCreate
            // 
            this.buttonCreateMatchCreate.AutoSize = true;
            this.buttonCreateMatchCreate.Location = new System.Drawing.Point(39, 333);
            this.buttonCreateMatchCreate.Name = "buttonCreateMatchCreate";
            this.buttonCreateMatchCreate.Size = new System.Drawing.Size(80, 23);
            this.buttonCreateMatchCreate.TabIndex = 9;
            this.buttonCreateMatchCreate.Text = "Create match";
            this.buttonCreateMatchCreate.UseVisualStyleBackColor = true;
            this.buttonCreateMatchCreate.Click += new System.EventHandler(this.buttonCreateMatchCreate_Click);
            // 
            // dateTimeCreateMatch
            // 
            this.dateTimeCreateMatch.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeCreateMatch.Location = new System.Drawing.Point(163, 169);
            this.dateTimeCreateMatch.Name = "dateTimeCreateMatch";
            this.dateTimeCreateMatch.Size = new System.Drawing.Size(119, 20);
            this.dateTimeCreateMatch.TabIndex = 8;
            this.dateTimeCreateMatch.Value = new System.DateTime(2025, 1, 30, 0, 0, 0, 0);
            // 
            // textCreateMatchTypeOfEvent
            // 
            this.textCreateMatchTypeOfEvent.Location = new System.Drawing.Point(163, 222);
            this.textCreateMatchTypeOfEvent.Name = "textCreateMatchTypeOfEvent";
            this.textCreateMatchTypeOfEvent.Size = new System.Drawing.Size(100, 20);
            this.textCreateMatchTypeOfEvent.TabIndex = 7;
            // 
            // textCreateMatchGuestTeam
            // 
            this.textCreateMatchGuestTeam.Location = new System.Drawing.Point(163, 127);
            this.textCreateMatchGuestTeam.Name = "textCreateMatchGuestTeam";
            this.textCreateMatchGuestTeam.Size = new System.Drawing.Size(100, 20);
            this.textCreateMatchGuestTeam.TabIndex = 5;
            // 
            // textCreateMatchHomeTeam
            // 
            this.textCreateMatchHomeTeam.Location = new System.Drawing.Point(163, 86);
            this.textCreateMatchHomeTeam.Name = "textCreateMatchHomeTeam";
            this.textCreateMatchHomeTeam.Size = new System.Drawing.Size(100, 20);
            this.textCreateMatchHomeTeam.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 225);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Type of match";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Guest team";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Home team";
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.numericUpdateMatchId);
            this.tabPage5.Controls.Add(this.textUpdateTypeOfEvent);
            this.tabPage5.Controls.Add(this.label12);
            this.tabPage5.Controls.Add(this.dateUpdateTime);
            this.tabPage5.Controls.Add(this.dateUpdateDate);
            this.tabPage5.Controls.Add(this.textUpdateGuestTeam);
            this.tabPage5.Controls.Add(this.textUpdateHomeTeam);
            this.tabPage5.Controls.Add(this.buttonUpdateUpdate);
            this.tabPage5.Controls.Add(this.buttonUpdateGetMatchInfo);
            this.tabPage5.Controls.Add(this.label7);
            this.tabPage5.Controls.Add(this.label9);
            this.tabPage5.Controls.Add(this.label10);
            this.tabPage5.Controls.Add(this.label11);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(1044, 400);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Update match";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // numericUpdateMatchId
            // 
            this.numericUpdateMatchId.Location = new System.Drawing.Point(47, 53);
            this.numericUpdateMatchId.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.numericUpdateMatchId.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpdateMatchId.Name = "numericUpdateMatchId";
            this.numericUpdateMatchId.Size = new System.Drawing.Size(100, 20);
            this.numericUpdateMatchId.TabIndex = 43;
            this.numericUpdateMatchId.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // textUpdateTypeOfEvent
            // 
            this.textUpdateTypeOfEvent.Location = new System.Drawing.Point(230, 320);
            this.textUpdateTypeOfEvent.Name = "textUpdateTypeOfEvent";
            this.textUpdateTypeOfEvent.Size = new System.Drawing.Size(100, 20);
            this.textUpdateTypeOfEvent.TabIndex = 42;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(44, 327);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(73, 13);
            this.label12.TabIndex = 41;
            this.label12.Text = "Type of event";
            // 
            // dateUpdateTime
            // 
            this.dateUpdateTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateUpdateTime.Location = new System.Drawing.Point(230, 220);
            this.dateUpdateTime.Name = "dateUpdateTime";
            this.dateUpdateTime.Size = new System.Drawing.Size(100, 20);
            this.dateUpdateTime.TabIndex = 40;
            // 
            // dateUpdateDate
            // 
            this.dateUpdateDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateUpdateDate.Location = new System.Drawing.Point(230, 194);
            this.dateUpdateDate.Name = "dateUpdateDate";
            this.dateUpdateDate.Size = new System.Drawing.Size(100, 20);
            this.dateUpdateDate.TabIndex = 39;
            // 
            // textUpdateGuestTeam
            // 
            this.textUpdateGuestTeam.Location = new System.Drawing.Point(230, 147);
            this.textUpdateGuestTeam.Name = "textUpdateGuestTeam";
            this.textUpdateGuestTeam.Size = new System.Drawing.Size(100, 20);
            this.textUpdateGuestTeam.TabIndex = 37;
            // 
            // textUpdateHomeTeam
            // 
            this.textUpdateHomeTeam.Location = new System.Drawing.Point(230, 98);
            this.textUpdateHomeTeam.Name = "textUpdateHomeTeam";
            this.textUpdateHomeTeam.Size = new System.Drawing.Size(100, 20);
            this.textUpdateHomeTeam.TabIndex = 36;
            // 
            // buttonUpdateUpdate
            // 
            this.buttonUpdateUpdate.Location = new System.Drawing.Point(210, 357);
            this.buttonUpdateUpdate.Name = "buttonUpdateUpdate";
            this.buttonUpdateUpdate.Size = new System.Drawing.Size(142, 23);
            this.buttonUpdateUpdate.TabIndex = 35;
            this.buttonUpdateUpdate.Text = "Update match information";
            this.buttonUpdateUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdateUpdate.Click += new System.EventHandler(this.buttonUpdateUpdate_Click);
            // 
            // buttonUpdateGetMatchInfo
            // 
            this.buttonUpdateGetMatchInfo.Location = new System.Drawing.Point(210, 50);
            this.buttonUpdateGetMatchInfo.Name = "buttonUpdateGetMatchInfo";
            this.buttonUpdateGetMatchInfo.Size = new System.Drawing.Size(142, 23);
            this.buttonUpdateGetMatchInfo.TabIndex = 34;
            this.buttonUpdateGetMatchInfo.Text = "Get match information";
            this.buttonUpdateGetMatchInfo.UseVisualStyleBackColor = true;
            this.buttonUpdateGetMatchInfo.Click += new System.EventHandler(this.buttonUpdateGetMatchInfo_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(44, 202);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 13);
            this.label7.TabIndex = 32;
            this.label7.Text = "Date";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(44, 37);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 13);
            this.label9.TabIndex = 31;
            this.label9.Text = "Match number";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(44, 154);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 13);
            this.label10.TabIndex = 29;
            this.label10.Text = "Guest team";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(44, 105);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(61, 13);
            this.label11.TabIndex = 28;
            this.label11.Text = "Home team";
            // 
            // tabUsers
            // 
            this.tabUsers.Controls.Add(this.dataGridViewUsers);
            this.tabUsers.Controls.Add(this.buttonUsersGetUsers);
            this.tabUsers.Location = new System.Drawing.Point(4, 22);
            this.tabUsers.Name = "tabUsers";
            this.tabUsers.Size = new System.Drawing.Size(1044, 400);
            this.tabUsers.TabIndex = 3;
            this.tabUsers.Text = "Users";
            this.tabUsers.UseVisualStyleBackColor = true;
            // 
            // dataGridViewUsers
            // 
            this.dataGridViewUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUsers.Location = new System.Drawing.Point(83, 90);
            this.dataGridViewUsers.Name = "dataGridViewUsers";
            this.dataGridViewUsers.Size = new System.Drawing.Size(687, 269);
            this.dataGridViewUsers.TabIndex = 1;
            // 
            // buttonUsersGetUsers
            // 
            this.buttonUsersGetUsers.Location = new System.Drawing.Point(83, 32);
            this.buttonUsersGetUsers.Name = "buttonUsersGetUsers";
            this.buttonUsersGetUsers.Size = new System.Drawing.Size(75, 23);
            this.buttonUsersGetUsers.TabIndex = 0;
            this.buttonUsersGetUsers.Text = "Get users";
            this.buttonUsersGetUsers.UseVisualStyleBackColor = true;
            this.buttonUsersGetUsers.Click += new System.EventHandler(this.buttonUsersGetUsers_Click);
            // 
            // AdminWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "AdminWindow";
            this.Text = "AdminWindow";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatch)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericTickersMatchId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTickets)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericTicketsMatchNumberOfTickets)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpdateMatchId)).EndInit();
            this.tabUsers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabUsers;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textCreateMatchTypeOfEvent;
        private System.Windows.Forms.TextBox textCreateMatchGuestTeam;
        private System.Windows.Forms.TextBox textCreateMatchHomeTeam;
        private System.Windows.Forms.DateTimePicker dateTimeCreateMatch;
        private System.Windows.Forms.Button buttonCreateMatchBack;
        private System.Windows.Forms.Button buttonCreateMatchCreate;
        private System.Windows.Forms.DateTimePicker dateTimeCreateMatchTime;
        private System.Windows.Forms.DataGridView dataGridViewMatch;
        private System.Windows.Forms.CheckBox checkBoxFutreMatches;
        private System.Windows.Forms.Button buttonGetMatches;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button buttonTicketsGetMatchInfo;
        private System.Windows.Forms.DateTimePicker dateUpdateTime;
        private System.Windows.Forms.DateTimePicker dateUpdateDate;
        private System.Windows.Forms.TextBox textUpdateGuestTeam;
        private System.Windows.Forms.TextBox textUpdateHomeTeam;
        private System.Windows.Forms.Button buttonUpdateUpdate;
        private System.Windows.Forms.Button buttonUpdateGetMatchInfo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textUpdateTypeOfEvent;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button buttonTicketsCreate;
        private System.Windows.Forms.NumericUpDown numericTicketsMatchNumberOfTickets;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.DataGridView dataGridViewTickets;
        private System.Windows.Forms.NumericUpDown numericUpdateMatchId;
        private System.Windows.Forms.NumericUpDown numericTickersMatchId;
        private System.Windows.Forms.Button buttonUsersGetUsers;
        private System.Windows.Forms.DataGridView dataGridViewUsers;
    }
}
namespace Test
{
    partial class CreateUser
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
            this.buttonCreateConfirm = new System.Windows.Forms.Button();
            this.textCreateFirstName = new System.Windows.Forms.TextBox();
            this.textCreateLastName = new System.Windows.Forms.TextBox();
            this.textCreateLogin = new System.Windows.Forms.TextBox();
            this.textCreatePassword = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonCreateConfirm
            // 
            this.buttonCreateConfirm.Location = new System.Drawing.Point(267, 356);
            this.buttonCreateConfirm.Name = "buttonCreateConfirm";
            this.buttonCreateConfirm.Size = new System.Drawing.Size(75, 23);
            this.buttonCreateConfirm.TabIndex = 0;
            this.buttonCreateConfirm.Text = "Confirm";
            this.buttonCreateConfirm.UseVisualStyleBackColor = true;
            this.buttonCreateConfirm.Click += new System.EventHandler(this.buttonCreateConfirm_Click);
            // 
            // textCreateFirstName
            // 
            this.textCreateFirstName.Location = new System.Drawing.Point(267, 88);
            this.textCreateFirstName.Name = "textCreateFirstName";
            this.textCreateFirstName.Size = new System.Drawing.Size(100, 20);
            this.textCreateFirstName.TabIndex = 1;
            // 
            // textCreateLastName
            // 
            this.textCreateLastName.Location = new System.Drawing.Point(267, 143);
            this.textCreateLastName.Name = "textCreateLastName";
            this.textCreateLastName.Size = new System.Drawing.Size(100, 20);
            this.textCreateLastName.TabIndex = 2;
            // 
            // textCreateLogin
            // 
            this.textCreateLogin.Location = new System.Drawing.Point(267, 193);
            this.textCreateLogin.Name = "textCreateLogin";
            this.textCreateLogin.Size = new System.Drawing.Size(100, 20);
            this.textCreateLogin.TabIndex = 3;
            // 
            // textCreatePassword
            // 
            this.textCreatePassword.Location = new System.Drawing.Point(267, 244);
            this.textCreatePassword.Name = "textCreatePassword";
            this.textCreatePassword.Size = new System.Drawing.Size(100, 20);
            this.textCreatePassword.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(382, 356);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(193, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "First Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(193, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Last Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(193, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Login";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(193, 247);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Password";
            // 
            // CreateUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textCreatePassword);
            this.Controls.Add(this.textCreateLogin);
            this.Controls.Add(this.textCreateLastName);
            this.Controls.Add(this.textCreateFirstName);
            this.Controls.Add(this.buttonCreateConfirm);
            this.Name = "CreateUser";
            this.Text = "Create user";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCreateConfirm;
        private System.Windows.Forms.TextBox textCreateFirstName;
        private System.Windows.Forms.TextBox textCreateLastName;
        private System.Windows.Forms.TextBox textCreateLogin;
        private System.Windows.Forms.TextBox textCreatePassword;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}
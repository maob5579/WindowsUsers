
namespace WindowsUsers
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnCreateUser = new System.Windows.Forms.Button();
            this.lstUsers = new System.Windows.Forms.ListBox();
            this.btnShowUsers = new System.Windows.Forms.Button();
            this.btnDeleteUser = new System.Windows.Forms.Button();
            this.chkPasswordOnLogon = new System.Windows.Forms.CheckBox();
            this.chkCannotChangePass = new System.Windows.Forms.CheckBox();
            this.chkNeverExpires = new System.Windows.Forms.CheckBox();
            this.chkAccDisabled = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 59);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(109, 23);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(235, 26);
            this.txtUsername.TabIndex = 2;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(109, 59);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(235, 26);
            this.txtPassword.TabIndex = 3;
            // 
            // btnCreateUser
            // 
            this.btnCreateUser.Location = new System.Drawing.Point(12, 109);
            this.btnCreateUser.Name = "btnCreateUser";
            this.btnCreateUser.Size = new System.Drawing.Size(171, 69);
            this.btnCreateUser.TabIndex = 4;
            this.btnCreateUser.Text = "Create user";
            this.btnCreateUser.UseVisualStyleBackColor = true;
            this.btnCreateUser.Click += new System.EventHandler(this.btnCreateUser_Click);
            // 
            // lstUsers
            // 
            this.lstUsers.FormattingEnabled = true;
            this.lstUsers.ItemHeight = 20;
            this.lstUsers.Location = new System.Drawing.Point(12, 184);
            this.lstUsers.Name = "lstUsers";
            this.lstUsers.Size = new System.Drawing.Size(332, 184);
            this.lstUsers.TabIndex = 5;
            this.lstUsers.SelectedIndexChanged += new System.EventHandler(this.lstUsers_SelectedIndexChanged);
            // 
            // btnShowUsers
            // 
            this.btnShowUsers.Location = new System.Drawing.Point(12, 385);
            this.btnShowUsers.Name = "btnShowUsers";
            this.btnShowUsers.Size = new System.Drawing.Size(149, 69);
            this.btnShowUsers.TabIndex = 6;
            this.btnShowUsers.Text = "Show users";
            this.btnShowUsers.UseVisualStyleBackColor = true;
            this.btnShowUsers.Click += new System.EventHandler(this.btnShowUsers_Click);
            // 
            // btnDeleteUser
            // 
            this.btnDeleteUser.Enabled = false;
            this.btnDeleteUser.Location = new System.Drawing.Point(201, 385);
            this.btnDeleteUser.Name = "btnDeleteUser";
            this.btnDeleteUser.Size = new System.Drawing.Size(143, 69);
            this.btnDeleteUser.TabIndex = 7;
            this.btnDeleteUser.Text = "Delete user";
            this.btnDeleteUser.UseVisualStyleBackColor = true;
            this.btnDeleteUser.Click += new System.EventHandler(this.btnDeleteUser_Click);
            // 
            // chkPasswordOnLogon
            // 
            this.chkPasswordOnLogon.AutoSize = true;
            this.chkPasswordOnLogon.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chkPasswordOnLogon.Location = new System.Drawing.Point(435, 25);
            this.chkPasswordOnLogon.Name = "chkPasswordOnLogon";
            this.chkPasswordOnLogon.Size = new System.Drawing.Size(216, 24);
            this.chkPasswordOnLogon.TabIndex = 8;
            this.chkPasswordOnLogon.Text = "Change pass on nex logon";
            this.chkPasswordOnLogon.UseVisualStyleBackColor = true;
            this.chkPasswordOnLogon.CheckedChanged += new System.EventHandler(this.chkPasswordOnLogon_CheckedChanged);
            // 
            // chkCannotChangePass
            // 
            this.chkCannotChangePass.AutoSize = true;
            this.chkCannotChangePass.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chkCannotChangePass.Location = new System.Drawing.Point(435, 61);
            this.chkCannotChangePass.Name = "chkCannotChangePass";
            this.chkCannotChangePass.Size = new System.Drawing.Size(244, 24);
            this.chkCannotChangePass.TabIndex = 9;
            this.chkCannotChangePass.Text = "User cannot change password";
            this.chkCannotChangePass.UseVisualStyleBackColor = true;
            this.chkCannotChangePass.CheckedChanged += new System.EventHandler(this.chkCannotChangePass_CheckedChanged);
            // 
            // chkNeverExpires
            // 
            this.chkNeverExpires.AutoSize = true;
            this.chkNeverExpires.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chkNeverExpires.Location = new System.Drawing.Point(435, 100);
            this.chkNeverExpires.Name = "chkNeverExpires";
            this.chkNeverExpires.Size = new System.Drawing.Size(194, 24);
            this.chkNeverExpires.TabIndex = 10;
            this.chkNeverExpires.Text = "Password never expires";
            this.chkNeverExpires.UseVisualStyleBackColor = true;
            this.chkNeverExpires.CheckedChanged += new System.EventHandler(this.chkNeverExpires_CheckedChanged);
            // 
            // chkAccDisabled
            // 
            this.chkAccDisabled.AutoSize = true;
            this.chkAccDisabled.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chkAccDisabled.Location = new System.Drawing.Point(435, 144);
            this.chkAccDisabled.Name = "chkAccDisabled";
            this.chkAccDisabled.Size = new System.Drawing.Size(165, 24);
            this.chkAccDisabled.TabIndex = 11;
            this.chkAccDisabled.Text = "Account is disabled";
            this.chkAccDisabled.UseVisualStyleBackColor = true;
            this.chkAccDisabled.CheckedChanged += new System.EventHandler(this.chkAccDisabled_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 536);
            this.Controls.Add(this.chkAccDisabled);
            this.Controls.Add(this.chkNeverExpires);
            this.Controls.Add(this.chkCannotChangePass);
            this.Controls.Add(this.chkPasswordOnLogon);
            this.Controls.Add(this.btnDeleteUser);
            this.Controls.Add(this.btnShowUsers);
            this.Controls.Add(this.lstUsers);
            this.Controls.Add(this.btnCreateUser);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnCreateUser;
        private System.Windows.Forms.ListBox lstUsers;
        private System.Windows.Forms.Button btnShowUsers;
        private System.Windows.Forms.Button btnDeleteUser;
        private System.Windows.Forms.CheckBox chkPasswordOnLogon;
        private System.Windows.Forms.CheckBox chkCannotChangePass;
        private System.Windows.Forms.CheckBox chkNeverExpires;
        private System.Windows.Forms.CheckBox chkAccDisabled;
    }
}


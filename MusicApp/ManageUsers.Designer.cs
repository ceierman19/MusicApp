namespace MusicApp
{
    partial class frmManageUsers
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
            this.btnRefreshUsers = new System.Windows.Forms.Button();
            this.btnDeactivateActivateUser = new System.Windows.Forms.Button();
            this.btnResetPassword = new System.Windows.Forms.Button();
            this.btnAddNewUser = new System.Windows.Forms.Button();
            this.lblManageUsers = new System.Windows.Forms.Label();
            this.dgvUsers = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRefreshUsers
            // 
            this.btnRefreshUsers.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnRefreshUsers.Font = new System.Drawing.Font("Berlin Sans FB", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefreshUsers.Location = new System.Drawing.Point(173, 107);
            this.btnRefreshUsers.Name = "btnRefreshUsers";
            this.btnRefreshUsers.Size = new System.Drawing.Size(181, 54);
            this.btnRefreshUsers.TabIndex = 25;
            this.btnRefreshUsers.Text = "Refresh";
            this.btnRefreshUsers.UseVisualStyleBackColor = false;
            this.btnRefreshUsers.Click += new System.EventHandler(this.btnRefreshUsers_Click);
            // 
            // btnDeactivateActivateUser
            // 
            this.btnDeactivateActivateUser.BackColor = System.Drawing.Color.LightCoral;
            this.btnDeactivateActivateUser.Font = new System.Drawing.Font("Berlin Sans FB", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeactivateActivateUser.Location = new System.Drawing.Point(587, 386);
            this.btnDeactivateActivateUser.Name = "btnDeactivateActivateUser";
            this.btnDeactivateActivateUser.Size = new System.Drawing.Size(201, 54);
            this.btnDeactivateActivateUser.TabIndex = 24;
            this.btnDeactivateActivateUser.Text = "Change Status";
            this.btnDeactivateActivateUser.UseVisualStyleBackColor = false;
            this.btnDeactivateActivateUser.Click += new System.EventHandler(this.btnDeactivateActivateUser_Click);
            // 
            // btnResetPassword
            // 
            this.btnResetPassword.BackColor = System.Drawing.Color.Gold;
            this.btnResetPassword.Font = new System.Drawing.Font("Berlin Sans FB", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResetPassword.Location = new System.Drawing.Point(286, 386);
            this.btnResetPassword.Name = "btnResetPassword";
            this.btnResetPassword.Size = new System.Drawing.Size(217, 54);
            this.btnResetPassword.TabIndex = 23;
            this.btnResetPassword.Text = "Reset Password";
            this.btnResetPassword.UseVisualStyleBackColor = false;
            this.btnResetPassword.Click += new System.EventHandler(this.btnResetPassword_Click);
            // 
            // btnAddNewUser
            // 
            this.btnAddNewUser.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnAddNewUser.Font = new System.Drawing.Font("Berlin Sans FB", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewUser.Location = new System.Drawing.Point(12, 386);
            this.btnAddNewUser.Name = "btnAddNewUser";
            this.btnAddNewUser.Size = new System.Drawing.Size(194, 54);
            this.btnAddNewUser.TabIndex = 22;
            this.btnAddNewUser.Text = "Add New User";
            this.btnAddNewUser.UseVisualStyleBackColor = false;
            this.btnAddNewUser.Click += new System.EventHandler(this.btnAddNewUser_Click);
            // 
            // lblManageUsers
            // 
            this.lblManageUsers.AutoSize = true;
            this.lblManageUsers.Font = new System.Drawing.Font("Berlin Sans FB", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManageUsers.Location = new System.Drawing.Point(232, 11);
            this.lblManageUsers.Name = "lblManageUsers";
            this.lblManageUsers.Size = new System.Drawing.Size(372, 66);
            this.lblManageUsers.TabIndex = 21;
            this.lblManageUsers.Text = "Manage Users";
            // 
            // dgvUsers
            // 
            this.dgvUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsers.Location = new System.Drawing.Point(141, 167);
            this.dgvUsers.Name = "dgvUsers";
            this.dgvUsers.RowHeadersWidth = 51;
            this.dgvUsers.RowTemplate.Height = 24;
            this.dgvUsers.Size = new System.Drawing.Size(495, 170);
            this.dgvUsers.TabIndex = 20;
            // 
            // frmManageUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRefreshUsers);
            this.Controls.Add(this.btnDeactivateActivateUser);
            this.Controls.Add(this.btnResetPassword);
            this.Controls.Add(this.btnAddNewUser);
            this.Controls.Add(this.lblManageUsers);
            this.Controls.Add(this.dgvUsers);
            this.Name = "frmManageUsers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Users";
            this.Load += new System.EventHandler(this.frmManageUsers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRefreshUsers;
        private System.Windows.Forms.Button btnDeactivateActivateUser;
        private System.Windows.Forms.Button btnResetPassword;
        private System.Windows.Forms.Button btnAddNewUser;
        private System.Windows.Forms.Label lblManageUsers;
        private System.Windows.Forms.DataGridView dgvUsers;
    }
}
namespace MusicApp
{
    partial class frmManageGenres
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
            this.lblManageGenres = new System.Windows.Forms.Label();
            this.dgvGenreList = new System.Windows.Forms.DataGridView();
            this.btnAddNewGenre = new System.Windows.Forms.Button();
            this.btnEditGenre = new System.Windows.Forms.Button();
            this.btnDeleteGenre = new System.Windows.Forms.Button();
            this.btnRefreshGenreList = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGenreList)).BeginInit();
            this.SuspendLayout();
            // 
            // lblManageGenres
            // 
            this.lblManageGenres.AutoSize = true;
            this.lblManageGenres.Font = new System.Drawing.Font("Berlin Sans FB", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManageGenres.Location = new System.Drawing.Point(188, 9);
            this.lblManageGenres.Name = "lblManageGenres";
            this.lblManageGenres.Size = new System.Drawing.Size(414, 66);
            this.lblManageGenres.TabIndex = 2;
            this.lblManageGenres.Text = "Manage Genres";
            // 
            // dgvGenreList
            // 
            this.dgvGenreList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvGenreList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGenreList.Location = new System.Drawing.Point(190, 157);
            this.dgvGenreList.Name = "dgvGenreList";
            this.dgvGenreList.RowHeadersWidth = 51;
            this.dgvGenreList.RowTemplate.Height = 24;
            this.dgvGenreList.Size = new System.Drawing.Size(200, 219);
            this.dgvGenreList.TabIndex = 3;
            // 
            // btnAddNewGenre
            // 
            this.btnAddNewGenre.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnAddNewGenre.Font = new System.Drawing.Font("Berlin Sans FB", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewGenre.Location = new System.Drawing.Point(407, 157);
            this.btnAddNewGenre.Name = "btnAddNewGenre";
            this.btnAddNewGenre.Size = new System.Drawing.Size(181, 54);
            this.btnAddNewGenre.TabIndex = 15;
            this.btnAddNewGenre.Text = "Add New";
            this.btnAddNewGenre.UseVisualStyleBackColor = false;
            this.btnAddNewGenre.Click += new System.EventHandler(this.btnAddNewGenre_Click);
            // 
            // btnEditGenre
            // 
            this.btnEditGenre.BackColor = System.Drawing.Color.Gold;
            this.btnEditGenre.Font = new System.Drawing.Font("Berlin Sans FB", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditGenre.Location = new System.Drawing.Point(407, 239);
            this.btnEditGenre.Name = "btnEditGenre";
            this.btnEditGenre.Size = new System.Drawing.Size(181, 54);
            this.btnEditGenre.TabIndex = 16;
            this.btnEditGenre.Text = "Edit";
            this.btnEditGenre.UseVisualStyleBackColor = false;
            this.btnEditGenre.Click += new System.EventHandler(this.btnEditGenre_Click);
            // 
            // btnDeleteGenre
            // 
            this.btnDeleteGenre.BackColor = System.Drawing.Color.LightCoral;
            this.btnDeleteGenre.Font = new System.Drawing.Font("Berlin Sans FB", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteGenre.Location = new System.Drawing.Point(407, 322);
            this.btnDeleteGenre.Name = "btnDeleteGenre";
            this.btnDeleteGenre.Size = new System.Drawing.Size(181, 54);
            this.btnDeleteGenre.TabIndex = 17;
            this.btnDeleteGenre.Text = "Delete";
            this.btnDeleteGenre.UseVisualStyleBackColor = false;
            this.btnDeleteGenre.Click += new System.EventHandler(this.btnDeleteGenre_Click);
            // 
            // btnRefreshGenreList
            // 
            this.btnRefreshGenreList.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnRefreshGenreList.Font = new System.Drawing.Font("Berlin Sans FB", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefreshGenreList.Location = new System.Drawing.Point(199, 97);
            this.btnRefreshGenreList.Name = "btnRefreshGenreList";
            this.btnRefreshGenreList.Size = new System.Drawing.Size(181, 54);
            this.btnRefreshGenreList.TabIndex = 18;
            this.btnRefreshGenreList.Text = "Refresh";
            this.btnRefreshGenreList.UseVisualStyleBackColor = false;
            this.btnRefreshGenreList.Click += new System.EventHandler(this.btnRefreshGenreList_Click);
            // 
            // frmManageGenres
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRefreshGenreList);
            this.Controls.Add(this.btnDeleteGenre);
            this.Controls.Add(this.btnEditGenre);
            this.Controls.Add(this.btnAddNewGenre);
            this.Controls.Add(this.dgvGenreList);
            this.Controls.Add(this.lblManageGenres);
            this.Name = "frmManageGenres";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Genres";
            this.Load += new System.EventHandler(this.frmManageGenres_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGenreList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblManageGenres;
        private System.Windows.Forms.DataGridView dgvGenreList;
        private System.Windows.Forms.Button btnAddNewGenre;
        private System.Windows.Forms.Button btnEditGenre;
        private System.Windows.Forms.Button btnDeleteGenre;
        private System.Windows.Forms.Button btnRefreshGenreList;
    }
}
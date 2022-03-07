namespace MusicApp
{
    partial class frmManageSongs
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
            this.btnRefreshSongs = new System.Windows.Forms.Button();
            this.btnDeleteSong = new System.Windows.Forms.Button();
            this.btnEditSong = new System.Windows.Forms.Button();
            this.btnAddNewSong = new System.Windows.Forms.Button();
            this.dgvSongList = new System.Windows.Forms.DataGridView();
            this.lblManageSongs = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSongList)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRefreshSongs
            // 
            this.btnRefreshSongs.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnRefreshSongs.Font = new System.Drawing.Font("Berlin Sans FB", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefreshSongs.Location = new System.Drawing.Point(33, 84);
            this.btnRefreshSongs.Name = "btnRefreshSongs";
            this.btnRefreshSongs.Size = new System.Drawing.Size(181, 54);
            this.btnRefreshSongs.TabIndex = 24;
            this.btnRefreshSongs.Text = "Refresh";
            this.btnRefreshSongs.UseVisualStyleBackColor = false;
            this.btnRefreshSongs.Click += new System.EventHandler(this.btnRefreshSongs_Click);
            // 
            // btnDeleteSong
            // 
            this.btnDeleteSong.BackColor = System.Drawing.Color.LightCoral;
            this.btnDeleteSong.Font = new System.Drawing.Font("Berlin Sans FB", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteSong.Location = new System.Drawing.Point(585, 309);
            this.btnDeleteSong.Name = "btnDeleteSong";
            this.btnDeleteSong.Size = new System.Drawing.Size(181, 54);
            this.btnDeleteSong.TabIndex = 23;
            this.btnDeleteSong.Text = "Delete";
            this.btnDeleteSong.UseVisualStyleBackColor = false;
            this.btnDeleteSong.Click += new System.EventHandler(this.btnDeleteSong_Click);
            // 
            // btnEditSong
            // 
            this.btnEditSong.BackColor = System.Drawing.Color.Gold;
            this.btnEditSong.Font = new System.Drawing.Font("Berlin Sans FB", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditSong.Location = new System.Drawing.Point(585, 224);
            this.btnEditSong.Name = "btnEditSong";
            this.btnEditSong.Size = new System.Drawing.Size(181, 55);
            this.btnEditSong.TabIndex = 22;
            this.btnEditSong.Text = "Edit";
            this.btnEditSong.UseVisualStyleBackColor = false;
            this.btnEditSong.Click += new System.EventHandler(this.btnEditSong_Click);
            // 
            // btnAddNewSong
            // 
            this.btnAddNewSong.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnAddNewSong.Font = new System.Drawing.Font("Berlin Sans FB", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewSong.Location = new System.Drawing.Point(585, 144);
            this.btnAddNewSong.Name = "btnAddNewSong";
            this.btnAddNewSong.Size = new System.Drawing.Size(181, 54);
            this.btnAddNewSong.TabIndex = 21;
            this.btnAddNewSong.Text = "Add New";
            this.btnAddNewSong.UseVisualStyleBackColor = false;
            this.btnAddNewSong.Click += new System.EventHandler(this.btnAddNewSong_Click);
            // 
            // dgvSongList
            // 
            this.dgvSongList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSongList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSongList.Location = new System.Drawing.Point(33, 144);
            this.dgvSongList.Name = "dgvSongList";
            this.dgvSongList.RowHeadersWidth = 51;
            this.dgvSongList.RowTemplate.Height = 24;
            this.dgvSongList.Size = new System.Drawing.Size(517, 219);
            this.dgvSongList.TabIndex = 20;
            // 
            // lblManageSongs
            // 
            this.lblManageSongs.AutoSize = true;
            this.lblManageSongs.Font = new System.Drawing.Font("Berlin Sans FB", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManageSongs.Location = new System.Drawing.Point(216, 9);
            this.lblManageSongs.Name = "lblManageSongs";
            this.lblManageSongs.Size = new System.Drawing.Size(386, 66);
            this.lblManageSongs.TabIndex = 19;
            this.lblManageSongs.Text = "Manage Songs";
            // 
            // frmManageSongs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRefreshSongs);
            this.Controls.Add(this.btnDeleteSong);
            this.Controls.Add(this.btnEditSong);
            this.Controls.Add(this.btnAddNewSong);
            this.Controls.Add(this.dgvSongList);
            this.Controls.Add(this.lblManageSongs);
            this.Name = "frmManageSongs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Songs";
            this.Load += new System.EventHandler(this.frmManageSongs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSongList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRefreshSongs;
        private System.Windows.Forms.Button btnDeleteSong;
        private System.Windows.Forms.Button btnEditSong;
        private System.Windows.Forms.Button btnAddNewSong;
        private System.Windows.Forms.DataGridView dgvSongList;
        private System.Windows.Forms.Label lblManageSongs;
    }
}
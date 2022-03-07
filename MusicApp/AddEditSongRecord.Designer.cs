namespace MusicApp
{
    partial class frmAddEditSongRecord
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddEditSongRecord));
            this.lblAddEditSongRecord = new System.Windows.Forms.Label();
            this.lblSongTitle = new System.Windows.Forms.Label();
            this.lblArtist = new System.Windows.Forms.Label();
            this.txtArtist = new System.Windows.Forms.TextBox();
            this.lblAlbum = new System.Windows.Forms.Label();
            this.txtAlbum = new System.Windows.Forms.TextBox();
            this.lblGenre = new System.Windows.Forms.Label();
            this.cboGenre = new System.Windows.Forms.ComboBox();
            this.picAlbumArtwork = new System.Windows.Forms.PictureBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.txtSongTitle = new System.Windows.Forms.TextBox();
            this.lblSongRecordId = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picAlbumArtwork)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAddEditSongRecord
            // 
            this.lblAddEditSongRecord.AutoSize = true;
            this.lblAddEditSongRecord.Font = new System.Drawing.Font("Berlin Sans FB", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddEditSongRecord.Location = new System.Drawing.Point(34, 9);
            this.lblAddEditSongRecord.Name = "lblAddEditSongRecord";
            this.lblAddEditSongRecord.Size = new System.Drawing.Size(386, 66);
            this.lblAddEditSongRecord.TabIndex = 1;
            this.lblAddEditSongRecord.Text = "Add/Edit Song";
            // 
            // lblSongTitle
            // 
            this.lblSongTitle.AutoSize = true;
            this.lblSongTitle.Font = new System.Drawing.Font("Berlin Sans FB", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSongTitle.Location = new System.Drawing.Point(12, 98);
            this.lblSongTitle.Name = "lblSongTitle";
            this.lblSongTitle.Size = new System.Drawing.Size(106, 26);
            this.lblSongTitle.TabIndex = 3;
            this.lblSongTitle.Text = "Song Title";
            // 
            // lblArtist
            // 
            this.lblArtist.AutoSize = true;
            this.lblArtist.Font = new System.Drawing.Font("Berlin Sans FB", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArtist.Location = new System.Drawing.Point(12, 149);
            this.lblArtist.Name = "lblArtist";
            this.lblArtist.Size = new System.Drawing.Size(63, 26);
            this.lblArtist.TabIndex = 5;
            this.lblArtist.Text = "Artist";
            // 
            // txtArtist
            // 
            this.txtArtist.Font = new System.Drawing.Font("Berlin Sans FB", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtArtist.Location = new System.Drawing.Point(93, 142);
            this.txtArtist.Name = "txtArtist";
            this.txtArtist.Size = new System.Drawing.Size(380, 33);
            this.txtArtist.TabIndex = 6;
            // 
            // lblAlbum
            // 
            this.lblAlbum.AutoSize = true;
            this.lblAlbum.Font = new System.Drawing.Font("Berlin Sans FB", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlbum.Location = new System.Drawing.Point(12, 204);
            this.lblAlbum.Name = "lblAlbum";
            this.lblAlbum.Size = new System.Drawing.Size(77, 26);
            this.lblAlbum.TabIndex = 7;
            this.lblAlbum.Text = "Album";
            // 
            // txtAlbum
            // 
            this.txtAlbum.Font = new System.Drawing.Font("Berlin Sans FB", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAlbum.Location = new System.Drawing.Point(107, 197);
            this.txtAlbum.Name = "txtAlbum";
            this.txtAlbum.Size = new System.Drawing.Size(366, 33);
            this.txtAlbum.TabIndex = 8;
            // 
            // lblGenre
            // 
            this.lblGenre.AutoSize = true;
            this.lblGenre.Font = new System.Drawing.Font("Berlin Sans FB", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenre.Location = new System.Drawing.Point(12, 256);
            this.lblGenre.Name = "lblGenre";
            this.lblGenre.Size = new System.Drawing.Size(70, 26);
            this.lblGenre.TabIndex = 10;
            this.lblGenre.Text = "Genre";
            // 
            // cboGenre
            // 
            this.cboGenre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGenre.Font = new System.Drawing.Font("Berlin Sans FB", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboGenre.FormattingEnabled = true;
            this.cboGenre.Location = new System.Drawing.Point(93, 248);
            this.cboGenre.Name = "cboGenre";
            this.cboGenre.Size = new System.Drawing.Size(160, 34);
            this.cboGenre.TabIndex = 12;
            // 
            // picAlbumArtwork
            // 
            this.picAlbumArtwork.Image = ((System.Drawing.Image)(resources.GetObject("picAlbumArtwork.Image")));
            this.picAlbumArtwork.Location = new System.Drawing.Point(497, 142);
            this.picAlbumArtwork.Name = "picAlbumArtwork";
            this.picAlbumArtwork.Size = new System.Drawing.Size(300, 288);
            this.picAlbumArtwork.TabIndex = 13;
            this.picAlbumArtwork.TabStop = false;
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnSubmit.Font = new System.Drawing.Font("Berlin Sans FB", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(45, 346);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(158, 51);
            this.btnSubmit.TabIndex = 14;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // txtSongTitle
            // 
            this.txtSongTitle.Font = new System.Drawing.Font("Berlin Sans FB", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSongTitle.Location = new System.Drawing.Point(138, 91);
            this.txtSongTitle.Name = "txtSongTitle";
            this.txtSongTitle.Size = new System.Drawing.Size(635, 33);
            this.txtSongTitle.TabIndex = 15;
            // 
            // lblSongRecordId
            // 
            this.lblSongRecordId.AutoSize = true;
            this.lblSongRecordId.Font = new System.Drawing.Font("Berlin Sans FB", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSongRecordId.Location = new System.Drawing.Point(675, 9);
            this.lblSongRecordId.Name = "lblSongRecordId";
            this.lblSongRecordId.Size = new System.Drawing.Size(109, 26);
            this.lblSongRecordId.TabIndex = 20;
            this.lblSongRecordId.Text = "Hidden ID";
            this.lblSongRecordId.Visible = false;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.LightCoral;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Font = new System.Drawing.Font("Berlin Sans FB", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(277, 346);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(158, 51);
            this.btnCancel.TabIndex = 21;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmAddEditSongRecord
            // 
            this.AcceptButton = this.btnSubmit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(813, 462);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lblSongRecordId);
            this.Controls.Add(this.txtSongTitle);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.picAlbumArtwork);
            this.Controls.Add(this.cboGenre);
            this.Controls.Add(this.lblGenre);
            this.Controls.Add(this.txtAlbum);
            this.Controls.Add(this.lblAlbum);
            this.Controls.Add(this.txtArtist);
            this.Controls.Add(this.lblArtist);
            this.Controls.Add(this.lblSongTitle);
            this.Controls.Add(this.lblAddEditSongRecord);
            this.Name = "frmAddEditSongRecord";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add/Edit Song";
            this.Load += new System.EventHandler(this.frmAddEditSongRecord_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picAlbumArtwork)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAddEditSongRecord;
        private System.Windows.Forms.Label lblSongTitle;
        private System.Windows.Forms.Label lblArtist;
        private System.Windows.Forms.TextBox txtArtist;
        private System.Windows.Forms.Label lblAlbum;
        private System.Windows.Forms.TextBox txtAlbum;
        private System.Windows.Forms.Label lblGenre;
        private System.Windows.Forms.ComboBox cboGenre;
        private System.Windows.Forms.PictureBox picAlbumArtwork;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TextBox txtSongTitle;
        private System.Windows.Forms.Label lblSongRecordId;
        private System.Windows.Forms.Button btnCancel;
    }
}
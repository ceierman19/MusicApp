namespace MusicApp
{
    partial class frmAddEditGenre
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
            this.lblGenreId = new System.Windows.Forms.Label();
            this.lblAddEditTitle = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.tlpAddEditGenre = new System.Windows.Forms.TableLayoutPanel();
            this.txtGenreName = new System.Windows.Forms.TextBox();
            this.lblGenreName = new System.Windows.Forms.Label();
            this.tlpAddEditGenre.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblGenreId
            // 
            this.lblGenreId.AutoSize = true;
            this.lblGenreId.Font = new System.Drawing.Font("Berlin Sans FB", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenreId.Location = new System.Drawing.Point(12, 9);
            this.lblGenreId.Name = "lblGenreId";
            this.lblGenreId.Size = new System.Drawing.Size(109, 26);
            this.lblGenreId.TabIndex = 19;
            this.lblGenreId.Text = "Hidden ID";
            this.lblGenreId.Visible = false;
            // 
            // lblAddEditTitle
            // 
            this.lblAddEditTitle.AutoSize = true;
            this.lblAddEditTitle.BackColor = System.Drawing.SystemColors.Control;
            this.lblAddEditTitle.Font = new System.Drawing.Font("Berlin Sans FB", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddEditTitle.Location = new System.Drawing.Point(213, 74);
            this.lblAddEditTitle.Name = "lblAddEditTitle";
            this.lblAddEditTitle.Size = new System.Drawing.Size(414, 66);
            this.lblAddEditTitle.TabIndex = 18;
            this.lblAddEditTitle.Text = "Add/Edit Genre";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.LightCoral;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Font = new System.Drawing.Font("Berlin Sans FB", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(369, 270);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(127, 51);
            this.btnCancel.TabIndex = 17;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnSubmit.Font = new System.Drawing.Font("Berlin Sans FB", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(161, 270);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(127, 51);
            this.btnSubmit.TabIndex = 16;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // tlpAddEditGenre
            // 
            this.tlpAddEditGenre.ColumnCount = 2;
            this.tlpAddEditGenre.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47.00461F));
            this.tlpAddEditGenre.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 52.99539F));
            this.tlpAddEditGenre.Controls.Add(this.txtGenreName, 1, 0);
            this.tlpAddEditGenre.Controls.Add(this.lblGenreName, 0, 0);
            this.tlpAddEditGenre.Location = new System.Drawing.Point(130, 197);
            this.tlpAddEditGenre.Name = "tlpAddEditGenre";
            this.tlpAddEditGenre.RowCount = 1;
            this.tlpAddEditGenre.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpAddEditGenre.Size = new System.Drawing.Size(434, 38);
            this.tlpAddEditGenre.TabIndex = 15;
            // 
            // txtGenreName
            // 
            this.txtGenreName.Font = new System.Drawing.Font("Berlin Sans FB", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGenreName.Location = new System.Drawing.Point(207, 3);
            this.txtGenreName.Name = "txtGenreName";
            this.txtGenreName.Size = new System.Drawing.Size(190, 33);
            this.txtGenreName.TabIndex = 15;
            // 
            // lblGenreName
            // 
            this.lblGenreName.AutoSize = true;
            this.lblGenreName.Font = new System.Drawing.Font("Berlin Sans FB", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenreName.Location = new System.Drawing.Point(3, 0);
            this.lblGenreName.Name = "lblGenreName";
            this.lblGenreName.Size = new System.Drawing.Size(166, 31);
            this.lblGenreName.TabIndex = 12;
            this.lblGenreName.Text = "Genre Name";
            // 
            // frmAddEditGenre
            // 
            this.AcceptButton = this.btnSubmit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(700, 422);
            this.Controls.Add(this.lblGenreId);
            this.Controls.Add(this.lblAddEditTitle);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.tlpAddEditGenre);
            this.Font = new System.Drawing.Font("Berlin Sans FB", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmAddEditGenre";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddEditGenre";
            this.tlpAddEditGenre.ResumeLayout(false);
            this.tlpAddEditGenre.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGenreId;
        private System.Windows.Forms.Label lblAddEditTitle;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TableLayoutPanel tlpAddEditGenre;
        private System.Windows.Forms.TextBox txtGenreName;
        private System.Windows.Forms.Label lblGenreName;
    }
}
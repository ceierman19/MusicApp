namespace MusicApp
{
    partial class MainWindow
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
            this.menuMusicAppMain = new System.Windows.Forms.MenuStrip();
            this.manageUsersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageMusicLibraryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.artistsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.albumsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageSongsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageGenresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.managePlaylistsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewPlaylistsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addPlaylistToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editPlaylistToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removePlaylistToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.shareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStripMainWindow = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelMainWindow = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuMusicAppMain.SuspendLayout();
            this.statusStripMainWindow.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuMusicAppMain
            // 
            this.menuMusicAppMain.Font = new System.Drawing.Font("Berlin Sans FB", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuMusicAppMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuMusicAppMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manageUsersToolStripMenuItem,
            this.manageMusicLibraryToolStripMenuItem,
            this.managePlaylistsToolStripMenuItem});
            this.menuMusicAppMain.Location = new System.Drawing.Point(0, 0);
            this.menuMusicAppMain.Name = "menuMusicAppMain";
            this.menuMusicAppMain.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.menuMusicAppMain.Size = new System.Drawing.Size(1013, 36);
            this.menuMusicAppMain.TabIndex = 0;
            this.menuMusicAppMain.Text = "MusicAppMainMenu";
            // 
            // manageUsersToolStripMenuItem
            // 
            this.manageUsersToolStripMenuItem.Name = "manageUsersToolStripMenuItem";
            this.manageUsersToolStripMenuItem.Size = new System.Drawing.Size(158, 30);
            this.manageUsersToolStripMenuItem.Text = "Manage Users";
            this.manageUsersToolStripMenuItem.Click += new System.EventHandler(this.manageUsersToolStripMenuItem_Click);
            // 
            // manageMusicLibraryToolStripMenuItem
            // 
            this.manageMusicLibraryToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.artistsToolStripMenuItem,
            this.albumsToolStripMenuItem,
            this.manageSongsToolStripMenuItem,
            this.manageGenresToolStripMenuItem});
            this.manageMusicLibraryToolStripMenuItem.Name = "manageMusicLibraryToolStripMenuItem";
            this.manageMusicLibraryToolStripMenuItem.Size = new System.Drawing.Size(153, 30);
            this.manageMusicLibraryToolStripMenuItem.Text = "Music Library";
            // 
            // artistsToolStripMenuItem
            // 
            this.artistsToolStripMenuItem.Name = "artistsToolStripMenuItem";
            this.artistsToolStripMenuItem.Size = new System.Drawing.Size(247, 30);
            this.artistsToolStripMenuItem.Text = "Artists";
            // 
            // albumsToolStripMenuItem
            // 
            this.albumsToolStripMenuItem.Name = "albumsToolStripMenuItem";
            this.albumsToolStripMenuItem.Size = new System.Drawing.Size(247, 30);
            this.albumsToolStripMenuItem.Text = "Albums";
            // 
            // manageSongsToolStripMenuItem
            // 
            this.manageSongsToolStripMenuItem.Name = "manageSongsToolStripMenuItem";
            this.manageSongsToolStripMenuItem.Size = new System.Drawing.Size(247, 30);
            this.manageSongsToolStripMenuItem.Text = "Manage Songs";
            this.manageSongsToolStripMenuItem.Click += new System.EventHandler(this.manageSongsToolStripMenuItem_Click);
            // 
            // manageGenresToolStripMenuItem
            // 
            this.manageGenresToolStripMenuItem.Name = "manageGenresToolStripMenuItem";
            this.manageGenresToolStripMenuItem.Size = new System.Drawing.Size(247, 30);
            this.manageGenresToolStripMenuItem.Text = "Manage Genres";
            this.manageGenresToolStripMenuItem.Click += new System.EventHandler(this.manageGenresToolStripMenuItem_Click);
            // 
            // managePlaylistsToolStripMenuItem
            // 
            this.managePlaylistsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewPlaylistsToolStripMenuItem,
            this.addPlaylistToolStripMenuItem,
            this.editPlaylistToolStripMenuItem,
            this.removePlaylistToolStripMenuItem,
            this.shareToolStripMenuItem});
            this.managePlaylistsToolStripMenuItem.Name = "managePlaylistsToolStripMenuItem";
            this.managePlaylistsToolStripMenuItem.Size = new System.Drawing.Size(101, 30);
            this.managePlaylistsToolStripMenuItem.Text = "Playlists";
            // 
            // viewPlaylistsToolStripMenuItem
            // 
            this.viewPlaylistsToolStripMenuItem.Name = "viewPlaylistsToolStripMenuItem";
            this.viewPlaylistsToolStripMenuItem.Size = new System.Drawing.Size(252, 30);
            this.viewPlaylistsToolStripMenuItem.Text = "View Playlists";
            // 
            // addPlaylistToolStripMenuItem
            // 
            this.addPlaylistToolStripMenuItem.Name = "addPlaylistToolStripMenuItem";
            this.addPlaylistToolStripMenuItem.Size = new System.Drawing.Size(252, 30);
            this.addPlaylistToolStripMenuItem.Text = "Add Playlist";
            // 
            // editPlaylistToolStripMenuItem
            // 
            this.editPlaylistToolStripMenuItem.Name = "editPlaylistToolStripMenuItem";
            this.editPlaylistToolStripMenuItem.Size = new System.Drawing.Size(252, 30);
            this.editPlaylistToolStripMenuItem.Text = "Edit Playlist";
            // 
            // removePlaylistToolStripMenuItem
            // 
            this.removePlaylistToolStripMenuItem.Name = "removePlaylistToolStripMenuItem";
            this.removePlaylistToolStripMenuItem.Size = new System.Drawing.Size(252, 30);
            this.removePlaylistToolStripMenuItem.Text = "Remove Playlist";
            // 
            // shareToolStripMenuItem
            // 
            this.shareToolStripMenuItem.Name = "shareToolStripMenuItem";
            this.shareToolStripMenuItem.Size = new System.Drawing.Size(252, 30);
            this.shareToolStripMenuItem.Text = "Share Playlist";
            // 
            // statusStripMainWindow
            // 
            this.statusStripMainWindow.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStripMainWindow.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelMainWindow});
            this.statusStripMainWindow.Location = new System.Drawing.Point(0, 566);
            this.statusStripMainWindow.Name = "statusStripMainWindow";
            this.statusStripMainWindow.Size = new System.Drawing.Size(1013, 24);
            this.statusStripMainWindow.TabIndex = 6;
            // 
            // toolStripStatusLabelMainWindow
            // 
            this.toolStripStatusLabelMainWindow.Name = "toolStripStatusLabelMainWindow";
            this.toolStripStatusLabelMainWindow.Size = new System.Drawing.Size(0, 18);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1013, 590);
            this.Controls.Add(this.statusStripMainWindow);
            this.Controls.Add(this.menuMusicAppMain);
            this.Font = new System.Drawing.Font("Berlin Sans FB", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuMusicAppMain;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Music App";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainWindow_FormClosing);
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.menuMusicAppMain.ResumeLayout(false);
            this.menuMusicAppMain.PerformLayout();
            this.statusStripMainWindow.ResumeLayout(false);
            this.statusStripMainWindow.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuMusicAppMain;
        private System.Windows.Forms.ToolStripMenuItem manageUsersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageMusicLibraryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem artistsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem albumsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageSongsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageGenresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem managePlaylistsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewPlaylistsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addPlaylistToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editPlaylistToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removePlaylistToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem shareToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStripMainWindow;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelMainWindow;
    }
}

